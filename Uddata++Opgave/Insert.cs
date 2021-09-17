using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uddata__Opgave.Models;

namespace Uddata__Opgave
{
    class Insert
    {        
        List<Lærer>Skole = new List<Lærer>();
        public void opret()
        {
            #region Fag
            Fag netværk = new Fag()
            {
                FagID = 1,
                FagName = FagEnum.Netværk
            };
            Fag grundlæggende_programmmmering = new Fag()
            {
                FagID = 2,
                FagName = FagEnum.grundlæggende_programmering
            };
            Fag OOP = new Fag()
            {
                FagID = 3,
                FagName = FagEnum.OOP
            };
            Fag Clientside = new Fag()
            {
                FagID = 4,
                FagName = FagEnum.Clientside
            };
            #endregion

            #region Klasse
            Klasser H1 = new Klasser()
            {
                KlasseNavn = Klasse.H1
            };
            Klasser H2 = new Klasser()
            {
                KlasseNavn = Klasse.H2
            };
            Klasser H3 = new Klasser()
            {
                KlasseNavn = Klasse.H3
            };
            #endregion

            #region Lærer
            Lærer Karl = new Lærer()
            {
                ID = 1,
                Name = "Karl Hansen",
                Kaffeklubben = true,
            };
            Lærer Frank = new Lærer()
            {
                ID = 2,
                Name = "Frank Bregnholt",
                Kaffeklubben = false,
            };
            Lærer Maibrit = new Lærer()
            {
                ID = 3,
                Name = "Maibrit Jürgensson",
                Kaffeklubben = true
            };
            Lærer Henrik = new Lærer()
            {
                ID = 4,
                Name = "Henrik Vincents Poulsen",
                Kaffeklubben = true,
            };
            #endregion

            #region Elev
            Elev Jeppe = new Elev()
            {
                ID = 1,
                Name = "Jeppe Frimann Larsen",
                Advarsler = 2,
                Klasse = Klasse.H2                                
            };
            Elev Anders = new Elev()
            {
                ID = 2,
                Name = "Anders Karlsson Johansen",
                Advarsler = 1,
                Klasse = Klasse.H2
            };
            Elev Lars = new Elev()
            {
                ID = 3,
                Name = "Lars Larsen",
                Advarsler = 0,
                Klasse = Klasse.H1
            };
            Elev Johanne = new Elev()
            {
                ID = 4,
                Name = "Johanne Van De Sande",
                Advarsler = 0,
                Klasse = Klasse.H1
            };
            Elev Jonas = new Elev()
            {
                ID = 5,
                Name = "Jonas Kirkelundgaard",
                Advarsler = 4,
                Klasse = Klasse.H2
            };
            Elev Inger = new Elev()
            {
                ID = 6,
                Name = "Inger Hellermand",
                Advarsler = 2,
                Klasse = Klasse.H2
            };
            Elev Lauge = new Elev()
            {
                ID = 7,
                Name = "Lauge Lunderstrup",
                Advarsler = 0,
                Klasse = Klasse.H3
            };
            Elev Victor = new Elev()
            {
                ID = 8,
                Name = "Victor Rosenborg",
                Advarsler = 7,
                Klasse = Klasse.H1
            };
            #endregion

            #region Karaktere + Fag
            Jeppe.FagKarakter.Add(FagEnum.grundlæggende_programmering, 12);
            Jeppe.FagKarakter.Add(FagEnum.OOP, 7);
            Jeppe.FagKarakter.Add(FagEnum.Netværk ,02);
            Jeppe.FagKarakter.Add(FagEnum.Clientside, 10);

            Anders.FagKarakter.Add(FagEnum.grundlæggende_programmering, 12);
            Anders.FagKarakter.Add(FagEnum.OOP, 10);
            Anders.FagKarakter.Add(FagEnum.Netværk, 12);
            Anders.FagKarakter.Add(FagEnum.Clientside, 7);

            Lars.FagKarakter.Add(FagEnum.grundlæggende_programmering, 02);
            Lars.FagKarakter.Add(FagEnum.OOP, 02);
            Lars.FagKarakter.Add(FagEnum.Netværk, 7);
            Lars.FagKarakter.Add(FagEnum.Clientside, 02);

            Johanne.FagKarakter.Add(FagEnum.grundlæggende_programmering, 12);
            Johanne.FagKarakter.Add(FagEnum.OOP, 7);
            Johanne.FagKarakter.Add(FagEnum.Netværk, 7);
            Johanne.FagKarakter.Add(FagEnum.Clientside, 7);

            Jonas.FagKarakter.Add(FagEnum.grundlæggende_programmering, 12);
            Jonas.FagKarakter.Add(FagEnum.OOP, 12);
            Jonas.FagKarakter.Add(FagEnum.Netværk, 02);
            Jonas.FagKarakter.Add(FagEnum.Clientside, 10);

            Inger.FagKarakter.Add(FagEnum.grundlæggende_programmering, 02);
            Inger.FagKarakter.Add(FagEnum.OOP, 7);
            Inger.FagKarakter.Add(FagEnum.Netværk, -3);
            Inger.FagKarakter.Add(FagEnum.Clientside, 4);

            Lauge.FagKarakter.Add(FagEnum.grundlæggende_programmering, 12);
            Lauge.FagKarakter.Add(FagEnum.OOP, 7);
            Lauge.FagKarakter.Add(FagEnum.Netværk, 12);
            Lauge.FagKarakter.Add(FagEnum.Clientside, 10);

            Victor.FagKarakter.Add(FagEnum.grundlæggende_programmering, 7);
            Victor.FagKarakter.Add(FagEnum.OOP, 7);
            Victor.FagKarakter.Add(FagEnum.Netværk, 10);
            Victor.FagKarakter.Add(FagEnum.Clientside, 00);
            #endregion

            Henrik.fag.AddRange(new List<Fag>() { grundlæggende_programmmmering, OOP, Clientside });
            Maibrit.fag.AddRange(new List<Fag>() { netværk, grundlæggende_programmmmering });
            Karl.fag.AddRange(new List<Fag>() { grundlæggende_programmmmering, OOP, Clientside });
            Frank.fag.Add(netværk);

            Karl.klasser.AddRange(new List<Elev>() {Jeppe,Anders,Jonas,Inger});
            Maibrit.klasser.AddRange(new List<Elev>() {Victor, Lars, Johanne});
            Henrik.klasser.AddRange(new List<Elev>() {Lauge});

            Skole.AddRange(new List<Lærer>() { Maibrit,Karl,Henrik,Frank});

            Console.WriteLine("******************** Uddata++ ********************\n\n\n");
            foreach (var L in Skole)
            {
                Console.WriteLine("******************** Lærer ********************");
                Console.WriteLine($"\nSkolelærer: {L.ID} \nNavn: {L.Name} \nKaffeklub: {L.Kaffeklubben}");
                Console.Write("Underviser i:  ");
                foreach (var I in L.fag)
                {
                    Console.Write(I.FagID + "-" + I.FagName + ", ");
                    Console.WriteLine("");
                }
                if (L.klasser.Count >= 1)
                {
                    Console.WriteLine("\n\n******************** Klasse ********************");
                }
                
                foreach (var K in L.klasser)
                {
                    Console.WriteLine($"Elev ID: {K.ID} \n Navn: {K.Name} \nAdvarsler: {K.Advarsler} \nKlasse: {K.Klasse} \nFag & Karaktere: ");
                    foreach (KeyValuePair<FagEnum, int> entry in K.FagKarakter)
                    {
                        Console.WriteLine(entry.Key + " " + entry.Value + "\n");
                    }
                }
                
                Console.Write("______________________________________________");
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        }

    }
}
