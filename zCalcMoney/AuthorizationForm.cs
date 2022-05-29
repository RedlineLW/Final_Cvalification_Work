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
    public partial class AuthorizationForm : MetroFramework.Forms.MetroForm
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        MainForm newForm = new MainForm();

        private void metroButton1_Click(object sender, EventArgs e) //Авторизироваться
        {
            if (loginBox.Text != "" && passwordBox.Text != "")
            {
                messageLabel.Text = "";
                string login = loginBox.Text;
                string password = passwordBox.Text;
                loginBox.WaterMarkColor = Color.FromArgb(105, 105, 105);
                passwordBox.WaterMarkColor = Color.FromArgb(105, 105, 105);

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
                        if (mysql_result[2].ToString() == "Бухгалтер")
                        {
                            //Заносим ФИО бухгалтера в общую переменную класса Program.cs
                            Username.userbuh = mysql_result[1].ToString();
                            //Переносим бухгалтера в окно с расчётами
                            MainForm go_to_main = new MainForm();
                            go_to_main.Show();
                            this.Hide();
                        }
                        else if (mysql_result[2].ToString() == "Кадры") {
                            kadrForm go_to_kadr = new kadrForm();
                            go_to_kadr.Show();
                            this.Hide();
                        }
                        else {
                            AdminForm admin = new AdminForm();
                            admin.Owner = this;
                            admin.ShowDialog();
                            this.Hide();
                        }
                        
                    }
                }
                else
                {
                    messageLabel.Text = "Проверьте логин или пароль.";
                }
            }
            else
            {
                messageLabel.Text = "Поля должны быть заполнены.";
            }
        }
    }
}
