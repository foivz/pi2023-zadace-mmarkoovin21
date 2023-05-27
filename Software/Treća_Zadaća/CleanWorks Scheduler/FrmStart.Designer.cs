namespace CleanWorks_Scheduler
{
    partial class FrmStart
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStart));
            this.btnAdmin = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnWorker = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblWelcome = new MaterialSkin.Controls.MaterialLabel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.AutoSize = true;
            this.btnAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdmin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAdmin.Depth = 0;
            this.btnAdmin.Icon = null;
            this.btnAdmin.Location = new System.Drawing.Point(116, 207);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Primary = false;
            this.btnAdmin.Size = new System.Drawing.Size(157, 36);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Administrator";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnWorker
            // 
            this.btnWorker.AutoSize = true;
            this.btnWorker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWorker.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnWorker.Depth = 0;
            this.btnWorker.Icon = null;
            this.btnWorker.Location = new System.Drawing.Point(368, 207);
            this.btnWorker.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWorker.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWorker.Name = "btnWorker";
            this.btnWorker.Primary = false;
            this.btnWorker.Size = new System.Drawing.Size(83, 36);
            this.btnWorker.TabIndex = 1;
            this.btnWorker.Text = "Radnik";
            this.btnWorker.UseVisualStyleBackColor = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Depth = 0;
            this.lblWelcome.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWelcome.Location = new System.Drawing.Point(101, 83);
            this.lblWelcome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(399, 72);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Dobrodošli u program CleanWorks  Scheduler!\r\n\r\nPrijavite se:";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(112, 277);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(377, 72);
            this.lblWarning.TabIndex = 4;
            this.lblWarning.Text = "Funkcija za radnike ne radi jer nije u sklopu \r\nzahtjeva koji se obrađuje!\r\nZa na" +
    "stavak pritisnite gumb administrator.";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(588, 409);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnWorker);
            this.Controls.Add(this.btnAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dobrodošli!";
            this.Load += new System.EventHandler(this.FrmStart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnAdmin;
        private MaterialSkin.Controls.MaterialFlatButton btnWorker;
        private MaterialSkin.Controls.MaterialLabel lblWelcome;
        private System.Windows.Forms.Label lblWarning;
    }
}