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
        [TestCase(3, Result = "hakkede tomater")]
        [TestCase(4, Result = "dåse tomatpure")]
        public string indlæsTest(int i)
        {
            //arrange
            Opskrift o = new Opskrift();
            //act
            o.Indlæs("Opskrifter.txt"); // filnavn som parameter

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
        public void ForslåEfterVareTest()
        {
            //Arrange
            Opskrift O = new Opskrift();
            string[] o = { "Forloren hare", "Æggekage" };
            O.Indlæs("Opskrifter.txt");
            string[] h = { "bacon" , "æg" };
            List<Opskrift> ol = new List<Opskrift>();
            //Act
            ol = O.ForeslåEfterVarer(h);
            //Assert
            for (int i = 0; i < ol.Count; i++)
            {
                Assert.AreEqual(o[i], ol[i].retNavn);
            }
        }
        [Test]
        public void ForslåEfterListeTest()
        {
            //Arrange
            int vareMatch = 0;
            Opskrift o = new Opskrift();
            Producent p = new Producent();
            List<Vare> v = p.indlaesProdukter("Produktkatalog.txt");
            List<Vare> v2 = new List<Vare>();
            for (int i = 0; i < 10; i += 2)
            {
                v2.Add(v[i]);
            }
            o.Indlæs("Opskrifter.txt");
            //Act
            List<Opskrift> op = o.ForeslåEfterListe(v2);
            foreach (Vare v1 in v2)
	        {
		        if (v1._Navn == op[0].Ingredienser.ToString())
	            {
		        vareMatch++; 
	            }
        	}

            //Assert
            Assert.GreaterOrEqual(vareMatch, 1);
        }
    }
}
