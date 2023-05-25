import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { MojConfig } from '../moj-config';
import { Router } from '@angular/router';
import { LoginInformacije } from '../_helpers/login-informacije';
import { AutentifikacijaHelper } from '../_helpers/autentifikacija-helper';

declare function porukaSuccess(a: string):any;
declare function porukaError(a: string):any;

@Component({
  selector: 'app-korisnickiRacun',
  templateUrl: 'korisnickiRacun.component.html',
  styleUrls: ['korisnickiRacun.component.css']
})
export class KorisnickiRacunComponent implements OnInit {

  id: number;
  racunPodaci: any;
  kreditnaPodaci: any;
  promjenaLozinke: boolean = false;
  txtTrenutnaLozinka: string = "";
  txtNovaLozinka: string = "";
  txtNovaPotvrdaLozinka: string = "";

  constructor(
    private httpKlijent: HttpClient,
    private route: ActivatedRoute,
    private router: Router
  ) {}

  loginInfo(): LoginInformacije {
    return AutentifikacijaHelper.getLoginInfo();
  }

  btnKreditna(kreditna: any): void {
    if (kreditna == 0) {
      this.router.navigate(['/upravljanjeKreditna', 0]);
    }
    else {
      this.router.navigate(['/upravljanjeKreditna', this.kreditnaPodaci.id]);
    }
  }

  LogOut(): void {
    AutentifikacijaHelper.setLoginInfo(null);
    this.httpKlijent.post(MojConfig.adresa_servera + "/Autentifikacija/Logout/", null, MojConfig.http_opcije())
      .subscribe((x: any) => {
        this.router.navigateByUrl("/pretraga");
        porukaSuccess("Kreditna kartica uspješno uklonjena, potrebno se ponovo ulogirati!");
      });
  }

  btnUkloniKarticu(): void {
    this.httpKlijent.delete(`${MojConfig.adresa_servera}/KreditnaKartica/Delete/${this.kreditnaPodaci.id}`, MojConfig.http_opcije()).subscribe(x=>{
      this.LogOut();
    });
  }

  PromijeniLozinku(): void {
    if (this.Validiraj()){
      let podaci = {
        id: this.loginInfo().autentifikacijaToken.korisnickiNalog.id,
        trenutnaLozinka: this.txtTrenutnaLozinka,
        novaLozinka: this.txtNovaLozinka
      };
      this.httpKlijent.post(`${MojConfig.adresa_servera}/Korisnik/PromijeniLozinku`, podaci, MojConfig.http_opcije()).subscribe(x=>{
        porukaSuccess("Lozinka uspješno promijenjena!");
        this.promjenaLozinke = false;
        this.ngOnInit();
      });
    }
  }

  Validiraj(): boolean {
    if (this.txtTrenutnaLozinka == "" || this.txtNovaLozinka == "" || this.txtNovaPotvrdaLozinka == ""){
      porukaError("Sva polja su obavezna!")
      return false;
    }
    if (this.txtNovaLozinka != this.txtNovaPotvrdaLozinka) {
      porukaError("Lozinke se ne poklapaju!")
      return false;
    }
    return true;
  }

  ngOnInit(): void {
    fetch(MojConfig.adresa_servera+ "/Korisnik/Get/id?id="+this.loginInfo().autentifikacijaToken.korisnickiNalog.id )
      .then(
        r=> {
          if (r.status != 200) {
            if (r.status == 400) {
              alert("Nepoznat korisnik!");
            }
            else {
              alert("greska" + r.status);
            }
            return;
          }
          r.json().then(x=>{
            this.racunPodaci = x;
            if (this.loginInfo().autentifikacijaToken.korisnickiNalog.posjedujeKreditnu) {
              fetch(MojConfig.adresa_servera+ "/KreditnaKartica/GetByKorisnik/korisnikId?korisnikId="+this.loginInfo().autentifikacijaToken.korisnickiNalog.id )
                .then(
                  r=> {
                    if (r.status != 200) {
                      if (r.status == 400) {
                        alert("Nepoznat korisnik!");
                      }
                      else {
                        alert("greska" + r.status);
                      }
                      return;
                    }
                    r.json().then(x=>{
                      this.kreditnaPodaci = x;
                    });
                  }
                )
                .catch(
                  err=>{
                    alert("greska" + err);
                  }
                )
            }
          });
        }
      )
      .catch(
        err=>{
          alert("greska" + err);
        }
      )
  }
}
