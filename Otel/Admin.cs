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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        // string strConn = @"Data Source=DBSrv\MsSQLita;Initial Catalog=907ca_Rylskaya;Integrated Security=True";
        string strConn = @"Data Source=DESKTOP-IDFMA1L\SQLEXPRESS;Initial Catalog=907ca_Rylskaya;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_907ca_RylskayaDataSet3.Бронирование_номеров". При необходимости она может быть перемещена или удалена.
            this.бронирование_номеровTableAdapter.Fill(this._907ca_RylskayaDataSet3.Бронирование_номеров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_907ca_RylskayaDataSet3.Тип_номера". При необходимости она может быть перемещена или удалена.
            this.тип_номераTableAdapter.Fill(this._907ca_RylskayaDataSet3.Тип_номера);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_907ca_RylskayaDataSet3.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this._907ca_RylskayaDataSet3.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_907ca_RylskayaDataSet3.Номер". При необходимости она может быть перемещена или удалена.
            this.номерTableAdapter.Fill(this._907ca_RylskayaDataSet3.Номер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_907ca_RylskayaDataSet3.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this._907ca_RylskayaDataSet3.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_907ca_RylskayaDataSet3.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this._907ca_RylskayaDataSet3.Сотрудник);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            string iFile = "";
            op.Title = "Выбор изображения";
            // задание начальной папки            
            op.InitialDirectory = @"C:\Users\ladyk\Downloads";
            // фильтр на файлы 
            op.Filter = "(*.JPG)|*.JPG|rich(*.rtf)|*.rtf";

            // выполнить открытие диалога            
            if (op.ShowDialog() == DialogResult.OK)
            { // обработка исключения               
                try
                {
                    iFile = op.FileName;
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                    return;
                }

            }

            // загрузить фото в PictureBox
            Bitmap image = new Bitmap(op.FileName);

            this.фотоPictureBox.Size = image.Size;
            фотоPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            фотоPictureBox.Image = image;
            фотоPictureBox.Invalidate();

        }

        private void bindingNavigatorAddNewItem2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vhod vhod = new Vhod();
            vhod.Show();
            this.Hide();
        }

        private void комплектацияLabel1_Click(object sender, EventArgs e)
        {

        }

        private void сотрудникNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._907ca_RylskayaDataSet3);
        }

        private void bindingNavigatorSaveItem1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._907ca_RylskayaDataSet3);
        }

        private void bindingNavigatorSaveItem2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.номерBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._907ca_RylskayaDataSet3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int poz = сотрудникBindingSource.Find(comboBox1.Text, textValue1.Text);
                сотрудникBindingSource.Position = poz;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return;
            }
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int poz = клиентBindingSource.Find(comboBox2.Text, textValue2.Text);
                клиентBindingSource.Position = poz;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
                string sql = "select * from Сотрудник";
            otchet(sql);
        }
               
        private void otchet(string sql)
        {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
               
                DataSet ds = new DataSet();
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = conn;
                    myCommand.CommandText = sql;
                   
                    dataAdapter.SelectCommand = myCommand;
                    
                    dataAdapter.Fill(ds, "Отчет");
                    
                    dataGridView4.DataSource = ds.Tables["Отчет"].DefaultView;
                } 
            }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "select * from Клиент";
            otchet(sql);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sql = "select * from Номер";
            otchet(sql);
        }
    }
    
}
