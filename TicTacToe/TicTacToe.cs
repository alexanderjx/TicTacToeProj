using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        private int turnStat = 1;
        private Dictionary<String, String> aGame = new Dictionary<string, string>();
        
        public List<List<String>> gameWins = new List<List<String>>();

        public TicTacToe()
        {
            InitializeComponent();
            gameWins.Add(new List<String> { "button1", "button2", "button3" });
            gameWins.Add(new List<String> { "button1", "button4", "button7" });
            gameWins.Add(new List<String> { "button2", "button5", "button8" });
            gameWins.Add(new List<String> { "button3", "button6", "button9" });
            gameWins.Add(new List<String> { "button4", "button5", "button6" });
            gameWins.Add(new List<String> { "button7", "button8", "button9" });
            gameWins.Add(new List<String> { "button1", "button5", "button9" });
            gameWins.Add(new List<String> { "button3", "button5", "button7" });

        }

        public void TakeTurn(Button b)  //score button, register scored button to dict, compare win combos to dict entries
        {
            if (b.Text == "")
            {
                ScoreMe(b);
                RegisterMove(b);
                JudgeGame(b);
            }
        }
        
        private void JudgeGame(Button b)
        {
            foreach (List<string> i in gameWins)
            {
                if (i.Contains(b.Name))
                {
                    string lOne = i[0];
                    string lTwo = i[1];
                    string lThree = i[2];

                    if (aGame[lOne] == aGame[lTwo] && aGame[lOne] == aGame[lThree])
                    {

                    }
                }
            }
        }

        private void RegisterMove(Button b) //register scored button to dict
        {
            aGame.Add(b.Name, b.Text);
        }

        private void ScoreMe(Button b) //score button - add check against replaying space
        {
            try
            {
                switch (turnStat)
                {
                    case 1:
                        b.Text = "X";
                        turnStat = 2;
                        break;

                    case 2:
                        b.Text = "O";
                        turnStat = 1;
                        break;

                    default:
                        b.Text = "";
                        break;
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TakeTurn(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TakeTurn(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TakeTurn(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TakeTurn(button4); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TakeTurn(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TakeTurn(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TakeTurn(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TakeTurn(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TakeTurn(button9);
        }

    }
}
