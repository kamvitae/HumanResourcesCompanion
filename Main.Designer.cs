namespace MP_5_2_HRCompanion
{
    partial class FormMain
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnFired = new System.Windows.Forms.Button();
            this.cbboxFilter = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvWorkers = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAdd.Location = new System.Drawing.Point(15, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Khaki;
            this.btnEdit.Location = new System.Drawing.Point(113, 28);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edycja";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnFired
            // 
            this.btnFired.BackColor = System.Drawing.Color.IndianRed;
            this.btnFired.Location = new System.Drawing.Point(735, 28);
            this.btnFired.Name = "btnFired";
            this.btnFired.Size = new System.Drawing.Size(53, 23);
            this.btnFired.TabIndex = 2;
            this.btnFired.Text = "Zwolnij";
            this.btnFired.UseVisualStyleBackColor = false;
            this.btnFired.Click += new System.EventHandler(this.btnFired_Click);
            // 
            // cbboxFilter
            // 
            this.cbboxFilter.BackColor = System.Drawing.Color.LightCyan;
            this.cbboxFilter.FormattingEnabled = true;
            this.cbboxFilter.Location = new System.Drawing.Point(514, 30);
            this.cbboxFilter.Name = "cbboxFilter";
            this.cbboxFilter.Size = new System.Drawing.Size(121, 21);
            this.cbboxFilter.TabIndex = 3;
            this.cbboxFilter.SelectedIndexChanged += new System.EventHandler(this.chboxFilter_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.PowderBlue;
            this.btnRefresh.Location = new System.Drawing.Point(211, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvWorkers
            // 
            this.dgvWorkers.AllowUserToOrderColumns = true;
            this.dgvWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWorkers.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkers.Location = new System.Drawing.Point(15, 57);
            this.dgvWorkers.Name = "dgvWorkers";
            this.dgvWorkers.Size = new System.Drawing.Size(776, 381);
            this.dgvWorkers.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(313, 28);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvWorkers);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbboxFilter);
            this.Controls.Add(this.btnFired);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "FormMain";
            this.Text = "HR Companion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnFired;
        private System.Windows.Forms.ComboBox cbboxFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvWorkers;
        private System.Windows.Forms.Button btnSave;
    }
}

