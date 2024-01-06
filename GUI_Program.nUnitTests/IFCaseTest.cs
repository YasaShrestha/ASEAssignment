using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Program.nUnitTests
{
    /* this is a test class for valid  and invalid test of IF command.
     */
    internal class IfCaseTest
    {

        CommandParser parser;
        [SetUp]
        public void Setup()
        {
            parser = new CommandParser();
        }

        [Test]
        public void IfValidTest()
        {
            String command = "if 5<20"; 
            parser.processEngine(null, command, true);

            Assert.AreEqual("0,0", parser.getPenPos());
        }

        [Test]
        public void IfValidTest2()
        {
            String command = "if 70>50"; 
            parser.processEngine(null, command, true);
            Assert.AreEqual("0,0", parser.getPenPos());
        }

        [Test]
        public void IfInValidTest()
        {
            String command = "if a<"; 
            var exception = Assert.Throws<GPLException>(() => parser.processEngine(null, command, true));

            Assert.AreEqual("a value is not a integer.", exception.Message);

            Assert.AreEqual("0,0", parser.getPenPos());
        }

        [Test]
        public void IfInValidTest2()
        {
            String command = "if <=b"; 
            var exception = Assert.Throws<GPLException>(() => parser.processEngine(null, command, true));

            Assert.AreEqual(" value is not a integer.", exception.Message);
            Assert.AreEqual("0,0", parser.getPenPos());
        }




    }
}
