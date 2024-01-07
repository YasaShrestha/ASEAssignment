using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Program.nUnitTests
{
    /* This a test class for variable to test valid variables.
     */
    internal class VariableTest
    {

        CommandParser parser;
        [SetUp]
        public void Setup()
        {
            parser = new CommandParser();
        }


        [Test]
        public void VariablValidTest()
        {
            String command = "a=10";
            parser.processEngine(null, command, true);

            Assert.AreEqual("0,0", parser.getPenPos());
        }

        [Test]
        public void VariableValidTest2()
        {
            String command = "a=10\r\na=a*10";
            parser.processEngine(null, command, true);

            Assert.AreEqual("0,0", parser.getPenPos());
        }
    }
}
