using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zxc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Меня зовут {textBox1.Text} " + $"Мне {textBox2.Text} лет " + $"Когда мне будет {Convert.ToInt32(textBox2.Text) + 10} я буду успешным программистом");
        }
    }
}
