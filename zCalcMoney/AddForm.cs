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

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (fioBox.Text != "" && metroComboBox1.Text != "" && brigadaBox.Text != "" && yowBox.Text != "" && ywcBox.Text != "")
            {
                messageLabel.Text = "";
                string fio = fioBox.Text;
                string role = metroComboBox1.Text;
                string brigada = brigadaBox.Text;
                metroDateTime1.Format = DateTimePickerFormat.Custom;
                string date = metroDateTime1.Value.ToShortDateString();
                int yow = Convert.ToInt32(yowBox.Text);
                int ywc = Convert.ToInt32(ywcBox.Text);
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
                mysql_query.CommandText = "INSERT INTO workers (fio, b_day, role, brigada, years_on_work, years_without_crashes, hard_work) " +
                "VALUES ('" + fio + "', '" + Kadr.GetDateSQLFormat(date) + "', '" + role + "', '" + brigada + "', '" + yow + "', '" + ywc + "', '" + hw + "');";
                mysql_connection.Open();
                MessageBox.Show(mysql_query.CommandText);
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
