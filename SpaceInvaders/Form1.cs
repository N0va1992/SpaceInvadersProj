using System;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {
        private PictureBox playerShip;
        private MenuControl menuControl;
        private StartGameControl startGameControl;
        private CreditsControl creditsControl;
        private int step = 10;

        public Form1()
        {
            InitializeComponent();
            ShowMainMenu();

            menuControl.StartBtnClick += MenuControl_StartGameBtnClick;
            menuControl.CreditsBtnClick += MenuControl_CreditsBtnClick;
            this.KeyDown += new KeyEventHandler(MainForm_KeyDown);
        }

        //obsługa przycisków
        private void MenuControl_CreditsBtnClick(object sender, EventArgs e)
        {
            ShowCreditsControl();
        }

        private void MenuControl_StartGameBtnClick(object sender, EventArgs e)
        {
            ShowStartGameControl();
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

        private void ShowStartGameControl()
        {
            startGameControl = new StartGameControl();
            startGameControl.Dock = DockStyle.Fill;

            Controls.Clear();
            Controls.Add(startGameControl);
        }

        private void ShowCreditsControl()
        {
            creditsControl = new CreditsControl();
            creditsControl.Dock = DockStyle.Fill;

            Controls.Clear();
            Controls.Add(creditsControl);

            creditsControl.BackBtnClick += CreditsControl_BackBtnClick;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Przesuń obrazek w zależności od kierunku strzałki
            switch (e.KeyCode)
            {
                case Keys.Up:
                    playerShip.Top -= step;
                    break;
                case Keys.Down:
                    playerShip.Top += step;
                    break;
                case Keys.Left:
                    playerShip.Left -= step;
                    break;
                case Keys.Right:
                    playerShip.Left += step;
                    break;
            }
        }
    }
}
