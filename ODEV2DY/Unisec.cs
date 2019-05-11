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
    
    public partial class Unisec : Form
    {
        public static string uniadi;
        public Unisec()
        {
            InitializeComponent();
        }

        private void Unisec_Load(object sender, EventArgs e)
        {

        }

        private void unibutton_Click(object sender, EventArgs e)
        {
            uniadi = txtuni.Text;
            this.Close();
        }
    }
}
