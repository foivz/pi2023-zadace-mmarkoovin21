namespace CleanWorks_Scheduler
{
    partial class FrmWorkers
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
            this.btnWorkerAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnWorkerEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnWorkerDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvWorkers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWorkerAdd
            // 
            this.btnWorkerAdd.AutoSize = true;
            this.btnWorkerAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWorkerAdd.Depth = 0;
            this.btnWorkerAdd.Icon = null;
            this.btnWorkerAdd.Location = new System.Drawing.Point(763, 521);
            this.btnWorkerAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWorkerAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWorkerAdd.Name = "btnWorkerAdd";
            this.btnWorkerAdd.Primary = false;
            this.btnWorkerAdd.Size = new System.Drawing.Size(77, 36);
            this.btnWorkerAdd.TabIndex = 4;
            this.btnWorkerAdd.Text = "Dodaj";
            this.btnWorkerAdd.UseVisualStyleBackColor = true;
            // 
            // btnWorkerEdit
            // 
            this.btnWorkerEdit.AutoSize = true;
            this.btnWorkerEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWorkerEdit.Depth = 0;
            this.btnWorkerEdit.Icon = null;
            this.btnWorkerEdit.Location = new System.Drawing.Point(667, 521);
            this.btnWorkerEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWorkerEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWorkerEdit.Name = "btnWorkerEdit";
            this.btnWorkerEdit.Primary = false;
            this.btnWorkerEdit.Size = new System.Drawing.Size(70, 36);
            this.btnWorkerEdit.TabIndex = 5;
            this.btnWorkerEdit.Text = "Uredi";
            this.btnWorkerEdit.UseVisualStyleBackColor = true;
            // 
            // btnWorkerDelete
            // 
            this.btnWorkerDelete.AutoSize = true;
            this.btnWorkerDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWorkerDelete.Depth = 0;
            this.btnWorkerDelete.Icon = null;
            this.btnWorkerDelete.Location = new System.Drawing.Point(862, 521);
            this.btnWorkerDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWorkerDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWorkerDelete.Name = "btnWorkerDelete";
            this.btnWorkerDelete.Primary = false;
            this.btnWorkerDelete.Size = new System.Drawing.Size(75, 36);
            this.btnWorkerDelete.TabIndex = 6;
            this.btnWorkerDelete.Text = "Obriši";
            this.btnWorkerDelete.UseVisualStyleBackColor = true;
            this.btnWorkerDelete.Click += new System.EventHandler(this.btnWorkerDelete_Click);
            // 
            // dgvWorkers
            // 
            this.dgvWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkers.Location = new System.Drawing.Point(21, 89);
            this.dgvWorkers.Name = "dgvWorkers";
            this.dgvWorkers.RowHeadersWidth = 51;
            this.dgvWorkers.RowTemplate.Height = 24;
            this.dgvWorkers.Size = new System.Drawing.Size(916, 410);
            this.dgvWorkers.TabIndex = 7;
            // 
            // FrmWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 570);
            this.Controls.Add(this.dgvWorkers);
            this.Controls.Add(this.btnWorkerDelete);
            this.Controls.Add(this.btnWorkerEdit);
            this.Controls.Add(this.btnWorkerAdd);
            this.Name = "FrmWorkers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija radnika";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnWorkerAdd;
        private MaterialSkin.Controls.MaterialFlatButton btnWorkerEdit;
        private MaterialSkin.Controls.MaterialFlatButton btnWorkerDelete;
        private System.Windows.Forms.DataGridView dgvWorkers;
    }
}

