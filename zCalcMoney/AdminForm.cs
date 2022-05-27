using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zCalcMoney
{
    public partial class AdminForm : MetroFramework.Forms.MetroForm
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void buhButton_Click(object sender, EventArgs e)
        {
            dataForm data = new dataForm();
            data.Owner = this;
            data.ShowDialog();
        } // переход к окну бухгалтера

        private void brigButton_Click(object sender, EventArgs e)
        {
            MainForm brig = new MainForm();
            brig.Owner = this;
            brig.ShowDialog();
        } // переход к онку бригадира

        private void kadrButton_Click(object sender, EventArgs e)
        {
            kadrForm kadr = new kadrForm();
            kadr.Owner = this;
            kadr.ShowDialog();
        } // переход к окну кадров
    }
}
