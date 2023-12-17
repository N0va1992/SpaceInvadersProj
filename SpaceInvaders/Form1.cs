using System;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {
        private MenuControl menuControl;

        public Form1()
        {
            InitializeComponent();
            ShowMainMenu();
        }
        
        private void ShowMainMenu()
        {
            menuControl = new MenuControl();
            menuControl.Dock = DockStyle.Fill;

            Controls.Clear();

            Controls.Add(menuControl);
        }
    }
}
