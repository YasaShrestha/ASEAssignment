using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Program.nUnitTests
{
    /* This is method test class to test valid methods.
     */
    internal class MethodTest
    {

        CommandParser parser;
        [SetUp]
        public void Setup()
        {
            parser = new CommandParser();
        }


        [Test]
        public void MethodValidTest()
        {
            String command = "method run\r\ncircle 10\r\nendmethod";
            parser.processEngine(null, command, true);

            Assert.AreEqual("0,0", parser.getPenPos());

        }
            [Test]
            public void MethodValidTest2()
            {
                String command = "method run\r\ncircle 50\r\nendmethod\r\ncallmethod run";
                parser.processEngine(null, command, true);

                Assert.AreEqual("0,0", parser.getPenPos());
            }


        }
    }
