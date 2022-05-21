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
    public partial class MainForm : Form
    {
        KoefForm edit_koef;
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
        string brigada = "Бригада";
        double totalSUM;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) //Расчитать
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
                prem_bez_avarii = Convert.ToDouble(mysql_result[7]);
                prem_za_let = Convert.ToDouble(mysql_result[8]);
                prem_za_hard = Convert.ToDouble(mysql_result[9]);
            }
            mysql_result.Close();
            mysql_connection.Close();

            if (hourBox.Text != "" || hourNightBox.Text != "" || holHoursBox.Text != "") //если поля заполнены, считаем Зарплату
            {
                label7.Text = "";
                double hours = Convert.ToDouble(hourBox.Text);
                double nighthours = Convert.ToDouble(hourNightBox.Text);
                double holydayhours = Convert.ToDouble(holHoursBox.Text);
                double totalH;
                double totalNH;
                double totalClass;
                double totalHH;
                double totalNR;
                double totalHard;
                try {
                    totalH = hours * avg_for_time; //ставка
                    totalNH = nighthours * (avg_for_time + koef_night_time); //ЗП за ночное время
                    totalClass = totalH * koef_class; //За классность
                    totalHH = holydayhours * avg_for_time * koef_holidays; //ЗП за праздники
                    totalNR = totalH * koef_night_razdrob;//ЗП за ночную раздробленную смену
                    totalHard = totalH * koef_hardwork;//ЗП за длинносоставные и тяжеловесящие составы
                    totalSUM = totalH + totalNH + totalClass + totalHH + totalNR + totalHard;//Подсчёт итоговой суммы
                    if (checkBox1.Checked) { //премия за выслугу лет
                        totalSUM += totalH * prem_za_let;
                    }
                    if (checkBox2.Checked) { //премия за безаварийность
                        totalSUM += totalH * prem_bez_avarii;
                    }
                    if (checkBox3.Checked) { //премия за работу на длинносоставных и тяжеловесящих составах
                        totalSUM += totalH * prem_za_hard;
                    }
                    label4.Text = "Сумма: " + totalSUM.ToString() + " Руб.";
                }
                catch {
                    label7.Text = "Произошла ошибка, проверьте правильность введённых данных и коэффециенты!";
                }
            }
            else {
                label7.Text = "Заполните все поля!";
            }
        }

        private void label5_Click(object sender, EventArgs e) //Изменить коэффициенты
        {
            if (edit_koef == null) edit_koef = new KoefForm();
            edit_koef.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e) //Добавить в базу
        {
            if (comboBox1.Text != "") {
                if (hourBox.Text != "" && hourNightBox.Text != "" && holHoursBox.Text != "") {
                    string fio_buh = Username.username;
                    string fio_worker = comboBox1.Text;
                    MySqlConnection mysql_connection = new MySqlConnection(conn);
                    MySqlCommand mysql_query = mysql_connection.CreateCommand();
                    mysql_query.CommandText = "INSERT INTO storage (fio_buh, fio_worker, brig_worker, zp_worker, date) VALUES ('" + fio_buh + "', '" + fio_worker + "', '" + brigada + "', '" + (totalSUM.ToString()).Replace(',', '.') + "', '" + (DateTime.Now).ToString("yyyy-MM-dd hh:mm:ss") + "');";
                    mysql_connection.Open();
                    MySqlDataReader mysql_result;
                    mysql_result = mysql_query.ExecuteReader();
                    label7.Text = "Данные добавлены!";
                    mysql_result.Close();
                    mysql_connection.Close();
                }
                else {
                    label7.Text = "Укажите количество часов!";
                }
                
            }
            else {
                label7.Text = "Укажите работника!";
            }
        }

        private void Main_Load(object sender, EventArgs e) //Загрузка формы и показ
        {
            Calc.VivodRole(role, comboBox1, conn);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //вывод данных о рабочем в listbox
        {
            MySqlConnection mysql_connection = new MySqlConnection(conn);
            MySqlCommand mysql_query = mysql_connection.CreateCommand();
            mysql_query.CommandText = "SELECT * FROM workers WHERE fio = '" + comboBox1.Text + "';";
            mysql_connection.Open();
            MySqlDataReader mysql_result;
            mysql_result = mysql_query.ExecuteReader();
            while (mysql_result.Read())
            {
                //берём название бригады из БД
                brigada = mysql_result[4].ToString(); 
                //Выводим данные о стаже и прочем о конкретном работнике
                listBox.Items.Clear();
                listBox.Items.Add("Стаж работы: " + mysql_result[5]);
                listBox.Items.Add("Лет без аварий: " + mysql_result[6]);
                listBox.Items.Add("Работает на тяжелых поездах: " + mysql_result[7]);
            }
            mysql_result.Close();
            mysql_connection.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //выбран машинист
        {
            if (radioButton1.Checked)
            {
                role = "Помощник машиниста";
                index = 1;
            }
            else {
                role = "Машинист";
                index = 2;
            }

            Calc.VivodRole(role, comboBox1, conn);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) //выбран помощник машиниста
        {
            if (radioButton2.Checked)
            {
                role = "Машинист";
                index = 2;
            }
            else
            {
                role = "Помощник машиниста";
                index = 1;
            }

            Calc.VivodRole(role, comboBox1, conn);
        }
    }
}
