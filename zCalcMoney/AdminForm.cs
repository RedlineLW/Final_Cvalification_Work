using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace zCalcMoney
{
    public partial class AdminForm : MetroFramework.Forms.MetroForm
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        string conn = "server = chuc.caseum.ru; port = 33333; user = st_2_18_23; database = is_2_18_st23_VKR; password = 51922291;";
        string fio;
        string role1;
        string login;
        string password;
        Random rnd = new Random();

        private void AdminForm_Load(object sender, EventArgs e)
        {
            
        }
        private void buhButton_Click(object sender, EventArgs e)
        {
            dataForm data = new dataForm();
            data.Owner = this;
            data.ShowDialog();
        } // переход к окну бухгалтера

        private void brigButton_Click(object sender, EventArgs e)
        {
            MainForm brig = new MainForm();
            brig.Owner = this;
            brig.ShowDialog();
        } // переход к онку бригадира

        private void kadrButton_Click(object sender, EventArgs e)
        {
            kadrForm kadr = new kadrForm();
            kadr.Owner = this;
            kadr.ShowDialog();
        } // переход к окну кадров

        private void metroButton1_Click(object sender, EventArgs e)
        {
            fio = textBox1.Text;
            role1 = textBox2.Text;
            login = textBox3.Text;

            Password P = new Password();
            password = P.GetPass();

            MySqlConnection mysql_connection = new MySqlConnection(conn);
            MySqlCommand mysql_query = mysql_connection.CreateCommand();
            mysql_query.CommandText = "INSERT INTO users (fio, role, login, password) " +
                "VALUES ('" + fio + "', '" + role1 + "', '" + login + "', '" + password + "');";
            mysql_connection.Open();
            MySqlDataReader mysql_result;
            mysql_result = mysql_query.ExecuteReader();

            MessageBox.Show("Пользователь " + fio + " зарегестрирован с должностью: " + role1 + " ; Логином " + login + " ; Паролем " + password + " ");
            
        } // зарегистрировать нового пользователя

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            login = textBox3.Text;
            MySqlConnection mysql_connection = new MySqlConnection(conn);
            MySqlCommand mysql_query = mysql_connection.CreateCommand();
            mysql_query.CommandText = "SELECT fio FROM users WHERE login = '" + login + "';";
            mysql_connection.Open();
            MySqlDataReader mysql_result;
            mysql_result = mysql_query.ExecuteReader();
            while (mysql_result.Read()) // вытаскиваем из БД нынешние коэффициенты
            {
                fio = mysql_result[0].ToString();
            }
            mysql_result.Close();
            mysql_connection.Close();
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить пользователя: " + fio + " ",
        "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                mysql_query.CommandText = "DELETE FROM users WHERE login = '" + login + "';";
                mysql_connection.Open();
                mysql_result = mysql_query.ExecuteReader();
                //Вызов метода обновления ДатаГрида            
                this.Refresh();
                mysql_result.Close();
                mysql_connection.Close();
                MessageBox.Show("Пользователь " + fio + " удалён");
            }
        } // Удалить пользователя
    }
} 
