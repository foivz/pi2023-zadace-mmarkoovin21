namespace CleanWorks_Scheduler
{
    partial class FrmEditWorker
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
            this.btnSaveWorker = new System.Windows.Forms.Button();
            this.btnPasswordGenerator = new System.Windows.Forms.Button();
            this.txtPasswordGenerator = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblPasswordGenerator = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblOIB = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveWorker
            // 
            this.btnSaveWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveWorker.Location = new System.Drawing.Point(652, 396);
            this.btnSaveWorker.Name = "btnSaveWorker";
            this.btnSaveWorker.Size = new System.Drawing.Size(112, 42);
            this.btnSaveWorker.TabIndex = 37;
            this.btnSaveWorker.Text = "Spremi";
            this.btnSaveWorker.UseVisualStyleBackColor = true;
            this.btnSaveWorker.Click += new System.EventHandler(this.btnSaveWorker_Click);
            // 
            // btnPasswordGenerator
            // 
            this.btnPasswordGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPasswordGenerator.Location = new System.Drawing.Point(391, 396);
            this.btnPasswordGenerator.Name = "btnPasswordGenerator";
            this.btnPasswordGenerator.Size = new System.Drawing.Size(134, 42);
            this.btnPasswordGenerator.TabIndex = 36;
            this.btnPasswordGenerator.Text = "Generiraj";
            this.btnPasswordGenerator.UseVisualStyleBackColor = true;
            this.btnPasswordGenerator.Click += new System.EventHandler(this.btnPasswordGenerator_Click);
            // 
            // txtPasswordGenerator
            // 
            this.txtPasswordGenerator.Location = new System.Drawing.Point(391, 364);
            this.txtPasswordGenerator.Name = "txtPasswordGenerator";
            this.txtPasswordGenerator.Size = new System.Drawing.Size(140, 22);
            this.txtPasswordGenerator.TabIndex = 35;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(391, 276);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(152, 22);
            this.txtTelephone.TabIndex = 34;
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(391, 181);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(152, 22);
            this.txtOIB.TabIndex = 33;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(391, 89);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(215, 22);
            this.txtMail.TabIndex = 32;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(41, 364);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(253, 22);
            this.txtAdress.TabIndex = 31;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(41, 276);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(192, 22);
            this.txtLastName.TabIndex = 30;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(41, 181);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(192, 22);
            this.txtFirstName.TabIndex = 29;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(41, 89);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(140, 22);
            this.txtId.TabIndex = 28;
            // 
            // lblPasswordGenerator
            // 
            this.lblPasswordGenerator.AutoSize = true;
            this.lblPasswordGenerator.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblPasswordGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPasswordGenerator.Location = new System.Drawing.Point(387, 313);
            this.lblPasswordGenerator.Name = "lblPasswordGenerator";
            this.lblPasswordGenerator.Size = new System.Drawing.Size(156, 24);
            this.lblPasswordGenerator.TabIndex = 27;
            this.lblPasswordGenerator.Text = "Generiraj lozinku:";
            this.lblPasswordGenerator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTelephone.Location = new System.Drawing.Point(387, 224);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(124, 24);
            this.lblTelephone.TabIndex = 26;
            this.lblTelephone.Text = "Broj mobitela:";
            this.lblTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirstName.Location = new System.Drawing.Point(37, 138);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(46, 24);
            this.lblFirstName.TabIndex = 25;
            this.lblFirstName.Text = "Ime:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLastName.Location = new System.Drawing.Point(37, 224);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 24);
            this.lblLastName.TabIndex = 24;
            this.lblLastName.Text = "Prezime:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdress.Location = new System.Drawing.Point(37, 313);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(169, 24);
            this.lblAdress.TabIndex = 23;
            this.lblAdress.Text = "Adresa stanovanja:";
            this.lblAdress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMail.Location = new System.Drawing.Point(387, 45);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(68, 24);
            this.lblMail.TabIndex = 22;
            this.lblMail.Text = "E-mail:";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOIB
            // 
            this.lblOIB.AutoSize = true;
            this.lblOIB.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblOIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOIB.Location = new System.Drawing.Point(387, 138);
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(46, 24);
            this.lblOIB.TabIndex = 21;
            this.lblOIB.Text = "OIB:";
            this.lblOIB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblId.Location = new System.Drawing.Point(37, 45);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(32, 24);
            this.lblId.TabIndex = 20;
            this.lblId.Text = "ID:";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmEditWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.btnSaveWorker);
            this.Controls.Add(this.btnPasswordGenerator);
            this.Controls.Add(this.txtPasswordGenerator);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblPasswordGenerator);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblOIB);
            this.Controls.Add(this.lblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmEditWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredite radnika";
            this.Load += new System.EventHandler(this.FrmEditWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveWorker;
        private System.Windows.Forms.Button btnPasswordGenerator;
        private System.Windows.Forms.TextBox txtPasswordGenerator;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblPasswordGenerator;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.Label lblId;
    }
}