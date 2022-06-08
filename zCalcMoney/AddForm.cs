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
    public partial class AddForm : MetroFramework.Forms.MetroForm
    {
        public AddForm()
        {
            InitializeComponent();
        }

        string conn = "server = chuc.caseum.ru; port = 33333; user = st_2_18_23; database = is_2_18_st23_VKR; password = 51922291;";

        private void AddForm_Load(object sender, EventArgs e)
        {
            MySqlConnection mysql_connection = new MySqlConnection(conn);
            MySqlCommand mysql_query = mysql_connection.CreateCommand();
            mysql_query.CommandText = "SELECT name FROM brigadi";
            mysql_connection.Open();
            MySqlDataReader mysql_result;
            mysql_result = mysql_query.ExecuteReader();
            while (mysql_result.Read()) {
                brigadaComboBox.Items.Add(mysql_result[0]);
            }
            mysql_result.Close();
            mysql_connection.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (fioBox.Text != "" && metroComboBox1.Text != "" && brigadaComboBox.Text != "")
            {
                messageLabel.Text = "";
                string fio = fioBox.Text;
                string role = metroComboBox1.Text;
                string brigada = brigadaComboBox.Text;
                metroDateTime1.Format = DateTimePickerFormat.Custom;
                string date = metroDateTime1.Value.ToShortDateString();
                string emp = metroDateTime2.Value.ToShortDateString();
                string hw;
                if (metroCheckBox1.Checked)
                {
                    hw = "Да";
                }
                else
                {
                    hw = "нет";
                }

                MySqlConnection mysql_connection = new MySqlConnection(conn);
                MySqlCommand mysql_query = mysql_connection.CreateCommand();
                mysql_query.CommandText = "INSERT INTO workers (fio, b_day, emp_day, role, brigada, hard_work) " +
                "VALUES ('" + fio + "', '" + Kadr.GetDateSQLFormat(date) + "', '" + Kadr.GetDateSQLFormat(emp) + "', '" + role + "', '" + brigada + "', '" + hw + "');";
                mysql_connection.Open();
                MySqlDataReader mysql_result;
                mysql_result = mysql_query.ExecuteReader();
                messageLabel.Text = "Сотрудник добавлен!";
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
