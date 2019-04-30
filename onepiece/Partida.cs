using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartagenaServer;


namespace onepiece
{
    class Partida
    {
        public string id { get; set; }
        public string nome { get; set; }
        protected string senha { get; set; }
        public string status { get; set; }

        public List<Jogador> jogadores { get; set; }

        public static List<Partida> Listar()
        {
            string retorno = Jogo.ListarPartidas("T");

            List<Partida> partidas = new List<Partida>();

            string[] partidasSplit = retorno.Split('\r');

            for (int i = 0; i < partidasSplit.Length; i++)
            {
                string partidasReal = partidasSplit[i].Replace("\n", "");

                string[] props = partidasReal.Split(',');

                Partida p = new Partida();

                if (props.Length > 1)
                {
                    p.id = props[0];
                    p.nome = props[1];
                   // p.senha = props[2];
                    p.status = props[3];

                    partidas.Add(p);

                }

            }
            return partidas;
        }

        public static List<Partida> Listar(string statusPartida)
        {
            string retorno = Jogo.ListarPartidas(statusPartida);

            List<Partida> partidas = new List<Partida>();

            string[] partidasSplit = retorno.Split('\r');

            for (int i = 0; i < partidasSplit.Length; i++)
            {
                string partidasReal = partidasSplit[i].Replace("\n", "");

                string[] props = partidasReal.Split(',');

                Partida p = new Partida();

                if (props.Length > 1)
                {
                    p.id = props[0];
                    p.nome = props[1];
                   // p.senha = props[2];
                    p.status = props[3];

                    partidas.Add(p);

                }

            }
            return partidas;
        }
    }
}


