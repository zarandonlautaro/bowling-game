using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class BowlingModelShould
    {
        BowlingModel bowlingModel;
        public void CreateModel()
        {
            bowlingModel = new BowlingModel();
        }


        [Test]
        public void AddScoreToPlayer()
        {
            CreateModel();

            bowlingModel.player1.AddScore(0, 0, 5);


            Assert.AreEqual(5, bowlingModel.player1.GetScore(0, 0));
        }
        [Test]
        public void AddScoreLessThan11On2ndThrow()
        {
            CreateModel();

            bowlingModel.player1.AddScore(0, 0, 5);
            var ok = bowlingModel.player1.AddScore(0, 1, 6);

            Assert.IsFalse(ok);
        }
        [Test]
        public void AddScoreLessThan11On1stThrow()
        {
            CreateModel();

            var ok = bowlingModel.player1.AddScore(0, 0, 11);
            Assert.IsFalse(ok);
        }

        [Test]
        public void PointsWithoutStrikeAndSpare()
        {
            CreateModel();
            int[,] scores = new int[10, 2] {
                { 5, 3 }, { 5, 1 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 4, 3 }
            };

            bowlingModel.player1.AddAllScores(scores);

            int points = bowlingModel.GetTotalScore(bowlingModel.player1);
            Assert.AreEqual(53, points);
        }
        
        
        [Test]
        public void PointsWithoutStrikeAndSpareAgain()
        {
            CreateModel();
            int[,] scores = new int[10, 2] {
                { 5, 3 }, { 5, 0 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 4, 3 }
            };
            bowlingModel.player1.AddAllScores(scores);

            int points = bowlingModel.GetTotalScore(bowlingModel.player1);
            Assert.AreEqual(52, points);
        }
        [Test]
        public void PointsWithSpare()
        {
            CreateModel();
            int[,] scores = new int[10, 2] {
                { 5, 5 }, { 5, 0 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 4, 3 }
            };
            bowlingModel.player1.AddAllScores(scores);

            int points = bowlingModel.GetTotalScore(bowlingModel.player1);
            Assert.AreEqual(59, points);
        }
        [Test]
        public void PointsWithStrike()
        {
            CreateModel();
            int[,] scores = new int[10, 2] {
                { 10, 0 }, { 5, 1 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 4, 3 }
            };
            bowlingModel.player1.AddAllScores(scores);

            int points = bowlingModel.GetTotalScore(bowlingModel.player1);
            Assert.AreEqual(61, points);
        }
    
        [Test]
        public void PointsSpareInLastThrow()
        {
            CreateModel();
            int[,] scores = new int[11, 2] {
                    { 4, 3 }, { 5, 1 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 5, 5 }, { 1, 0 }
                };
            bowlingModel.player1.AddAllScores(scores);

            int points = bowlingModel.GetTotalScore(bowlingModel.player1);
            Assert.AreEqual(57, points);
        }
        [Test]
        public void PointsStrikeInLastThrow()
        {
            CreateModel();
            int[,] scores = new int[11, 2] {
                { 4, 3 }, { 5, 1 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 10, 0 }, { 5, 3 }
            };
            bowlingModel.player1.AddAllScores(scores);
            int points = bowlingModel.GetTotalScore(bowlingModel.player1);
            Assert.AreEqual(71, points);
        }




    }


}
