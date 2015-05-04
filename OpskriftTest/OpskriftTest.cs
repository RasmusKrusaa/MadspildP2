using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Madspildprojekt;

namespace MadspildprojektTests
{
    [TestFixture]
    public class OpskriftTest
    {
        [TestCase(0, Result = "Forloren hare")]
        [TestCase(1, Result = "Æggekage")]
        [TestCase(2, Result = "Kødsovs")]
        [TestCase(3, Result = "hakkede tomat")]
        [TestCase(4, Result = "dåse tomatpure")]
        public string indlæsTest(int i)
        {
            //arrange
            Opskrift o = new Opskrift();
            //act
            o.Indlæs("Opskrifter.txt"); // Eller skal det være et TestFil.

            //assert
            if (i < 3)
	        {
		        string h = o.Opskrifter[i].retNavn;
                return h;
	        }
            else
            {
                string h = o.Opskrifter[2].Ingredienser[i]._Navn;
                return h;
            }

            
        }
        [Test]
        public void ForslåEfterVareTest() // mangler info
        {
            //Arrange
            Opskrift O = new Opskrift();
            string[] o = { "Forloren hare", "Æggekage", };
            O.Indlæs("Opskrifter.txt");
            string[] h = { "bacon" , "æg" };
            List<Opskrift> ol = new List<Opskrift>();
            //Act
            ol = O.ForeslåEfterVarer(h);
            //Assert
            for (int i = 0; i < ol.Count(); i++)
            {
                Assert.AreEqual(o[i], ol[i].retNavn);
            }
        }
        [Test]
        public void ForslåEfterListeTest1()
        {
            //Arrange
            Opskrift o = new Opskrift();
            Producent p = new Producent();
            List<Vare> v = p.indlaesProdukter("Produktkatalog.txt");
            List<Vare> v2 = new List<Vare>();
            for (int i = 0; i < 20; i += 2)
            {
                v2.Add(v[i]);
            }
            o.Indlæs("Opskrifter.txt");
            //Act
            List<Opskrift> op = o.ForeslåEfterListe(v2);
            int[] vareMatch = new int[] { 0, 0, 0, 0, 0 };
            int y = 0;
            foreach (Opskrift oo in op)
            {
                foreach (Vare v3 in oo.Ingredienser)
                {
                    foreach (Vare v1 in v2)
                    {
                        if (v3._Navn == v1._Navn)
                        {
                            vareMatch[y]++;
                        }
                    }
                }
                y++;
            }               
            //Assert
            Assert.GreaterOrEqual(vareMatch[0], vareMatch[1]);

        }
        [Test]
        public void ForslåEfterListeTest2()
        {
            //Arrange
            Opskrift o = new Opskrift();
            Producent p = new Producent();
            List<Vare> v = p.indlaesProdukter("Produktkatalog.txt");
            List<Vare> v2 = new List<Vare>();
            for (int i = 0; i < 20; i += 2)
            {
                v2.Add(v[i]);
            }
            o.Indlæs("Opskrifter.txt");
            //Act
            List<Opskrift> op = o.ForeslåEfterListe(v2);
            int[] vareMatch = new int[] { 0, 0, 0, 0, 0 };
            int y = 0;
            foreach (Opskrift oo in op)
            {
                foreach (Vare v3 in oo.Ingredienser)
                {
                    foreach (Vare v1 in v2)
                    {
                        if (v3._Navn == v1._Navn)
                        {
                            vareMatch[y]++;
                        }
                    }
                }
                y++;
            }
            //Assert
            Assert.GreaterOrEqual(vareMatch[0], vareMatch[2]);
        }
        [Test]
        public void ForslåEfterListeTest3()
        {
            //Arrange
            Opskrift o = new Opskrift();
            Producent p = new Producent();
            List<Vare> v = p.indlaesProdukter("Produktkatalog.txt");
            List<Vare> v2 = new List<Vare>();
            for (int i = 0; i < 20; i += 2)
            {
                v2.Add(v[i]);
            }
            o.Indlæs("Opskrifter.txt");
            //Act
            List<Opskrift> op = o.ForeslåEfterListe(v2);
            int[] vareMatch = new int[] { 0, 0, 0, 0, 0 };
            int y = 0;
            foreach (Opskrift oo in op)
            {
                foreach (Vare v3 in oo.Ingredienser)
                {
                    foreach (Vare v1 in v2)
                    {
                        if (v3._Navn == v1._Navn)
                        {
                            vareMatch[y]++;
                        }
                    }
                }
                y++;
            }
            //Assert
            Assert.GreaterOrEqual(vareMatch[0], vareMatch[3]);
        }
        [Test]
        public void ForslåEfterListeTest4()
        {
            //Arrange
            Opskrift o = new Opskrift();
            Producent p = new Producent();
            List<Vare> v = p.indlaesProdukter("Produktkatalog.txt");
            List<Vare> v2 = new List<Vare>();
            for (int i = 0; i < 20; i += 2)
            {
                v2.Add(v[i]);
            }
            o.Indlæs("Opskrifter.txt");
            //Act
            List<Opskrift> op = o.ForeslåEfterListe(v2);
            int[] vareMatch = new int[] { 0, 0, 0, 0, 0 };
            int y = 0;
            foreach (Opskrift oo in op)
            {
                foreach (Vare v3 in oo.Ingredienser)
                {
                    foreach (Vare v1 in v2)
                    {
                        if (v3._Navn == v1._Navn)
                        {
                            vareMatch[y]++;
                        }
                    }
                }
                y++;
            }
            //Assert
            Assert.GreaterOrEqual(vareMatch[0], vareMatch[4]);
        }
        [Test]
        public void ForslåEfterListeTest5()
        {
            //Arrange
            Opskrift o = new Opskrift();
            Producent p = new Producent();
            List<Vare> v = p.indlaesProdukter("Produktkatalog.txt");
            List<Vare> v2 = new List<Vare>();
            for (int i = 0; i < 20; i += 2)
            {
                v2.Add(v[i]);
            }
            o.Indlæs("Opskrifter.txt");
            //Act
            List<Opskrift> op = o.ForeslåEfterListe(v2);
            int[] vareMatch = new int[] { 0, 0, 0, 0, 0 };
            int y = 0;
            foreach (Opskrift oo in op)
            {
                foreach (Vare v3 in oo.Ingredienser)
                {
                    foreach (Vare v1 in v2)
                    {
                        if (v3._Navn == v1._Navn)
                        {
                            vareMatch[y]++;
                        }
                    }
                }
                y++;
            }
            //Assert
            Assert.GreaterOrEqual(vareMatch[1], vareMatch[2]);
        }
        [Test]
        public void ForslåEfterListeTest6()
        {
            //Arrange
            Opskrift o = new Opskrift();
            Producent p = new Producent();
            List<Vare> v = p.indlaesProdukter("Produktkatalog.txt");
            List<Vare> v2 = new List<Vare>();
            for (int i = 0; i < 20; i += 2)
            {
                v2.Add(v[i]);
            }
            o.Indlæs("Opskrifter.txt");
            //Act
            List<Opskrift> op = o.ForeslåEfterListe(v2);
            int[] vareMatch = new int[] { 0, 0, 0, 0, 0 };
            int y = 0;
            foreach (Opskrift oo in op)
            {
                foreach (Vare v3 in oo.Ingredienser)
                {
                    foreach (Vare v1 in v2)
                    {
                        if (v3._Navn == v1._Navn)
                        {
                            vareMatch[y]++;
                        }
                    }
                }
                y++;
            }
            //Assert
            Assert.GreaterOrEqual(vareMatch[1], vareMatch[3]);
        }
        [Test]
        public void ForslåEfterListeTest7()
        {
            //Arrange
            Opskrift o = new Opskrift();
            Producent p = new Producent();
            List<Vare> v = p.indlaesProdukter("Produktkatalog.txt");
            List<Vare> v2 = new List<Vare>();
            for (int i = 0; i < 20; i += 2)
            {
                v2.Add(v[i]);
            }
            o.Indlæs("Opskrifter.txt");
            //Act
            List<Opskrift> op = o.ForeslåEfterListe(v2);
            int[] vareMatch = new int[] { 0, 0, 0, 0, 0 };
            int y = 0;
            foreach (Opskrift oo in op)
            {
                foreach (Vare v3 in oo.Ingredienser)
                {
                    foreach (Vare v1 in v2)
                    {
                        if (v3._Navn == v1._Navn)
                        {
                            vareMatch[y]++;
                        }
                    }
                }
                y++;
            }
            //Assert
            Assert.GreaterOrEqual(vareMatch[1], vareMatch[4]);
        }
        [Test]
        public void ForslåEfterListeTest8()
        {
            //Arrange
            Opskrift o = new Opskrift();
            Producent p = new Producent();
            List<Vare> v = p.indlaesProdukter("Produktkatalog.txt");
            List<Vare> v2 = new List<Vare>();
            for (int i = 0; i < 20; i += 2)
            {
                v2.Add(v[i]);
            }
            o.Indlæs("Opskrifter.txt");
            //Act
            List<Opskrift> op = o.ForeslåEfterListe(v2);
            int[] vareMatch = new int[] { 0, 0, 0, 0, 0 };
            int y = 0;
            foreach (Opskrift oo in op)
            {
                foreach (Vare v3 in oo.Ingredienser)
                {
                    foreach (Vare v1 in v2)
                    {
                        if (v3._Navn == v1._Navn)
                        {
                            vareMatch[y]++;
                        }
                    }
                }
                y++;
            }
            //Assert
            Assert.GreaterOrEqual(vareMatch[2], vareMatch[3]);
        }
        [Test]
        public void ForslåEfterListeTest9()
        {
            //Arrange
            Opskrift o = new Opskrift();
            Producent p = new Producent();
            List<Vare> v = p.indlaesProdukter("Produktkatalog.txt");
            List<Vare> v2 = new List<Vare>();
            for (int i = 0; i < 20; i += 2)
            {
                v2.Add(v[i]);
            }
            o.Indlæs("Opskrifter.txt");
            //Act
            List<Opskrift> op = o.ForeslåEfterListe(v2);
            int[] vareMatch = new int[] { 0, 0, 0, 0, 0 };
            int y = 0;
            foreach (Opskrift oo in op)
            {
                foreach (Vare v3 in oo.Ingredienser)
                {
                    foreach (Vare v1 in v2)
                    {
                        if (v3._Navn == v1._Navn)
                        {
                            vareMatch[y]++;
                        }
                    }
                }
                y++;
            }
            //Assert
            Assert.GreaterOrEqual(vareMatch[2], vareMatch[4]);
        }
        [Test]
        public void ForslåEfterListeTest10()
        {
            //Arrange
            Opskrift o = new Opskrift();
            Producent p = new Producent();
            List<Vare> v = p.indlaesProdukter("Produktkatalog.txt");
            List<Vare> v2 = new List<Vare>();
            for (int i = 0; i < 20; i += 2)
            {
                v2.Add(v[i]);
            }
            o.Indlæs("Opskrifter.txt");
            //Act
            List<Opskrift> op = o.ForeslåEfterListe(v2);
            int[] vareMatch = new int[] { 0, 0, 0, 0, 0 };
            int y = 0;
            foreach (Opskrift oo in op)
            {
                foreach (Vare v3 in oo.Ingredienser)
                {
                    foreach (Vare v1 in v2)
                    {
                        if (v3._Navn == v1._Navn)
                        {
                            vareMatch[y]++;
                        }
                    }
                }
                y++;
            }
            //Assert
            Assert.GreaterOrEqual(vareMatch[3], vareMatch[4]);
        }

        [Test]
        public void TilføjOpskriftTilFilTest() 
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
            to.TilføjOpskriftTilFil(retNavn, ingredienser, instruktioner);

            //Assert
            Assert.AreEqual(retNavn, to.Opskrifter[to.Opskrifter.Count-1].retNavn);
        }
    }
}
