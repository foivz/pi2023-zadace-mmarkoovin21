namespace CleanWorks_Scheduler
{
    partial class FrmChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChoice));
            this.btnWorkers = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClients = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCalendar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnServices = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWorkers
            // 
            this.btnWorkers.AutoSize = true;
            this.btnWorkers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWorkers.Depth = 0;
            this.btnWorkers.Icon = ((System.Drawing.Image)(resources.GetObject("btnWorkers.Icon")));
            this.btnWorkers.Location = new System.Drawing.Point(67, 72);
            this.btnWorkers.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Primary = true;
            this.btnWorkers.Size = new System.Drawing.Size(116, 36);
            this.btnWorkers.TabIndex = 0;
            this.btnWorkers.Text = "Radnici";
            this.btnWorkers.UseVisualStyleBackColor = true;
            this.btnWorkers.Click += new System.EventHandler(this.btnWorkers_Click);
            // 
            // btnClients
            // 
            this.btnClients.AutoSize = true;
            this.btnClients.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClients.Depth = 0;
            this.btnClients.Icon = ((System.Drawing.Image)(resources.GetObject("btnClients.Icon")));
            this.btnClients.Location = new System.Drawing.Point(249, 72);
            this.btnClients.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClients.Name = "btnClients";
            this.btnClients.Primary = true;
            this.btnClients.Size = new System.Drawing.Size(122, 36);
            this.btnClients.TabIndex = 1;
            this.btnClients.Text = "Klijenti";
            this.btnClients.UseVisualStyleBackColor = true;
            // 
            // btnCalendar
            // 
            this.btnCalendar.AutoSize = true;
            this.btnCalendar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalendar.Depth = 0;
            this.btnCalendar.Icon = ((System.Drawing.Image)(resources.GetObject("btnCalendar.Icon")));
            this.btnCalendar.Location = new System.Drawing.Point(67, 141);
            this.btnCalendar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Primary = true;
            this.btnCalendar.Size = new System.Drawing.Size(137, 36);
            this.btnCalendar.TabIndex = 2;
            this.btnCalendar.Text = "Raspored";
            this.btnCalendar.UseVisualStyleBackColor = true;
            // 
            // btnServices
            // 
            this.btnServices.AutoSize = true;
            this.btnServices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnServices.Depth = 0;
            this.btnServices.Icon = ((System.Drawing.Image)(resources.GetObject("btnServices.Icon")));
            this.btnServices.Location = new System.Drawing.Point(249, 141);
            this.btnServices.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnServices.Name = "btnServices";
            this.btnServices.Primary = true;
            this.btnServices.Size = new System.Drawing.Size(113, 36);
            this.btnServices.TabIndex = 3;
            this.btnServices.Text = "Usluge";
            this.btnServices.UseVisualStyleBackColor = true;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.Color.White;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(32, 216);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(375, 72);
            this.lblWarning.TabIndex = 5;
            this.lblWarning.Text = "Ostale funkcije nisu implementirane u ovom\r\nfunkcionalnom zahtjevu!\r\nPritisnite g" +
    "umb Radnici za nastavak.\r\n";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(436, 347);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnCalendar);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnWorkers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izbornik";
            this.Load += new System.EventHandler(this.FrmChoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnWorkers;
        private MaterialSkin.Controls.MaterialRaisedButton btnClients;
        private MaterialSkin.Controls.MaterialRaisedButton btnCalendar;
        private MaterialSkin.Controls.MaterialRaisedButton btnServices;
        private System.Windows.Forms.Label lblWarning;
    }
}