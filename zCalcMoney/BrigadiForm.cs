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
    public partial class brigadiForm : MetroFramework.Forms.MetroForm
    {
        public brigadiForm()
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
            //Запрос для формирования списка расчётов
            commandString = "SELECT " +
            "brigadi.id, " + //0
            "brigadi.name AS 'Название' " + //1
            "FROM brigadi;";

            //MessageBox.Show(commandString);

            metroGrid1.DataSource = bs_list_tasks;
            ShowData.GetList(commandString, connStr, bs_list_tasks, dt_list_tasks);
            //Автоматически увеличивать размер строк по содержимому
            metroGrid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            metroGrid1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //Видимость полей в гриде
            metroGrid1.Columns[0].Visible = false;
            metroGrid1.Columns[1].Visible = true;
            //Ширина полей
            metroGrid1.Columns[0].FillWeight = 10;
            metroGrid1.Columns[1].FillWeight = 110;
            //Режим для полей "Только для чтения"
            metroGrid1.Columns[0].ReadOnly = true;
            metroGrid1.Columns[1].ReadOnly = true;
            //Растягивание полей грида
            metroGrid1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            metroGrid1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Убираем заголовки строк
            metroGrid1.RowHeadersVisible = false;
            conn.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Вызываем форму добавления
            AddBrigadaForm addBrigadaForm = new AddBrigadaForm();
            addBrigadaForm.Owner = this;
            addBrigadaForm.ShowDialog(this);
            //Вызов метода обновления ДатаГрида            
            dbRemove();
        } // добавить бригаду

        private void updateButton_Click(object sender, EventArgs e)
        {
            //Индекс выбранной строки
            index_selected_rows = metroGrid1.SelectedCells[0].RowIndex.ToString();
            //ID задачи
            id_selected_rows = metroGrid1.Rows[Convert.ToInt32(index_selected_rows)].Cells[0].Value.ToString();
            //Заносим ID в переменную статичного класса
            EditBrigada.id = Convert.ToInt32(id_selected_rows);

            //Вызываем форму
            EditBrigadaForm editBrigadaForm = new EditBrigadaForm();
            editBrigadaForm.Owner = this;
            editBrigadaForm.ShowDialog(this);

            //Вызов метода обновления ДатаГрида            
            dbRemove();
            //Изменение текущей фокусной ячейки
            metroGrid1.CurrentCell = metroGrid1.Rows[Convert.ToInt32(index_selected_rows)].Cells[1];
        } // изменить название бригады

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Индекс выбранной строки
            index_selected_rows = metroGrid1.SelectedCells[0].RowIndex.ToString();

            //ID записи
            id_selected_rows = metroGrid1.Rows[Convert.ToInt32(index_selected_rows)].Cells[0].Value.ToString();

            //вызов метода удаления задачи с передачей параметра ID задачи
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить бригаду: " + metroGrid1.Rows[Convert.ToInt32(index_selected_rows)].Cells[1].Value.ToString(),
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
        } // удалить бригаду

        private void dbRemove()
        {
            dt_list_tasks.Clear();
            ShowData.GetList(commandString, connStr, bs_list_tasks, dt_list_tasks);
            list_tasks_adapter.Update((DataTable)bs_list_tasks.DataSource);
            metroGrid1.Update();
        } // Обновление

        public void delete_task(int id)
        {
            string sql_worker_delete = "DELETE FROM brigadi WHERE id = " + id;
            MySqlCommand del_worker = new MySqlCommand(sql_worker_delete, conn);
            try
            {
                conn.Open();
                del_worker.ExecuteNonQuery();
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
        } // метод удаления записей
    }
}
