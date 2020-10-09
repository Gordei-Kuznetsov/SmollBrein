using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

//This class decribes each unit of the network
//The idea is that all neurons behave in a similar way that neurons in human brain do
//There is nothing that diffirentiates them appart from how their are interconnected,
//and this coplex arrangement of the neurons is what dictates the behaviour of the network and actually allows it make desisions, makes it 'smart'
namespace SmollBrein
{
    public class Neuron
    {
        public Neuron(Form1 form1)
        {
            ParentForm = form1;                                 //reference to the main form for the neuron to be identified with
            neuronDot.BorderStyle = BorderStyle.FixedSingle;    //styling the picturebox
            neuronDot.BackColor = Color.Black;
            neuronDot.Enabled = true;
            neuronDot.Visible = true;
            ParentForm.InnerW.Controls.Add(neuronDot);
        }
        //below are all fields/properties of the class
        private bool state = false;                             //describes the condition of the neuron: true = active, false = inactive
        private Neuron[] InputConnections = null;               //array of all neurons that affect this neuron
        private Neuron[] OutputConnections = null;              //array of all neurons that are affected by this neuron
        public PictureBox neuronDot = new PictureBox();         //picturebox that will visualise the neuron's behavior on the form
        private Form1 ParentForm;                               //instance of the main form, which the entire network will work in
        private readonly Color TrueNeuron = Color.Chartreuse;   //instance of the color that represents active state of the neuron
        private readonly Color FalseNeuron = Color.Black;       //instance of the color that represents inactive state of the neuron
        
        public void SetConnections(Neuron[] InputConnections, Neuron[] OutputConnections, int neuronDot_X_Position, int neuronDot_Y_Position)
        {
            //assigns the connections of the neuron and positions the picturebox on the form
            this.InputConnections = InputConnections;
            this.OutputConnections = OutputConnections;
            neuronDot.SetBounds(neuronDot_X_Position, neuronDot_Y_Position, 38, 23);
        }
        public void CheckInputs()
        {
            //this method is called to make a neuron inspect the states of all neurons that affect it
            foreach (Neuron neuron in InputConnections)
            {
                if (!neuron.state)
                {
                    SetState(false);    //if atleast one of the neurons is inactive, this neuron turns inactive as well 
                    break;              //and the execution breaks out of the loop
                }
                if (InputConnections.Last() == neuron)
                {
                    //if the loop has iterated through every neuron in the array (which is possible only if they were all active)
                    //the neuron will activate
                    SetState(true);
                }
            }
        }
        public void SetState(bool State)
        {
            //this method is called to activate/diactivate this beuron
            state = State;
            if (!State)
            {
                neuronDot.BackColor = FalseNeuron;
            }
            else
            {
                neuronDot.BackColor = TrueNeuron;
                ParentForm.DisplayResult(this);
                //DisplayResult function of the main form is called to check if the activation of this neuron has given some results on the scale of the entire network
                //this function is what reads and shows the outcomes of the network's activity
                if (!(OutputConnections == null))                   //if this neuron has neurons that are affected by it (that is, if this neuron doesn't finish the network)
                {                                                   
                    foreach (Neuron neuron in OutputConnections)    
                    {
                        neuron.CheckInputs();                       //every neuron (that is affected by this neuron) is provoked to inspect the states of all neurons that affect it
                    }
                }
            }
        }
    }
}
