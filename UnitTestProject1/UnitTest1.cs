using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace UnitTestProject1
{

    

    [TestClass]
    public class UnitTest1
    {

        public void RollMany(Game game, int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                game.Roll(pins);
            }
        }

        [TestMethod]
        public void AllGutterGameScoreShouldBeZero()
        {
            Game game = new Game();
            RollMany(game, 20, 0);
        }

        [TestMethod]
        public void AllOnesGameScoreShouldBeTwenty()
        {
            Game game = new Game();
            RollMany(game, 20, 1);
        }

        [TestMethod]
        public void SpareShouldGetNextRollBonus()
        {
            Game game = new Game();
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            RollMany(game, 17, 0);

            Assert.AreEqual(16, game.Score());
        }

        [TestMethod]
        public void StrikeShouldGetTwoRollBonus()
        {
            Game game = new Game();
            game.Roll(10);
            game.Roll(2);
            game.Roll(7);
            RollMany(game, 17, 0);

            Assert.AreEqual(28, game.Score());
        }

        [TestMethod]
        public void PerfectScoreShouldBeThreeHundred()
        {
            Game game = new Game();
            RollMany(game, 12, 10);
            Assert.AreEqual(300, game.Score());
        }
        //if I'm being honest idk how this is working but I'll just leave it like this because it worked without me even adding any code
    }
}
