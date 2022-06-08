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
    public partial class KoefForm : MetroFramework.Forms.MetroForm
    {
        public KoefForm()
        {
            InitializeComponent();
        }

        string conn = "server = chuc.caseum.ru; port = 33333; user = st_2_18_23; database = is_2_18_st23_VKR; password = 51922291;";
        int index = 2; //переменная для отслеживания поставленной должности работника (Машинист/Пом. машиниста)
        string role = "Машинист";

        private void Form3_Load(object sender, EventArgs e)
        {
            Calc.Vivod(index, metroTextBox1, metroTextBox2, metroTextBox3, metroTextBox4, metroTextBox5, metroTextBox6, metroTextBox10, conn);
        }

        private void metroButton1_Click(object sender, EventArgs e) //сохранить
        {
            if (metroTextBox1.Text != "" && metroTextBox2.Text != "" && metroTextBox3.Text != "" && metroTextBox4.Text != "" && metroTextBox5.Text != "" && metroTextBox6.Text != "" && metroTextBox10.Text != "")
            {
                MySqlConnection mysql_connection = new MySqlConnection(conn);
                MySqlCommand mysql_query = mysql_connection.CreateCommand();
                mysql_query.CommandText = "UPDATE main SET " +
                    "avg_for_time = '" + metroTextBox1.Text + "', " +
                    "koef_night_time = '" + metroTextBox2.Text + "', " +
                    "koef_class = '" + metroTextBox3.Text + "', " +
                    "koef_holidays = '" + metroTextBox4.Text + "', " +
                    "koef_night_razdrob = '" + metroTextBox5.Text + "', " +
                    "koef_hardwork = '" + metroTextBox6.Text + "', " +
                    "koef_ndfl = '" + metroTextBox10.Text + "' WHERE id = '" + index + "';";
                mysql_connection.Open();
                MySqlDataReader mysql_result;
                mysql_result = mysql_query.ExecuteReader();
                metroLabel10.Text = "Данные успешно изменены";
                mysql_result.Close();
                mysql_connection.Close();

                mysql_connection.CreateCommand();
                mysql_query.CommandText = "INSERT INTO history (buh, date, role, stavka, koef_night, koef_class, koef_holiday, koef_razdrob, koef_hard, koef_ndfl) VALUES " +
                    " ('" + Username.userbuh + "',  " +
                    " '" + (DateTime.Now).ToString("yyyy-MM-dd") + "', " +
                    " '" + role + "', " +
                    " '" + metroTextBox1.Text + "', " +
                    " '" + metroTextBox2.Text + "', " +
                    " '" + metroTextBox3.Text + "', " +
                    " '" + metroTextBox4.Text + "', " +
                    " '" + metroTextBox5.Text + "', " +
                    " '" + metroTextBox6.Text + "', " +
                    " '" + metroTextBox10.Text + "') ;";
                MessageBox.Show(mysql_query.CommandText); // проверка запроса
                mysql_connection.Open();
                mysql_result = mysql_query.ExecuteReader();
                mysql_result.Close();
                mysql_connection.Close();
            }
            else
            {
                metroLabel10.Text = "Поля не могут быть пустыми";
            }
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e) //выбран машинист
        {
            if (metroRadioButton1.Checked)
            {
                index = 1; //Помощник машиниста
                role = "Помощник машиниста";
            }
            else
            {
                index = 2; //Машинист
                role = "Машинист";
            }

            Calc.Vivod(index, metroTextBox1, metroTextBox2, metroTextBox3, metroTextBox4, metroTextBox5, metroTextBox6, metroTextBox10, conn);
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e) //выбран помощник машиниста
        {
            if (metroRadioButton2.Checked)
            {
                index = 2; //Машинист
                role = "Машинист";
            }
            else
            {
                index = 1; //Помощник машиниста
                role = "Помощник машиниста";
            }

            Calc.Vivod(index, metroTextBox1, metroTextBox2, metroTextBox3, metroTextBox4, metroTextBox5, metroTextBox6, metroTextBox10, conn);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            HistoryForm go_to_history = new HistoryForm();
            go_to_history.Owner = this;
            go_to_history.ShowDialog(this);
        } // узнать историю изменений
    }
}
