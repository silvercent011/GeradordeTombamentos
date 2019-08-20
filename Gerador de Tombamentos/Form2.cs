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
    public partial class formNot : Form
    {
        public formNot(string entrada,string codigo)
        {
            InitializeComponent();
            if (entrada == "DSK")
            {
                ITEM.Image = imagens.Images[0];
            } else if(entrada == "MNT")
            {
                ITEM.Image = imagens.Images[1];
            } else if(entrada == "NTB")
            {
                ITEM.Image = imagens.Images[2];
            } else if(entrada == "NBR")
            {
                ITEM.Image = imagens.Images[3];
            } else if(entrada == "EST")
            {
                ITEM.Image = imagens.Images[4];
            } else if(entrada == "IMP")
            {
                //Impressora
                ITEM.Image = imagens.Images[5];
            } else if(entrada == "FAX")
            {
                //Fax
                ITEM.Image = imagens.Images[6];
            } else if(entrada == "DTS")
            {
                //Datashow
                ITEM.Image = imagens.Images[7];
            } else if(entrada == "PRJ")
            {
                //Projetor
                ITEM.Image = imagens.Images[7];
            } else if(entrada == "SCN")
            {
                //Scanner
                ITEM.Image = imagens.Images[8];
            } else if(entrada == "TVD")
            {
                //TV Digital
                ITEM.Image = imagens.Images[9];
            } else if(entrada == "OTR")
            {
                //Outro
                ITEM.Image = imagens.Images[10];
            }

            cod.Text = codigo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = cod.Text;
            Clipboard.SetText(codigo);
        }
    }
}
