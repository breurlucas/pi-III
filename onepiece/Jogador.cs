using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onepiece
{
    class Jogador
    {
        private string _nome;
        private string _senha;
        private string _corJogador;
        private string _idPartida;
        private string _idJogador;
        //private Color _cor;

        public string nome { get { return _nome; } }
        public string senha { get { return _senha; } }
        public string corJogador { get { return _corJogador; } }
        public string idPartida { get { return _idPartida; } }
        public string idJogador { get { return _idJogador; } }
        //private Color cor { get { return _cor } }

        //public Jogador(string id, Color cor)
        //{
        //    _idJogador = id;
        //    _cor = cor;
        //}

        public void EntrouPartida(string nome, string senha, string cor, string idP, string idJ)
        {
            _nome = nome;
            _senha = senha;
            _corJogador = cor;
            _idPartida = idP;
            _idJogador = idJ;
           
        }

        public string novoFormPartida()
        {
            //return _nome + "," + _senha + "," + _idPartida;
            return _idJogador+ "," + this.senha;
        }

        public static void definirCores(string listaJogadores, Dictionary<string, Color> colors)
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
    }
}
