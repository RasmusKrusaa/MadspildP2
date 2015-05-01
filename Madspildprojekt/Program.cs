using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Madspildprojekt
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                //Arrange
                string retNavn = "Tomatsuppe";
                string[] ingredienser = { "1000_g_cherrytomat", "4_tomat", "4_fed hvidløg", "2_rødløg",
                                        "1_ciabattabrød", "1_rød chili", "0,25_cremefraiche" };

                string[] instruktioner = { "Tænd ovnen på 220° og sæt en stor gryde over lav varme", 
                                         "Skær tomater i kvarte og fordel alle tomaterne i en bradepande", 
                                         "Dryp generøst med olivenolie og krydr med salt og peber", 
                                         "Flæk og udkern chilien og kom den op i", 
                                         "Kvas 4 pillede fed hvidløg i",
                                         "Vend alt hurtigt sammen og sæt det på øverste rille i ovnen i 12-15 min", 
                                         "Pil løgene, hak dem groft og kom dem op i den varme gryde med en sjat olivenolie og lidt salt", 
                                         "Skru op til middel varme og lad løgene stå og blive bløde", 
                                         "Rør rundt af og til. Rør 4 spsk balsamico i løgene og lad den koge ind", 
                                         "Tag bradepanden med tomater ud af ovnen og hæld det hele op i gryden med løg", 
                                         "Hæld forsigtigt grøntsagerne fra gryden op i blenderen; det skal gøres i to omgange",
                                         "Tilsæt næsten al basilikum, sæt låg på blenderskålen", 
                                         "Læg et viskestykke over og blitz til ret grov konsistens",
                                         "Hæld din tomatsuppe op i en stor serveringsskål efterhånden",
                                         "Bland alt godt til sidst",
                                         "Smag din tomatsuppe til og slut af med en klat cremefraiche",
                                         "Nogle basilikumblade og et dryp ekstra-jomfruolivenolie",
                                         "Stil skålen på bordet sammen med en stabel suppeskåle og bradepanden med croutoner fra ovnen" 
                                      };
                Opskrift to = new Opskrift();
                //Act
                to.Indlæs("Opskrifter.txt");
                to.TilføjOpskriftTilFil(retNavn, ingredienser, instruktioner);

                Console.ReadKey();
            }
        }
    }
}
