using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Program.nUnitTests
{
    /* this is Invalid test class which test all invalid  commads that users inputs while drawing shapes.
     */
    internal class InvalidDrawCommandTest
    {

        CommandParser parser;
        [SetUp]
        public void Setup()
        {
            parser = new CommandParser();
        }

        [Test]
        public void CircleInvalidTest()
        {
            String command = "circle x"; 
            

            var exception = Assert.Throws<GPLException>(() => parser.processEngine(null, command, true));

            Assert.AreEqual("Cirlce need one parameter. Please input the valid radius value. Error at Line 1", exception.Message);
            Assert.AreEqual("0,0", parser.getPenPos());
        }

        [Test]
        public void RectangleInvalidTest()
        {
            String command = "rectangle"; 


            var exception = Assert.Throws<GPLException>(() => parser.processEngine(null, command, true));

            Assert.AreEqual("Please input valid width and height for rectangle  Error at Line 1", exception.Message);
            Assert.AreEqual("0,0", parser.getPenPos());
        }


        [Test]
        public void TriangleInvalidTest()
        {
            String command = "triangle a"; 


            var exception = Assert.Throws<GPLException>(() => parser.processEngine(null, command, true));

            Assert.AreEqual("Please input valid width and height for the triangle  Error at Line 1", exception.Message);
            Assert.AreEqual("0,0", parser.getPenPos());
        }


        [Test]
        public void MovetoInvalidTest()
        {
            String command = "moveto"; 


            var exception = Assert.Throws<GPLException>(() => parser.processEngine(null, command, true));

            Assert.AreEqual("Please input valid X axis and Y axis  Error at Line 1", exception.Message);
            Assert.AreEqual("0,0", parser.getPenPos());
        }

        [Test]
        public void DrawtoInvalidTest()
        {
            String command = "drawto"; 


            var exception = Assert.Throws<GPLException>(() => parser.processEngine(null, command, true));

            Assert.AreEqual("Please input valid starting point value and end point value  Error at Line 1", exception.Message);
            Assert.AreEqual("0,0", parser.getPenPos());
        }


    }
}
