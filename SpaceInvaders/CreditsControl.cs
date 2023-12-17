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
    public partial class CreditsControl : UserControl
    {
        public event EventHandler BackBtnClick;
        public CreditsControl()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            BackBtnClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
