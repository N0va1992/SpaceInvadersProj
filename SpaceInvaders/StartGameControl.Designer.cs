namespace SpaceInvaders
{
    partial class StartGameControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartGameControl));
            this.playerShip = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerShip)).BeginInit();
            this.SuspendLayout();
            // 
            // playerShip
            // 
            this.playerShip.Image = ((System.Drawing.Image)(resources.GetObject("playerShip.Image")));
            this.playerShip.Location = new System.Drawing.Point(476, 512);
            this.playerShip.Name = "playerShip";
            this.playerShip.Size = new System.Drawing.Size(134, 90);
            this.playerShip.TabIndex = 0;
            this.playerShip.TabStop = false;
            // 
            // StartGameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.playerShip);
            this.Name = "StartGameControl";
            this.Size = new System.Drawing.Size(1119, 744);
            ((System.ComponentModel.ISupportInitialize)(this.playerShip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playerShip;
    }
}
