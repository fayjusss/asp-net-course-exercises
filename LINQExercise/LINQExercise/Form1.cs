using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQExercise
{
    public partial class Form1 : Form
    {
        string[] names = { "Darlena", "Gary", "Lizeth", "Eldridge",
                "Ethan", "Bethany", "Saul", "Tesha", "Caprice", "Carleen", "Stormy", "Rodger", "Willie", "Irina", "Reynalda", "Arvilla",
                "Sherri", "Kris" };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var allNames = from s in names
                                    select s.ToString();
            textBox1.Text = "";
            foreach (string name in allNames)
                textBox1.Text += name + ", ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var alphabeticallyOrdered = from s in names
                           orderby s
                           select s.ToString();
            textBox1.Text = "";
            foreach (string name in alphabeticallyOrdered)
                textBox1.Text += name + ", ";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var allNames = from s in names
                           where s.Length < 5
                           select s.ToString();
            textBox1.Text = "";
            foreach (string name in allNames)
                textBox1.Text += name + ", ";
        }
    }
}
