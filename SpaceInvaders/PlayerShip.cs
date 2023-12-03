using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public class PlayerShip
    {
        private const int StepSize = 5;
        private PictureBox playerShipPictureBox;

        public PlayerShip(Form parentForm)
        {
            InitializePlayerShip(parentForm);
        }

        private void InitializePlayerShip(Form parentForm)
        {
            // Inicjalizacja PictureBox dla statku gracza
            playerShipPictureBox = new PictureBox();
            playerShipPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            playerShipPictureBox.Location = new Point(100, 100);
            parentForm.Controls.Add(playerShipPictureBox); // Dodaj PictureBox do formularza
        }

        public void MoveLeft()
        {
            MoveShip(-StepSize, 0);
        }
        public void MoveRight()
        {
            MoveShip(StepSize, 0);
        }
        public void MoveUp()
        {
            MoveShip(0, -StepSize);
        }
        public void MoveDown()
        {
            MoveShip(0, StepSize);
        }
        private void MoveShip(int deltaX, int deltaY)
        {
            // Aktualizacja pozycji statku na PictureBox
            playerShipPictureBox.Left += deltaX;
            playerShipPictureBox.Top += deltaY;
        }
    }
}
