using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SmollBrein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArrangeInputButtons(3, 5, 5);   //arranges the inputbuttons in a grid of 3 by 5 with a margin of 5px
            InitializeAllNeurons();         //intializes all neurons of the network
            SetConnectionsForAll();         //sets the input and output connections for the neurons
        }
        private InputButton[,] InputButtonsArray = new InputButton[3, 5];   //two-dimentional array containing all inputbuttons

        private void ArrangeInputButtons(int HorizontalNum, int VerticalNum, int Margin) //arranges the inputbuttons in a grid with specified width, height, and margin
        {
            int X = 40, Y = 20;                                         //initial positions (top-left corner)
            for (int Yindex = 0; Yindex < VerticalNum; Yindex++)        //the loop iterates through every row of buttons
            {
                for (int Xindex = 0; Xindex < HorizontalNum; Xindex++)  //the nested loop iterates through every column within a row of buttons
                {
                    InputButton inputButton = new InputButton(X, Y);    //initializes new button
                    InputButtonsArray[Xindex, Yindex] = inputButton;    //assignes it to the appropriate index in the array
                    SelectionGroupBox.Controls.Add(inputButton);        //adds it to the groupbox on the main form
                    X += 30 + Margin;                                   //increments the x coordinate for the next button in the row
                }
                X = 40;                                                 //resets the initial x coordinate for the next row
                Y += 30 + Margin;                                       //increments the y coordinate for the next column
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            SelectButton.Enabled = false;                   //diavles the selectbutton
            ResultButton.Text = "";                         //cleares the result area
            //diactivates all neurons in the network
            foreach (Neuron neuron in Rneurons)
            {
                neuron.SetState(false);
            }
            foreach (Neuron neuron in V1neurons)
            {
                neuron.SetState(false);
            }
            foreach (Neuron neuron in V2neurons)
            {
                neuron.SetState(false);
            }
            foreach (Neuron neuron in V3neurons)
            {
                neuron.SetState(false);
            }
            foreach (Neuron neuron in ITneurons)
            {
                neuron.SetState(false);
            }
            if (FeedInput())                        //feeds the values from the input into the first layer of the network
            {
                foreach (InputButton inputButton in InputButtonsArray)
                {
                    inputButton.SetState(false);    //diactivates the button
                    inputButton.Enabled = true;     //enables the button
                }
            }
            SelectButton.Enabled = true;
            StartButton.Enabled = false;
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = !StartButton.Enabled;             //switches between enabled/disabled
            foreach (InputButton inputButton in InputButtonsArray)
            {
                inputButton.Enabled = !inputButton.Enabled;         //enables/diasbles the inputbuttons
            }
        }

        Neuron[] Rneurons = new Neuron[16];                 //all neurons in the retina layer
        Neuron[] V1neurons = new Neuron[10];                //all neurons in the V1 layer
        Neuron[] V2neurons = new Neuron[11];                //all neurons in the V2 layer
        Neuron[] V3neurons = new Neuron[11];                //all neurons in the V3 layer
        Neuron[] ITneurons = new Neuron[10];                //all neurons in the IT layer

        private void InitializeAllNeurons()                 //intializes all neurons of the network
        {
            for(int i = 0; i < 16; i++)
            {
                Neuron Rneuron = new Neuron(this);
                Rneurons[i] = Rneuron;
            }
            for (int i = 0; i < 10; i++)
            {
                Neuron V1neuron = new Neuron(this);
                V1neurons[i] = V1neuron;
            }
            for (int i = 0; i < 11; i++)
            {
                Neuron V2neuron = new Neuron(this);
                V2neurons[i] = V2neuron;
            }
            for (int i = 0; i < 11; i++)
            {
                Neuron V3neuron = new Neuron(this);
                V3neurons[i] = V3neuron;
            }
            for (int i = 0; i < 10; i++)
            {
                Neuron ITneuron = new Neuron(this);
                ITneurons[i] = ITneuron;
            }
        }
        public void DisplayResult(Neuron neuron)            //reads and displays the outcomes of the network's activity
        {
            int index = Array.IndexOf(ITneurons, neuron);   //get the index of the passed neuron in the IT array
            if (index != -1)                                //if it was in the array, that is the neuron is an IT neuron
            {
                ResultButton.Text = index.ToString();       //displays the index of the neuron in the array (the index represents the number which the neurons checks for)
            }
        }
        private bool FeedInput()                            //feeds the values from the input into the first layer of the network
        {
            int counter = 1;
            for (int Yindex = 0; Yindex < 5; Yindex++)      //iterates through the two-dimentional array of the inputbuttons
            {
                for (int Xindex = 0; Xindex < 3; Xindex++)
                {
                    Rneurons[counter].SetState(InputButtonsArray[Xindex, Yindex].state);    //gets the state of the button and assings it to the state of the corresponding neuron
                    counter++;
                }
            }
            return true;
        }
        private void SetConnectionsForAll()
        {
            //sets the input and output connections for the neurons
            
            //Rneurons
            Rneurons[1].SetConnections(null, new Neuron[] { V1neurons[1], V1neurons[2] }, 14, 600);
            Rneurons[2].SetConnections(null, new Neuron[] { V1neurons[1], V1neurons[3] }, 56, 600);
            Rneurons[3].SetConnections(null, new Neuron[] { V1neurons[1], V1neurons[4] }, 98, 600);

            Rneurons[4].SetConnections(null, new Neuron[] { V1neurons[2] }, 161, 600);
            Rneurons[5].SetConnections(null, new Neuron[] { V1neurons[3] }, 203, 600);
            Rneurons[6].SetConnections(null, new Neuron[] { V1neurons[4] }, 245, 600);

            Rneurons[7].SetConnections(null, new Neuron[] { V1neurons[5], V1neurons[2], V1neurons[6] }, 309, 600);
            Rneurons[8].SetConnections(null, new Neuron[] { V1neurons[5], V1neurons[3], V1neurons[7] }, 351, 600);
            Rneurons[9].SetConnections(null, new Neuron[] { V1neurons[5], V1neurons[4], V1neurons[8] }, 393, 600);

            Rneurons[10].SetConnections(null, new Neuron[] { V1neurons[6] }, 455, 600);
            Rneurons[11].SetConnections(null, new Neuron[] { V1neurons[7] }, 497, 600);
            Rneurons[12].SetConnections(null, new Neuron[] { V1neurons[8] }, 539, 600);

            Rneurons[13].SetConnections(null, new Neuron[] { V1neurons[9], V1neurons[6] }, 602, 600);
            Rneurons[14].SetConnections(null, new Neuron[] { V1neurons[9], V1neurons[7] }, 644, 600);
            Rneurons[15].SetConnections(null, new Neuron[] { V1neurons[9], V1neurons[8] }, 686, 600);


            //V1neurons
            V1neurons[1].SetConnections(new Neuron[] { Rneurons[1], Rneurons[2], Rneurons[3] }, new Neuron[] { V2neurons[1], V2neurons[2] }, 56, 501);

            V1neurons[2].SetConnections(new Neuron[] { Rneurons[1], Rneurons[4], Rneurons[7] }, new Neuron[] { V2neurons[1], V2neurons[3], V2neurons[9] }, 161, 501);
            V1neurons[3].SetConnections(new Neuron[] { Rneurons[2], Rneurons[5], Rneurons[8] }, new Neuron[] { V2neurons[9] }, 203, 501);
            V1neurons[4].SetConnections(new Neuron[] { Rneurons[3], Rneurons[6], Rneurons[9] }, new Neuron[] { V2neurons[2], V2neurons[4], V2neurons[10] }, 245, 501);
            
            V1neurons[5].SetConnections(new Neuron[] { Rneurons[7], Rneurons[8], Rneurons[9] }, new Neuron[] { V2neurons[3], V2neurons[4], V2neurons[5], V2neurons[6] }, 351, 501);
            
            V1neurons[6].SetConnections(new Neuron[] { Rneurons[7], Rneurons[10], Rneurons[13] }, new Neuron[] { V2neurons[5], V2neurons[7], V2neurons[9] }, 456, 501);
            V1neurons[7].SetConnections(new Neuron[] { Rneurons[8], Rneurons[11], Rneurons[14] }, new Neuron[] { V2neurons[9] }, 498, 501);
            V1neurons[8].SetConnections(new Neuron[] { Rneurons[9], Rneurons[12], Rneurons[15] }, new Neuron[] { V2neurons[6], V2neurons[8], V2neurons[10] }, 540, 501);
            
            V1neurons[9].SetConnections(new Neuron[] { Rneurons[13], Rneurons[14], Rneurons[15] }, new Neuron[] { V2neurons[7], V2neurons[8] }, 644, 501);


            //V2neurons
            V2neurons[1].SetConnections(new Neuron[] { V1neurons[1], V1neurons[2] }, new Neuron[] { V3neurons[1], V3neurons[3] }, 50, 398);
            V2neurons[2].SetConnections(new Neuron[] { V1neurons[1], V1neurons[4] }, new Neuron[] { V3neurons[1], V3neurons[2], V3neurons[5] }, 133, 398);           
            
            V2neurons[3].SetConnections(new Neuron[] { V1neurons[2], V1neurons[5] }, new Neuron[] { V3neurons[3], V3neurons[4] }, 217, 398);
            V2neurons[4].SetConnections(new Neuron[] { V1neurons[4], V1neurons[5] }, new Neuron[] { V3neurons[2], V3neurons[4] }, 301, 398);
            
            V2neurons[5].SetConnections(new Neuron[] { V1neurons[5], V1neurons[6] }, new Neuron[] { V3neurons[10] }, 407, 398);
            V2neurons[6].SetConnections(new Neuron[] { V1neurons[5], V1neurons[8] }, new Neuron[] { V3neurons[9] }, 491, 398);
            
            V2neurons[7].SetConnections(new Neuron[] { V1neurons[6], V1neurons[9] }, new Neuron[] { V3neurons[8], V3neurons[10] }, 575, 398);
            V2neurons[8].SetConnections(new Neuron[] { V1neurons[8], V1neurons[9] }, new Neuron[] { V3neurons[8], V3neurons[9] }, 658, 398);
            
            V2neurons[9].SetConnections(new Neuron[] { V1neurons[3], V1neurons[7] }, new Neuron[] { V3neurons[6] }, 353, 326);
            V2neurons[10].SetConnections(new Neuron[] { V1neurons[4], V1neurons[8] }, new Neuron[] { V3neurons[5], V3neurons[7] }, 395, 326);


            //V3neurons
            V3neurons[1].SetConnections(new Neuron[] { V2neurons[1], V2neurons[2] }, new Neuron[] { ITneurons[0] }, 106, 257);
            V3neurons[2].SetConnections(new Neuron[] { V2neurons[2], V2neurons[4] }, new Neuron[] { ITneurons[2] }, 161, 257);
            
            V3neurons[3].SetConnections(new Neuron[] { V2neurons[1], V2neurons[3] }, new Neuron[] { ITneurons[5] }, 216, 257);
            V3neurons[4].SetConnections(new Neuron[] { V2neurons[3], V2neurons[4] }, new Neuron[] { ITneurons[4] }, 271, 257);
            
            V3neurons[5].SetConnections(new Neuron[] { V2neurons[2], V2neurons[10] }, new Neuron[] { ITneurons[7] }, 325, 257);
            V3neurons[6].SetConnections(new Neuron[] { V2neurons[9] }, new Neuron[] { ITneurons[1] }, 380, 257);
            
            V3neurons[7].SetConnections(new Neuron[] { V2neurons[10] }, new Neuron[] { ITneurons[4] }, 434, 257);
            V3neurons[8].SetConnections(new Neuron[] { V2neurons[7], V2neurons[8] }, new Neuron[] { ITneurons[0] }, 488, 257);
            
            V3neurons[9].SetConnections(new Neuron[] { V2neurons[6], V2neurons[8] }, new Neuron[] { ITneurons[3], ITneurons[5] }, 541, 257);
            V3neurons[10].SetConnections(new Neuron[] { V2neurons[5], V2neurons[7] }, new Neuron[] { ITneurons[2], ITneurons[6] }, 595, 257);


            //ITneurons
            ITneurons[0].SetConnections(new Neuron[] { V3neurons[1], V3neurons[8], ITneurons[7] }, null, 209, 95);
            ITneurons[1].SetConnections(new Neuron[] { V3neurons[6] }, null, 405, 167);
            ITneurons[2].SetConnections(new Neuron[] { V3neurons[2], V3neurons[10] }, null, 289, 167);

            ITneurons[3].SetConnections(new Neuron[] { V3neurons[9], ITneurons[7] }, null, 288, 95);
            ITneurons[4].SetConnections(new Neuron[] { V3neurons[4], V3neurons[7] }, new Neuron[] { ITneurons[9] }, 347, 167);
            ITneurons[5].SetConnections(new Neuron[] { V3neurons[3], V3neurons[9] }, new Neuron[] { ITneurons[6], ITneurons[9] }, 462, 167);

            ITneurons[6].SetConnections(new Neuron[] { V3neurons[10], ITneurons[5] }, new Neuron[] { ITneurons[8] }, 472, 95);
            ITneurons[7].SetConnections(new Neuron[] { V3neurons[5] }, new Neuron[] { ITneurons[0], ITneurons[3], ITneurons[9] }, 231, 167);
            ITneurons[8].SetConnections(new Neuron[] { ITneurons[6], ITneurons[9] }, null, 421, 21);
            ITneurons[9].SetConnections(new Neuron[] { ITneurons[4], ITneurons[5], ITneurons[7] }, new Neuron[] { ITneurons[8] }, 367, 95);

            {
                //Other
                Rneurons[0].SetConnections(null, null, -40, -25);
                V1neurons[0].SetConnections(null, null, -40, -25);
                V2neurons[0].SetConnections(null, null, -40, -25);
                V3neurons[0].SetConnections(null, null, -40, -25);
            }
        }
    }
}
