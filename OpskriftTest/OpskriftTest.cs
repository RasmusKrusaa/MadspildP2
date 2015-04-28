﻿using System;
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
            o.Indlæs(@"C:\Users\mads\Desktop\program\MadspildP2\Opskrifter.txt"); // filnavn som parameter
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
            O.Indlæs(@"C:\Users\Mark\Documents\GitHub\MadspildP2\Opskrifter.txt");
            string[] h = { "bacon" };
            List<Opskrift> ol = new List<Opskrift>();
            //Act
            ol = O.ForeslåEfterVarer(h);
            //Assert
            Assert.AreEqual("Æggekage", ol[1].retNavn);
            
        }
    }
}
