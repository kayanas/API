using System.Collections.Generic;
using System.Linq;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Medus Su Avietemis",
                    Description =
                        "Dar vienas mūsų mišinys saldumynų mėgėjams / medaus skanėstas su avietėmis.  Avietės (juo labiau medus su jomis) yra puiki pagalba Jūsų organizmui sveikstant nuo peršalimo ar virusinių ligų: jos skatina virškinimą ir prakaitavimą karščiuojant ir yra skaniausi kada nors ragauti vaistai. Įsigykite šį medaus mišinį, prisiminkite vasariško miško kvapą ir būkite sveiki!",
                    Subtitle = "Vasaros skonis Jūsų namuose ištisus metus! Sudedamosios dalys: medus 92 %, liofilizuotos avietės 8 %",
                    Price = 5,
                    Weight = 0.2,
                    PictureUrl = "src/images/products/honey1.jpg",
                    Type = "Medaus skanestas",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Medus Su Spanguolemis",
                    Description =
                        "Spanguolės plačiausiai vartojamos kaip natūralus antioksidantas, kuris gali padėti kovoti su senėjimo procesu, gerinanti imuninės sistemos būklę, teigiamai veikianti šlapimo organų sistemos veiklą. Nesvarbu, dirbate fizinį ar protinį darbą, šis medaus mišinys gali suteikti Jums jėgų ir padėti valdyti stresą. Medus su spanguolėmis yra skaniausias būdas būti sveikam, žvaliam ir energingam visais metų laikais!",
                    Subtitle = "Saldžiarūgštis medaus skanėstas ne tik paįvairins saldumynų kraitį, tačiau ir praturtins organizmą vitaminu C. Sudedamosios dalys: medus 92 %, liofilizuotos spanguolės 8 %",
                    Price = 5,
                    Weight = 0.2,
                    PictureUrl = "src/images/products/honey2.jpg",
                    Type = "Medaus skanestas",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Medus Su Saltalankiais",
                    Description =
                        "Šaltalankiai – tikra vitaminų ir kitų naudingųjų medžiagų bomba! Šaltalankių uogose galima rasti net 14 žmogui naudingų vitaminų, riebalų rūgščių, antioksidantų ir daugybę kitų naudingųjų medžiagų, padedančių kovoti su ūmiais bei lėtiniais uždegiminiais procesais. Šis medaus skanėstas džiugins Jus savo nuostabiu skoniu, išskirtiniu aromatu.",
                    Subtitle = "Saulėtas medaus su šaltalankiais skonis ne tik primins vasarą, tačiau gali padėti išlikti jauniems bei jaunatviškiems! Sudedamosios dalys: medus 92 %, liofilizuoti šaltalankiai 8 %.",
                    Price = 5,
                    Weight = 0.2,
                    PictureUrl = "src/images/products/honey3.jpg",
                    Type = "Medaus skanestas",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Medus Su Svarainiais",
                    Description =
                        "Itin gaivus medaus skanėstas ne tik nuteiks linksmiau, tačiau ir gali padėti stiprinti imuninę sistemą. Svarainiai – tikri gamtos sveikatinantys perliukai, kurie padeda stimuliuoti kraujotaką, slopina kosulį ir turi antibakterinių savybių.  Dabar svarainiais galite mėgautis tiek vasarą, tiek žiemą ir likti žvalūs bei sveiki!",
                    Subtitle = "Medus su svarainiais – Jūsų gerai nuotaikai ir gaiviems potyriams. Sudedamosios dalys: medus 92 %, liofilizuoti svarainiai 8 %",
                    Price = 5,
                    Weight = 0.2,
                    PictureUrl = "src/images/products/honey4.jpg",
                    Type = "Medaus skanestas",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Liepu Medus",
                    Description =
                        "Liepų medus – daugiausiai saulės savyje sukaupęs medus, daugelio pamėgtas, žinomas ir išbandytas. Jei nesidomite medaus rūšimis, ko gero, būtent liepų medų ir vadinate tikruoju medumi.",
                    Subtitle = "Tikras, lietuviškas, vidurvasario saulės prisotintas medus Jūsų gerai savijautai, puikiai nuotaikai, ilgaamžiškumui ir laimei.",
                    Price = 7,
                    Weight = 0.5,
                    PictureUrl = "src/images/products/honey_main.jpg",
                    Type = "Medus",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Medus",
                    Description =
                        "Pavasarinį medų bitės gamina iš sodų ir pievų žiedų nektaro, dažniausiai – kiaulpienių, rapsų. Pavasarinis medus gali būti galingas ginklas kovojant su peršalimo ligomis, nes šis medus turi daug antibakterinių savybių. Taip pat manoma, kad jis yra vienas mažiausiai alergizuojančių, todėl rekomenduojama būtent jį duoti vaikams dar neragavusiems medaus.",
                    Subtitle = "Pavasario žiedų medus – gera nuotaika ir pavasario saulės šiluma Jūsų namuose visus metus!",
                    Price = 10,
                    Weight = 1,
                    PictureUrl = "src/images/products/honey_main.jpg",
                    Type = "Medus",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Grikiu medus",
                    Description =
                        "Sodraus skonio, malonios konsistencijos ir įsimenančio kvapo grikių medus – vienas maistingiausių. Iš visų Lietuvoje parduodamo medaus rūšių, būtent šis medus pasižymi didžiausiu antioksidantų bei geležies kiekiu. Dėl šių savybių Lietuviškas grikių medus vertinamas ir užsienio rinkoje. Kadangi iš medaus žmogaus organizmas geba pasisavinti beveik visas vertingąsias medžiagas, šis medus itin rekomenduojamas sergant mažakraujyste ir norint sustiprinti nervų sistemą.",
                    Subtitle = "Grikių medus – jaunystės eliksyras iš gamtos Jums. Turtingiausias medus ieškantiems aukščiausios kokybės ir maistingiausio pasirinkimo.",
                    Price = 10,
                    Weight = 1,
                    PictureUrl = "src/images/products/honey_main.jpg",
                    Type = "Medus",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Medaus rinkinys",
                    Description =
                        "Šis rinkinys gali būti puikia dovana močiutei, mamai, tetai, draugei ar net verslo partneriui, klientams ir visiems, kuriems norisi padovanoti ką nors išskirtinai kokybiško, šilto ir asmeniško.",
                    Subtitle = "Rinkinys tikram sveikuoliui ir didžiam smaližiui. Rinkinį sudaro: dviejų rūšių medus po 500 g, bičių žiedadulkės 200 g, trispalvis medaus skanėstas 200 g.",
                    Price = 15,
                    Weight = 1.5,
                    PictureUrl = "src/images/products/complete.jpg",
                    Type = "Medus",
                    QuantityInStock = 100
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}