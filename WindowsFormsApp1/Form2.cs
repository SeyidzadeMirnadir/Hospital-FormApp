using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private Dictionary<string, string> Hekimler = new Dictionary<string, string>();
        private List<string> Shobeler = new List<string>();
        public Form2()
        {

            InitializeComponent();
            comboBox2.Text = "Shobeler";
            comboBox1.Text = "Hekimler";
            Shobeler.Add("Shobe 1");
            Shobeler.Add("Shobe 2");
            Shobeler.Add("Shobe 3");
            Shobeler.Add("Shobe 4");

            UpdateCombo();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var item in this.Hekimler)
            {
                if (item.Value == (string)comboBox2.SelectedItem)
                {
                    comboBox1.Items.Add(item.Key);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shobeler.RemoveAt(comboBox2.SelectedIndex);
            comboBox2.Items.RemoveAt(comboBox2.SelectedIndex);
            comboBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shobeler.Add(textBox1.Text);
            UpdateCombo();
            textBox1.Text = "";
            label4.Visible = true;
        }

        private void UpdateCombo()
        {
            comboBox2.Items.Clear();
            foreach (var item in Shobeler)
            {
                comboBox2.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tebib = textBox2.Text;
            string shobe = (string)comboBox2.SelectedItem;
            Hekimler.Add(tebib, shobe);
            comboBox1.Items.Clear();
            foreach (var item in this.Hekimler)
            {
              comboBox1.Items.Add(item.Key);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string hekim = textBox2.Text;

            comboBox1.Items.Clear();
            foreach (var item in this.Hekimler)
            {
                comboBox1.Items.Add(item.Key);
            }
        }
    }
}
