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
        [TestCase(0, Result="Forloren hare")]
        [TestCase(1, Result="Æggekage")]
        [TestCase(2, Result="Kødsovs")]
        public string indlæsTest(int i)
        {
            //arrange
            Opskrift o = new Opskrift();
            //act
            o.Indlæs(@"C:\Users\Mark\Documents\GitHub\MadspildP2\Opskrifter.txt"); // filnavn som parameter
            //assert
            string h = o.Opskrifter[i].retNavn;
            return h;
            
        }
        [Test]
        public void RasmusKTest()
        {
            Assert.AreEqual(3, 2);
        }
    }
}
