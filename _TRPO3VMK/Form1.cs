using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _TRPO3VMK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView2.Columns.Add("_BolFIO", "ФИО");
            dataGridView2.Columns.Add("_BolPol", "Пол");
            dataGridView2.Columns.Add("_BolPolis", "Номер полиса");
            dataGridView2.Columns.Add("_BolDate", "Дата рождения");
            dataGridView2.Columns.Add("_BolDiag", "Диагноз");
            dataGridView2.Columns.Add("_BolFrom", "Откуда нахуй");
            dataGridView2.Columns.Add("_BolDateReg", "Дата регистрации");
            dataGridView2.Columns.Add("_BolBolnitsa", "Больница");
            dataGridView2.Columns.Add("_BolDataVip", "Дата выписки");
            dataGridView2.Columns.Add("_BolPrich", "Причина выписки");
        }

        // Работа со справочником

        void TablSpravUpdate(int Index)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            switch(Index)
            {
                case 0:
                    dataGridView1.Columns.Add("_BName", "Название больницы");
                    dataGridView1.Columns.Add("_BPhone", "Телефон");
                    dataGridView1.Columns.Add("_BPalataNum", "Номер палаты");
                    for(int i = 0; i < Database.BName.Count; i++)
                    {
                        dataGridView1.Rows.Add(
                            Database.BName[i],
                            Database.BPhone[i],
                            Database.BPalataNum[i]);
                    }
                    break;
                case 1:
                    dataGridView1.Columns.Add("_VFIO", "ФИО");
                    dataGridView1.Columns.Add("_VSpecialize", "Специализация");
                    for (int i = 0; i < Database.VFIO.Count; i++)
                    {
                        dataGridView1.Rows.Add(
                            Database.VFIO[i],
                            Database.VSpecialize[i]);
                    }
                    break;
                case 2:
                    dataGridView1.Columns.Add("_From", "Откуда");
                    dataGridView1.Columns.Add("_VSpecialize", "Специализация");
                    for (int i = 0; i < Database.From.Count; i++)
                    {
                        dataGridView1.Rows.Add(
                            Database.From[i]);
                    }
                    break;
            }
        }

        private void buttonAddDir_Click(object sender, EventArgs e)
        {
            switch(tabControlAddDir.SelectedIndex)
            {
                case 0:
                    Database.BName.Add(textBoxBNameAdd.Text);
                    Database.BPhone.Add(textBoxBPhoneAdd.Text);
                    Database.BPalataNum.Add(textBoxBPalNumAdd.Text);
                    break;
                case 1:
                    Database.VFIO.Add(textBoxVFIO.Text);
                    Database.VSpecialize.Add(textBoxVSpecialize.Text);
                    break;
                case 2:
                    Database.From.Add(textBoxFromAdd.Text);
                    break;
            }
            TablSpravUpdate(tabControlAddDir.SelectedIndex);
        }

        private void tabControlAddDir_SelectedIndexChanged(object sender, EventArgs e)
        {
            TablSpravUpdate(tabControlAddDir.SelectedIndex);
        }

        // Работа с главбазой

        void ComboUpdates()
        {

        }

    }
}
