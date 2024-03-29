using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = string.Empty;
                Dictionary<char, int> characterCounts = text.Text
                    .GroupBy(c => c)
                    .ToDictionary(grp => grp.Key, grp => grp.Count());


                int count = text.Text.Length - text.Text.Distinct().Count();
                label1.Text += $"Кількість однакових елементів : {count}\n";
                foreach (var pair in characterCounts)
                {
                    label1.Text += $"{pair.Key}: {pair.Value}\n";
                }
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
            
        }
    }
}
