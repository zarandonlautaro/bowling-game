using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class BowlingModelShould
    {

        [SetUp]
        public void SetUpBowlingModel()
        {

        }


        BowlingModel bowlingModel;
        public void CreateModel()
        {
            bowlingModel = new BowlingModel();
        }

        [Test]
        public void BowlingGeneralScoreWithoutStrikesAndSpares()
        {
            CreateModel();
            Assert.True(true);
        }

    }


}
