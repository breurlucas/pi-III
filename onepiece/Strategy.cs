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
        public List<int> backwards = new List<int>();
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

        public void definePlay()
        {
            /* Look back and check for good plays backwards */
            lookBack();

            if (cartas.Any())
            {
                if (cartas.Count > 1)
                    play = checkFarthestPlay();
                else
                    play = cartas.First();
            }

            if (cartas.Any() && !backwards.Any() && play != "wait")
            {
                forward = true;
            }
            else if (cartas.Count >= 6 && play != "wait")
            {
                forward = true;
            }
            else
            {
                // If there are no good options, move the first pirate backwards
                if (!backwards.Any())
                {
                    backwards.Add(myPos.Last());
                }

                forward = false;
               
            }
        }

        private void lookBack()
        {
            backwards.Clear();

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
                        break;
                    }
                    else if (occupation[pos - 1] == 2)
                    {
                        backwards.Add(myPos[i]);
                        break;
                    }
                    else
                    {
                        pos -= 1;
                        step++;
                    }
                }
            }
        }

        private string checkFarthestPlay()
        {
            // List with the vacated tiles
            List<char> options = new List<char>();
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
                    }

                    symbols.Remove(blueprint[i - 1]);
                }
            }

            /* Check if there are entries left in the symbols vector, if so, add them at the end of the options vector, 
            these symbols lead directly to the boat */
            if (symbols.Any())
            {
                // Needs to be inverted to make up for the remove action
                for (int i = symbols.Count - 1; i >= 0; i--)
                {
                    options.Add(symbols[i]);
                    symbols.RemoveAt(i);
                }
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

        private string puloDoGato()
        {
            // List with the vacated tiles
            List<char> options = new List<char>();
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
                    }

                    symbols.Remove(blueprint[i - 1]);
                }
            }

            /* Check if there are entries left in the symbols vector, if so, add them at the end of the options vector, 
            these symbols lead directly to the boat */
            if (symbols.Any())
            {
                // Needs to be inverted to make up for the remove action
                for (int i = symbols.Count - 1; i >= 0; i--)
                {
                    options.Add(symbols[i]);
                    symbols.RemoveAt(i);
                }
            }

            if (options.Any())
            {
                for (int i = options.Count - 1; i > 0; i--)
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

