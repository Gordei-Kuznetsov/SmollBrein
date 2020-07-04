using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SmollBrein
{
    class Neuron
    {
        public Neuron(Form1 form1)
        {
            form1.Controls.Add(this.NeuronDot);
        }
        private bool state = false;
        private Neuron[] InputConnections;
        private Neuron[] OutputConnections;
        private readonly Color TrueNeuron = Color.Chartreuse;
        private readonly Color FalseNeuron = Color.Black;
        public PictureBox NeuronDot = new PictureBox();
        public void SetConnections(int NeuronDot_X_Position, int NeuronDot_Y_Position, Neuron[] InputConnections = null, Neuron[] OutputConnections = null)
        {
            this.InputConnections = InputConnections;
            this.OutputConnections = OutputConnections;
            NeuronDot.BackColor = FalseNeuron;
            NeuronDot.SetBounds(NeuronDot_X_Position, NeuronDot_Y_Position, 20, 20);
            NeuronDot.BorderStyle = BorderStyle.FixedSingle;
            NeuronDot.Enabled = true;
            NeuronDot.Visible = true;
        }
        public void CheckInputs()
        {
            foreach (Neuron neuron in InputConnections)
            {
                if (neuron.state)
                {
                    if (InputConnections[InputConnections.Length - 1] == neuron)
                    {
                        SetState(true);
                        NeuronDot.BackColor = TrueNeuron;
                    }
                }
                else
                {
                    SetState(false);
                    break;
                }
            }
        }
        public void SetState(bool State)
        {
            this.state = State;
            if (State)
            {
                NeuronDot.BackColor = TrueNeuron;
                foreach (Neuron neuron in OutputConnections)
                {
                    neuron.CheckInputs();
                }
            }
            else
            {
                NeuronDot.BackColor = FalseNeuron;
            }
        }
    }
}
