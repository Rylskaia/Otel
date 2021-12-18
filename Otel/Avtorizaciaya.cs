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
    public partial class Avtorizaciaya : Form
    {
        // string strConn = @"Data Source=DBSrv\MsSQLita;Initial Catalog=907ca_Rylskaya;Integrated Security=True";
        string strConn = @"Data Source=DESKTOP-IDFMA1L\SQLEXPRESS;Initial Catalog=907ca_Rylskaya;Integrated Security=True";
        
        
        public Avtorizaciaya()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string role = "";
            string poisk1 = "SELECT COUNT(*) FROM Клиент WHERE Логин = '" + login.Text + "'";
            string poisk2 = "SELECT COUNT(*) FROM Сотрудник WHERE Логин = '" + login.Text + "'";
            string poisk3 = "SELECT COUNT(*) FROM Сотрудник WHERE Логин = '" + login.Text + "' and Должность = 'Администратор'";
            string parol1 = "SELECT COUNT(*) FROM Клиент WHERE Логин = '"+login.Text+"' and Пароль = '"+parol.Text+"'";
            string parol2 = "SELECT COUNT(*) FROM Сотрудник WHERE Логин = '" + login.Text + "' and Пароль = '" + parol.Text + "'";
            if (proverka(poisk1) == 1)
            {
                role = "Клиент";
                Console.WriteLine(parol1);
                if (proverka(parol1) == 0)
                {
                    MessageBox.Show("Пароль не подходит");
                    return;
                }
            }
            else
            {
                if (proverka(poisk2) == 1)
                {
                    role = "Сотрудник";
                    Console.WriteLine(parol2);
                    if (proverka(parol2) == 0)
                    {
                        MessageBox.Show("Пароль не подходит");
                        return;
                    }
                    if (proverka(poisk3) == 1)
                        role = "Администратор";
                }
            }
            if(role == "")
            {
                MessageBox.Show("Пользователя с таким логином не существует");
                return;
            }


            string sql = "INSERT INTO Использование(Логин, Роль) " + "VALUES('" + login.Text + "','" + role + "')";

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }

            switch (role){
                case "Администратор":
                 Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                    break;
                case "Клиент":
                    Klient klient = new Klient();
                klient.Show();
                this.Hide();
                break;
                case "Сотрудник":
                    Sotrudnik sotrudnik = new Sotrudnik();
                sotrudnik.Show();
                this.Hide();
                break;
            }
           
           
        


        }

        private int proverka(string poisk)
        {
            Int32 m=0;
           using (SqlConnection conn = new SqlConnection(strConn))
            {
                //conn.Open();
                SqlCommand cmd = new SqlCommand(poisk, conn);
                try
                {
                    conn.Open();
                    m = (Int32)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            Console.WriteLine(m);
            return (int)m;
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vhod vhod = new Vhod();
            vhod.Show();
            this.Hide();
        }

        private void parol_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
