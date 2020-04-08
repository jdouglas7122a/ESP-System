using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEntryTestApp
{
    public partial class GetForm : Form
    {
        // coordinates for window moving
        int originFormX = 0;
        int originFormY = 0;
        int originMouseX = 0;
        int originMouseY = 0;
        //is window allowed to move?
        bool mouseDown;
        public string returnValue1 { get; set; }
        public GetForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.returnValue1 = DataBox.Text;
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void FormHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;

            originFormX = this.Location.X;
            originFormY = this.Location.Y;
            originMouseX = MousePosition.X;
            originMouseY = MousePosition.Y;
        }
        private void FormHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void FormHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(originFormX + (MousePosition.X - originMouseX), originFormY + (MousePosition.Y - originMouseY));
            }
        }
    }
}
