using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROZ.Models
{
    public class Zaginiony
    {
        string imie;
        string nazwisko;
        string imgPath;
        string opis;
        int wiek;
        char plec;
        Wojewodztwo wojewodztwo;

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string ImgPath { get => imgPath; set => imgPath = value; }
        public int Wiek { get => wiek; set => wiek = value; }
        public char Plec { get => plec; set => plec = value; }
        public string Opis { get => opis; set => opis = value; }
        public Wojewodztwo Wojewodztwo { get => wojewodztwo; set => wojewodztwo = value; }
    }

    public enum Wojewodztwo
    {
        dolnośląskie,
        kujawskoPomorskie,
        lubelskie,
        lubuskie,
        łódzkie,
        małopolskie,
        mazowieckie,
        opolskie,
        podkarpackie,
        podlaskie,
        pomorskie,
        śląskie,
        świętokrzyskie,
        warmińskoMazurskie,
        wielkopolskie,
        zachodniopomorskie

    }
}
