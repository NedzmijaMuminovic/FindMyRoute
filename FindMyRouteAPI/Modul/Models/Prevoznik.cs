﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FindMyRouteAPI.Modul.Models
{
    public class Prevoznik
    {
        [Key]
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        [JsonIgnore]
        public byte[]? Logo { get; set; }
        [JsonIgnore]
        public byte[]? LogoMali { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
