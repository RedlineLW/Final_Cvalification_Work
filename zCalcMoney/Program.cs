using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace zCalcMoney
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
            Application.Run(new AuthorizationForm());
        }
    }
    static class Username
    {
        public static string username { get; set; }
    }

    static class Worker 
    { 
        public static string selected_worker { get; set; }
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
        } // Метод вывода по фильтру должности машиниста и помощника машиниста

        public static void Vivod(int ind, MetroFramework.Controls.MetroTextBox textbox1, MetroFramework.Controls.MetroTextBox textbox2, MetroFramework.Controls.MetroTextBox textbox3, MetroFramework.Controls.MetroTextBox textbox4, MetroFramework.Controls.MetroTextBox textbox5, MetroFramework.Controls.MetroTextBox textbox6, MetroFramework.Controls.MetroTextBox textbox7, MetroFramework.Controls.MetroTextBox textbox8, MetroFramework.Controls.MetroTextBox textbox9, string conn)
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
        } // метод вывода коэффициентов
    }

    public class ShowData 
    {
        public static void GetList(string selectCommand, string conn, BindingSource bs_list_tasks, System.Data.DataTable dt_list_tasks)
        {
            try
            {
                MySqlDataAdapter list_task_adapter = new MySqlDataAdapter(selectCommand, conn);
                bs_list_tasks.DataSource = dt_list_tasks;
                list_task_adapter.Fill(dt_list_tasks);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка при вызове метода GetData! \n\n\n" + ex, "Ошибка");
            }
        } // получение списка проведённых расчётов
    }
}
