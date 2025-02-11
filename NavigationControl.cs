using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial
{
    public class NavigationControl
    {
        private List<UserControl> userControls; // Declare a list of UserControls
        private Panel panel; // Declare a Panel

        // Constructor to initialize the class with a list of UserControls and a Panel
        public NavigationControl(List<UserControl> userControls, Panel panel)
        {
            this.userControls = userControls;
            this.panel = panel;
            AddUserControls(); // Automatically add UserControls to the panel
        }

        // Method to add UserControls to the Panel
        private void AddUserControls()
        {
            for (int i = 0; i < userControls.Count; i++)
            {
                // Set each UserControl's Dock style to fill the Panel
                userControls[i].Dock = DockStyle.Fill;

                // Add the UserControl to the Panel
                panel.Controls.Add(userControls[i]);
            }
        }

        // Method to display a specific UserControl by index
        public void Display(int index)
        {
            if (index < userControls.Count)
            {
                // Bring the specified UserControl to the front
                userControls[index].BringToFront();
            }
        }
    }
}

