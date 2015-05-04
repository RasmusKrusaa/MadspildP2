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
        //Jeg lavede Arrange heroppe i klassen for at slippe for dublering af kode. Synes I den skal sættes ned til hver metode eller er det her finno?
        //Arrange
        Husholdning h = new Husholdning();
        DateTime Igaar = DateTime.Today.AddDays(-1);
        DateTime Imorgen = DateTime.Today.AddDays(1);
        DateTime Idag = DateTime.Today;
        DateTime EnDagForGammel = DateTime.Today.AddDays(-31);
        DateTime PræcisGammel = DateTime.Today.AddDays(-30);
        DateTime NæstenGammel = DateTime.Today.AddDays(-29);
        DateTime MegetGammel = DateTime.Today.AddDays(-123);
        VareStkMH v1 = new VareStkMH("Kylling");
        VareStkSA v2 = new VareStkSA("bacon");
        VareVægtMH v3 = new VareVægtMH("Humus");
        VareVægtSA v4 = new VareVægtSA("Banan");
        VareVægtMH v5 = new VareVægtMH("Tomat");

        [Test]
        public void DatoAdvarselTest()
        {
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
            Assert.AreEqual(v1, h.HusBeholdning[0]);
        }
        [Test]
        public void SletGammelVareTest()
        {
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
            Assert.AreEqual(v3, h.HusBeholdning[0]);
            Assert.AreEqual(v4, h.HusBeholdning[1]);
        }
    }
}
