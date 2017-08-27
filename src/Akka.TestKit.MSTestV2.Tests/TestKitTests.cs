﻿using Akka.Actor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Akka.TestKit.MSTestV2.Tests
{
    [TestClass]
    public class TestKitTests : TestKit
    {
        [TestCleanup]
        public void Cleanup()
        {
            Shutdown();
        }

        [TestMethod]
        public void Expect_a_message()
        {
            TestActor.Tell("Test");
            ExpectMsg("Test");
        }
    }
}
