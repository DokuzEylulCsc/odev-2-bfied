using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODEV2DY
{
    public partial class Bolumformu : Form
    {
        public Bolumformu()
        {
            InitializeComponent();
        }

        private void Bolumformu_Load(object sender, EventArgs e)
        {
            load_combo();

        }
        private void load_combo()
        {
            cmbfak.Items.Clear();
            foreach (Fakulte fak in Fakulte.get_array())
            {
                cmbfak.Items.Add(fak.ad);
            }
            cmbbolum.Items.Clear();
            foreach (Bolum bol in Bolum.get_array(""))
            {
                cmbbolum.Items.Add(bol.ad);
                cmbBolumOgrelemani.Items.Add(bol.ad);
                cmbBolumogrekle.Items.Add(bol.ad);
            }
            cmbders.Items.Clear();
            foreach (Ders bol in Ders.get_array(""))
            {
                cmbders.Items.Add(bol.ad);
            }

        }

        private void btnbolumekle_Click_1(object sender, EventArgs e)
        {
            Dosya.yaz(cmbfak.SelectedItem + "," + txtbolumadi.Text, Main.bol_path);
            txtbolumadi.Text = "";
            load_combo();
        }

        private void btnders_Click(object sender, EventArgs e)
        {
            Dosya.yaz(cmbbolum.SelectedItem +"," + txtders.Text, Main.ders_path);
            txtders.Text = "";
            load_combo();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbbolum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsube_Click(object sender, EventArgs e)
        {
            Dosya.yaz(cmbders.SelectedItem + "," + txtsube.Text, Main.sube_path);
            txtsube.Text = ""; //textbox ı boşaltır boşken işlem yapmaz (exception önlemek için)
            load_combo();
        }

        private void btnOgrElemani_Click(object sender, EventArgs e)
        {
            Dosya.yaz(cmbBolumOgrelemani.SelectedItem + "," + txtOgrElemani.Text, Main.ogreleman_path);
            txtsube.Text = "";
            load_combo();
        }
    }
}
