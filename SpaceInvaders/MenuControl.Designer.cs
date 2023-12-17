namespace SpaceInvaders
{
    partial class MenuControl
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.creditsBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Bauhaus 93", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(382, 619);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(315, 83);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // creditsBtn
            // 
            this.creditsBtn.Font = new System.Drawing.Font("Bauhaus 93", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsBtn.Location = new System.Drawing.Point(382, 501);
            this.creditsBtn.Name = "creditsBtn";
            this.creditsBtn.Size = new System.Drawing.Size(315, 83);
            this.creditsBtn.TabIndex = 6;
            this.creditsBtn.Text = "Credits";
            this.creditsBtn.UseVisualStyleBackColor = true;
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Bauhaus 93", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(382, 385);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(315, 83);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "Start game";
            this.startBtn.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Bauhaus 93", 75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(89, 143);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(898, 141);
            this.title.TabIndex = 4;
            this.title.Text = "Space Invaders";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.creditsBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.title);
            this.Name = "MenuControl";
            this.Size = new System.Drawing.Size(1080, 920);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button creditsBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label title;
    }
}
