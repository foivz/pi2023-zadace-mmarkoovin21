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
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvWorkers = new System.Windows.Forms.DataGridView();
            this.btnWorkerDelete = new System.Windows.Forms.Button();
            this.btnWorkerEdit = new System.Windows.Forms.Button();
            this.btnWorkerAdd = new System.Windows.Forms.Button();
            this.txtSearchWorker = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUsername.Location = new System.Drawing.Point(23, 27);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(159, 24);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Pretražite radnike:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearch.Location = new System.Drawing.Point(198, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(187, 34);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Osvježi rezultate";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvWorkers
            // 
            this.dgvWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkers.Location = new System.Drawing.Point(27, 129);
            this.dgvWorkers.Name = "dgvWorkers";
            this.dgvWorkers.RowHeadersWidth = 51;
            this.dgvWorkers.RowTemplate.Height = 24;
            this.dgvWorkers.Size = new System.Drawing.Size(807, 347);
            this.dgvWorkers.TabIndex = 7;
            // 
            // btnWorkerDelete
            // 
            this.btnWorkerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWorkerDelete.Location = new System.Drawing.Point(716, 69);
            this.btnWorkerDelete.Name = "btnWorkerDelete";
            this.btnWorkerDelete.Size = new System.Drawing.Size(103, 34);
            this.btnWorkerDelete.TabIndex = 8;
            this.btnWorkerDelete.Text = "Obriši";
            this.btnWorkerDelete.UseVisualStyleBackColor = true;
            this.btnWorkerDelete.Click += new System.EventHandler(this.btnWorkerDelete_Click);
            // 
            // btnWorkerEdit
            // 
            this.btnWorkerEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWorkerEdit.Location = new System.Drawing.Point(593, 69);
            this.btnWorkerEdit.Name = "btnWorkerEdit";
            this.btnWorkerEdit.Size = new System.Drawing.Size(103, 34);
            this.btnWorkerEdit.TabIndex = 9;
            this.btnWorkerEdit.Text = "Uredi";
            this.btnWorkerEdit.UseVisualStyleBackColor = true;
            this.btnWorkerEdit.Click += new System.EventHandler(this.btnWorkerEdit_Click);
            // 
            // btnWorkerAdd
            // 
            this.btnWorkerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWorkerAdd.Location = new System.Drawing.Point(469, 69);
            this.btnWorkerAdd.Name = "btnWorkerAdd";
            this.btnWorkerAdd.Size = new System.Drawing.Size(103, 34);
            this.btnWorkerAdd.TabIndex = 10;
            this.btnWorkerAdd.Text = "Dodaj";
            this.btnWorkerAdd.UseVisualStyleBackColor = true;
            this.btnWorkerAdd.Click += new System.EventHandler(this.btnWorkerAdd_Click);
            // 
            // txtSearchWorker
            // 
            this.txtSearchWorker.Location = new System.Drawing.Point(198, 30);
            this.txtSearchWorker.Name = "txtSearchWorker";
            this.txtSearchWorker.Size = new System.Drawing.Size(253, 22);
            this.txtSearchWorker.TabIndex = 11;
            // 
            // FrmWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(861, 502);
            this.Controls.Add(this.txtSearchWorker);
            this.Controls.Add(this.btnWorkerAdd);
            this.Controls.Add(this.btnWorkerEdit);
            this.Controls.Add(this.btnWorkerDelete);
            this.Controls.Add(this.dgvWorkers);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmWorkers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radnici";
            this.Load += new System.EventHandler(this.FrmWorkers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvWorkers;
        private System.Windows.Forms.Button btnWorkerDelete;
        private System.Windows.Forms.Button btnWorkerEdit;
        private System.Windows.Forms.Button btnWorkerAdd;
        private System.Windows.Forms.TextBox txtSearchWorker;
    }
}