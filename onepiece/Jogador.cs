using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartagenaServer;

namespace onepiece
{
    class Jogador
    {
        // Protected and private variables
        private Color _corARGB;
        private int _nrPiratas;

        public Color corARGB { get { return _corARGB; } }
        public int nrPiratas {  get { return _nrPiratas;  } }

        // Static variables
        private static Dictionary<string, Color> colors;

        /*
         * 
         * CONSTRUCTORS
         */

         // Parameterless constructor to prevent heritage conflicts
         public Jogador() { }

         public Jogador(Color cor, int nrPiratas)
        {
            _corARGB = cor;
            _nrPiratas = nrPiratas;
        }

        /*
         * 
         * METHODS
         */
        public static Dictionary<string, Color> definirCores(string listaJogadores)
        {
            listaJogadores = listaJogadores.Replace("\n", "");
            string[] players = listaJogadores.Split('\r', ',');

            string p1 = "player id 1";
            string p2 = "player id 2";
            string p3 = "player id 3";
            string p4 = "player id 4";
            string p5 = "player id 5";

            for (int i = 0; i < players.Length - 1; i += 3)
            {
                switch (i)
                {
                    case 0:
                        p1 = players[i];
                        break;
                    case 3:
                        p2 = players[i];
                        break;
                    case 6:
                        p3 = players[i];
                        break;
                    case 9:
                        p4 = players[i];
                        break;
                    case 12:
                        p5 = players[i];
                        break;
                }
            }

            // Colors are always distributed in the same order
            colors = new Dictionary<string, Color>
                {
                    { p1, Color.Red },
                    { p2, Color.DarkGreen },
                    { p3, Color.Yellow },
                    { p4, Color.Blue },
                    { p5, Color.Brown },
                };

            return colors;
        }

        //private string ConvertColor(string color)
        //{
        //    switch (color.Substring(0, 4))
        //    {
        //        case "Amar":
        //            return "Yellow";
        //        case "Verm":
        //            return "Red";
        //        case "Azul":
        //            return "Blue";
        //        case "Verd":
        //            return "Green";
        //        case "Marr":
        //            return "Brown";
        //        default:
        //            return "Pink";
        //    }
        //}


        public string id { get; set; }
        public string nome { get; set; }
        public string cor { get; set; }

        public static List<Jogador> Listar(string idPartida)
        {
            string retorno = Jogo.ListarJogadores(Convert.ToInt32(idPartida));

            List<Jogador> jogadores = new List<Jogador>();

            if (!retorno.Contains("ERRO")){

                string[] jogadoresSplit = retorno.Split('\r');

                for (int i = 0; i < jogadoresSplit.Length; i++)
                {
                    string jogadoresReal = jogadoresSplit[i].Replace("\n", "");

                    string[] props = jogadoresReal.Split(',');

                    Jogador p = new Jogador();

                    if (props.Length > 1)
                    {
                        p.id = props[0];
                        p.nome = props[1];
                        p.cor = props[2];

                        jogadores.Add(p);

                    }
                }
            }
            return jogadores;
        }

      
    }


}

