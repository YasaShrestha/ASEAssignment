using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Program.nUnitTests
{
    /* 
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
            String command = "if 20"; ;
            parser.processEngine(null, command, true);

            Assert.AreEqual("0,0", parser.getPenPos());
        }

     

       
    }
}
