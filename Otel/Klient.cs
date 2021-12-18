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
    public partial class Klient : Form
    {
        public Klient()
        {
            InitializeComponent();
        }

        private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._907ca_RylskayaDataSet3);

        }

        private void Klient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_907ca_RylskayaDataSet3.Бронирование_номеров". При необходимости она может быть перемещена или удалена.
           // this.бронирование_номеровTableAdapter.Fill(this._907ca_RylskayaDataSet3.Бронирование_номеров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_907ca_RylskayaDataSet3.Клиент". При необходимости она может быть перемещена или удалена.
           // this.клиентTableAdapter.Fill(this._907ca_RylskayaDataSet3.Клиент);
            try
            {
                this.клиентTableAdapter.KlientFillBy(this._907ca_RylskayaDataSet3.Клиент);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            try
            {
                this.бронирование_номеровTableAdapter.ZakazFillBy(this._907ca_RylskayaDataSet3.Бронирование_номеров);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void фИОTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void klientFillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.клиентTableAdapter.KlientFillBy(this._907ca_RylskayaDataSet3.Клиент);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void zakazFillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.бронирование_номеровTableAdapter.ZakazFillBy(this._907ca_RylskayaDataSet3.Бронирование_номеров);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nomera nomera = new Nomera();
            nomera.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Vhod vhod = new Vhod();
            vhod.Show();
            this.Hide();
        }
    }
}
