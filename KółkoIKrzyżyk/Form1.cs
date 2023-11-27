using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KółkoIKrzyżyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ladowanie()
        {
            progressBar.Visible = true;
            for (int i = 0; i < 100; i++)
            {
                progressBar.Value += 1;
                Thread.Sleep(1);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ladowanie();
            progressBar.Visible = false;
            Form2 form2 = new Form2();
            form2.Show();
            progressBar.Value = 0;
            
        }
    }
}
