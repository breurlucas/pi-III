using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onepiece
{
    class Strategy
    {
        // Plays backwards available
        private int backSingle;
        private List<int> backDouble = new List<int>();
        // All symbols on the map, in order
        public List<char> blueprint = new List<char>();
        // Keeps track of the number of pirates on each tile
        public int[] occupation;
        // List with my positions
        public List<int> myPos = new List<int>();
        // All cards in hand, chars only
        public List<string> cartas = new List<string>();
        // Double symbols list
        private List<string> cartasDouble = new List<string>();
        // The card that is going to be played
        public string play;
        public bool forward;
        public int backwardsPlay;
        public int twoTurnPlay = 0;

        public string firstCard = "";
        public string secondCard = "";
        public int posNextPlay = 0;

        // List with the vacated tiles that can be jumped to (char)
        private List<char> jump = new List<char>();
        // List with the vacated tiles that can be jumped to (int)
        private List<int> jumpPos = new List<int>();

        public void definePlay(int rodada)
        {
            /* Look back and check for good plays backwards */
            lookBack();

            if (cartas.Any())
            {
                // If we have more than 1 pirate or more than one card
                if (myPos.Count > 1 || cartas.Count > 1)
                    play = checkFarthestPlay(rodada);
                else
                    play = cartas.First();
            }

            if (play == "Pulo do gato!")
            {
                twoTurnPlay++;
            }

            if (cartas.Any() && !backDouble.Any() && play != "wait")
            {
                forward = true;
            }
            else if (cartas.Count >= 6 && play != "wait")
            {
                forward = true;
            }
            else if (play == "Pulo do gato!")
            {
                forward = true;
            }
            else
            {
                if (backDouble.Any())
                    backwardsPlay = backDouble.First();
                else
                    backwardsPlay = backSingle;
                forward = false;
            }
        }

        private void lookBack()
        {
            backDouble.Clear();
            backSingle = 0;
            // List that keeps track of the distance of myPos to the first tile occupied by one unit
            List<int> steps = new List<int>();
            // List of the myPos entries tracked by the list above
            List<int> myPosOneCard = new List<int>();

            for (int i = myPos.Count - 1; i > 0; i--)
            {
                int step = 1;
                int range = 4;
                int pos = myPos[i] - 1;

                while (step <= range && pos >= 1)
                {

                    // pos minus one to account for the index 0 of the occupation vector
                    if (occupation[pos - 1] == 1)
                    {
                        steps.Add(step);
                        myPosOneCard.Add(myPos[i]);
                        break;
                    }
                    else if (occupation[pos - 1] == 2)
                    {
                        backDouble.Add(myPos[i]);
                        break;
                    }
                    else
                    {
                        pos -= 1;
                        step++;
                    }
                }
            }

            if(!backDouble.Any() && steps.Any())
            {
                if(steps.Min() < 6)
                {
                    // Index of the lowest entry
                    int index = steps.IndexOf(steps.Min());
                    // Position with the smallest number of steps backwards
                    backSingle = myPosOneCard.ElementAt(index);
                }
            }
        }

        private string checkFarthestPlay(int rodada)
        {
            // List with the vacated tiles
            List<char> options = new List<char>();
            List<char> boat = new List<char>();
            jump.Clear();
            jumpPos.Clear();
            List<char> symbols = new List<char> { 'T', 'P', 'C', 'E', 'G', 'F' };
            // Position of the pirate that is going to be played + 1
            int pos = myPos.First() + 1;

            // Needs to be '<=' to account for the (-1) of the occupation and blueprint indexes        
            for (int i = pos; i <= occupation.Length; i++)
            {
                if (occupation[i - 1] == 0 && isFirstAppearance(symbols, blueprint[i - 1]))
                {
                    if (i <= 30)
                    {
                        options.Add(blueprint[i - 1]);
                    } else
                    {
                        jump.Add(blueprint[i - 1]);
                        jumpPos.Add(i);
                    }

                    symbols.Remove(blueprint[i - 1]);
                } 
            }

            /* Check if there are entries left in the symbols vector, if so, add them to the boat vector */
            if (symbols.Any())
            {
                // Needs to be inverted to make up for the remove action
                for (int i = symbols.Count - 1; i >= 0; i--)
                {
                    boat.Add(symbols[i]);
                    symbols.RemoveAt(i);
                }
            }

            // Check if there are options leading to the boat
            if(boat.Any())
            {
                for (int i = boat.Count - 1; i >= 0; i--)
                {
                    for (int j = 0; j < cartas.Count; j++)
                    {
                        if (boat[i].ToString() == cartas[j])
                        {
                            return cartas[j];
                        }
                    }
                }
            }

            if (cartas.Count >= 2 && rodada != 3)
            {
                if (canPuloDoGato())
                    return "Pulo do gato!";
            }

            if (options.Any())
            {
                for (int i = options.Count - 1; i >= 0; i--)
                {
                    for (int j = 0; j < cartas.Count; j++)
                    {
                        if (options[i].ToString() == cartas[j])
                        {
                            return cartas[j];
                        }
                    }
                }
            }

            return "wait";
        }

        private bool isFirstAppearance(List<char> symbols, char symbol)
        {
            for (int i = 0; i < symbols.Count; i++)
            {
                if (symbol == symbols[i])
                {
                    return true;
                }
            }
            return false;
        }

        private bool canPuloDoGato() 
        {
            List<char> symbols = new List<char> { 'T', 'P', 'C', 'E', 'G', 'F' };
            firstCard = "";
            secondCard = "";
            List<string> available = cartas;
  
            // Check which cards would be eligible for the next play
            for (int i = jump.Count - 1; i >= 0; i--) 
            {
                for (int j = available.Count - 1; j >= 0; j--)
                {
                    if (jump[i].ToString() == available[j])
                    {
                        posNextPlay = jumpPos[i];
                        firstCard = available[j];
                        available.RemoveAt(j);
                        goto FoundCard;
                    }
                   
                }
            }

            FoundCard:
            if (firstCard != "")
            {
                /* No 'PosNextPlay - 1'  is needed to compensate for the '0' index of the occupation array 
                   because it should start at the next tile anyway. Because of this, 'occupation[i + 1]' in
                   the loop should also be avoided. */
                for (int i = posNextPlay; i < occupation.Length; i++)
                {
                    for (int j = available.Count - 1; j >= 0; j--)
                    {
                        if (occupation[i] == 0 && (blueprint[i].ToString() == available[j]))
                        {
                            available.RemoveAt(j);
                        }
                    }
                }

                if(available.Any())
                {
                    secondCard = available.First();
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        private void checkForDoubles()
        {
            cartasDouble.Clear();

            // Populate double symbol list
            for (int i = 0; i < cartas.Count - 1; i++)
            {
                if (cartas[i] == cartas[i + 1])
                {
                    if (!cartasDouble.Any())
                    {
                        cartasDouble.Add(cartas[i]);
                    }
                    else
                    {
                        for (int j = 0; j < cartasDouble.Count; j++)
                        {
                            if (cartasDouble[j] != cartas[i])
                            {
                                cartasDouble.Add(cartas[i]);
                            }
                        }
                    }

                }
            }
        }

        //private bool checkForDoublePlay(char symbol)
        //{
        //    if (cartasDouble.Any())
        //    {
        //        for(int i = 0; i < cartasDouble.Count; i++)
        //        {
        //            if(cartasDouble[i] == symbol.ToString())
        //            {
        //                doublePlay = cartasDouble[i];
        //                return true;
        //            }
        //        }
        //    } 

        //    return false; 
        //}

    }
}

