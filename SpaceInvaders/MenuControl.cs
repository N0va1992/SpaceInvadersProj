using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class MenuControl : UserControl
    {
        public event EventHandler CreditsBtnClick;
        public MenuControl()
        {
            InitializeComponent();
        }

        private void creditsBtn_Click(object sender, EventArgs e)
        {
            CreditsBtnClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
