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
        double zahard;
        double ndfl;

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
                zahard = Convert.ToDouble(mysql_result[10]);
                ndfl = Convert.ToDouble(mysql_result[11]);
            }
            mysql_result.Close();
            conn.Close();

            metroLabel1.Text = "Премия за выслугу лет = "+ zalet + " рублей.";
            metroLabel3.Text = "Премия за работу на тяж. составах = " + zahard + " рублей.";
            metroLabel5.Text = "Налоговые вычеты = " + ndfl + " рублей.";

            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            chart1.Series[0].Points.Add(Convert.ToDouble(dayHours));
            chart1.Series[0].Points.Add(Convert.ToDouble(nightHours));
            chart1.Series[0].Points.Add(Convert.ToDouble(holHours));
            /* chart1.Series[0].Points[0].LegendText = "Дневные часы";
            chart1.Series[0].Points[1].LegendText = "Ночные часы";
            chart1.Series[0].Points[2].LegendText = "Праздничные часы"; */
        }
    }
}
