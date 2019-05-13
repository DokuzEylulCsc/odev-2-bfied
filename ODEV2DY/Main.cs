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
using System.Collections;

namespace ODEV2DY
{
    public partial class Main : Form
    {
        //dosya oluşturma işlemleri
        public static  string fak_path = @".\\fakulte.txt";
        public static string bol_path = @".\\bolum.txt";
        public static string ders_path = @".\\ders.txt";
        public static string sube_path = @".\\sube.txt";
        public static string ogreleman_path = @".\\ogreleman.txt";
        public static Universite universite = new Universite();
        public unimemento memento = universite.extract();
        public Main()
        {
            InitializeComponent();
        }

        

        private void Main_Load(object sender, EventArgs e)
        {
            universite.ad = "";
            while (universite.ad == "")
            { 
                Unisec uniform = new Unisec();
                uniform.ShowDialog();
                universite.ad = Unisec.uniadi;
            }
            universite.fakulteler = new List<Fakulte>();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fakulte_islemleri newform = new Fakulte_islemleri();
            newform.ShowDialog();
                  memento = universite.extract();

    }

    private void btnbolum_Click(object sender, EventArgs e)
        {
            Bolumformu newform = new Bolumformu();
            newform.ShowDialog();
              memento = universite.extract();

}

private void memomento_Click(object sender, EventArgs e)
        {
            universite.insert(memento);
        }
    }
}
