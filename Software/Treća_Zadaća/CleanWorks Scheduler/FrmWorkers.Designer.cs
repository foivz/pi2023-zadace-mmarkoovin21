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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWorkers));
            this.btnWorkerAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnWorkerEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnWorkerDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvWorkers = new System.Windows.Forms.DataGridView();
            this.lblSearchWorker = new MaterialSkin.Controls.MaterialLabel();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.txtSearchWorker = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWorkerAdd
            // 
            this.btnWorkerAdd.AutoSize = true;
            this.btnWorkerAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWorkerAdd.Depth = 0;
            this.btnWorkerAdd.Icon = ((System.Drawing.Image)(resources.GetObject("btnWorkerAdd.Icon")));
            this.btnWorkerAdd.Location = new System.Drawing.Point(705, 519);
            this.btnWorkerAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWorkerAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWorkerAdd.Name = "btnWorkerAdd";
            this.btnWorkerAdd.Primary = false;
            this.btnWorkerAdd.Size = new System.Drawing.Size(105, 36);
            this.btnWorkerAdd.TabIndex = 4;
            this.btnWorkerAdd.Text = "Dodaj";
            this.btnWorkerAdd.UseVisualStyleBackColor = true;
            // 
            // btnWorkerEdit
            // 
            this.btnWorkerEdit.AutoSize = true;
            this.btnWorkerEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWorkerEdit.Depth = 0;
            this.btnWorkerEdit.Icon = ((System.Drawing.Image)(resources.GetObject("btnWorkerEdit.Icon")));
            this.btnWorkerEdit.Location = new System.Drawing.Point(574, 519);
            this.btnWorkerEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWorkerEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWorkerEdit.Name = "btnWorkerEdit";
            this.btnWorkerEdit.Primary = false;
            this.btnWorkerEdit.Size = new System.Drawing.Size(98, 36);
            this.btnWorkerEdit.TabIndex = 5;
            this.btnWorkerEdit.Text = "Uredi";
            this.btnWorkerEdit.UseVisualStyleBackColor = true;
            this.btnWorkerEdit.Click += new System.EventHandler(this.btnWorkerEdit_Click);
            // 
            // btnWorkerDelete
            // 
            this.btnWorkerDelete.AutoSize = true;
            this.btnWorkerDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWorkerDelete.Depth = 0;
            this.btnWorkerDelete.Icon = ((System.Drawing.Image)(resources.GetObject("btnWorkerDelete.Icon")));
            this.btnWorkerDelete.Location = new System.Drawing.Point(834, 519);
            this.btnWorkerDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWorkerDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWorkerDelete.Name = "btnWorkerDelete";
            this.btnWorkerDelete.Primary = false;
            this.btnWorkerDelete.Size = new System.Drawing.Size(103, 36);
            this.btnWorkerDelete.TabIndex = 6;
            this.btnWorkerDelete.Text = "Obriši";
            this.btnWorkerDelete.UseVisualStyleBackColor = true;
            this.btnWorkerDelete.Click += new System.EventHandler(this.btnWorkerDelete_Click);
            // 
            // dgvWorkers
            // 
            this.dgvWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkers.Location = new System.Drawing.Point(21, 139);
            this.dgvWorkers.Name = "dgvWorkers";
            this.dgvWorkers.RowHeadersWidth = 51;
            this.dgvWorkers.RowTemplate.Height = 24;
            this.dgvWorkers.Size = new System.Drawing.Size(916, 360);
            this.dgvWorkers.TabIndex = 7;
            // 
            // lblSearchWorker
            // 
            this.lblSearchWorker.AutoSize = true;
            this.lblSearchWorker.Depth = 0;
            this.lblSearchWorker.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSearchWorker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSearchWorker.Location = new System.Drawing.Point(21, 91);
            this.lblSearchWorker.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSearchWorker.Name = "lblSearchWorker";
            this.lblSearchWorker.Size = new System.Drawing.Size(172, 24);
            this.lblSearchWorker.TabIndex = 8;
            this.lblSearchWorker.Text = "Pretražite korisnike";
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtSearchWorker
            // 
            this.txtSearchWorker.Location = new System.Drawing.Point(209, 92);
            this.txtSearchWorker.Name = "txtSearchWorker";
            this.txtSearchWorker.Size = new System.Drawing.Size(219, 22);
            this.txtSearchWorker.TabIndex = 9;
            this.txtSearchWorker.TextChanged += new System.EventHandler(this.txtSearchWorker_TextChanged);
            // 
            // FrmWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 580);
            this.Controls.Add(this.txtSearchWorker);
            this.Controls.Add(this.lblSearchWorker);
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
        private MaterialSkin.Controls.MaterialLabel lblSearchWorker;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.TextBox txtSearchWorker;
    }
}

