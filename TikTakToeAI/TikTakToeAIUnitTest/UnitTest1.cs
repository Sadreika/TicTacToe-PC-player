using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TikTakToeAIUnitTest
{
    [TestClass]
    public class UnitTest1
    {    
        public List<string> settingBoardList(List<string> board)
        {
            for (int i = 0; i < 9; i++){
                board.Add(" ");
            }
            return board;
        }

        [TestMethod]
        public void countingHowManyThereAreGivenSymbolIsInTheGivenRowUnitTest()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            List<int> whichToCheck = new List<int>();
            board = settingBoardList(board);

            string symbol_X = "X";
            string symbol_O = "O";

            board[0] = "X";
            board[1] = "O";
            board[2] = " ";
            whichToCheck.Add(0);

            int result_1 = program.countingHowManyThereAreGivenSymbolIsInTheGivenRow(symbol_X, whichToCheck, board);
            int result_2 = program.countingHowManyThereAreGivenSymbolIsInTheGivenRow(symbol_O, whichToCheck, board);

            whichToCheck[0] = 1;

            int result_3 = program.countingHowManyThereAreGivenSymbolIsInTheGivenRow(symbol_X, whichToCheck, board);
            int result_4 = program.countingHowManyThereAreGivenSymbolIsInTheGivenRow(symbol_O, whichToCheck, board);

            whichToCheck[0] = 2;

            int result_5 = program.countingHowManyThereAreGivenSymbolIsInTheGivenRow(symbol_X, whichToCheck, board);
            int result_6 = program.countingHowManyThereAreGivenSymbolIsInTheGivenRow(symbol_O, whichToCheck, board);

            Assert.AreEqual(result_1, 1);
            Assert.AreEqual(result_2, -1);
            Assert.AreEqual(result_3, -1);
            Assert.AreEqual(result_4, 1);
            Assert.AreEqual(result_5, 0);
            Assert.AreEqual(result_6, 0);
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
            //int result = program.checkingWhichOneIsEmpty(whichToCheck, board);

            //Assert.AreEqual(result, 2);
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
            board[1] = " ";
            board[2] = "X";
            string pcPlayerSymbol = "X";
            bool result_1 = program.checkingIfOtherPlayerWillWinNextTurn(pcPlayerSymbol, board);
            pcPlayerSymbol = "O";
            bool result_2 = program.checkingIfOtherPlayerWillWinNextTurn(pcPlayerSymbol, board);

            Assert.AreEqual(result_1, false);
            Assert.AreEqual(result_2, true);
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
        public void WhereToGo_Final_5()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            List<int> whichToCheck = new List<int>();
            board = settingBoardList(board);
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

        [TestMethod]
        public void checkingIfSelectedWindowIsEmpty()
        {
            TikTakToeAI.Program program = new TikTakToeAI.Program();
            List<string> board = new List<string>();
            List<int> whichToCheck = new List<int>();
            board = settingBoardList(board);
            board.Add(" ");
            board[0] = "X";
            bool result_1 = program.checkingIfSelectedWindowIsEmpty(0, board);
            board[0] = "O";
            bool result_2 = program.checkingIfSelectedWindowIsEmpty(0, board);
            board[0] = " ";
            bool result_3 = program.checkingIfSelectedWindowIsEmpty(0, board);

            Assert.AreEqual(result_1, false);
            Assert.AreEqual(result_2, false);
            Assert.AreEqual(result_3, true);
        }
    }
}
