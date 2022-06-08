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
    public partial class EditForm : MetroFramework.Forms.MetroForm
    {
        public EditForm()
        {
            InitializeComponent();
        }

        int id = EditWorker.id;
        string hard = "Да";
        string connStr = "server = chuc.caseum.ru; port = 33333; user = st_2_18_23; database = is_2_18_st23_VKR; password = 51922291;";

        private void EditForm_Load(object sender, EventArgs e)
        {
            MySqlConnection mysql_connection = new MySqlConnection(connStr);
            MySqlCommand mysql_query = mysql_connection.CreateCommand();
            mysql_query.CommandText = "SELECT * FROM brigadi;";
            mysql_connection.Open();
            MySqlDataReader mysql_result;
            mysql_result = mysql_query.ExecuteReader();
            while (mysql_result.Read()) // заполняет список существующих бригад
            {
                 brigadaComboBox.Items.Add(mysql_result[1]);
            }
            mysql_result.Close();
            mysql_connection.Close();

            mysql_query = mysql_connection.CreateCommand();
            mysql_query.CommandText = "SELECT * FROM workers WHERE id = '" + id + "';";
            mysql_connection.Open();
            mysql_result = mysql_query.ExecuteReader();
            while (mysql_result.Read())
            {
                fioBox.Text = mysql_result[1].ToString();
                b_dayBox.Text = mysql_result[2].ToString().Remove(10, 8);
                empTextBox.Text = mysql_result[3].ToString().Remove(10, 8);
                roleComboBox1.Text = mysql_result[4].ToString();
                brigadaComboBox.Text = mysql_result[5].ToString();
                if (mysql_result[6].ToString() == hard)
                {
                    metroCheckBox1.Checked = true;
                }
                else {
                    metroCheckBox1.Checked = false;
                }
            }
            //MessageBox.Show("Дата из БД " + mysql_result[2].ToString());
            mysql_result.Close();
            mysql_connection.Close();

            mysql_query.CommandText = "SELECT name FROM brigadi";
            mysql_connection.Open();
            mysql_result = mysql_query.ExecuteReader();
            while (mysql_result.Read())
            {
                brigadaComboBox.Items.Add(mysql_result[0]);
            }
            mysql_result.Close();
            mysql_connection.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string hw = "Нет";
            if (fioBox.Text != "" && roleComboBox1.Text != "" && brigadaComboBox.Text != "" && b_dayBox.Text.Length == 10)
            {
                messageLabel.Text = "";
                string fio = fioBox.Text;
                string role = roleComboBox1.Text;
                string brigada = brigadaComboBox.Text;
                string date = b_dayBox.Text;
                if (metroCheckBox1.Checked)
                {
                    hw = "Да";
                }

                MySqlConnection mysql_connection = new MySqlConnection(connStr);
                MySqlCommand mysql_query = mysql_connection.CreateCommand();
                mysql_query.CommandText = "UPDATE workers SET " +
                    "fio = '" + fio + "', " +
                    "b_day = '" + Kadr.GetDateSQLFormat(date) + "', " +
                    "role = '" + role + "', " +
                    "brigada = '" + brigada + "', " +
                    "hard_work = '" + hw + "' WHERE id = '" + id + "';";
                mysql_connection.Open();
                MySqlDataReader mysql_result;
                mysql_result = mysql_query.ExecuteReader();
                messageLabel.Text = "Данные обновлены!";
                mysql_result.Close();
                mysql_connection.Close();
            }
            else
            {
                messageLabel.Text = "Заполните поля!";
            }
        }
    }
}
