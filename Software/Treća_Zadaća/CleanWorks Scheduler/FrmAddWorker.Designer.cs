namespace CleanWorks_Scheduler
{
    partial class FrmAddWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddWorker));
            this.lblLastName = new MaterialSkin.Controls.MaterialLabel();
            this.lblFirstName = new MaterialSkin.Controls.MaterialLabel();
            this.lblAdress = new MaterialSkin.Controls.MaterialLabel();
            this.lblMail = new MaterialSkin.Controls.MaterialLabel();
            this.lblOIB = new MaterialSkin.Controls.MaterialLabel();
            this.lblTelephone = new MaterialSkin.Controls.MaterialLabel();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.btnSaveWorker = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblPasswordGenerator = new MaterialSkin.Controls.MaterialLabel();
            this.txtPasswordGenerator = new System.Windows.Forms.TextBox();
            this.btnPasswordGenerator = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblIdentificationNumber = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Depth = 0;
            this.lblLastName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLastName.Location = new System.Drawing.Point(27, 272);
            this.lblLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 24);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Prezime:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Depth = 0;
            this.lblFirstName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFirstName.Location = new System.Drawing.Point(27, 183);
            this.lblFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(47, 24);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "Ime:";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Depth = 0;
            this.lblAdress.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdress.Location = new System.Drawing.Point(27, 364);
            this.lblAdress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(170, 24);
            this.lblAdress.TabIndex = 3;
            this.lblAdress.Text = "Adresa stanovanja:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Depth = 0;
            this.lblMail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMail.Location = new System.Drawing.Point(390, 97);
            this.lblMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(78, 24);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "E - mail:";
            // 
            // lblOIB
            // 
            this.lblOIB.AutoSize = true;
            this.lblOIB.Depth = 0;
            this.lblOIB.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblOIB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOIB.Location = new System.Drawing.Point(390, 183);
            this.lblOIB.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(45, 24);
            this.lblOIB.TabIndex = 5;
            this.lblOIB.Text = "OIB:";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Depth = 0;
            this.lblTelephone.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTelephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTelephone.Location = new System.Drawing.Point(390, 275);
            this.lblTelephone.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(129, 24);
            this.lblTelephone.TabIndex = 6;
            this.lblTelephone.Text = "Broj mobitela:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(31, 223);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(188, 22);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(31, 315);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(182, 22);
            this.txtLastName.TabIndex = 8;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(31, 413);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(224, 22);
            this.txtAdress.TabIndex = 9;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(394, 134);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(250, 22);
            this.txtMail.TabIndex = 10;
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(394, 226);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(148, 22);
            this.txtOIB.TabIndex = 11;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(394, 323);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(148, 22);
            this.txtTelephone.TabIndex = 12;
            // 
            // btnSaveWorker
            // 
            this.btnSaveWorker.AutoSize = true;
            this.btnSaveWorker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveWorker.Depth = 0;
            this.btnSaveWorker.Icon = ((System.Drawing.Image)(resources.GetObject("btnSaveWorker.Icon")));
            this.btnSaveWorker.Location = new System.Drawing.Point(659, 449);
            this.btnSaveWorker.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveWorker.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveWorker.Name = "btnSaveWorker";
            this.btnSaveWorker.Primary = false;
            this.btnSaveWorker.Size = new System.Drawing.Size(112, 36);
            this.btnSaveWorker.TabIndex = 13;
            this.btnSaveWorker.Text = "Spremi";
            this.btnSaveWorker.UseVisualStyleBackColor = true;
            this.btnSaveWorker.Click += new System.EventHandler(this.btnSaveWorker_Click);
            // 
            // lblPasswordGenerator
            // 
            this.lblPasswordGenerator.AutoSize = true;
            this.lblPasswordGenerator.Depth = 0;
            this.lblPasswordGenerator.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPasswordGenerator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPasswordGenerator.Location = new System.Drawing.Point(393, 369);
            this.lblPasswordGenerator.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPasswordGenerator.Name = "lblPasswordGenerator";
            this.lblPasswordGenerator.Size = new System.Drawing.Size(133, 24);
            this.lblPasswordGenerator.TabIndex = 14;
            this.lblPasswordGenerator.Text = "Generiraj šifru:";
            // 
            // txtPasswordGenerator
            // 
            this.txtPasswordGenerator.Location = new System.Drawing.Point(393, 407);
            this.txtPasswordGenerator.Name = "txtPasswordGenerator";
            this.txtPasswordGenerator.Size = new System.Drawing.Size(133, 22);
            this.txtPasswordGenerator.TabIndex = 15;
            // 
            // btnPasswordGenerator
            // 
            this.btnPasswordGenerator.AutoSize = true;
            this.btnPasswordGenerator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPasswordGenerator.Depth = 0;
            this.btnPasswordGenerator.Icon = null;
            this.btnPasswordGenerator.Location = new System.Drawing.Point(393, 449);
            this.btnPasswordGenerator.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPasswordGenerator.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPasswordGenerator.Name = "btnPasswordGenerator";
            this.btnPasswordGenerator.Primary = false;
            this.btnPasswordGenerator.Size = new System.Drawing.Size(163, 36);
            this.btnPasswordGenerator.TabIndex = 16;
            this.btnPasswordGenerator.Text = "Generiraj šifru";
            this.btnPasswordGenerator.UseVisualStyleBackColor = true;
            this.btnPasswordGenerator.Click += new System.EventHandler(this.btnPasswordGenerator_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(31, 135);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(183, 22);
            this.txtId.TabIndex = 17;
            // 
            // lblIdentificationNumber
            // 
            this.lblIdentificationNumber.AutoSize = true;
            this.lblIdentificationNumber.Depth = 0;
            this.lblIdentificationNumber.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIdentificationNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdentificationNumber.Location = new System.Drawing.Point(27, 97);
            this.lblIdentificationNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdentificationNumber.Name = "lblIdentificationNumber";
            this.lblIdentificationNumber.Size = new System.Drawing.Size(31, 24);
            this.lblIdentificationNumber.TabIndex = 18;
            this.lblIdentificationNumber.Text = "Id:";
            // 
            // FrmAddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.lblIdentificationNumber);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnPasswordGenerator);
            this.Controls.Add(this.txtPasswordGenerator);
            this.Controls.Add(this.lblPasswordGenerator);
            this.Controls.Add(this.btnSaveWorker);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblOIB);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Name = "FrmAddWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje";
            this.Load += new System.EventHandler(this.FrmAddWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblLastName;
        private MaterialSkin.Controls.MaterialLabel lblFirstName;
        private MaterialSkin.Controls.MaterialLabel lblAdress;
        private MaterialSkin.Controls.MaterialLabel lblMail;
        private MaterialSkin.Controls.MaterialLabel lblOIB;
        private MaterialSkin.Controls.MaterialLabel lblTelephone;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox txtTelephone;
        private MaterialSkin.Controls.MaterialFlatButton btnSaveWorker;
        private MaterialSkin.Controls.MaterialLabel lblPasswordGenerator;
        private System.Windows.Forms.TextBox txtPasswordGenerator;
        private MaterialSkin.Controls.MaterialFlatButton btnPasswordGenerator;
        private System.Windows.Forms.TextBox txtId;
        private MaterialSkin.Controls.MaterialLabel lblIdentificationNumber;
    }
}