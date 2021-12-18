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
    public partial class Registr : Form
    {
       // string strConn = @"Data Source=DBSrv\MsSQLita;Initial Catalog=907ca_Rylskaya;Integrated Security=True";
        string strConn = @"Data Source=DESKTOP-IDFMA1L\SQLEXPRESS;Initial Catalog=907ca_Rylskaya;Integrated Security=True";
        
        public Registr()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            string sql = "INSERT INTO Клиент(ФИО, Адрес, Телефон, Логин, Пароль) " + "VALUES('" + fio.Text + "','" + adres.Text + "','" + tel.Text + "','" + login.Text + "','" + parol.Text + "')";

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
                MessageBox.Show("Вы успешно зарегистрированны");
                Vhod vhod = new Vhod();
                vhod.Show();
                this.Hide();

            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void fio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
