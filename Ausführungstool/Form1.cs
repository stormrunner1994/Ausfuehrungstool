using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hardware_;

namespace Ausführungstool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hw = new Hardware(richTextBoxausgabe, button1, 100000, this, null, richTextBoxeingabe, false);
        }

        Hardware hw;


        private void Form1_Load(object sender, EventArgs e)
        {
            hw.ReagiereAufKey();
          }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Aufzeichnen starten")
            {
                hw.AufzeichnungStarten(InputModus.KeyUndMaus);
                button2.Text = "Aufzeichnen stoppen";            
                }
            else
            {
                hw.AufzeichnungStopp(InputModus.KeyUndMaus);
                button2.Text = "Aufzeichnen starten";
                hw.showAufzeichnung(richTextBoxausgabe);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Abspielen")
            {
                hw.Starten(textBox1.Text);
                button3.Text = "Stoppen";
            }
            else
            {
                hw.Stoppen();
                button3.Text = "Abspielen";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hw.loadAufzeichnung("log.txt");
            hw.showAufzeichnung(richTextBoxausgabe);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hw.SetAufzeichnung(richTextBoxausgabe.Text.Split('\n').ToList());
        }
    }
}
