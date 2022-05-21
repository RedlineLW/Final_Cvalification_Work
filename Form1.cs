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

namespace Zarplata
{
    public partial class Authorization : Form
    {
        MainForm newForm = new MainForm();

        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginBox.Text != "" && passwordBox.Text != "")
            {
                string login = loginBox.Text;
                string password = passwordBox.Text;

                string conn = "server = chuc.caseum.ru; port = 33333; user = st_2_18_23; database = is_2_18_st23_VKR; password = 51922291;";
                MySqlConnection mysql_connection = new MySqlConnection(conn);
                MySqlCommand mysql_query = mysql_connection.CreateCommand();
                mysql_query.CommandText = "SELECT * FROM users WHERE login = '" + @login + "' AND password = '" + @password + "';";
                mysql_query.Parameters.AddWithValue("@login", loginBox.Text);
                mysql_query.Parameters.AddWithValue("@password", passwordBox.Text);
                mysql_connection.Open();
                MySqlDataReader mysql_result;
                mysql_result = mysql_query.ExecuteReader();
                if (mysql_result.HasRows)
                {
                    while (mysql_result.Read())
                    {
                        //Заносим ФИО бухгалтера в общую переменную класса Program.cs
                        Username.username = mysql_result[1].ToString(); 
                        //Переходим к основной форме и закрываем авторизацию
                        MainForm go_to_main = new MainForm();
                        go_to_main.Show();
                        this.Hide();
                    }
                }
                else
                {
                    labelMessage.Text = "Произошла ошибка. Проверьте правильность логина и пароля или свяжитесь с администратором!";
                }
            }
            else
            {
                labelMessage.Text = "Поля не могут быть пустыми!";
            }
        }
    }
}
