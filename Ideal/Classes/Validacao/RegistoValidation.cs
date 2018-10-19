using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ideal.Classes.Template_Method;

namespace Ideal.Classes.Validacao
{
    class RegistoValidation : IValidation
    {
        //Singleton
        private static RegistoValidation _instance;

        public static RegistoValidation Singleton()
        {
            if (_instance == null)
            {
                _instance = new RegistoValidation();
            }
            return _instance;
        }

        /// <summary>
        /// Validação dos inputs do registo
        /// </summary>
        public bool Validar(IList<string> obj)
        {
            bool validar = true;

            //Verifica string vazias
            if (StringVazias(obj[0], "Nome") && StringVazias(obj[1], "Aplido") && StringVazias(obj[2], "Email") &&
                StringVazias(obj[4], "UserName") && StringVazias(obj[5], "Password"))
                validar = true;
            else
                validar = false;



            //Verifica a data de nascimento
            if (Convert.ToDateTime(obj[3])> DateTime.Today || Convert.ToDateTime(obj[3]) == DateTime.Today)
            {
                MessageBox.Show("Data Nascimento está Errada");
                validar = false;
            }

            // ReSharper disable once InvertIf
            if (!Regex.IsMatch(obj[2], "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*"))
            {
                MessageBox.Show("Email com formato errado");
                validar = false;
            }

            //Verificar as Password se são iguais
            if (obj[5] != obj[6])
            {
                MessageBox.Show("As passwords não são iguais");
                validar = false;
            }

            //Verificar utilizadores na base de dados
            string sql = "Select idConta from Conta where username = '" + obj[4] + "'";
            SB_DB procurarConta = new SB_DB(sql, 1, "select");
            procurarConta.Run();

            if (procurarConta.List.Count > 0)
            {
                validar = false;
                MessageBox.Show("Nome do Username ja registado!");
            }

            return validar;
        }

        /// <summary>
        /// Verificação das strings vazias
        /// </summary>
        public bool StringVazias(string s, string nome)
        {
            if (s.Length == 0)
            {
                MessageBox.Show(nome + " é necessário preencher");
                return false;
            }
            return true;
        }
    }
}
