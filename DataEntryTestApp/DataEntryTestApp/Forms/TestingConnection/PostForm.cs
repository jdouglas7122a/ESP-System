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
    public partial class PostForm : System.Windows.Forms.Form
    {
        // coordinates for window moving
        int originFormX = 0;
        int originFormY = 0;
        int originMouseX = 0;
        int originMouseY = 0;
        //is window allowed to move?
        bool mouseDown;
        public string returnValue1 { get; set; }
        public string returnValue2 { get; set; }
        public string returnValue3 { get; set; }
        public PostForm()
        {
            InitializeComponent();
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
             DialogResult = DialogResult.Cancel;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.returnValue1 = TableName.Text;
            this.returnValue2 = TableColumn.Text;
            this.returnValue3 = DataBox.Text;
            DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
