using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Zarplata
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authorization());
        }
    }

    static class Username
    {
        public static string username { get; set; }
    }

    public class Calc 
    {
        public static void VivodRole(string rol, ComboBox combobox, string conn)
        {
            MySqlConnection mysql_connection = new MySqlConnection(conn);
            MySqlCommand mysql_query = mysql_connection.CreateCommand();
            mysql_query.CommandText = "SELECT fio FROM workers WHERE role = '" + rol + "';";
            mysql_connection.Open();
            MySqlDataReader mysql_result;
            mysql_result = mysql_query.ExecuteReader();
            combobox.Items.Clear();
            while (mysql_result.Read())
            {
                combobox.Items.Add(mysql_result[0]);
            }
            mysql_result.Close();
            mysql_connection.Close();
        }

        public static void Vivod(int ind, TextBox textbox1, TextBox textbox2, TextBox textbox3, TextBox textbox4, TextBox textbox5, TextBox textbox6, TextBox textbox7, TextBox textbox8, TextBox textbox9, string conn)
        {
            MySqlConnection mysql_connection = new MySqlConnection(conn);
            MySqlCommand mysql_query = mysql_connection.CreateCommand();
            mysql_query.CommandText = "SELECT * FROM main WHERE id = '" + ind + "';";
            mysql_connection.Open();
            MySqlDataReader mysql_result;
            mysql_result = mysql_query.ExecuteReader();
            while (mysql_result.Read()) // вытаскиваем из БД нынешние коэффициенты
            {
                textbox1.Text = (mysql_result[1].ToString()).Replace(',', '.'); //avg_for_time
                textbox2.Text = (mysql_result[2].ToString()).Replace(',', '.'); //koef_night_time
                textbox3.Text = (mysql_result[3].ToString()).Replace(',', '.'); //koef_class
                textbox4.Text = (mysql_result[4].ToString()).Replace(',', '.'); //koef_holidays
                textbox5.Text = (mysql_result[5].ToString()).Replace(',', '.'); //koef_night_razdrob
                textbox6.Text = (mysql_result[6].ToString()).Replace(',', '.'); //koef_hardwork
                textbox7.Text = (mysql_result[7].ToString()).Replace(',', '.'); //prem_bez_avarii
                textbox8.Text = (mysql_result[8].ToString()).Replace(',', '.'); //prem_za_let
                textbox9.Text = (mysql_result[9].ToString()).Replace(',', '.'); //prem_za_hard
            }
            mysql_result.Close();
            mysql_connection.Close();
        }
    }
}
