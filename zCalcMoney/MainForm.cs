﻿using System;
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
        double bezavarii;
        double zahard;
        double totalndfl;
        int ow;
        int wc;
        string hw;
        string brig;

        private void MainForm_Load(object sender, EventArgs e)
        {
            MySqlConnection mysql_connection = new MySqlConnection(conn);
            MySqlCommand mysql_query = mysql_connection.CreateCommand();
            mysql_query.CommandText = "SELECT * FROM workers;";
            mysql_connection.Open();
            MySqlDataReader mysql_result;
            mysql_result = mysql_query.ExecuteReader();
            while (mysql_result.Read()) // заполняет список существующих бригад
            {
                if (brig != mysql_result[4].ToString()) {
                    metroComboBox2.Items.Add(mysql_result[4]);
                    brig = mysql_result[4].ToString();
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
                prem_bez_avarii = Convert.ToDouble(mysql_result[7]);
                prem_za_let = Convert.ToDouble(mysql_result[8]);
                prem_za_hard = Convert.ToDouble(mysql_result[9]);
                ndfl = Convert.ToDouble(mysql_result[10]);
            }
            mysql_result.Close();
            mysql_connection.Close();

            if (hourBox.Text != "" && hourNightBox.Text != "" && holHoursBox.Text != "") //если поля заполнены, считаем Зарплату
            {
                metroLabel6.Text = "";
                double hours = Convert.ToDouble(hourBox.Text);
                double nighthours = Convert.ToDouble(hourNightBox.Text);
                double holydayhours = Convert.ToDouble(holHoursBox.Text);
                double totalH;
                double totalNH;
                double totalClass;
                double totalHH;
                double totalNR;
                double totalHard;
                try
                {
                    mysql_query.CommandText = "SELECT * FROM workers WHERE fio = '" + metroComboBox1.Text + "';";
                    mysql_connection.Open();
                    mysql_result = mysql_query.ExecuteReader();
                    while (mysql_result.Read()) // вытаскиваем из БД данные о работнике
                    {
                        ow = Convert.ToInt32(mysql_result[5]);
                        wc = Convert.ToInt32(mysql_result[6]);
                        hw = mysql_result[7].ToString();
                    }
                    mysql_result.Close();
                    mysql_connection.Close();

                    totalH = hours * avg_for_time; //ставка
                    totalNH = nighthours * (avg_for_time + koef_night_time); //ЗП за ночное время
                    totalClass = totalH * koef_class; //За классность
                    totalHH = holydayhours * avg_for_time * koef_holidays; //ЗП за праздники
                    totalNR = totalH * koef_night_razdrob;//ЗП за ночную раздробленную смену
                    totalHard = totalH * koef_hardwork;//ЗП за длинносоставные и тяжеловесящие составы
                    totalSUM = totalH + totalNH + totalClass + totalHH + totalNR + totalHard;//Подсчёт итоговой суммы
                    if (ow >= 5)
                    { //премия за выслугу лет
                        totalSUM += totalH * prem_za_let;
                        zalet = totalH * prem_za_let;
                    }
                    if (wc >= 5)
                    { //премия за безаварийность
                        totalSUM += totalH * prem_bez_avarii;
                        bezavarii = totalH * prem_bez_avarii;
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
                catch
                {
                    metroLabel6.Text = "Произошла ошибка, проверьте правильность введённых данных и коэффециенты!";
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
                    mysql_query.CommandText = "INSERT INTO storage (fio_buh, fio_worker, brig_worker, zp_worker, date, dayHours, nightHours, holHours, prem_za_let, prem_bez_avarii, prem_za_hard, ndfl) " +
                    "VALUES ('" + fio_buh + "', '" + fio_worker + "', '" + brigada + "', " +
                    "'" + (totalSUM.ToString()).Replace(',', '.') + "', " +
                    "'" + (DateTime.Now).ToString("yyyy-MM-dd hh:mm:ss") + "', " +
                    "'" + Convert.ToInt32(hourBox.Text) + "', " +
                    "'" + Convert.ToInt32(hourNightBox.Text) + "', " +
                    "'" + Convert.ToInt32(holHoursBox.Text) + "', " +
                    "'" + (zalet.ToString().Replace(',', '.')) + "', " +
                    "'" + (bezavarii.ToString().Replace(',','.')) + "', " +
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
            MySqlConnection mysql_connection = new MySqlConnection(conn);
            MySqlCommand mysql_query = mysql_connection.CreateCommand();
            mysql_query.CommandText = "SELECT * FROM workers WHERE fio = '" + metroComboBox1.Text + "';";
            mysql_connection.Open();
            MySqlDataReader mysql_result;
            mysql_result = mysql_query.ExecuteReader();
            while (mysql_result.Read())
            {
                //берём название бригады из БД
                role = mysql_result[3].ToString();
                brigada = mysql_result[4].ToString();
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
            hourBox.Text = "";
            hourNightBox.Text = "";
            holHoursBox.Text = "";
            metroLabel6.Text = "";
            metroLabel5.Text = "Сумма: ";
            Calc.VivodRole(metroComboBox1, metroComboBox2, conn);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            dataForm go_to_data = new dataForm();
            go_to_data.Show();
        }
    }
}
