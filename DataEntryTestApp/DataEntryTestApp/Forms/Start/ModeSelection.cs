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
    public partial class ModeSelection : BaseForm
    {
       
        List<Event> events = new List<Event>(){new NoNetworkEvent().tempEvent};  // loads an example into application
        public ModeSelection()
        {
            InitializeComponent();
            DisplayEventNames();
        }

        private void FormHeader_MouseDown(object sender, MouseEventArgs e)
        {
            HeaderMouseDownAction();
        }

        private void FormHeader_MouseUp(object sender, MouseEventArgs e)
        {
            HeaderMouseUpAction();
        }

        private void FormHeader_MouseMove(object sender, MouseEventArgs e)
        {
            HeaderMouseMoveAction();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            MinimizeAction();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitAction();
        }

        //hides current window and opens event viewer
        private void SelectButton_Click(object sender, EventArgs e)
        {
            if(EventsListBox.SelectedIndex != -1) // checks that item is selected
            {
                this.Hide();
                using (var eventViewer = new EventViewer(events[EventsListBox.SelectedIndex]))
                {
                    switch (eventViewer.ShowDialog())
                    {
                        case DialogResult.OK:
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
                this.Show();
            }
            else
            {
                ErrorLabel.Text = "No Target Selected";
            }
        }

        //hides current window and opens event creation tool
        private void NewButton_Click(object sender, EventArgs e)
        {
            if(EventNameTextBox.TextLength != 0)
            {
                this.Hide();
                using (var eventViewer = new EventInitializer())
                {
                    switch (eventViewer.ShowDialog())
                    {
                        case DialogResult.OK:
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
                this.Show();
            }
            else
            {
                ErrorLabel.Text = "ERROR: No event name given.";
            }
        }

        //adds all event names to list
        private void DisplayEventNames()
        {
            foreach(Event foo in events)
            {
                EventsListBox.Items.Add(foo.eventName);
            }
        }
    }
}
