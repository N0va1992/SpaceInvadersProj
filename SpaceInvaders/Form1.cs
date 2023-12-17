using System;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {
        private MenuControl menuControl;
        private CreditsControl creditsControl;

        public Form1()
        {
            InitializeComponent();
            ShowMainMenu();

            menuControl.CreditsBtnClick += MenuControl_CreditsBtnClick;
        }

        //obsługa przycisków
        private void MenuControl_CreditsBtnClick(object sender, EventArgs e)
        {
            ShowCreditsControl();
        }

        private void CreditsControl_BackBtnClick(object sender, EventArgs e)
        {
            ShowMainMenu();
        }
        
        private void ShowMainMenu()
        {
            menuControl = new MenuControl();
            menuControl.Dock = DockStyle.Fill;

            Controls.Clear();

            Controls.Add(menuControl);

            menuControl.CreditsBtnClick += MenuControl_CreditsBtnClick;
        }

        private void ShowCreditsControl()
        {
            creditsControl = new CreditsControl();
            creditsControl.Dock = DockStyle.Fill;

            Controls.Clear();

            Controls.Add(creditsControl);

            creditsControl.BackBtnClick += CreditsControl_BackBtnClick;
        }
    }
}
