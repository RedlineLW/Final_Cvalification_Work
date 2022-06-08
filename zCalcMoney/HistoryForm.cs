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
    public partial class HistoryForm : MetroFramework.Forms.MetroForm
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        static string connStr = "server = chuc.caseum.ru; port = 33333; user = st_2_18_23; database = is_2_18_st23_VKR; password = 51922291;";
        MySqlConnection conn = new MySqlConnection(connStr);
        DataTable dt_list_tasks = new DataTable();
        BindingSource bs_list_tasks = new BindingSource();
        MySqlDataAdapter list_tasks_adapter = new MySqlDataAdapter();
        string commandString = "";
        string id_selected_rows = "";
        string index_selected_rows = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            //"INSERT INTO history (buh, date, role, stavka, koef_night, koef_class, koef_holiday, koef_razdrob, koef_hard) VALUES "
            //Запрос для формирования списка расчётов
            commandString = "SELECT " +
            "history.id, " + //0
            "history.buh AS 'Бухгалтер', " + //1
            "history.date AS 'Дата изменения', " + //2
            "history.role AS 'Должность', " + //3
            "history.stavka AS 'Ставка', " + //4
            "history.koef_night AS 'коэф. ноч. времени'," + // 5
            "history.koef_class AS 'коэф. классности'," + // 6
            "history.koef_holiday AS 'коэф. выходных дней'," + // 7
            "history.koef_razdrob AS 'коэф. раздробленной смены'," + // 8
            "history.koef_hard AS 'размер премии за работу на тяж. поездах'," + // 9
            "history.koef_ndfl AS 'размер НДФЛ'" + // 10
            "FROM history;";

            metroGrid1.DataSource = bs_list_tasks;
            ShowData.GetList(commandString, connStr, bs_list_tasks, dt_list_tasks);
            //Автоматически увеличивать размер строк по содержимому
            metroGrid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            metroGrid1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //Видимость полей в гриде
            metroGrid1.Columns[0].Visible = false;
            metroGrid1.Columns[1].Visible = true;
            metroGrid1.Columns[2].Visible = true;
            metroGrid1.Columns[3].Visible = true;
            metroGrid1.Columns[4].Visible = true;
            metroGrid1.Columns[5].Visible = true;
            metroGrid1.Columns[6].Visible = true;
            metroGrid1.Columns[7].Visible = true;
            metroGrid1.Columns[8].Visible = true;
            metroGrid1.Columns[9].Visible = true;
            metroGrid1.Columns[10].Visible = true;
            //Ширина полей
            metroGrid1.Columns[0].FillWeight = 10;
            metroGrid1.Columns[1].FillWeight = 90;
            metroGrid1.Columns[2].FillWeight = 90;
            metroGrid1.Columns[3].FillWeight = 100;
            metroGrid1.Columns[4].FillWeight = 100;
            metroGrid1.Columns[5].FillWeight = 100;
            metroGrid1.Columns[6].FillWeight = 100;
            metroGrid1.Columns[7].FillWeight = 100;
            metroGrid1.Columns[8].FillWeight = 100;
            metroGrid1.Columns[9].FillWeight = 100;
            metroGrid1.Columns[10].FillWeight = 100;
            //Режим для полей "Только для чтения"
            metroGrid1.Columns[0].ReadOnly = true;
            metroGrid1.Columns[1].ReadOnly = true;
            metroGrid1.Columns[2].ReadOnly = true;
            metroGrid1.Columns[3].ReadOnly = true;
            metroGrid1.Columns[4].ReadOnly = true;
            metroGrid1.Columns[5].ReadOnly = true;
            metroGrid1.Columns[6].ReadOnly = true;
            metroGrid1.Columns[7].ReadOnly = true;
            metroGrid1.Columns[8].ReadOnly = true;
            metroGrid1.Columns[9].ReadOnly = true;
            metroGrid1.Columns[10].ReadOnly = true;
            //Растягивание полей грида
            metroGrid1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            metroGrid1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            metroGrid1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            metroGrid1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            metroGrid1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            metroGrid1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            metroGrid1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            metroGrid1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            metroGrid1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            metroGrid1.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            metroGrid1.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Убираем заголовки строк
            metroGrid1.RowHeadersVisible = false;
            dbRemove();
            conn.Close();
        }

        private void dbRemove()
        {
            dt_list_tasks.Clear();
            ShowData.GetList(commandString, connStr, bs_list_tasks, dt_list_tasks);
            list_tasks_adapter.Update((DataTable)bs_list_tasks.DataSource);
            metroGrid1.Update();
        } // Обновление

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Индекс выбранной строки
            index_selected_rows = metroGrid1.SelectedCells[0].RowIndex.ToString();

            //ID записи
            id_selected_rows = metroGrid1.Rows[Convert.ToInt32(index_selected_rows)].Cells[0].Value.ToString();

            //вызов метода удаления задачи с передачей параметра ID задачи
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить запись от " + metroGrid1.Rows[Convert.ToInt32(index_selected_rows)].Cells[2].Value.ToString(),
        "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                delete_task(Convert.ToInt32(id_selected_rows));
                //Вызов метода обновления ДатаГрида            
                this.Refresh();
            }
        } //удалить запись

        public void delete_task(int id)
        {
            string sql_delete = "DELETE FROM history WHERE id = " + id;
            MySqlCommand delete = new MySqlCommand(sql_delete, conn);
            try
            {
                conn.Open();
                delete.ExecuteNonQuery();
                //MessageBox.Show("Удаление прошло успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbRemove();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        } // Удаление записей
    }
}
