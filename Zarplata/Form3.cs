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
    public partial class KoefForm : Form
    {
        string conn = "server = 127.0.0.1; port = 3306; user = root; database = testdb; password = '';";
        int index = 1; //переменная для отслеживания поставленной должности работника (Машинист/Пом. машиниста)

        public KoefForm()
        {
            InitializeComponent();
        }

        private void buttonSafe_Click(object sender, EventArgs e) //принять изменения
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "") 
            {
                MySqlConnection mysql_connection = new MySqlConnection(conn);
                MySqlCommand mysql_query = mysql_connection.CreateCommand();
                mysql_query.CommandText = "UPDATE main SET " +
                    "avg_for_time = '" + textBox1.Text + "', " +
                    "koef_night_time = '" + textBox2.Text + "', " +
                    "koef_class = '" + textBox3.Text + "', " +
                    "koef_holidays = '" + textBox4.Text + "', " +
                    "koef_night_razdrob = '" + textBox5.Text + "', " +
                    "koef_hardwork = '" + textBox6.Text + "', " +
                    "prem_bez_avarii = '" + textBox7.Text + "', " +
                    "prem_za_let = '" + textBox8.Text + "', " +
                    "prem_za_hard = '" + textBox9.Text + "' WHERE id = '" + index + "';";
                mysql_connection.Open();
                MySqlDataReader mysql_result;
                mysql_result = mysql_query.ExecuteReader();
                label10.Text = "Данные успешно изменены";
                mysql_result.Close();
                mysql_connection.Close();
            }
            else{
                MessageBox.Show("Поля не могут быть пустыми");
            }
        }

        private void button2_Click(object sender, EventArgs e) //Вернуться
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //radiobutton Машинист
        {
            if (radioButton1.Checked)
            {
                index = 1; //Машинист
            }
            else
            {
                index = 2; //Помощник машиниста
            }

            Calc.Vivod(index, textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, conn);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) //radiobutton Помощник машиниста
        {
            if (radioButton2.Checked)
            {
                index = 2; //Помощник машиниста
            }
            else
            {
                index = 1; //Машинист
            }

            Calc.Vivod(index, textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, conn);
        }

        private void KoefForm_Load(object sender, EventArgs e)
        {
            Calc.Vivod(index, textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, conn);
        }
    }
}
