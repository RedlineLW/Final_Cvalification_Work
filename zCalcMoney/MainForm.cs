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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        int emp; // переменная для хранения даты трудоустройства сотрудника
        int now; // переменная для хранения нынешней даты
        string p = "0"; // переменная для хранения значения процентов
        string conn = "server = chuc.caseum.ru; port = 33333; user = st_2_18_23; database = is_2_18_st23_VKR; password = 51922291;";
        string role = "Машинист";
        double index = 2;
        double avg_for_time = 0;
        double koef_night_time = 0;
        double koef_class = 0;
        double koef_holidays = 0;
        double koef_night_razdrob = 0;
        double koef_hardwork = 0;
        double prem_bez_avarii = 0;
        double prem_za_let = 0;
        double prem_za_hard = 0;
        double ndfl = 0;
        string brigada = "Бригада";
        double totalSUM;
        double zalet;
        double zahard;
        double totalndfl;
        double totalH;
        double totalNH;
        double totalClass;
        double totalHH;
        double totalNR;
        double totalHard;
        double hours;
        double nighthours;
        double holydayhours;
        int ow;
        string hw;
        string brig;
        string a;

        private void MainForm_Load(object sender, EventArgs e)
        {
            MySqlConnection mysql_connection = new MySqlConnection(conn);
            MySqlCommand mysql_query = mysql_connection.CreateCommand();
            mysql_query.CommandText = "SELECT * FROM brigadi;";
            mysql_connection.Open();
            MySqlDataReader mysql_result;
            mysql_result = mysql_query.ExecuteReader();
            while (mysql_result.Read()) // заполняет список существующих бригад
            {
                if (brig != mysql_result[1].ToString()) {
                    metroComboBox2.Items.Add(mysql_result[1]);
                    brig = mysql_result[1].ToString();
                }
            }
            mysql_result.Close();
            mysql_connection.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e) //расчитать
        {
            MySqlConnection mysql_connection = new MySqlConnection(conn);
            MySqlCommand mysql_query = mysql_connection.CreateCommand();
            mysql_query.CommandText = "SELECT * FROM main WHERE id = '" + index + "';";
            mysql_connection.Open();
            MySqlDataReader mysql_result;
            mysql_result = mysql_query.ExecuteReader();
            while (mysql_result.Read()) // вытаскиваем из БД нынешние коэффициенты
            {
                avg_for_time = Convert.ToDouble(mysql_result[1]);
                koef_night_time = Convert.ToDouble(mysql_result[2]);
                koef_class = Convert.ToDouble(mysql_result[3]);
                koef_holidays = Convert.ToDouble(mysql_result[4]);
                koef_night_razdrob = Convert.ToDouble(mysql_result[5]);
                koef_hardwork = Convert.ToDouble(mysql_result[6]);
                prem_za_hard = Convert.ToDouble(mysql_result[7]);
                ndfl = Convert.ToDouble(mysql_result[8]);
            }
            mysql_result.Close();
            mysql_connection.Close();

            if (hourBox.Text != "" && hourNightBox.Text != "" && holHoursBox.Text != "") //если поля заполнены, считаем Зарплату
            {
                metroLabel6.Text = "";
                hours = Convert.ToDouble(hourBox.Text);
                nighthours = Convert.ToDouble(hourNightBox.Text);
                holydayhours = Convert.ToDouble(holHoursBox.Text);
                try
                {
                    mysql_query.CommandText = "SELECT * FROM workers WHERE fio = '" + metroComboBox1.Text + "';";
                    mysql_connection.Open();
                    mysql_result = mysql_query.ExecuteReader();
                    now = Convert.ToInt32((DateTime.Now).ToString("yyyy"));
                    while (mysql_result.Read()) // вытаскиваем из БД данные о работнике
                    {
                        a = (mysql_result[3].ToString()); //Получаем год трудоустройства
                        hw = mysql_result[6].ToString();
                    }
                    a = a.Substring(6, a.Length - 14);
                    emp = Convert.ToInt32(a);
                    mysql_result.Close();
                    mysql_connection.Close();
                    ow = now - emp;
                    totalH = hours * avg_for_time; //ставка
                    totalNH = nighthours * (avg_for_time + koef_night_time); //ЗП за ночное время
                    totalClass = totalH * koef_class; //За классность
                    totalHH = holydayhours * avg_for_time * koef_holidays; //ЗП за праздники
                    totalNR = totalNH * koef_night_razdrob;//ЗП за ночную раздробленную смену
                    totalHard = totalH * koef_hardwork;//ЗП за длинносоставные и тяжеловесящие составы
                    totalSUM = totalH + totalNH + totalClass + totalHH + totalNR + totalHard;//Подсчёт итоговой суммы
                    if (ow >= 2 && ow < 5) { // определяем размер премии за выслугу лет
                        totalSUM += totalH * 0.10;
                        zalet = totalH * 0.10;
                        p = "10";
                    }
                    else if (ow >= 5 && ow < 10) {
                        totalSUM += totalH * 0.15;
                        zalet = totalH * 0.15;
                        p = "15";
                    }
                    else if (ow >= 10 && ow < 15) {
                        totalSUM += totalH * 0.20;
                        zalet = totalH * 0.20;
                        p = "20";
                    }
                    else if (ow >= 15 && ow < 20)
                    {
                        totalSUM += totalH * 0.25;
                        zalet = totalH * 0.25;
                        p = "25";
                    }
                    else if (ow >= 20 && ow < 25) {
                        totalSUM += totalH * 0.30;
                        zalet = totalH * 0.30;
                        p = "30";
                    }
                    else if (ow >= 25) {
                        totalSUM += totalH * 0.40;
                        zalet = totalH * 0.40;
                        p = "40";
                    }
                    if (hw == "Да")
                    { //премия за работу на длинносоставных и тяжеловесящих составах
                        totalSUM += totalH * prem_za_hard;
                        zahard = totalH * prem_za_hard;
                    }
                    totalndfl = totalSUM * ndfl; // расчитываем НДФЛ
                    totalSUM -= totalndfl; // вычитаем из зарплаты НДФЛ
                    metroLabel5.Text = "Сумма: " + totalSUM.ToString() + " Руб.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(a);
                    MessageBox.Show($"Исключение: {ex.Message} /n Метод: {ex.TargetSite} /n Трассировка стека: {ex.StackTrace}");
                }
            }
            else
            {
                metroLabel6.Text = "Заполните все поля!";
            }
        }

        private void metroButton2_Click(object sender, EventArgs e) //сохранить в бд
        {
            if (metroComboBox1.Text != "")
            {
                if (hourBox.Text != "" && hourNightBox.Text != "" && holHoursBox.Text != "")
                {
                    string fio_buh = Username.userbuh;
                    string fio_worker = metroComboBox1.Text;
                    MySqlConnection mysql_connection = new MySqlConnection(conn);
                    MySqlCommand mysql_query = mysql_connection.CreateCommand();
                    mysql_query.CommandText = "INSERT INTO storage (fio_buh, fio_worker, brig_worker, zp_worker, date, dayHours, nightHours, holHours, prem_za_let, prem_za_hard, ndfl) " +
                    "VALUES ('" + fio_buh + "', '" + fio_worker + "', '" + brigada + "', " +
                    "'" + (totalSUM.ToString()).Replace(',', '.') + "', " +
                    "'" + (DateTime.Now).ToString("yyyy-MM-dd hh:mm:ss") + "', " +
                    "'" + Convert.ToInt32(hourBox.Text) + "', " +
                    "'" + Convert.ToInt32(hourNightBox.Text) + "', " +
                    "'" + Convert.ToInt32(holHoursBox.Text) + "', " +
                    "'" + (zalet.ToString().Replace(',', '.')) + "', " +
                    "'" + (zahard.ToString().Replace(',','.')) + "', " +
                    "'" + (totalndfl.ToString().Replace(',', '.')) + "');";
                    mysql_connection.Open();
                    //MessageBox.Show(mysql_query.CommandText);
                    MySqlDataReader mysql_result;
                    mysql_result = mysql_query.ExecuteReader();
                    metroLabel6.Text = "Данные добавлены!";
                    mysql_result.Close();
                    mysql_connection.Close();
                }
                else
                {
                    metroLabel6.Text = "Укажите количество часов!";
                }

            }
            else
            {
                metroLabel6.Text = "Укажите работника!";
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hourBox.Text = "";
            hourNightBox.Text = "";
            holHoursBox.Text = "";
            metroLabel6.Text = "";
            metroLabel5.Text = "Сумма: ";
            MySqlConnection mysql_connection = new MySqlConnection(conn);
            MySqlCommand mysql_query = mysql_connection.CreateCommand();
            mysql_query.CommandText = "SELECT * FROM workers WHERE fio = '" + metroComboBox1.Text + "';";
            mysql_connection.Open();
            MySqlDataReader mysql_result;
            mysql_result = mysql_query.ExecuteReader();
            while (mysql_result.Read())
            {
                //берём название должности
                role = mysql_result[4].ToString();
            }
            mysql_result.Close();
            mysql_connection.Close();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e) //выбран другой сотрудник
        {
            metroComboBox1.Items.Clear();
            MySqlConnection mysql_connection = new MySqlConnection(conn);
            MySqlCommand mysql_query = mysql_connection.CreateCommand();
            mysql_query.CommandText = "SELECT * FROM workers WHERE brigada = '" + metroComboBox2.Text + "';";
            mysql_connection.Open();
            MySqlDataReader mysql_result;
            mysql_result = mysql_query.ExecuteReader();
            while (mysql_result.Read()) // заполняет список сотрудников из данной бригады
            {
                metroComboBox1.Items.Add(mysql_result[1]);
            }
            mysql_result.Close();
            mysql_connection.Close();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            dataForm go_to_data = new dataForm();
            go_to_data.Show();
        } // перейти к Базе Данных с расчётами

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (hourBox.Text != "" && hourNightBox.Text != "" && holHoursBox.Text != "") {
                MessageBox.Show("Сотрудник: " + metroComboBox1.Text + " \n " +
                    "Отработал " + hourBox.Text + " часов днём и заработал " + totalH + " рублей \n " +
                    hourNightBox.Text + " часов ночью и заработал " + totalNH + " рублей \n " +
                    holHoursBox.Text + " часов в выходные и заработал " + totalHH + " рублей \n " +
                    "Выслуга лет за " + ow + " лет составляет " + p + " % (" + zalet + " рублей) \n" +
                    "За работу на тяж. поездах " + totalHard + " рублей (если работает) \n" +
                    "Вычеты по НДФЛ составляют " + totalndfl + " рублей.", "Подробности");
            }
        } // подробнее

        private void metroButton5_Click(object sender, EventArgs e)
        {
            KoefForm go_to_koef = new KoefForm();
            go_to_koef.Owner = this;
            go_to_koef.ShowDialog(this);
        } // изменить коэффициенты
    }
}
