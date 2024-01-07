using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Program.nUnitTests
{
    /* this is valid command test class which test all valid  commads that users inputs while drawing shapes.
     */
    internal class DrawCommandTest
    {

        CommandParser parser;
        [SetUp]
        public void Setup()
        {
            parser = new CommandParser();
        }

        [Test]
        public void CircleValidTest()
        {
            String command = "circle 80"; 
            parser.processEngine(null, command, true);

            Assert.AreEqual("0,0", parser.getPenPos());
        }

        [Test]
        public void RectangleValidTest()
        {
            String command = "rectangle 40,40"; 
            parser.processEngine(null, command, true);

            Assert.AreEqual("0,0", parser.getPenPos());
        }

        [Test]
        public void TriangleValidTest()
        {
            String command = "triangle 40,40"; 
            parser.processEngine(null, command, true);

            Assert.AreEqual("0,0", parser.getPenPos());
        }

        [Test]
        public void DrawToValidTest()
        {
            String command = "drawto 40,40"; 
            parser.processEngine(null, command, true);

            Assert.AreEqual("0,0", parser.getPenPos());
        }

    }
}
