using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ODEV2DY
{
    public partial class Main : Form
    {
        public static  string fak_path = @".\\fakulte.txt";
        public static string bol_path = @".\\bolum.txt";
        public static string ders_path = @".\\ders.txt";
        public static string sube_path = @".\\sube.txt";
        public static string ogreleman_path = @".\\ogreleman.txt";
        Universite uni = new Universite();
        public Main()
        {
            InitializeComponent();
        }

        public void universiteolustur(string uniadi)
        {
            Dosya.ustuneyaz(uniadi, @".\universite.txt");
            lbl.Text = uniadi;
            FileStream fs = File.Create(fak_path);
            fs.Close();
            fs = File.Create(bol_path);
            fs.Close();
            fs = File.Create(ders_path);
            fs.Close();
            fs = File.Create(sube_path);
            fs.Close();
            fs = File.Create(ogreleman_path);
            fs.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!Dosya.universitevarmi())
            {
                Unisec newform = new Unisec();
                newform.ShowDialog();
                universiteolustur(Unisec.uniadi);
            }
            StreamReader sr = new StreamReader(@".\universite.txt");
            lbl.Text = sr.ReadLine();
            sr.Close();
            while (lbl.Text == "")
            {
                Unisec newform = new Unisec();
                newform.ShowDialog();
                universiteolustur(Unisec.uniadi);
            }
            uni.ad = lbl.Text;
            uni.load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fakulte_islemleri newform = new Fakulte_islemleri();
            newform.ShowDialog();
        }

        private void btnbolum_Click(object sender, EventArgs e)
        {
            Bolumformu newform = new Bolumformu();
            newform.ShowDialog();
        }

    }
}
