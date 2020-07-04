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

//huh, so for small changes, you can make them in VS code, and push them to master quickly
//but for larger changes, and the ability to modify the actual form, clone it and use visual studio

//okay so fun fact, github desktop can have local copies of master, which can be "pushed to origin" 
//which ACTUALLY pushes it to the project

namespace SmollBrein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttons = new Button[25] { ret1, ret2, ret3, ret4, ret5, ret6, ret7, ret8, ret9, ret10, ret11, ret12, ret13, ret14, ret15, ret16, ret17, ret18, ret19, ret20, ret21, ret22, ret23, ret24, ret25, };
        }
        public Button[] buttons;
        public bool[] mainArray = new bool[25];
        private readonly Color TrueButton = Color.Black;
        private readonly Color FalseButton = Color.Chartreuse;

        private void StartButton_Click(object sender, EventArgs e)
        {
            //disables selection area
            //Starts the proccess
            //feeds the input into the first layer of Neurons
            //when proccess finishes, displays enables the selection area
        }

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
