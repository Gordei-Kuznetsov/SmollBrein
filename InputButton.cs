using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SmollBrein
{
    public class InputButton: Button
    {
        public InputButton(int xPosition, int yPosition)
        {
            Location = new Point(xPosition, yPosition);
            BackColor = FalseButton;
            Size = new Size(30, 30);
            Click += InputButton_Click;
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            BackColor = (state = !state) ? TrueButton : FalseButton;
        }

        public void SetState(bool State)
        {
            BackColor = (state = State) ? TrueButton : FalseButton;
        }

        public bool state = false;
        private readonly Color TrueButton = Color.Black;
        private readonly Color FalseButton = Color.Chartreuse;
    }
}
