using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TambolaGameDemo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private readonly Random _random = new Random();

        // Generates a random number within a range.      
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        public Form3(String a, String b)
        {
            InitializeComponent();
            groupBox1.Text = a;
            groupBox2.Text = b;
            //Mapping buttons to List
            List<List<Button> > lst = new List<List<Button> > () 
            { new List<Button>{button1,button2,button3, button4, button5, button6, button7, button8,button9, button10 },
              new List<Button>{button11, button12, button13, button14, button15, button16, button17, button18, button19, button20 },
              new List<Button>{button21, button22, button23, button24,  button25,  button26,  button27,  button28, button29, button30 },
              new List<Button>{button31, button32, button33, button34,  button35,  button36,  button37,  button38, button39, button40 },
              new List<Button>{button41, button42, button43, button44,  button45,  button46,  button47,  button48, button49, button50 },
              new List<Button>{button51, button52, button53, button54,  button55,  button56,  button57,  button58, button59, button60 }
            };

            Dictionary<int, Button> player1 = new Dictionary<int, Button>();
            Dictionary<int, Button> player2 = new Dictionary<int, Button>();

            HashSet<int> usedNumbers = new HashSet<int>();
            
            for (int i = 0; i < 6; i++)
            {
                HashSet<int> usedButtons = new HashSet<int>();
                int count = 0;
                while (count < 5)
                {
                    int randButton = RandomNumber(0, 10);
                    if (!usedButtons.Contains(randButton))
                    {
                        int randNumber = RandomNumber(1, 100);
                        if (!usedNumbers.Contains(randNumber))
                        {
                            count++;
                            lst[i][randButton].Text = randNumber.ToString();
                            usedNumbers.Add(randNumber);
                            if (i < 3)
                                player1[randNumber] = lst[i][randButton];
                            else
                                player2[randNumber] = lst[i][randButton];
                        }
                        usedButtons.Add(randButton);
                    }
                }
            }

            //starting game from here
            startGame(player1, player2, a, b);
            
        }

        public async void startGame(Dictionary<int, Button> player1, Dictionary<int, Button> player2, String a, String b)
        {  
            MessageBox.Show("Game will start in 5 sec.");
            await Task.Delay(5000);
            int count = 0;
            int player1Count = 0, player2Count = 0;
            bool early5 = false;

            HashSet<int> numbers = new HashSet<int>();
            while(count<15)
            {
                int randNumber = RandomNumber(1, 100);
                if(!numbers.Contains(randNumber))
                {
                    label1.Text = randNumber.ToString();
                    numbers.Add(randNumber);
                    if(player1.ContainsKey(randNumber))
                    {
                        Button btn = player1[randNumber];
                        btn.BackColor = Color.DarkViolet;
                        btn.ForeColor = Color.White;
                        player1Count++;
                    }
                    else if (player2.ContainsKey(randNumber))
                    {
                        Button btn = player2[randNumber];
                        btn.BackColor = Color.DarkViolet;
                        btn.ForeColor = Color.White;
                        player2Count++;
                    }
                    if(player1Count==5 && !early5)
                    {
                        earlyFiveButton.BackColor = Color.DarkViolet;
                        MessageBox.Show(a + " claimed Early 5");
                        early5 = true;
                    }
                    else if(player2Count==5 && !early5)
                    {
                        earlyFiveButton.BackColor = Color.DarkViolet;
                        MessageBox.Show(b + " claimed Early 5");
                    }
                    await Task.Delay(500);
                }
            }
        }

        public void makeDBEntry()
        {
            string connectionString = "data source=.; database=TambolaGame ; Integrated Security=SSPI;";

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button61_Click(object sender, EventArgs e)
        {

        }

        private void button62_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.ForeColor = Color.White;
        }

        private void startButton_MouseEnter(object sender, EventArgs e)
        {
            startButton.BackColor = Color.SkyBlue;
        }

        private void startButton_MouseLeave(object sender, EventArgs e)
        {
            startButton.BackColor = Color.DeepSkyBlue;
        }
    }
}

