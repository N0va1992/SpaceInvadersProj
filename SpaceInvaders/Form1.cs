using System;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {
        private PlayerShip playerShip;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            playerShip = new PlayerShip(this); // Przekazujemy referencję do formularza
            KeyPreview = true;
            KeyDown += Form1_KeyDown; // Obsługa zdarzenia naciśnięcia klawisza
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Obsługa ruchu statku gracza na podstawie naciśniętego klawisza
            switch (e.KeyCode)
            {
                case Keys.Left:
                    playerShip.MoveLeft();
                    break;
                case Keys.Right:
                    playerShip.MoveRight();
                    break;
                case Keys.Up:
                    playerShip.MoveUp();
                    break;
                case Keys.Down:
                    playerShip.MoveDown();
                    break;
            }
        }
    }
}
