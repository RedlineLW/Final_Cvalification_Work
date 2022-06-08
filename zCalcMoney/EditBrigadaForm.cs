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
    public partial class EditBrigadaForm : MetroFramework.Forms.MetroForm
    {
        public EditBrigadaForm()
        {
            InitializeComponent();
        }

        int id = EditBrigada.id;
        string connStr = "server = chuc.caseum.ru; port = 33333; user = st_2_18_23; database = is_2_18_st23_VKR; password = 51922291;";

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection mysql_connection = new MySqlConnection(connStr);
            MySqlCommand mysql_query = mysql_connection.CreateCommand();
            mysql_query.CommandText = "SELECT * FROM brigadi WHERE id = '" + id + "';";
            mysql_connection.Open();
            MySqlDataReader mysql_result;
            mysql_result = mysql_query.ExecuteReader();
            while (mysql_result.Read())
            {
                metroTextBox1.Text = mysql_result[1].ToString();
            }
            mysql_result.Close();
            mysql_connection.Close();
        } // Загрузка формы

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != "")
            {
                string name = metroTextBox1.Text;
                MySqlConnection mysql_connection = new MySqlConnection(connStr);
                MySqlCommand mysql_query = mysql_connection.CreateCommand();
                mysql_query.CommandText = "UPDATE brigadi SET name = '" + name + "' WHERE id = '" + id + "';";
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
        } // ОК

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        } // Отмена
    }
}
