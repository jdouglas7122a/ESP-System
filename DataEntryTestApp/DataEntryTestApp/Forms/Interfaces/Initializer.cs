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
    public partial class Initializer : BaseForm
    {
        public void ShowInitializer(string type, EventInitializer _temp, Event _eventData)
        {
            System.Windows.Forms.Form newForm = new System.Windows.Forms.Form();
            windowPosition = this.Location;

            switch (type.ToLower())
            {
                case "store":
                    newForm = new StoreInitialize(_temp, _eventData);
                    break;
                case "item":
                    newForm = new ItemInitializer(_temp, _eventData);
                    break;
                case "employee":
                    newForm = new EmployeeInitializer(_temp, _eventData);
                    break;
            }
            this.Hide();
            newForm.Location = windowPosition;
            newForm.ShowDialog();
            if (!(this is EventInitializer)) // if the current open page is not an event viewer
            {
                this.Close();
            }
        }

        protected void UnhideEventInitializer(EventInitializer _temp)
        {
            if (!_temp.Visible)
            {
                windowPosition = this.Location;
                this.Hide();
                _temp.Location = windowPosition;
                _temp.Show();
                _temp.UpdatePageContents();
                this.Close();
            }
        }
    }
}
