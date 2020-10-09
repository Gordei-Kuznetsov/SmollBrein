using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

//This class describes the buttons that are used to draw numbers on the input area on the main form
namespace SmollBrein
{
    public class InputButton: Button
    {
        public InputButton(int xPosition, int yPosition)    //constructor has two parameters for the x and y coordinates
        {
            Location = new Point(xPosition, yPosition);     //positions the button
            BackColor = FalseButton;                        //styling the button
            Size = new Size(30, 30);                        //styling the button
            Click += InputButton_Click;
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            BackColor = (state = !state) ? TrueButton : FalseButton;    //when clicked the button switches between two colors (black/green) and two states(active/inactive)
        }

        public void SetState(bool State)
        {
            BackColor = (state = State) ? TrueButton : FalseButton;     //this method is the same as above but is used to manually set the state for the button
        }
        
        //fields/properties of the class
        public bool state = false;                                  //describes the condition of the button: active/inactive
        private readonly Color TrueButton = Color.Black;            //instance of the color that represents active state of the button
        private readonly Color FalseButton = Color.Chartreuse;      //instance of the color that represents inactive state of the button
    }
}
