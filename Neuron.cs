using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmollBrein
{
    class Neuron
    {
        private bool state = false;
        public Neuron[] InputConnections;
        public Neuron[] OutputConnections;
        public void SetConnections(Neuron[] InputConnections, Neuron[] OutputConnections)
        {
            this.InputConnections = InputConnections;
            this.OutputConnections = OutputConnections;
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
                    }
                }
                else
                {
                    break;
                }
            }
        }
        public void SetState(bool State)
        {
            this.state = State;
            if (State)
            {
                foreach (Neuron neuron in OutputConnections)
                {
                    neuron.CheckInputs();
                }
            }
        }
    }
}
