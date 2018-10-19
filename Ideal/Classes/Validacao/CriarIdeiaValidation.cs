using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ideal.Classes.Validacao
{
    class CriarIdeiaValidation : IValidation
    {
        //Singleton
        private static CriarIdeiaValidation _instance;

        public static CriarIdeiaValidation Singleton()
        {
            if (_instance == null)
            {
                MessageBox.Show("Instacia Criada.");
                _instance = new CriarIdeiaValidation();
            }
            return _instance;
        }

        public bool Validar(IList<string> obj)
        {
            bool validar = true;

            //Verifica string vazias
            if (StringVazias(obj[0], "Titulo") && StringVazias(obj[3], "Mensagem"))
                validar = true;
            else
                validar = false;


            if(obj[2] == "Selecionar")
            {
                MessageBox.Show("É necessário escolher uma categoria");
                validar = false;
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
