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
    public partial class Nomera : Form
    {
        public Nomera()
        {
            InitializeComponent();
        }

        //string strConn = @"Data Source=DBSrv\MsSQLita;Initial Catalog=907ca_Rylskaya;Integrated Security=True";
        string strConn = @"Data Source=DESKTOP-IDFMA1L\SQLEXPRESS;Initial Catalog=907ca_Rylskaya;Integrated Security=True";
        
        private void Nomera_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_907ca_RylskayaDataSet3.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this._907ca_RylskayaDataSet3.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_907ca_RylskayaDataSet3.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this._907ca_RylskayaDataSet3.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_907ca_RylskayaDataSet3.Бронирование_номеров". При необходимости она может быть перемещена или удалена.
            this.бронирование_номеровTableAdapter.Fill(this._907ca_RylskayaDataSet3.Бронирование_номеров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_907ca_RylskayaDataSet3.Тип_номера". При необходимости она может быть перемещена или удалена.
            this.тип_номераTableAdapter.Fill(this._907ca_RylskayaDataSet3.Тип_номера);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_907ca_RylskayaDataSet3.Номер". При необходимости она может быть перемещена или удалена.
            this.номерTableAdapter.Fill(this._907ca_RylskayaDataSet3.Номер);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Vhod vhod = new Vhod();
            vhod.Show();
            this.Hide();
        }
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            updateType(sender, e);
        }

        private void updateType(object sender, EventArgs e)
        {
            try
            {
                this.тип_номераTableAdapter.FillBy(this._907ca_RylskayaDataSet3.Тип_номера, ((int)(System.Convert.ChangeType(номерTextBox1.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            updateType(sender, e);
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            updateType(sender, e);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            updateType(sender, e);
        }

        private void updateNomer(object sender, EventArgs e)
        {
                try
                { 
                    this.номерTableAdapter.FillBy(this._907ca_RylskayaDataSet3.Номер, date1.Value, date2.Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            updateNomer(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date01 = "CAST('" + date1.Value + "' AS DATE)";
            string date02 = "CAST('" + date2.Value + "' AS DATE)";
            Console.WriteLine(date01);
            Console.WriteLine(date02);
            string zavtrak;
            if (checkBox1.Checked == true)
            {
                 zavtrak = "Есть";
            }
            else  zavtrak = "Нет";

            string sql = "INSERT INTO [Бронирование Номеров]([ID Клиента], Номер, [ID Сотрудника], [Дата заселения], [Дата выезда], Завтрак, Статус) " + "VALUES('" + iDComboBox.Text + "','" + номерTextBox1.Text + "','" + iD_СотрудникаComboBox.Text + "',"+date01+","+date02+",'"+ zavtrak+"','Бронь')";

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
                MessageBox.Show("Номер забронирован");
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cena = 0;
            int cenaN = int.Parse(стоимостьTextBox1.Text);
            DateTime date02 = date2.Value;
            DateTime date01 = date1.Value;
            TimeSpan t = date02.Date - date01.Date;
            int days = t.Days;
            if (checkBox1.Checked == true) cena += 200 * days;
            cena += cenaN * days;
            label1.Text = cena.ToString();
        }
    }
}
