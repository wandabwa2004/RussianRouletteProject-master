using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRouletteProject
{
    public partial class Form2 : Form
    {
        Trig myTrig = new Trig();
        Form myForm = new Form1();
        Form myForm2 = new Form3();

        public Form2()
        {
            InitializeComponent();
        }

        public void menuBtnSanta_Click(object sender, EventArgs e)
        {
            myForm.Show();
        }

        public void menuBtnBatman_Click(object sender, EventArgs e)
        {
            myForm2.Show();
        }
    }
}
