using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIEWS
{
    public partial class Frm_Login : Form
    {
        private Boolean close = false;
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            txt_User.Text = (UTILS.HashCode.GenerateHashValue(txt_Pass.Text.Trim()));
        }

        private void Frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!close)
            {
                if(MessageBox.Show("teste1","Teste2",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
