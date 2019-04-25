using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onepiece
{
    class Myself : Jogador
    {
        private string _idJogador;
        private string _nome;
        private string _senha;
        private string _cor;
        private string _idPartida;

        public string idJogador { get { return _idJogador; } }
        public string nome { get { return _nome; } }
        public string senha { get { return _senha; } }
        public string cor { get { return _cor; } }
        public string idPartida { get { return _idPartida; } }


        /*
         * 
         * CONSTRUCTOR
         */

        public Myself(string nome, string senha, string cor, string idP, string idJ)
        {
            _nome = nome;
            _senha = senha;
            _cor = cor;
            _idPartida = idP;
            _idJogador = idJ;
        }

        //public string getMyIdAndSenha()
        //{
        //    //return _nome + "," + _senha;
        //    return _idJogador + "," + senha;
        //}
    }
}
