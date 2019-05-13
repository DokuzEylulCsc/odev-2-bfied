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
            /*cmbfak.Items.Clear();
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
            }*/
            foreach(Fakulte fak in Main.universite.fakulteler)
            {
                cmbfak.Items.Clear();
                cmbfak.Items.Add(fak.ad);
                cmbfakdersekle.Items.Clear();
                cmbfakdersekle.Items.Add(fak.ad);
                cmbfaksube.Items.Clear();
                cmbfaksube.Items.Add(fak.ad);
                cmbfakogreleman.Items.Clear();
                cmbfakogreleman.Items.Add(fak.ad);
                cmbfakogrekle.Items.Clear();
                cmbfakogrekle.Items.Add(fak.ad);
                cmbfakbolsil.Items.Clear();
                cmbfakbolsil.Items.Add(fak.ad);
                cmbfakderssil.Items.Clear();
                cmbfakderssil.Items.Add(fak.ad);
                cmbfakogrsil.Items.Clear();
                cmbfakogrsil.Items.Add(fak.ad);
                cmbfakogrelemansil.Items.Clear();
                cmbfakogrelemansil.Items.Add(fak.ad);
            }

        }

        private void btnbolumekle_Click_1(object sender, EventArgs e)
        {
            /*Dosya.yaz(cmbfak.SelectedItem + "," + txtbolumadi.Text, Main.bol_path);
            txtbolumadi.Text = "";
            load_combo();*/
            if (txtbolumadi.Text != "")
            {
                Bolum bolum = new Bolum();
                bolum.ad = txtbolumadi.Text;
                bolum.dersler = new List<Ders>();
                bolum.ogretimelemanlari = new List<Ogretimelemani>();
                bolum.ogrenciler = new List<Ogr>();
                Main.universite.fakulteler[cmbfak.SelectedIndex].bolumler.Add(bolum);
            }
            txtbolumadi.Text = "";
        }

        private void btnders_Click(object sender, EventArgs e)
        {
            /*Dosya.yaz(cmbbolum.SelectedItem +"," + txtders.Text, Main.ders_path);*/
            if(txtders.Text != "")
            {
                Ders ders = new Ders();
                ders.ad = txtders.Text;
                ders.subeler = new List<Sube>();
                Main.universite.fakulteler[cmbfakdersekle.SelectedIndex].bolumler[cmbbolum.SelectedIndex].dersler.Add(ders); 
                // universitedeki cmbfakdersekle indexli fakultedeki cmbbolum indexli bolumün derslerine adı verilen dersi ekleme 
            }
            txtders.Text = "";

        }

        private void btnsube_Click(object sender, EventArgs e)
        {
            /*Dosya.yaz(cmbderssube.SelectedItem + "," + txtsube.Text, Main.sube_path);*/
            if(txtsube.Text != "")
            {
                Sube sube = new Sube();
                sube.ad = txtsube.Text;
                sube.ogrenciler = new List<Ogr>();
                Main.universite.fakulteler[cmbfaksube.SelectedIndex].bolumler[cmbbolsube.SelectedIndex].dersler[cmbderssube.SelectedIndex].subeler.Add(sube);
            }
            txtsube.Text = ""; //textbox ı boşaltır boşken işlem yapmaz (exception önlemek için)
        }

        private void btnOgrElemani_Click(object sender, EventArgs e)
        {
            /*Dosya.yaz(cmbBolumOgrelemani.SelectedItem + "," + txtOgrElemani.Text, Main.ogreleman_path);*/
            if (txtOgrElemani.Text != "")
            {
                Ogretimelemani ogreleman = new Ogretimelemani();
                ogreleman.ad = txtOgrElemani.Text;
                Main.universite.fakulteler[cmbfakogreleman.SelectedIndex].bolumler[cmbBolumOgrelemani.SelectedIndex].ogretimelemanlari.Add(ogreleman);
            }
            txtOgrElemani.Text = "";
        }

        private void btnOgr_Click(object sender, EventArgs e)
        {
            if (txtOgradi.Text != "")
            {
                switch (cmbDuzey.SelectedIndex)
                {
                    case 0:
                        Lisans ogr = new Lisans();
                        ogr.ad = txtOgradi.Text;
                        Main.universite.fakulteler[cmbfakogrekle.SelectedIndex].bolumler[cmbBolumogrekle.SelectedIndex].ogrenciler.Add(ogr);
                        break;
                    case 1:
                        Yukseklisans yogr = new Yukseklisans();
                        yogr.ad = txtOgradi.Text;
                        Main.universite.fakulteler[cmbfakogrekle.SelectedIndex].bolumler[cmbBolumogrekle.SelectedIndex].ogrenciler.Add(yogr);
                        break;
                    case 2:
                        Doktora dogr = new Doktora();
                        dogr.ad = txtOgradi.Text;
                        Main.universite.fakulteler[cmbfakogrekle.SelectedIndex].bolumler[cmbBolumogrekle.SelectedIndex].ogrenciler.Add(dogr);
                        break;
                }
            }
            txtOgradi.Text = "";
        }

        private void cmbfakdersekle_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbolum.Items.Clear();
            foreach (Bolum bol in Main.universite.fakulteler[cmbfakdersekle.SelectedIndex].bolumler)
            {
                
                cmbbolum.Items.Add(bol.ad);
            }
        }

        private void cmbfaksube_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbolsube.Items.Clear();
            foreach (Bolum bol in Main.universite.fakulteler[cmbfaksube.SelectedIndex].bolumler)
            {
                
                cmbbolsube.Items.Add(bol.ad);
            }
        }

        private void cmbbolsube_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbderssube.Items.Clear();
            foreach (Ders ders in Main.universite.fakulteler[cmbfaksube.SelectedIndex].bolumler[cmbbolsube.SelectedIndex].dersler)
            {
                
                cmbderssube.Items.Add(ders.ad);
            }
        }

        private void cmbfakogreleman_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBolumOgrelemani.Items.Clear();
            foreach (Bolum bol in Main.universite.fakulteler[cmbfakogreleman.SelectedIndex].bolumler)
            {
                
                cmbBolumOgrelemani.Items.Add(bol.ad);
            }
        }

        private void cmbfakogrekle_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBolumogrekle.Items.Clear();
            foreach (Bolum bol in Main.universite.fakulteler[cmbfakogrekle.SelectedIndex].bolumler)
            {
                
                cmbBolumogrekle.Items.Add(bol.ad);
            }
        }

        private void btnsubeograta_Click(object sender, EventArgs e)
        {
            Main.universite.fakulteler[cmbfakograta.SelectedIndex].bolumler[cmbbolograta.SelectedIndex].dersler[cmbdersograta.SelectedIndex].subeler[cmbsubeograta.SelectedIndex].ogrenciler.Add(
                Main.universite.fakulteler[cmbfakograta.SelectedIndex].bolumler[cmbbolograta.SelectedIndex].ogrenciler[cmbograta.SelectedIndex]);
        }

        private void cmbfakograta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbolograta.Items.Clear();
            foreach (Bolum bol in Main.universite.fakulteler[cmbfakograta.SelectedIndex].bolumler)
            {
                
                cmbbolograta.Items.Add(bol.ad);
            }
        }

        private void cmbbolograta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdersograta.Items.Clear();
            foreach (Ders ders in Main.universite.fakulteler[cmbfakograta.SelectedIndex].bolumler[cmbbolograta.SelectedIndex].dersler)
            {
                
                cmbdersograta.Items.Add(ders.ad);
            }
            cmbograta.Items.Clear();
            foreach (Ogr ogr in Main.universite.fakulteler[cmbfakograta.SelectedIndex].bolumler[cmbbolograta.SelectedIndex].ogrenciler)
            {
                
                cmbograta.Items.Add(ogr.ad);
            }
        }

        private void cmbdersograta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbsubeograta.Items.Clear();
            foreach (Sube sube in Main.universite.fakulteler[cmbfakograta.SelectedIndex].bolumler[cmbbolograta.SelectedIndex].dersler[cmbdersograta.SelectedIndex].subeler)
            {
                
                cmbsubeograta.Items.Add(sube.ad);
            }
        }

        private void btnogrelemanata_Click(object sender, EventArgs e)
        {
            Main.universite.fakulteler[cmbfakogrelemanata.SelectedIndex].bolumler[cmbbologrelemanata.SelectedIndex]
                .dersler[cmbdersogrelemanata.SelectedIndex].subeler[cmbsubeogrelemanata.SelectedIndex].ogretimelemani=
                Main.universite.fakulteler[cmbfakogrelemanata.SelectedIndex].bolumler[cmbbologrelemanata.SelectedIndex]
                .ogretimelemanlari[cmbogrelemanata.SelectedIndex];
        }

        private void cmbfakogrelemanata_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbologrelemanata.Items.Clear();
            foreach (Bolum bol in Main.universite.fakulteler[cmbfakogrelemanata.SelectedIndex].bolumler)
            {
                
                cmbbologrelemanata.Items.Add(bol.ad);
            }
        }

        private void cmbbologrelemanata_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdersogrelemanata.Items.Clear();
            foreach (Ders ders in Main.universite.fakulteler[cmbfakogrelemanata.SelectedIndex].bolumler[cmbbologrelemanata.SelectedIndex].dersler)
            {
                
                cmbdersogrelemanata.Items.Add(ders.ad);
            }
            cmbogrelemanata.Items.Clear();
            foreach (Ogretimelemani ogreleman in Main.universite.fakulteler[cmbfakogrelemanata.SelectedIndex].bolumler[cmbbologrelemanata.SelectedIndex].ogretimelemanlari)
            {
                
                cmbogrelemanata.Items.Add(ogreleman.ad);
            }
        }

        private void cmbdersogrelemanata_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbsubeogrelemanata.Items.Clear();
            foreach (Sube sube in Main.universite.fakulteler[cmbfakogrelemanata.SelectedIndex].bolumler[cmbbologrelemanata.SelectedIndex].dersler[cmbdersogrelemanata.SelectedIndex].subeler)
            {
                
                cmbsubeogrelemanata.Items.Add(sube.ad);
            }
        }

        private void btnbolsil_Click(object sender, EventArgs e)
        {
            Main.universite.fakulteler[cmbfakbolsil.SelectedIndex].bolumler.RemoveAt(cmbbolsil.SelectedIndex);
        }

        private void cmbfakbolsil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbolsil.Items.Clear();
            foreach (Bolum bol in Main.universite.fakulteler[cmbfakbolsil.SelectedIndex].bolumler)
            {
                cmbbolsil.Items.Add(bol.ad);
            }
        }

        private void btnderssil_Click(object sender, EventArgs e)
        {
            Main.universite.fakulteler[cmbfakderssil.SelectedIndex].bolumler[cmbbolderssil.SelectedIndex].dersler.RemoveAt(cmbderssil.SelectedIndex);
        }

        private void cmbfakderssil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbolderssil.Items.Clear();
            foreach (Bolum bol in Main.universite.fakulteler[cmbfakderssil.SelectedIndex].bolumler)
            {
                cmbbolderssil.Items.Add(bol.ad);
            }
        }

        private void cmbbolderssil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbderssil.Items.Clear();
            foreach (Ders ders in Main.universite.fakulteler[cmbfakderssil.SelectedIndex].bolumler[cmbbolderssil.SelectedIndex].dersler)
            {

                cmbderssil.Items.Add(ders.ad);
            }
        }

        private void btnogrsil_Click(object sender, EventArgs e)
        {
            Main.universite.fakulteler[cmbfakogrsil.SelectedIndex].bolumler[cmbbologrsil.SelectedIndex].ogretimelemanlari.RemoveAt(cmbogrsil.SelectedIndex);
        }

        private void cmbfakogrsil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbologrsil.Items.Clear();
            foreach (Bolum bol in Main.universite.fakulteler[cmbfakogrsil.SelectedIndex].bolumler)
            {
                cmbbologrsil.Items.Add(bol.ad);
            }
        }

        private void cmbbologrsil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbogrsil.Items.Clear();
            foreach (Ogr ogr in Main.universite.fakulteler[cmbfakogrsil.SelectedIndex].bolumler[cmbbologrsil.SelectedIndex].ogrenciler)
            {

                cmbogrsil.Items.Add(ogr.ad);
            }
        }

        private void btnogrelemansil_Click(object sender, EventArgs e)
        {
            Main.universite.fakulteler[cmbfakogrelemansil.SelectedIndex].bolumler[cmbbologrelemansil.SelectedIndex].ogretimelemanlari.RemoveAt(cmbogrelemansil.SelectedIndex);
        }

        private void cmbfakogrelemansil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbologrelemansil.Items.Clear();
            foreach (Bolum bol in Main.universite.fakulteler[cmbfakogrelemansil.SelectedIndex].bolumler)
            {
                cmbbologrelemansil.Items.Add(bol.ad);
            }
        }

        private void cmbbologrelemansil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbogrelemansil.Items.Clear();
            foreach (Ogretimelemani ogr in Main.universite.fakulteler[cmbfakogrsil.SelectedIndex].bolumler[cmbbologrsil.SelectedIndex].ogretimelemanlari)
            {

                cmbogrelemansil.Items.Add(ogr.ad);
            }
        }
    }
}
