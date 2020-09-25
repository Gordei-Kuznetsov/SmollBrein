using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SmollBrein
{
    public class Neuron
    {
        public Neuron(Form1 form1)
        {
            ParentForm = form1;
            neuronDot.BorderStyle = BorderStyle.FixedSingle;
            neuronDot.BackColor = Color.Black;
            neuronDot.Enabled = true;
            neuronDot.Visible = true;
            ParentForm.InnerW.Controls.Add(neuronDot);
        }
        private bool state = false;
        private Neuron[] InputConnections = null;
        private Neuron[] OutputConnections = null;
        public PictureBox neuronDot = new PictureBox();
        private Form1 ParentForm;
        private readonly Color TrueNeuron = Color.Chartreuse;
        private readonly Color FalseNeuron = Color.Black;
        public void SetConnections(Neuron[] InputConnections, Neuron[] OutputConnections, int neuronDot_X_Position, int neuronDot_Y_Position)
        {
            this.InputConnections = InputConnections;
            this.OutputConnections = OutputConnections;
            neuronDot.SetBounds(neuronDot_X_Position, neuronDot_Y_Position, 38, 23);
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
                neuronDot.BackColor = FalseNeuron;
            }
            else
            {
                neuronDot.BackColor = TrueNeuron;
                ParentForm.DisplayResult(this);
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
