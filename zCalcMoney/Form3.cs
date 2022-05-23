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

        private void Form3_Load(object sender, EventArgs e)
        {
            Calc.Vivod(index, metroTextBox1, metroTextBox2, metroTextBox3, metroTextBox4, metroTextBox5, metroTextBox6, metroTextBox7, metroTextBox8, metroTextBox9, conn);
        }

        private void metroButton1_Click(object sender, EventArgs e) //сохранить
        {
            if (metroTextBox1.Text != "" && metroTextBox2.Text != "" && metroTextBox3.Text != "" && metroTextBox4.Text != "" && metroTextBox5.Text != "" && metroTextBox6.Text != "" && metroTextBox7.Text != "" && metroTextBox8.Text != "" && metroTextBox9.Text != "")
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
                    "prem_bez_avarii = '" + metroTextBox7.Text + "', " +
                    "prem_za_let = '" + metroTextBox8.Text + "', " +
                    "prem_za_hard = '" + metroTextBox9.Text + "' WHERE id = '" + index + "';";
                mysql_connection.Open();
                MySqlDataReader mysql_result;
                mysql_result = mysql_query.ExecuteReader();
                metroLabel10.Text = "Данные успешно изменены";
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
                index = 1; //Машинист
            }
            else
            {
                index = 2; //Помощник машиниста
            }

            Calc.Vivod(index, metroTextBox1, metroTextBox2, metroTextBox3, metroTextBox4, metroTextBox5, metroTextBox6, metroTextBox7, metroTextBox8, metroTextBox9, conn);
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e) //выбран помощник машиниста
        {
            if (metroRadioButton2.Checked)
            {
                index = 2; //Помощник машиниста
            }
            else
            {
                index = 1; //Машинист
            }

            Calc.Vivod(index, metroTextBox1, metroTextBox2, metroTextBox3, metroTextBox4, metroTextBox5, metroTextBox6, metroTextBox7, metroTextBox8, metroTextBox9, conn);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            metroLabel10.Text = "";
        } // вернуться
    }
}
