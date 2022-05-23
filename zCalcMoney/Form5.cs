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
using System.Windows.Forms.DataVisualization.Charting;

namespace zCalcMoney
{
    public partial class InfoForm : MetroFramework.Forms.MetroForm
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        static string connStr = "server = chuc.caseum.ru; port = 33333; user = st_2_18_23; database = is_2_18_st23_VKR; password = 51922291;";
        MySqlConnection conn = new MySqlConnection(connStr);
        int dayHours;
        int nightHours;
        int holHours;
        double zalet;
        double bezavarii;
        double zahard;

        private void Form5_Load(object sender, EventArgs e)
        {
            MySqlCommand mysql_query = conn.CreateCommand();
            mysql_query.CommandText = "SELECT * FROM storage WHERE id = '" + Worker.selected_worker + "';";
            conn.Open();
            MySqlDataReader mysql_result;
            mysql_result = mysql_query.ExecuteReader();
            while (mysql_result.Read()) // вытаскиваем из БД нынешние коэффициенты
            {
                dayHours = Convert.ToInt32(mysql_result[6]);
                nightHours = Convert.ToInt32(mysql_result[7]);
                holHours = Convert.ToInt32(mysql_result[8]);
                zalet = Convert.ToDouble(mysql_result[9]);
                bezavarii = Convert.ToDouble(mysql_result[10]);
                zahard = Convert.ToDouble(mysql_result[11]);
            }
            mysql_result.Close();
            conn.Close();

            metroLabel1.Text = "Премия за выслугу лет = "+ zalet + " рублей.";
            metroLabel2.Text = "Премия за безаварийность = " + bezavarii + " рублей.";
            metroLabel3.Text = "Премия за работу на тяж. и длин.составах = " + zahard + " рублей.";

            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            chart1.Series[0].Points.AddY(Convert.ToDouble(dayHours.ToString()));
            chart1.Series[0].Points.AddY(Convert.ToDouble(nightHours.ToString()));
            chart1.Series[0].Points.AddY(Convert.ToDouble(holHours.ToString()));
            chart1.Series[0].Points[0].LegendText = "Дневные часы";
            chart1.Series[0].Points[1].LegendText = "Ночные часы";
            chart1.Series[0].Points[2].LegendText = "Праздничные часы";

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        } //Закрыть
    }
}
