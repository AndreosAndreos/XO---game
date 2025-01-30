using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {
        public class Kolkokrzyzyk
        {

        }
        public Form1()
        {
            InitializeComponent();
            niewidocznosc();
        }

        public void niewidocznosc()
        {
            button11.Visible = false; button21.Visible = false; button31.Visible = false; button12.Visible = false; button22.Visible = false; button32.Visible = false; button13.Visible = false; button23.Visible = false; button33.Visible = false;
            buttonRozpocznij.Visible = false;
        }

        public void widocznoscPlanszy()
        {
            button11.Visible = true; button21.Visible = true; button31.Visible = true; button12.Visible = true; button22.Visible = true; button32.Visible = true; button13.Visible = true; button23.Visible = true; button33.Visible = true;
        }

        private void comboBoxKtoGra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxKtoGra.SelectedIndex == 0)
            {
                buttonRozpocznij.Text = "Rozpocznij grę z komputerem";
                buttonRozpocznij.Visible = true;
            }
            else if (comboBoxKtoGra.SelectedIndex == 1)
            {
                buttonRozpocznij.Text = "Rozpocznij grę z kolegą";
                buttonRozpocznij.Visible = true;
            }
        }

        private void buttonRozpocznij_Click(object sender, EventArgs e)
        {
            widocznoscPlanszy();
            if(buttonRozpocznij.Text == "Rozpocznij grę z komputerem")
            {
                
            }
            else
            {

            }
        }
    }
}
