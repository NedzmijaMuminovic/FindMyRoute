import {Component, OnInit} from '@angular/core';
import {MojConfig} from "./moj-config";
import {HttpClient} from "@angular/common/http";
import {Router} from "@angular/router";
import {AutentifikacijaHelper} from "./_helpers/autentifikacija-helper";
import {LoginInformacije} from "./_helpers/login-informacije";

/*declare function porukaSuccess(a: string):any;
declare function porukaError(a: string):any;*/

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit {
  constructor(private httpKlijent: HttpClient, private router: Router) {}

  ngOnInit(): void {
    this.router.navigate(['/pretraga']);
  }

  loginInfo():LoginInformacije {
    return AutentifikacijaHelper.getLoginInfo();
  }

  logoutButton() {
    AutentifikacijaHelper.setLoginInfo(null);

    this.httpKlijent.post(MojConfig.adresa_servera + "/Autentifikacija/Logout/", null, MojConfig.http_opcije())
      .subscribe((x: any) => {
        this.router.navigateByUrl("/pretraga");
        //porukaSuccess("Logout uspješan");
      });
  }
}

/*export class AppComponent {


  constructor(private httpKlijent: HttpClient, private router: Router) {
  }
  ngOnInit(): void {
    this.router.navigateByUrl("/app-korisnici");
  }
  logoutButton() {
    AutentifikacijaHelper.setLoginInfo(null);

    this.httpKlijent.post(MojConfig.adresa_servera + "/Autentifikacija/Logout/", null, MojConfig.http_opcije())
      .subscribe((x: any) => {
        this.router.navigateByUrl("/app-login");
        porukaSuccess("Logout uspješan");
      });
  }

  loginInfo():LoginInformacije {
    return AutentifikacijaHelper.getLoginInfo();
  }
}*/
