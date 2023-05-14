using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;


namespace Minesweeper
{
    public partial class Form1 : Form
    {
        private static System.Timers.Timer gameTimer;
        int timecount = 0;
        string level;
        //int boombClicked;
        public Form1()
        {
            InitializeComponent();
        }
        public void StartGame()
        {
            // Start the timer when the game starts
            gameTimer = new System.Timers.Timer(1000);
            gameTimer.Elapsed += OnTimedEvent;
            gameTimer.AutoReset = true;
            gameTimer.Enabled = true;   
            gameTimer.Start();
        }
        public void EndGame()
        {
            // Stop the timer when the game ends
            if (gameTimer != null)
            {
                gameTimer.Stop();
                gameTimer.Dispose();
                gameTimer = null;
            }
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            timecount++;
            // Update the UI with the new timecount value
            // (assuming you have a label named "timerLabel")
            label1.Invoke((MethodInvoker)(() =>
            {
                label1.Text = "Time: " + timecount.ToString();
            }));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //IntialGame(25, 25, 50);
            /*switch (level)
            {
                case "biggner":
                    
                    break;
                case "intermediat":
                    IntialGame(50, 25, 60);
                    boombClicked = 60;
                    break;
                case "expert":
                    IntialGame(100, 25, 70);
                    boombClicked = 70;
                    break;
                default:
                    IntialGame(25, 25, 50);
                    break;
            }*/
            if (level == "biggner")
            {
                IntialGame(25, 25, 50);
                boombClicked = 50;
            }
            else if (level == "intermediat")
            {
                IntialGame(50, 25, 60);
                boombClicked = 60;
            }
            else if (level == "expert")
            {
                IntialGame(100, 25, 70);
                boombClicked = 70;
            }
            else
            {
                IntialGame(25, 25, 50);
            }
        }
        void IntialGame(int width, int height, int boombCount)
        {
            StartGame();
            Random ra = new Random();
            List<boomb> listB = new List<boomb>();
            pGame.Width = width * 50;
            pGame.Height = height * 50;
            for (int i = 0; i < boombCount; i++)
            {
            select:
                boomb b = new boomb(ra.Next(0, width + 1), ra.Next(0, height + 1));
                //check if b is ther or no 
                if (listB.SingleOrDefault(a => a.x == b.x && a.y == b.y) != null)
                {
                    goto select;
                }
                else
                {
                    //if ther's no one go to addd at list of boomb
                    listB.Add(b);
                }
            }
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Mbutton mb = new Mbutton { x = i, y = j, Width = 50, Height = 50, Margin = new Padding(0), Font = new Font("Cairo", 12, FontStyle.Bold, GraphicsUnit.Point), BackColor = Color.Gray, Location = new Point(i * 50, j * 50), FlatStyle = FlatStyle.Flat };
                    if (listB.SingleOrDefault(a => a.x == mb.x && a.y == mb.y) != null)
                    {
                        //ther is boomb
                        mb.isBoomb = true;
                        //mb.BackColor = Color.Red;
                    }
                    pGame.Controls.Add(mb);
                    //Add event for button 
                    mb.MouseDown += Mb_MouseDown;
                }
            }
        }

        int boombClicked = 50;
        public void Mb_MouseDown(Object? sender , MouseEventArgs e)
        {
            // here we convert sender to button for help
            Mbutton mb = sender as Mbutton;
            if (mb != null)
            {
                //when user click on right button of mouse 
                if (e.Button == MouseButtons.Left)
                {
                    if (mb.isCLicked)
                    {
                        return;
                    }
                    if (mb.isBoomb)
                    {
                        MessageBox.Show("Try Again");
                    }
                    else
                    {
                        //for all seniaro button is clicked
                        mb.isCLicked = true;
                        mb.BackColor = Color.White;
                        //if ther is no boomb nearly form it 
                        if (mb.NearlyCount == 0)
                        {
                            foreach (var item in mb.Nearly)
                            {
                                if (!item.isFlaged && !item.isCLicked)
                                {

                                }
                                Mb_MouseDown(item, e);
                            }
                        }
                        else
                        {
                            // if number of boomb nearly is not equal to 0
                            mb.ForeColor = mb.NearlyCount == 1 ? Color.Blue : mb.NearlyCount == 2 ? Color.Green : mb.NearlyCount == 3 ? Color.Red : Color.Purple;
                            mb.Text = mb.NearlyCount.ToString();
                        }
                    }
                }
                else
                {
                    //when user click on Left button of mouse 
                    if (mb.isFlaged)
                    {
                        //if button flagged
                        mb.Image = null;
                        mb.isFlaged = false;
                        boombClicked++;
                    }
                    else
                    {
                        //if button  not flagged
                        mb.Image = Minesweeper.Resource1._1200px_Flag_icon_orange_4_svg;
                        mb.isFlaged = true;
                        boombClicked--;
                    }
                    if (boombClicked == 3)
                    {
                        MessageBox.Show("You Win" + timecount);
                    }
                    label2.Text = boombClicked.ToString();
                }
            }
        }
        //here we check if player is win in game 
        void CheckWinner()
        {
            //here we collacte all button that not open 
            //and if the button  not open equal to boomb button then 
            List<Mbutton> ls = new List<Mbutton>();
            foreach (var item in pGame.Controls)
            {
                ls.Add(item as Mbutton);
            }
            //How many button are Clicked
            int c = ls.Where(a=> a.isCLicked == false).Count();
            //here we check if the button not open that mean  the boomb button not open and he win 
            if (c == 50)
            {
                MessageBox.Show("You Win");
                EndGame();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void biggnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = "biggner";
        }
        private void intermediatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = "intermediat";
        }
        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = "expert";
        }
    }
    public class Mbutton : Button
    {
        //location of other button in game not spisify button 
        public int x { get; set; }
        public int y { get; set; }
        public bool isCLicked { get; set; }
        public bool isBoomb { get; set; }
        public bool isFlaged { get; set; }
        public int NearlyCount
        {
            get
            {
                // button is definded in panel and parent is panel | all Controls in panel and it button 
                List<Mbutton> ls = new List<Mbutton>();
                foreach (var item in Parent.Controls)
                {
                    ls.Add(item as Mbutton);
                }
                //How many button are rounded by this button 
                int c = ls.Where(a => (a.x == x || a.x == x + 1 || a.x == x - 1) && (a.y == y || a.y == y + 1 || a.y == y - 1)).Where(a => a.isBoomb).Count();
                //  This return numbner of boomb rounded in button              
                return c;
            }
        }
        public List<Mbutton> Nearly
        {
            get
            {
                // button is definded in panel and parent is panel | all Controls in panel and it button 
                List<Mbutton> ls = new List<Mbutton>();
                foreach (var item in Parent.Controls)
                {
                    ls.Add(item as Mbutton);
                }
                //How many button are rounded by this button 
                // ToList because Nearly with type List
                //C# LINQ expression to filter a collection of objects
                var c = ls.Where(a =>
                      (a.x == x || a.x == x + 1 || a.x == x - 1) &&
                      (a.y == y || a.y == y + 1 || a.y == y - 1))
              .ToList();
                //  This return numbner of boomb rounded in button              
                return c;
            }
        }
    }
    public class boomb
    {
        public boomb(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int x { get; set; }
        public int y { get; set; }
    }
}
//the button that ref to game button 

//we make class that take x and y of avry boomb

