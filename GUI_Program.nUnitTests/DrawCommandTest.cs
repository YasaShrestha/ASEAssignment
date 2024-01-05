using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Program.nUnitTests
{
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
            String command = "circle 80"; ;
            parser.processEngine(null, command, true);

            Assert.AreEqual("0,0", parser.getPenPos());
        }

        [Test]
        public void RectangleValidTest()
        {
            String command = "rectangle 40,40"; ;
            parser.processEngine(null, command, true);

            Assert.AreEqual("0,0", parser.getPenPos());
        }
    }
}
