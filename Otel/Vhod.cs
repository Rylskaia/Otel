using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel
{
    public partial class Vhod : Form
    {
        public Vhod()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Avtorizaciaya avtorizaciaya = new Avtorizaciaya();
            avtorizaciaya.Show();
            this.Hide();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Registr registr = new Registr();
            registr.Show();
            this.Hide();
        }
    }
}
