using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace oef1
{
    public partial class Form1 : Form
    {
        string[] words = new string[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i != words.Length; i++) 
            {
                words[i] = Interaction.InputBox("give 5 words", "5 words");
                
            }
            for(int j =0; j!= words.Length;j++)
            {
                txtwords.Text += words[j] +Environment.NewLine;
            }
        }

        private void Txtwords_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnsort_Click(object sender, EventArgs e)
        {
            txtwords.Text = "";

            Array.Sort(words);
            for (int k = 0; k != words.Length; k++)
            {
                txtwords.Text += words[k] + Environment.NewLine;
            }
            
        }

        private void Btnsort2_Click(object sender, EventArgs e)
        {
            txtwords.Text = "";
            for (int i = 0; i <= 3; i++)
            {
                string hulp;
                for (int j = i + 1; j <= 4; j++)
                {
                    if (words[i].CompareTo(words[j]) > 0)
                    {
                        hulp = words[i];
                        words[i] = words[j];
                        words[j] = hulp;
                    }
                }
            }
            for (int k = 0; k != words.Length; k++)
            {
                txtwords.Text += words[k] + Environment.NewLine;
            }
        }
    }
}
