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
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnWorkers = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(83, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 72);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ostali gumbi nisu funcionalni jer se ne \r\nobrađuju u funkcionalnom zahtjevu.\r\nZa " +
    "nastavak pritisnite gumb Radnici.\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalendar
            // 
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCalendar.Location = new System.Drawing.Point(96, 145);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(145, 78);
            this.btnCalendar.TabIndex = 6;
            this.btnCalendar.Text = "Kalendar";
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnClients
            // 
            this.btnClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClients.Location = new System.Drawing.Point(250, 59);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(145, 78);
            this.btnClients.TabIndex = 7;
            this.btnClients.Text = "Klijenti";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnWorkers
            // 
            this.btnWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWorkers.Location = new System.Drawing.Point(96, 59);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Size = new System.Drawing.Size(145, 78);
            this.btnWorkers.TabIndex = 8;
            this.btnWorkers.Text = "Radnici";
            this.btnWorkers.UseVisualStyleBackColor = true;
            this.btnWorkers.Click += new System.EventHandler(this.btnWorkers_Click);
            // 
            // btnServices
            // 
            this.btnServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnServices.Location = new System.Drawing.Point(250, 145);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(145, 78);
            this.btnServices.TabIndex = 9;
            this.btnServices.Text = "Usluge";
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // FrmChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(507, 366);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnWorkers);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnCalendar);
            this.Controls.Add(this.label3);
            this.Name = "FrmChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izbornik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnWorkers;
        private System.Windows.Forms.Button btnServices;
    }
}