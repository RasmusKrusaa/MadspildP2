using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MadspildGUI;
using System.Windows.Forms;

namespace MadspildprojektTests
{
    [TestFixture]
    class HusholdningTest
    {
        Husholdning h = new Husholdning();
        DateTime Igaar = DateTime.Today.AddDays(-1);
        DateTime Imorgen = DateTime.Today.AddDays(1);
        DateTime Idag = DateTime.Today;
        DateTime EnDagForGammel = DateTime.Today.AddDays(-31);
        DateTime PræcisGammel = DateTime.Today.AddDays(-30);
        DateTime NæstenGammel = DateTime.Today.AddDays(-29);
        DateTime MegetGammel = DateTime.Today.AddDays(-123);
        VareStkMH v1 = new VareStkMH("æg");
        VareVægtSA v2 = new VareVægtSA("bacon");
        VareVægtMH v3 = new VareVægtMH("humus");
        VareVægtSA v4 = new VareVægtSA("banan");
        VareStkMH v5 = new VareStkMH("tomat");

        [Test]
        public void DatoAdvarselTest()
        {
            //Arrange
            v1.MindstHoldbar = Imorgen;
            v2.SidsteAnvendelse = Igaar;
            v3.MindstHoldbar = Igaar;
            v4.SidsteAnvendelse = Idag;
            v5.MindstHoldbar = MegetGammel;

            //Act
            h.TilføjVare(v1, h.HusBeholdning);
            h.TilføjVare(v2, h.HusBeholdning);
            h.TilføjVare(v3, h.HusBeholdning);
            h.TilføjVare(v4, h.HusBeholdning);
            h.TilføjVare(v5, h.HusBeholdning);
            h.DatoAdvarsel(DateTime.Today);
            
            //Assert
            Assert.AreEqual(v1, h.HusBeholdning[0]);
        }
        [Test]
        public void DatoAdvarselAntalIListeTest()
        {
            //Arrange
            v1.MindstHoldbar = Imorgen;
            v2.SidsteAnvendelse = Igaar;
            v3.MindstHoldbar = Igaar;
            v4.SidsteAnvendelse = Idag;
            v5.MindstHoldbar = MegetGammel;

            //Act
            h.TilføjVare(v1, h.HusBeholdning);
            h.TilføjVare(v2, h.HusBeholdning);
            h.TilføjVare(v3, h.HusBeholdning);
            h.TilføjVare(v4, h.HusBeholdning);
            h.TilføjVare(v5, h.HusBeholdning);
            h.DatoAdvarsel(DateTime.Today);

            //Assert
            Assert.AreEqual(1, h.HusBeholdning.Count);
        }
        [TestCase(0, Result = "humus")]
        [TestCase(1, Result = "banan")]
        public string SletGammelVareTestCases(int i)
        {
            //Arrange
            v1.MindstHoldbar = PræcisGammel;
            v2.SidsteAnvendelse = MegetGammel;
            v3.MindstHoldbar = NæstenGammel;
            v4.SidsteAnvendelse = Idag;
            v5.MindstHoldbar = EnDagForGammel;

            //Act & Assert
            h.TilføjVare(v1, h.HusBeholdning);
            h.TilføjVare(v2, h.HusBeholdning);
            h.TilføjVare(v3, h.HusBeholdning);
            h.TilføjVare(v4, h.HusBeholdning);
            h.TilføjVare(v5, h.HusBeholdning);
            h.SletGammelVare(DateTime.Today.AddDays(-30));

            return h.HusBeholdning[i]._Navn;
        }
        [Test]
        public void SletGammelVareTest()
        {
            //Arrange
            v1.MindstHoldbar = PræcisGammel;
            v2.SidsteAnvendelse = MegetGammel;
            v3.MindstHoldbar = NæstenGammel;
            v4.SidsteAnvendelse = Idag;
            v5.MindstHoldbar = EnDagForGammel;

            //Act
            h.TilføjVare(v1, h.HusBeholdning);
            h.TilføjVare(v2, h.HusBeholdning);
            h.TilføjVare(v3, h.HusBeholdning);
            h.TilføjVare(v4, h.HusBeholdning);
            h.TilføjVare(v5, h.HusBeholdning);
            h.SletGammelVare(DateTime.Today.AddDays(-30));

            //Assert
            Assert.AreEqual(2, h.HusBeholdning.Count);
        }

        [TestCase(0, Result = 8)]
        [TestCase(1, Result = 50)]
        [TestCase(2, Result = 200)]
        [TestCase(3, Result = 150)]
        [TestCase(4, Result = 5)]
        public decimal SletVareUdFraOpskriftTest(int i)
        {
            //Arrange
            decimal TestVolume = 0;
            h.HusBeholdning.Clear();
            Opskrift o = new Opskrift();
            o.Indlæs("Opskrifter.txt");
            v1.Stk = 16;
            v2.Vægt = 150;
            v3.Vægt = 200;
            v4.Vægt = 150;
            v5.Stk = 10;         
            //Act & Assert
            if (h.HusBeholdning.Count == 0)
            {
                h.TilføjVare(v1, h.HusBeholdning);
                h.TilføjVare(v2, h.HusBeholdning);
                h.TilføjVare(v3, h.HusBeholdning);
                h.TilføjVare(v4, h.HusBeholdning);
                h.TilføjVare(v5, h.HusBeholdning);
            }
            h.SkrivListeAfVarerTilFil("HusholdningTest.txt", h.HusBeholdning);
            h.SletVareUdFraOpskrift(o.Opskrifter[1], "HusholdningTest.txt");
            TestVolume = h.HusBeholdning[i].VolumenTjek();
            return TestVolume;
        }
    }
}
