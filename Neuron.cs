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
        private bool state = false;
        private Neuron[] InputConnections = null;
        private Neuron[] OutputConnections = null;
        private readonly Color TrueNeuron = Color.Chartreuse;
        private readonly Color FalseNeuron = Color.Black;
        public PictureBox NeuronDot = new PictureBox();
        public void SetConnections(Neuron[] InputConnections, Neuron[] OutputConnections, int NeuronDot_X_Position, int NeuronDot_Y_Position, Form1 form1)
        {
            this.InputConnections = InputConnections;
            this.OutputConnections = OutputConnections;
            NeuronDot.SetBounds(NeuronDot_X_Position, NeuronDot_Y_Position, 20, 20);
            NeuronDot.BackColor = FalseNeuron;
            NeuronDot.BorderStyle = BorderStyle.FixedSingle;
            NeuronDot.Enabled = true;
            NeuronDot.Visible = true;
            form1.Controls.Add(this.NeuronDot);
        }
        public void CheckInputs()
        {
            foreach (Neuron neuron in InputConnections)
            {
                if (!neuron.state)
                {
                    SetState(false);
                    break;
                }
                if (InputConnections.Last() == neuron)
                {
                    SetState(true);
                }
            }
        }
        public void SetState(bool State)
        {
            state = State;
            if (!State)
            {
                NeuronDot.BackColor = FalseNeuron;
            }
            else
            {
                NeuronDot.BackColor = TrueNeuron;
                if (!(OutputConnections == null))
                {
                    foreach (Neuron neuron in OutputConnections)
                    {
                        neuron.CheckInputs();
                    }
                }
            }
        }
    }
}
