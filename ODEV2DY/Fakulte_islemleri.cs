using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ODEV2DY
{
    public partial class Fakulte_islemleri : Form
    {
       

        public Fakulte_islemleri()
        {
            InitializeComponent();
        }

        private void btnfac_Click(object sender, EventArgs e)
        {
            if (txtfac.Text != "")
            {
                /* Dosya.yaz(txtfac.Text,Main.fak_path);
                 txtfac.Text = ""; */
                Fakulte fak = new Fakulte();
                fak.ad = txtfac.Text;
                fak.bolumler = new List<Bolum>();
                Main.universite.fakulteler.Add(fak);
            }
            txtfac.Text = "";
        }

        private void Fakulte_islemleri_Load(object sender, EventArgs e)
        {
          
        }
    }
}
