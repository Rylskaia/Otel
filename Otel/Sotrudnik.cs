using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otel
{
    public partial class Sotrudnik : Form
    {
        public Sotrudnik()
        {
            InitializeComponent();
        }

        // string strConn = @"Data Source=DBSrv\MsSQLita;Initial Catalog=907ca_Rylskaya;Integrated Security=True";
        string strConn = @"Data Source=DESKTOP-IDFMA1L\SQLEXPRESS;Initial Catalog=907ca_Rylskaya;Integrated Security=True";
        private void Sotrudnik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_907ca_RylskayaDataSet3.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this._907ca_RylskayaDataSet3.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_907ca_RylskayaDataSet3.Номер". При необходимости она может быть перемещена или удалена.
            this.номерTableAdapter.Fill(this._907ca_RylskayaDataSet3.Номер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_907ca_RylskayaDataSet3.Бронирование_номеров". При необходимости она может быть перемещена или удалена.
            this.бронирование_номеровTableAdapter.Fill(this._907ca_RylskayaDataSet3.Бронирование_номеров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_907ca_RylskayaDataSet3.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this._907ca_RylskayaDataSet3.Клиент);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vhod vhod = new Vhod();
            vhod.Show();
            this.Hide();
        }

        private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.бронированиеНомеровBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._907ca_RylskayaDataSet3);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._907ca_RylskayaDataSet3);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int poz = клиентBindingSource.Find(comboBox1.Text, textValue1.Text);
                клиентBindingSource.Position = poz;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int poz = бронированиеНомеровBindingSource.Find(comboBox2.Text, textValue2.Text);
                бронированиеНомеровBindingSource.Position = poz;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string order;
            if (radioButton1.Checked) order = "ASC";
            else order = "DESC";
            try
            {
                бронированиеНомеровBindingSource.Sort = comboBox3.Text + " " + order;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return;
            }
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "DELETE from [Бронирование номеров] Where [Дата заселения] < CAST(GETDATE() AS DATE) and Статус = 'Бронь'";

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                    return;
                }
            }
            this.бронирование_номеровTableAdapter.Fill(this._907ca_RylskayaDataSet3.Бронирование_номеров);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Nomera nomera = new Nomera();
            nomera.Show();
            this.Hide();
        }
    }
}
