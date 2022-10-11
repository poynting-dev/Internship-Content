using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TambolaGameDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hostButton1_MouseCaptureChanged(object sender, EventArgs e)
        {
            hostbutton1.ForeColor = Color.Black;
            hostbutton1.BackColor = Color.Violet;
            joinbutton1.ForeColor = Color.Black;
            joinbutton1.BackColor = Color.Violet;
        }

        private readonly Random _random = new Random();

        // Generates a random number within a range.      
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        private void hostbutton1_Click(object sender, EventArgs e)
        {
            hostbutton1.ForeColor = Color.Red;
            hostbutton1.BackColor = Color.AliceBlue;

            //Genrating Random numbers
            
        }

        private void hostbutton1_MouseLeave(object sender, EventArgs e)
        {
            hostbutton1.ForeColor = Color.Red;
            hostbutton1.BackColor = Color.AliceBlue;
        }

        private void hostbutton1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void hostbutton1_MouseHover(object sender, EventArgs e)
        {

        }

        private void hostbutton1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void joinButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
