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
            ArrangeInputButtons(5, 5, 5);
            if (InitializeAllNeurons())
            {
                Exception exception = SetConnectionsForAll();
                if (exception != null)
                {
                    MessageBox.Show("Setting connections for the neurons had failed.\nMessage:\n" + exception.Message);
                }
            }
        }
        private InputButton[,] InputButtonsArray = new InputButton[5, 5];

        private void ArrangeInputButtons(int HorizontalNum, int VerticalNum, int Margin)
        {
            int X = 10, Y = 20;
            for (int Yindex = 0; Yindex < VerticalNum; Yindex++)
            {
                for (int Xindex = 0; Xindex < HorizontalNum; Xindex++)
                {
                    InputButton inputButton = new InputButton(X, Y);
                    InputButtonsArray[Xindex, Yindex] = inputButton;
                    SelectionGroupBox.Controls.Add(inputButton);
                    X += 30 + Margin;
                }
                X = 10;
                Y += 30 + Margin;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            SelectButton.Enabled = false;
            if (FeedInput())
            {
                foreach (InputButton inputButton in InputButtonsArray)
                {
                    inputButton.SetState(false);
                    inputButton.Enabled = true;
                }
            }
            SelectButton.Enabled = true;
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = !StartButton.Enabled;
            foreach (InputButton inputButton in InputButtonsArray)
            {
                inputButton.Enabled = !inputButton.Enabled;
            }
        }


        Neuron[] Rneuorns = new Neuron[25];
        Neuron[] V1neurons = new Neuron[30];
        Neuron[] V2neurons = new Neuron[40];
        Neuron[] ITneurons = new Neuron[10];

        private bool InitializeAllNeurons()
        {
            for(int i = 0; i < 25; i++)
            {
                Neuron Rneuron = new Neuron();
                Rneuorns[i] = Rneuron;
            }
            for (int i = 0; i < 30; i++)
            {
                Neuron V1neuron = new Neuron();
                V1neurons[i] = V1neuron;
            }
            for (int i = 0; i < 40; i++)
            {
                Neuron V2neuron = new Neuron();
                V2neurons[i] = V2neuron;
            }
            for (int i = 0; i < 10; i++)
            {
                Neuron ITneuron = new Neuron();
                ITneurons[i] = ITneuron;
            }
            return true;
        }
        private bool FeedInput()
        {
            int counter = 0;
            foreach (InputButton inputButton in InputButtonsArray)
            {
                Rneuorns[counter].SetState(inputButton.state);
                counter++;
            }
            return true;
        }

        private Exception SetConnectionsForAll()
        {
            Exception exception = null;
            try
            {
                int a = 0;
                int b = 1 / a;
            }
            catch (Exception error)
            {
                exception = error;
            }
            return exception;
        }
    }
}
