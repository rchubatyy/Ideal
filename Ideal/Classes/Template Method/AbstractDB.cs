using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ideal.Classes.Template_Method
{
    abstract class AbstractDB
    {
        protected string connectionString;

        public abstract void Connect();
        public abstract void Process();
        public abstract void Disconnect();

        //Template Method
        public void Run()
        {
            Connect();
            Process();
            Disconnect();
        }
    }
}
