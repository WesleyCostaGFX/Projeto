using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    class controle
    {
        public bool tem;
        public string mensagem = "";
        public string funcao = "";
        public string nome_usuario = "";
        public int id_usuario = -1;
        public bool acessar(string login, string senha)
        {
            LoginDaoComandos LoginDao = new LoginDaoComandos();
            tem = LoginDao.verificarlogin(login, senha);
            if (!(LoginDao.mensagem.Equals("")))
            {
                this.mensagem = LoginDao.mensagem;
            }
            funcao = LoginDao.funcao;
            nome_usuario = LoginDao.nome_usuario;
            id_usuario = LoginDao.id_usuario;
            return tem;
        }
    }
}
