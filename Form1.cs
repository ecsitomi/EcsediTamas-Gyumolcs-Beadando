using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcsediTamas_Gyumolcs_Beadando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Betoltes_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string adatFile = openFileDialog.FileName;
                using (StreamReader reader = new StreamReader(adatFile))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] sor = reader.ReadLine().Split(';');
                        Gyumolcs ujGyumolcs = new Gyumolcs(int.Parse(sor[0]), sor[1], int.Parse(sor[2]));
                        listBox_Gyumolcs.Items.Add(ujGyumolcs);
                    }
                }
            }
        }

        private void button_Mentes_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (Gyumolcs item in listBox_Gyumolcs.Items)
                    {
                        writer.Write(item.toTxt() + "\n");
                    }
                    writer.Flush();
                }
            }
        }

        private void button_Uj_Click(object sender, EventArgs e)
        {
            Form2 GyumolcsForm = new Form2("insert");
            GyumolcsForm.ShowDialog();
        }

        private void button_Modosit_Click(object sender, EventArgs e)
        {
            if (listBox_Gyumolcs.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott gyümölcs!");
                return;
            }
            Gyumolcs gyumolcs = (Gyumolcs)listBox_Gyumolcs.SelectedItem;
            listBox_Gyumolcs.Items.Remove(gyumolcs);
            Form2 GyumolcsForm = new Form2("update", gyumolcs);
            GyumolcsForm.ShowDialog();
        }

        private void button_Torol_Click(object sender, EventArgs e)
        {
            if (listBox_Gyumolcs.SelectedIndex < 0)
            {
                MessageBox.Show("Nem választot ki gyümölcsöt!");
                return;
            }
            Gyumolcs gyumolcs = (Gyumolcs)listBox_Gyumolcs.SelectedItem;
            listBox_Gyumolcs.Items.Remove(gyumolcs);
        }
    }
}
