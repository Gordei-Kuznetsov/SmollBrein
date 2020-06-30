using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//this was an edit i did from Visual studio code via github desktop, i just wanna see if it directly modifies the code or makes
//another branch

namespace SmollBrein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttons = new Button[25] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, };
        }
        public Button[] buttons;
        public bool[] mainArray = new bool[25];
        private Color TrueButton = Color.Black;
        private Color FalseButton = Color.Chartreuse;

        private void SelectionButton_Click(object sender, EventArgs e)
        {
            //taking and cleaning input
            //!note that the order of the buttons are reversed after the first row, this is due to copy/pasting issues, 
            //however it will be compensated for in the cleanup stage

            //taking the first row
            
        }
        private void AnyButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = Array.IndexOf(buttons, button);
            if (!mainArray[index])
            {
                mainArray[index] = true;
                button.BackColor = TrueButton;
            }
            else
            {
                mainArray[index] = false;
                button.BackColor = FalseButton;
            }
        }
    }
}
