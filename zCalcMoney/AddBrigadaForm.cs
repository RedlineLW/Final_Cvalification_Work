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
    public partial class AddBrigadaForm : MetroFramework.Forms.MetroForm
    {
        public AddBrigadaForm()
        {
            InitializeComponent();
        }

        string conn = "server = chuc.caseum.ru; port = 33333; user = st_2_18_23; database = is_2_18_st23_VKR; password = 51922291;";

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != "")
            {
                string name = metroTextBox1.Text;
                MySqlConnection mysql_connection = new MySqlConnection(conn);
                MySqlCommand mysql_query = mysql_connection.CreateCommand();
                mysql_query.CommandText = "INSERT INTO brigadi (name) VALUES ('" + name + "');";
                mysql_connection.Open();
                MySqlDataReader mysql_result;
                mysql_result = mysql_query.ExecuteReader();
                messageLabel.Text = "Бригада добавлена!";
                mysql_result.Close();
                mysql_connection.Close();
            }
            else
            {
                messageLabel.Text = "Заполните поле!";
            }
        } // ОК

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        } // Отмена
    }
}
