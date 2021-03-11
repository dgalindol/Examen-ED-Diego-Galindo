using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Examen_ED_Diego_Galindo;


namespace Examen_Test_Diego_Galindo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(5, 5)]
        public void TestMethod1(double ancho, double alto)
        {
            Rectangle r = new Rectangle();
            r.Height = alto;
            r.Width = ancho;

            double calc = r.Height * r.Width;

            Assert.AreEqual(calc, Rectangle.Area2(ancho, alto));
        }
    }
}
