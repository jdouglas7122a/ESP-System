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
    public partial class Form : BaseForm
    {
        public EventViewer parentReference;
        public Event storedEvent;

        public Form(EventViewer _temp, Event _eventData)
        {
            parentReference = _temp;
            storedEvent = _eventData;
            InitializeComponent();
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

        private void StoreViewerButton_Click(object sender, EventArgs e)
        {
            ShowViewer("store", parentReference, storedEvent);
        }

        private void ItemViewerButton_Click(object sender, EventArgs e)
        {
            ShowViewer("item", parentReference, storedEvent);
        }

        private void ManagerViewerButton_Click(object sender, EventArgs e)
        {
            ShowViewer("manager", parentReference, storedEvent);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            UnhideEventViewer(parentReference);
        }
    }
}
