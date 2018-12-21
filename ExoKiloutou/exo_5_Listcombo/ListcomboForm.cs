using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exo_5_Listcombo
{
    public partial class ListcomboForm : Form
    {
        public ListcomboForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxList.Items.Add("France");
            comboBoxList.Items.Add("Finlande");
            comboBoxList.Items.Add("Fidji");
            comboBoxList.Items.Add("Belgique");
            comboBoxList.Items.Add("Allemagne");
            comboBoxList.Items.Add("Japon");
            comboBoxList.Items.Add("Portugal");
            comboBoxList.Items.Add("Grece");
        }

        private void comboBoxList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                ajoutCombo();
            }
        }

        public void ajoutCombo()
        {
            if (comboBoxList.Text.Length > 0 && comboBoxList.FindStringExact(comboBoxList.Text) == -1 && listBox1.FindStringExact(comboBoxList.Text) == -1)
            {
                comboBoxList.Items.Add(comboBoxList.Text);
                comboBoxList.Text = "";
            }
        }

        private void buttonAddSimple_Click(object sender, EventArgs e)
        {
            ajoutCombo();
            Deplacement_Combo();
            comboBoxList.AutoCompleteSource = AutoCompleteSource.None;
            comboBoxList.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Deplacement_Combo()
        {
            if (comboBoxList.Text.Length > 0)
            {
                if (listBox1.FindStringExact(comboBoxList.Text) == -1)// && comboBoxList.FindStringExact(comboBoxList.Text)==-1)
                {
                    listBox1.Items.Add(comboBoxList.Text);
                    comboBoxList.Items.Remove(comboBoxList.Text);
                    comboBoxList.Text = "";
                }
                else
                {
                    comboBoxList.Items.Remove(comboBoxList.Text);
                }
            }

        }

        private void Deplacement_List()
        {
            if (listBox1.SelectedIndex != -1)
            {
                comboBoxList.Items.Add(listBox1.Text);
                listBox1.Items.Remove(listBox1.Text);
            }
        }

        private void buttonRemoveSimple_Click(object sender, EventArgs e)
        {
            Deplacement_List();
            comboBoxList.Text = "";
        }

        private void buttonAddAll_Click(object sender, EventArgs e)
        {
            foreach (var item in comboBoxList.Items)
            {
                listBox1.Items.Add(item);
            }
            comboBoxList.Items.Clear();
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                comboBoxList.Items.Add(item);
            }
            listBox1.Items.Clear();
        }

        private void buttonTop_Click(object sender, EventArgs e)
        {
            MoveList(-1);
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            MoveList(1);
        }

        private void MoveList(int direction)
        {
            object select = listBox1.SelectedItem;
            int indexnew = listBox1.SelectedIndex + direction;
            if (listBox1.SelectedIndex != -1 && indexnew >= 0 && indexnew < listBox1.Items.Count)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.Items.Insert(indexnew, select);
                listBox1.SetSelected(indexnew,true);
            }

        }


    }

}
