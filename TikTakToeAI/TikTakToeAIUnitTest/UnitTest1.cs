using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TikTakToeAIUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CountingHowManySymbols()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            for(int i = 0; i < 9; i++)
            {
                board.Add(" ");
            }
            board[0] = "X";
            string symbol = "X";
            List<int> whichToCheck = new List<int>();
            whichToCheck.Add(0);
            whichToCheck.Add(1);
            whichToCheck.Add(2);
            int result = program.countingHowManySymbolsInTheGivenRow(symbol, whichToCheck, board);

            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void CountingHowManySymbols_2()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                board.Add(" ");
            }
            board[0] = "X";
            board[1] = "X";
            string symbol = "X";
            List<int> whichToCheck = new List<int>();
            whichToCheck.Add(0);
            whichToCheck.Add(1);
            whichToCheck.Add(2);
            int result = program.countingHowManySymbolsInTheGivenRow(symbol, whichToCheck, board);

            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void CountingHowManySymbols_3()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                board.Add(" ");
            }
            board[0] = "X";
            board[2] = "X";
            string symbol = "X";
            List<int> whichToCheck = new List<int>();
            whichToCheck.Add(0);
            whichToCheck.Add(1);
            whichToCheck.Add(2);
            int result = program.countingHowManySymbolsInTheGivenRow(symbol, whichToCheck, board);

            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void CountingHowManySymbols_4()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                board.Add(" ");
            }
            board[0] = "X";
            board[1] = "O";
            string symbol = "X";
            List<int> whichToCheck = new List<int>();
            whichToCheck.Add(0);
            whichToCheck.Add(1);
            whichToCheck.Add(2);
            int result = program.countingHowManySymbolsInTheGivenRow(symbol, whichToCheck, board);

            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void CheckingWhichOneIsEmpty()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                board.Add(" ");
            }
            board[0] = "X";
            board[1] = "O";
            List<int> whichToCheck = new List<int>();
            whichToCheck.Add(0);
            whichToCheck.Add(1);
            whichToCheck.Add(2);
            int result = program.checkingWhichOneIsEmpty(whichToCheck, board);

            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void checkingIfOtherPlayerWillWinNextTurn()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                board.Add(" ");
            }
            board[0] = "X";
            board[1] = "O";
            bool result = program.checkingIfOtherPlayerWillWinNextTurn(board);

            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void checkingIfOtherPlayerWillWinNextTurn_2()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                board.Add(" ");
            }
            board[0] = "X";
            board[1] = "O";
            board[2] = "X";
            bool result = program.checkingIfOtherPlayerWillWinNextTurn(board);

            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void checkingIfOtherPlayerWillWinNextTurn_3()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                board.Add(" ");
            }
            board[0] = "X";
            board[1] = " ";
            board[2] = "X";
            bool result = program.checkingIfOtherPlayerWillWinNextTurn(board);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void checkingIfOtherPlayerWillWinNextTurn_4()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                board.Add(" ");
            }
            board[0] = " ";
            board[1] = "X";
            board[2] = "X";
            bool result = program.checkingIfOtherPlayerWillWinNextTurn(board);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void WhereToGo()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                board.Add(" ");
            }
            board[0] = " ";
            board[1] = "X";
            board[2] = "X";
            int result = program.whereToGo(board);

            Assert.AreEqual(result, 0);
        }
        [TestMethod]
        public void WhereToGo_3()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                board.Add(" ");
            }
            board[0] = "X";
            board[1] = "X";
            board[2] = " ";
            int result = program.whereToGo(board);

            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void WhereToGo_4()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                board.Add(" ");
            }
            board[0] = " ";
            board[1] = " ";
            board[2] = " ";
            board[3] = " ";
            board[4] = "X";
            board[5] = "X";
            int result = program.whereToGo(board);

            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void CountingHowManyPossiblePlaces()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                board.Add(" ");
            }
            board[0] = " ";
            board[1] = " ";
            board[2] = " ";
            board[3] = " ";
            board[4] = " ";
            board[5] = " ";
            board[6] = " ";
            board[7] = " ";
            board[8] = "X";

            List<int> whichToCheck = new List<int>();
            whichToCheck.Add(0);
            whichToCheck.Add(1);
            whichToCheck.Add(2);

            int result = program.countingHowManyPossibleFields(whichToCheck, board);

            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void CountingHowManyPossiblePlaces_2()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                board.Add(" ");
            }
            board[0] = " ";
            board[1] = "X";
            board[2] = " ";
            board[3] = " ";
            board[4] = " ";
            board[5] = " ";
            board[6] = " ";
            board[7] = " ";
            board[8] = " ";

            List<int> whichToCheck = new List<int>();
            whichToCheck.Add(0);
            whichToCheck.Add(1);
            whichToCheck.Add(2);

            int result = program.countingHowManyPossibleFields(whichToCheck, board);

            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void BestPlaceToTake()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                board.Add(" ");
            }

            board[0] = " ";
            board[1] = " ";
            board[2] = " ";
            board[3] = " ";
            board[4] = " ";
            board[5] = " ";
            board[6] = " ";
            board[7] = " ";
            board[8] = " ";

            int result = program.bestPlaceToTake(board);

            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void WhereToGo_Final()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                board.Add(" ");
            }
            board[0] = " ";
            board[1] = " ";
            board[2] = " ";
            board[3] = " ";
            board[4] = " ";
            board[5] = " ";
            board[6] = " ";
            board[7] = " ";
            board[8] = " ";

            int result = program.whereToGo(board);

            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void WhereToGo_Final_2()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                board.Add(" ");
            }
            board[0] = " ";
            board[1] = " ";
            board[2] = " ";
            board[3] = " ";
            board[4] = "X";
            board[5] = " ";
            board[6] = " ";
            board[7] = " ";
            board[8] = " ";

            int result = program.whereToGo(board);

            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void WhereToGo_Final_3()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                board.Add(" ");
            }
            board[0] = "X";
            board[1] = " ";
            board[2] = "O";
            board[3] = " ";
            board[4] = "X";
            board[5] = " ";
            board[6] = " ";
            board[7] = " ";
            board[8] = " ";

            int result = program.whereToGo(board);

            Assert.AreEqual(result, 8);
        }

        [TestMethod]
        public void WhereToGo_Final_4()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                board.Add(" ");
            }
            board[0] = "X";
            board[1] = " ";
            board[2] = "O";
            board[3] = " ";
            board[4] = "X";
            board[5] = " ";
            board[6] = "X";
            board[7] = " ";
            board[8] = "O";

            int result = program.whereToGo(board);

            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void WhereToGo_Final_5()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                board.Add(" ");
            }
            board[0] = "X";
            board[1] = " ";
            board[2] = " ";
            board[3] = " ";
            board[4] = " ";
            board[5] = " ";
            board[6] = " ";
            board[7] = " ";
            board[8] = " ";

            int result = program.whereToGo(board);

            Assert.AreEqual(result, 4);
        }
    }
}
