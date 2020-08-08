using Kırtasiye_Barkod_Programı.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kırtasiye_Barkod_Programı
{
    public partial class frm_homepage : Form
    {
        public frm_homepage() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void btn_satisyap_Click(object sender, EventArgs e) {
            frm_satisyap show = new frm_satisyap();
            show.ShowDialog();
        }
    }
}
