using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_Tombamentos
{
    public partial class formGeral : Form
    {
        public formGeral()
        {
            InitializeComponent();
        }

        private void menu1_Load(object sender, EventArgs e)
        {

        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string geraCod(string entrada)
        {
            string tipo = entrada;
            DateTime atual = DateTime.Now;
            //DDMMAAHHMMSS
            string cod = atual.ToString("ddMMyHHmmss");
            string final = tipo + '_' + cod;
            return final;
        }

        void exibeCod(string cat, string codigo)
        {
            formNot a = new formNot(cat,codigo);
            a.Show();
        }

        private void bt_Desk_Click(object sender, EventArgs e)
        {
            string codigo = geraCod("DSK");
            exibeCod("DSK",codigo);
        }

        private void bt_Monit_Click(object sender, EventArgs e)
        {
            string codigo = geraCod("MNT");
            exibeCod("MNT",codigo);
        }

        private void bt_Noteb_Click(object sender, EventArgs e)
        {
            string codigo = geraCod("NTB");
            exibeCod("NTB",codigo);
        }

        private void bt_Nobreak_Click(object sender, EventArgs e)
        {
            string codigo = geraCod("NBR");
            exibeCod("NBR",codigo);
        }

        private void bt_Estabil_Click(object sender, EventArgs e)
        {
            string codigo = geraCod("EST");
            exibeCod("EST",codigo);
        }

        private void bt_Impres_Click(object sender, EventArgs e)
        {
            string codigo = geraCod("IMP");
            exibeCod("IMP", codigo);
        }

        private void bt_Fax_Click(object sender, EventArgs e)
        {
            string codigo = geraCod("FAX");
            exibeCod("FAX", codigo);
        }

        private void bt_Proj_Click(object sender, EventArgs e)
        {
            string codigo = geraCod("PRJ");
            exibeCod("PRJ", codigo);
        }

        private void bt_Datas_Click(object sender, EventArgs e)
        {
            string codigo = geraCod("DTS");
            exibeCod("DTS", codigo);
        }

        private void bt_Scan_Click(object sender, EventArgs e)
        {
            string codigo = geraCod("SCN");
            exibeCod("SCN", codigo);
        }

        private void bt_tvd_Click(object sender, EventArgs e)
        {
            string codigo = geraCod("TVD");
            exibeCod("TVD", codigo);
        }

        private void bt_out_Click(object sender, EventArgs e)
        {
            string codigo = geraCod("OTR");
            exibeCod("OTR", codigo);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
