using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToeAI
{
    public class Program
    {
        public int valueWhereToGo = -1;
        public void setWhereToGo(int value){
            valueWhereToGo = value;
        }

        static void Main(string[] args)
        {
            List<string> board = new List<string>();
            Program programObject = new Program();
            for(int i = 0; i < 9; i++)
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
            var finalValue = programObject.whereToGo(board);
            Console.WriteLine(finalValue);

        }
        public int whereToGo(List<string> board)
        {
            string pcPlayerSymbol = "O";
            int placeInTheListWhereToGo;
            bool willWin = checkingIfOtherPlayerWillWinNextTurn(pcPlayerSymbol, board);
            bool willIWin = checkingIfIWin(board);

            if(willIWin.Equals(true))
            {
                placeInTheListWhereToGo = valueWhereToGo;
                setWhereToGo(-1);
            }
            else if(willWin.Equals(true))
            {
                placeInTheListWhereToGo = valueWhereToGo;
                setWhereToGo(-1);
            }
            else
            {
                placeInTheListWhereToGo = bestPlaceToTake(board);
            }

            return placeInTheListWhereToGo;
        }
        public bool checkingIfIWin(List<string> board)
        {
            bool willIWin = false;
            List<int> whichToCheck = new List<int>();
            whichToCheck.Add(0);
            whichToCheck.Add(0);
            whichToCheck.Add(0);
            int howMuch = 0;

            for (int i = 0; i < 9; i = i + 3)
            {
                whichToCheck[0] = i;
                whichToCheck[1] = i + 1;
                whichToCheck[2] = i + 2;
                howMuch = countingHowManyThereAreGivenSymbolIsInTheGivenRow("O", whichToCheck, board);
                if (howMuch == 2)
                {
                    willIWin = true;
                    break;
                }
            }

            for (int i = 0; i < 3; i = i + 1)
            {
                whichToCheck[0] = i;
                whichToCheck[1] = i + 3;
                whichToCheck[2] = i + 6;
                howMuch = countingHowManyThereAreGivenSymbolIsInTheGivenRow("O", whichToCheck, board);
                if (howMuch == 2)
                {
                    willIWin = true;
                    break;
                }
            }

            whichToCheck[0] = 0;
            whichToCheck[1] = 4;
            whichToCheck[2] = 8;
            howMuch = countingHowManyThereAreGivenSymbolIsInTheGivenRow("O", whichToCheck, board);
            if (howMuch == 2)
            {
                willIWin = true;
            }

            whichToCheck[0] = 2;
            whichToCheck[1] = 4;
            whichToCheck[2] = 6;
            howMuch = countingHowManyThereAreGivenSymbolIsInTheGivenRow("O", whichToCheck, board);
            if (howMuch == 2)
            {
                willIWin = true;
            }
            return willIWin;
        }
        public int bestPlaceToTake(List<string>board)
        {
            int placeToTake = -1;
            int howManyPossibleFields = 0;
            List<int> valueList = new List<int>();
            List<int> whichToCheck = new List<int>();
            whichToCheck.Add(0);
            whichToCheck.Add(0);
            whichToCheck.Add(0);
            bool value;
            for(int i = 0; i < board.Count; i++)
            {
                value = checkingIfSelectedWindowIsEmpty(i, board);
                if(i == 0 && value.Equals(true))
                {
                    valueList.Add(0);
                    whichToCheck[0] = 0;
                    whichToCheck[1] = 1;
                    whichToCheck[2] = 2;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;

                    whichToCheck[0] = 0;
                    whichToCheck[1] = 3;
                    whichToCheck[2] = 6;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;
                  
                    whichToCheck[0] = 0;
                    whichToCheck[1] = 4;
                    whichToCheck[2] = 8;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;
                }
                else if (i == 0)
                {
                    valueList.Add(0);
                }
                if (i == 1 && value.Equals(true))
                {
                    valueList.Add(0);
                    whichToCheck[0] = 0;
                    whichToCheck[1] = 1;
                    whichToCheck[2] = 2;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;

                    whichToCheck[0] = 1;
                    whichToCheck[1] = 2;
                    whichToCheck[2] = 7;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;
                }
                else if (i == 1)
                {
                    valueList.Add(0);
                }
                if (i == 2 && value.Equals(true))
                {
                    valueList.Add(0);
                    whichToCheck[0] = 0;
                    whichToCheck[1] = 1;
                    whichToCheck[2] = 2;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;

                    whichToCheck[0] = 2;
                    whichToCheck[1] = 5;
                    whichToCheck[2] = 8;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;

                    whichToCheck[0] = 2;
                    whichToCheck[1] = 4;
                    whichToCheck[2] = 6;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;
                }
                else if (i == 2)
                {
                    valueList.Add(0);
                }
                if (i == 3 && value.Equals(true))
                {
                    valueList.Add(0);
                    whichToCheck[0] = 3;
                    whichToCheck[1] = 4;
                    whichToCheck[2] = 5;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;

                    whichToCheck[0] = 0;
                    whichToCheck[1] = 3;
                    whichToCheck[2] = 6;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;
                }
                else if (i == 3)
                {
                    valueList.Add(0);
                }
                if (i == 4 && value.Equals(true))
                {
                    valueList.Add(0);
                    whichToCheck[0] = 3;
                    whichToCheck[1] = 4;
                    whichToCheck[2] = 5;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;

                    whichToCheck[0] = 1;
                    whichToCheck[1] = 4;
                    whichToCheck[2] = 7;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;

                    whichToCheck[0] = 0;
                    whichToCheck[1] = 4;
                    whichToCheck[2] = 8;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;

                    whichToCheck[0] = 2;
                    whichToCheck[1] = 4;
                    whichToCheck[2] = 6;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;
                }
                else if(i == 4)
                {
                    valueList.Add(0);
                }
                if (i == 5 && value.Equals(true))
                {
                    valueList.Add(0);
                    whichToCheck[0] = 2;
                    whichToCheck[1] = 5;
                    whichToCheck[2] = 8;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;

                    whichToCheck[0] = 3;
                    whichToCheck[1] = 4;
                    whichToCheck[2] = 5;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;
                }
                else if (i == 5)
                {
                    valueList.Add(0);
                }
                if (i == 6 && value.Equals(true))
                {
                    valueList.Add(0);
                    whichToCheck[0] = 0;
                    whichToCheck[1] = 3;
                    whichToCheck[2] = 6;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;

                    whichToCheck[0] = 6;
                    whichToCheck[1] = 7;
                    whichToCheck[2] = 8;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;

                    whichToCheck[0] = 6;
                    whichToCheck[1] = 4;
                    whichToCheck[2] = 2;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;
                }
                else if (i == 6)
                {
                    valueList.Add(0);
                }
                if (i == 7 && value.Equals(true))
                {
                    valueList.Add(0);
                    whichToCheck[0] = 6;
                    whichToCheck[1] = 7;
                    whichToCheck[2] = 8;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;

                    whichToCheck[0] = 1;
                    whichToCheck[1] = 4;
                    whichToCheck[2] = 7;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;
                }
                else if (i == 7)
                {
                    valueList.Add(0);
                }
                if (i == 8 && value.Equals(true))
                {
                    valueList.Add(0);
                    whichToCheck[0] = 2;
                    whichToCheck[1] = 5;
                    whichToCheck[2] = 8;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;

                    whichToCheck[0] = 6;
                    whichToCheck[1] = 7;
                    whichToCheck[2] = 8;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;

                    whichToCheck[0] = 0;
                    whichToCheck[1] = 4;
                    whichToCheck[2] = 8;
                    howManyPossibleFields = countingHowManyPossibleFields(whichToCheck, board);
                    valueList[i] = valueList[i] + howManyPossibleFields;
                }
                else if (i == 8)
                {
                    valueList.Add(0);
                }
            }
            int maxindex = 0;
            int maxvalue = valueList[0];
            for (int i = 1; i < valueList.Count; i++)
            {
                if(maxvalue < valueList[i])
                {
                    maxvalue = valueList[i];
                    maxindex = i;
                }
            }
            int countOfEmptyPlaces = 0;
            int lastEmptySpot = 0;
            for(int i = 0; i < board.Count; i++)
            {
                if(board[i] == " ")
                {
                    countOfEmptyPlaces = countOfEmptyPlaces + 1;
                    lastEmptySpot = i;
                }    
            }
            if(countOfEmptyPlaces == 1)
            {
                placeToTake = lastEmptySpot;
            }
            else
            {
                placeToTake = maxindex;
            }
            
            return placeToTake;
        }
        public int countingHowManyPossibleFields(List<int> whichToCheck, List<string>board)
        {
            int howMany = 0;
            for(int i = 0; i < whichToCheck.Count; i++)
            {
                if(board[whichToCheck[i]].Equals(" ") || board[whichToCheck[i]].Equals("O"))
                {
                    howMany = howMany + 1;
                }
                if(board[whichToCheck[i]].Equals("X"))
                {
                    howMany = 0;
                    break;
                }
            }
            return howMany;
        }
        public bool checkingIfOtherPlayerWillWinNextTurn(string pcPlayerSymbol, List<string> boardList)
        {
            string enemieSymbol = "";
            if(pcPlayerSymbol.Equals("O")){
                enemieSymbol = "X";
            }
            else{
                enemieSymbol = "O";
            }
            bool willWin = false;
            List<int> whichWindowsNeedToCheck = new List<int>();
            whichWindowsNeedToCheck.Add(0);
            whichWindowsNeedToCheck.Add(0);
            whichWindowsNeedToCheck.Add(0);
            int howMany;
    
            for (int i = 0; i < 9; i = i + 3){
                whichWindowsNeedToCheck[0] = i;
                whichWindowsNeedToCheck[1] = i + 1;
                whichWindowsNeedToCheck[2] = i + 2;
                howMany = countingHowManyThereAreGivenSymbolIsInTheGivenRow(enemieSymbol, whichWindowsNeedToCheck, boardList);
                if(howMany == 2){
                    willWin = true;
                    break;
                }    
            }

            for(int i = 0; i < 3; i = i + 1){
                whichWindowsNeedToCheck[0] = i;
                whichWindowsNeedToCheck[1] = i + 3;
                whichWindowsNeedToCheck[2] = i + 6;
                howMany = countingHowManyThereAreGivenSymbolIsInTheGivenRow(enemieSymbol, whichWindowsNeedToCheck, boardList);
                if (howMany == 2){
                    willWin = true;
                    break;
                }
            }

            whichWindowsNeedToCheck[0] = 0;
            whichWindowsNeedToCheck[1] = 4;
            whichWindowsNeedToCheck[2] = 8;
            howMany = countingHowManyThereAreGivenSymbolIsInTheGivenRow(enemieSymbol, whichWindowsNeedToCheck, boardList);
            if (howMany == 2){
                willWin = true;
            }

            whichWindowsNeedToCheck[0] = 2;
            whichWindowsNeedToCheck[1] = 4;
            whichWindowsNeedToCheck[2] = 6;
            howMany = countingHowManyThereAreGivenSymbolIsInTheGivenRow(enemieSymbol, whichWindowsNeedToCheck, boardList);
            if (howMany == 2){
                willWin = true;
            }
            return willWin;
        }
        public int countingHowManyThereAreGivenSymbolIsInTheGivenRow(string givenSymbol, List<int> listOfWindowsWhichNeedToCheck, List<string> boardList)
        {
            int howManySymbols = 0;
            int windowWhichNeedToTake = -1;
            for (int i = 0; i < listOfWindowsWhichNeedToCheck.Count; i++)
            {
                if (boardList[listOfWindowsWhichNeedToCheck[i]].Equals(givenSymbol)){
                    howManySymbols = howManySymbols + 1;
                }
                if (boardList[listOfWindowsWhichNeedToCheck[i]].Equals(" ")){
                    windowWhichNeedToTake = listOfWindowsWhichNeedToCheck[i];
                }
                if(givenSymbol.Equals("X")){
                    if (boardList[listOfWindowsWhichNeedToCheck[i]].Equals("O")){
                        howManySymbols = -1;
                        break;
                    }
                }
                else if(givenSymbol.Equals("O")){
                    if (boardList[listOfWindowsWhichNeedToCheck[i]].Equals("X")){
                        howManySymbols = -1;
                        break;
                    }
                }
            }
            if (howManySymbols == 2){
                setWhereToGo(windowWhichNeedToTake);
            }
            return howManySymbols;
        }
        public bool checkingIfSelectedWindowIsEmpty(int whichWindowToCheck, List<string> boardList)
        {
            bool isEmpty = true;
            if(boardList[whichWindowToCheck] != " "){isEmpty = false;}
            return isEmpty;
        }
    }
}
