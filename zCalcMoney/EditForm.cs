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
            mysql_query.CommandText = "SELECT * FROM workers WHERE id = '" + id + "';";
            mysql_connection.Open();
            MySqlDataReader mysql_result;
            mysql_result = mysql_query.ExecuteReader();
            while (mysql_result.Read())
            {
                fioBox.Text = mysql_result[1].ToString();
                b_dayBox.Text = mysql_result[2].ToString().Remove(10, 8);
                metroComboBox1.Text = mysql_result[3].ToString();
                brigadaBox.Text = mysql_result[4].ToString();
                yowBox.Text = mysql_result[5].ToString();
                ywcBox.Text = mysql_result[6].ToString();
                if (mysql_result[7].ToString() == hard)
                {
                    metroCheckBox1.Checked = true;
                }
                else {
                    metroCheckBox1.Checked = false;
                }
            }
            MessageBox.Show("Дата из БД " + mysql_result[2].ToString());
            mysql_result.Close();
            mysql_connection.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string hw = "Нет";
            if (fioBox.Text != "" && metroComboBox1.Text != "" && brigadaBox.Text != "" && yowBox.Text != "" && ywcBox.Text != "" && b_dayBox.Text.Length == 10)
            {
                messageLabel.Text = "";
                string fio = fioBox.Text;
                string role = metroComboBox1.Text;
                string brigada = brigadaBox.Text;
                string date = b_dayBox.Text;
                int yow = Convert.ToInt32(yowBox.Text);
                int ywc = Convert.ToInt32(ywcBox.Text);
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
                    "years_on_work = '" + yow + "', " +
                    "years_without_crashes = '" + ywc + "', " +
                    "hard_work = '" + hw + "' WHERE id = '" + id + "';";
                mysql_connection.Open();
                MessageBox.Show(mysql_query.CommandText);
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
