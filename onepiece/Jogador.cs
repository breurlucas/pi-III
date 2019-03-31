using System;
using System.Collections.Generic;
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

        public string nome { get { return _nome; } }
        public string senha { get { return _senha; } }
        public string corJogador { get { return _corJogador; } }
        public string idPartida { get { return _idPartida; } }
        public string idJogador { get { return _idJogador; } }


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

    }
}
