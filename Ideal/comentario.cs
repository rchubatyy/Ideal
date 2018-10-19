using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ideal
{
    public partial class comentario : UserControl
    {
        public comentario()
        {
            InitializeComponent();
        }

        public void setTxtUsername(string v)
        {
            txtcusername.Text = v;
        }

        public void setTxtmensagem(string v)
        {
            rtbccomentario.Text = v;
        }

        public void setTxtdata(string v)
        {
            txtcdata.Text = v;
        }
    }
}
