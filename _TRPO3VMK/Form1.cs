using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _TRPO3VMK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Series.Clear();
            chart2.Series.Clear();
            dataGridView2.Columns.Add("_BolFIO", "ФИО");
            dataGridView2.Columns.Add("_BolPol", "Пол");
            dataGridView2.Columns.Add("_BolPolis", "Номер полиса");
            dataGridView2.Columns.Add("_BolDate", "Дата рождения");
            dataGridView2.Columns.Add("_BolDiag", "Диагноз");
            dataGridView2.Columns.Add("_BolFrom", "Откуда");
            dataGridView2.Columns.Add("_BolVrach", "Врач");
            dataGridView2.Columns.Add("_BolSpec", "Специализация");
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
                    for (int i = 0; i < Database.From.Count; i++)
                    {
                        dataGridView1.Rows.Add(
                            Database.From[i]);
                    }
                    break;
                case 3:
                    dataGridView1.Columns.Add("_Sex", "Пол");
                    for (int i = 0; i < Database.Sex.Count; i++)
                    {
                        dataGridView1.Rows.Add(
                            Database.Sex[i]);
                    }
                    break;
                case 4:
                    dataGridView1.Columns.Add("_Diag", "Диагноз");
                    for (int i = 0; i < Database.Diag.Count; i++)
                    {
                        dataGridView1.Rows.Add(
                            Database.Diag[i]);
                    }
                    break;
                case 5:
                    dataGridView1.Columns.Add("_Reason", "Причина");
                    for (int i = 0; i < Database.Reason.Count; i++)
                    {
                        dataGridView1.Rows.Add(
                            Database.Reason[i]);
                    }
                    break;
                case 6:
                    dataGridView1.Columns.Add("_Spec", "Специализация");
                    for (int i = 0; i < Database.VSpecializeList.Count; i++)
                    {
                        dataGridView1.Rows.Add(
                            Database.VSpecializeList[i]);
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
                    Database.VSpecialize.Add(comboBoxDirSpec.SelectedItem.ToString());
                    break;
                case 2:
                    Database.From.Add(textBoxFromAdd.Text);
                    break;
                case 3:
                    Database.Sex.Add(textBoxDirSex.Text);
                    break;
                case 4:
                    Database.Diag.Add(textBoxDirDiag.Text);
                    break;
                case 5:
                    Database.Reason.Add(textBoxDirReason.Text);
                    break;
                case 6:
                    Database.VSpecializeList.Add(textBoxDirSpecAdd.Text);
                    break;
            }
            TablSpravUpdate(tabControlAddDir.SelectedIndex);
            ComboUpdates();
        }

        private void tabControlAddDir_SelectedIndexChanged(object sender, EventArgs e)
        {
            TablSpravUpdate(tabControlAddDir.SelectedIndex);
        }

        // Работа с главбазой

        void ComboUpdates()
        {
            comboBoxFrom.Items.Clear();
            comboBoxVrach.Items.Clear();
            comboBoxBolnitsa.Items.Clear();
            comboBoxSex.Items.Clear();
            comboBoxDiag.Items.Clear();
            comboBoxReason.Items.Clear();
            comboBoxDirSpec.Items.Clear();
            foreach(string i in Database.From)
            {
                comboBoxFrom.Items.Add(i);
            }
            foreach (string i in Database.VFIO)
            {
                comboBoxVrach.Items.Add(i);
            }
            foreach(string i in Database.BName)
            {
                comboBoxBolnitsa.Items.Add(i);
            }
            foreach (string i in Database.Sex)
            {
                comboBoxSex.Items.Add(i);
            }
            foreach (string i in Database.Diag)
            {
                comboBoxDiag.Items.Add(i);
            }
            foreach (string i in Database.Reason)
            {
                comboBoxReason.Items.Add(i);
            }
            foreach (string i in Database.VSpecializeList)
            {
                comboBoxDirSpec.Items.Add(i);
            }
        }

        List<string> Prichini()
        {
            List<string> Temp = new List<string>();
            foreach (string i in Database.PrichinaVipiski)
            {
                if (!Temp.Contains(i))
                {
                    Temp.Add(i);
                }
            }
            return Temp;
        }

        int[] FindMajorityReasons()
        {
            int[] PrichAmount = new int[Prichini().Count];
            for (int i = 0; i < Prichini().Count; i++)
            {
                foreach (string j in Database.PrichinaVipiski)
                {
                    if (j == Prichini()[i])
                    {
                        PrichAmount[i]++;
                    }
                }
            }
            return PrichAmount;
        }

        void Grafik2Update()
        {
            chart2.Series.Clear();
            chart2.Series.Add(new Series("Data2")
            {
                ChartType = SeriesChartType.Pie
            });
            chart2.Series["Data2"].Points.DataBindXY(Prichini(), FindMajorityReasons());
        }

        void Grafik1Update()
        {
            string[] Names = new string[2] { "Поступившие", "Выписанные" };
            chart1.Series.Clear();
            int[] Values = new int[2] { 0, 0 };
            foreach(bool i in OnPlace)
            {
                if(i)
                {
                    Values[1]++;
                } 
                else
                {
                    Values[0]++;
                }
            }
            chart1.Series.Add(new Series("Data1") 
            {
                ChartType = SeriesChartType.Pie
            });
            chart1.Series["Data1"].Points.DataBindXY(Names, Values);
        }

        List<bool> OnPlace = new List<bool>();

        private void buttonAddMain_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(
                textBoxMainFio.Text,
                comboBoxSex.SelectedItem.ToString(),
                textBoxMainPolis.Text,
                dateTimePickerMainBirth.Value.ToString(),
                comboBoxDiag.SelectedItem.ToString(),
                comboBoxFrom.SelectedItem.ToString(),
                comboBoxVrach.SelectedItem.ToString(),
                Database.VSpecialize[comboBoxVrach.SelectedIndex],
                dateTimePickerReg.Value.ToString(),
                comboBoxBolnitsa.SelectedItem.ToString(),
                checkBoxKicked.Checked ? dateTimePickerExpDate.Value.ToString() : "На месте",
                checkBoxKicked.Checked ? comboBoxReason.SelectedItem.ToString() : "На месте");
            OnPlace.Add(checkBoxKicked.Checked);
            if (checkBoxKicked.Checked)
            {
                Database.PrichinaVipiski.Add(comboBoxReason.SelectedItem.ToString());
            }
            Grafik1Update();
            Grafik2Update();
        }
    }
}
