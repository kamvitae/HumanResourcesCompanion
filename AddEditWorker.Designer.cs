namespace MP_5_2_HRCompanion
{
    partial class AddEditWorker
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbWorkerID = new System.Windows.Forms.TextBox();
            this.tbFired = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbHired = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbHired = new System.Windows.Forms.Label();
            this.lbWorkerID = new System.Windows.Forms.Label();
            this.lbSalary = new System.Windows.Forms.Label();
            this.lbFired = new System.Windows.Forms.Label();
            this.lbComments = new System.Windows.Forms.Label();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(124, 79);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(190, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(124, 105);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(190, 20);
            this.tbLastName.TabIndex = 1;
            // 
            // tbWorkerID
            // 
            this.tbWorkerID.Location = new System.Drawing.Point(124, 36);
            this.tbWorkerID.Name = "tbWorkerID";
            this.tbWorkerID.ReadOnly = true;
            this.tbWorkerID.Size = new System.Drawing.Size(190, 20);
            this.tbWorkerID.TabIndex = 2;
            // 
            // tbFired
            // 
            this.tbFired.Location = new System.Drawing.Point(124, 179);
            this.tbFired.Name = "tbFired";
            this.tbFired.Size = new System.Drawing.Size(190, 20);
            this.tbFired.TabIndex = 5;
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(124, 233);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(190, 20);
            this.tbSalary.TabIndex = 4;
            // 
            // tbHired
            // 
            this.tbHired.Location = new System.Drawing.Point(124, 153);
            this.tbHired.Name = "tbHired";
            this.tbHired.Size = new System.Drawing.Size(190, 20);
            this.tbHired.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(20, 82);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(29, 13);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Imię:";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(20, 108);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(56, 13);
            this.lbLastName.TabIndex = 7;
            this.lbLastName.Text = "Nazwisko:";
            // 
            // lbHired
            // 
            this.lbHired.AutoSize = true;
            this.lbHired.Location = new System.Drawing.Point(20, 156);
            this.lbHired.Name = "lbHired";
            this.lbHired.Size = new System.Drawing.Size(67, 13);
            this.lbHired.TabIndex = 8;
            this.lbHired.Text = "Zatrudniono:";
            // 
            // lbWorkerID
            // 
            this.lbWorkerID.AutoSize = true;
            this.lbWorkerID.Location = new System.Drawing.Point(20, 39);
            this.lbWorkerID.Name = "lbWorkerID";
            this.lbWorkerID.Size = new System.Drawing.Size(68, 13);
            this.lbWorkerID.TabIndex = 9;
            this.lbWorkerID.Text = "Identyfikator:";
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Location = new System.Drawing.Point(20, 236);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(72, 13);
            this.lbSalary.TabIndex = 11;
            this.lbSalary.Text = "Pensja brutto:";
            // 
            // lbFired
            // 
            this.lbFired.AutoSize = true;
            this.lbFired.Location = new System.Drawing.Point(20, 182);
            this.lbFired.Name = "lbFired";
            this.lbFired.Size = new System.Drawing.Size(103, 13);
            this.lbFired.TabIndex = 10;
            this.lbFired.Text = "Zakończył(a) pracę:";
            // 
            // lbComments
            // 
            this.lbComments.AutoSize = true;
            this.lbComments.Location = new System.Drawing.Point(20, 290);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(40, 13);
            this.lbComments.TabIndex = 12;
            this.lbComments.Text = "Uwagi:";
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(124, 290);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(190, 126);
            this.rtbComments.TabIndex = 13;
            this.rtbComments.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(239, 448);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(124, 448);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // AddEditWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 504);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.lbFired);
            this.Controls.Add(this.lbWorkerID);
            this.Controls.Add(this.lbHired);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbFired);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.tbHired);
            this.Controls.Add(this.tbWorkerID);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbName);
            this.Name = "AddEditWorker";
            this.Text = "AddEditWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbWorkerID;
        private System.Windows.Forms.TextBox tbFired;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbHired;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbHired;
        private System.Windows.Forms.Label lbWorkerID;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Label lbFired;
        private System.Windows.Forms.Label lbComments;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
    }
}