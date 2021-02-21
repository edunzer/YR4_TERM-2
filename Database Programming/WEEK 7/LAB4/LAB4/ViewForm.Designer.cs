
namespace LAB4
{
    partial class ViewForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstbxStudents = new System.Windows.Forms.ListBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxScoreTotal = new System.Windows.Forms.TextBox();
            this.txtbxScoreCount = new System.Windows.Forms.TextBox();
            this.txtbxAverage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students:";
            // 
            // lstbxStudents
            // 
            this.lstbxStudents.FormattingEnabled = true;
            this.lstbxStudents.Location = new System.Drawing.Point(15, 48);
            this.lstbxStudents.Name = "lstbxStudents";
            this.lstbxStudents.Size = new System.Drawing.Size(302, 147);
            this.lstbxStudents.TabIndex = 1;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(332, 48);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(92, 23);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add New ...";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(332, 77);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update ...";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(332, 106);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(332, 262);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Score total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Score count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Average:";
            // 
            // txtboxScoreTotal
            // 
            this.txtboxScoreTotal.Location = new System.Drawing.Point(250, 209);
            this.txtboxScoreTotal.Name = "txtboxScoreTotal";
            this.txtboxScoreTotal.ReadOnly = true;
            this.txtboxScoreTotal.Size = new System.Drawing.Size(67, 20);
            this.txtboxScoreTotal.TabIndex = 9;
            // 
            // txtbxScoreCount
            // 
            this.txtbxScoreCount.Location = new System.Drawing.Point(250, 237);
            this.txtbxScoreCount.Name = "txtbxScoreCount";
            this.txtbxScoreCount.ReadOnly = true;
            this.txtbxScoreCount.Size = new System.Drawing.Size(67, 20);
            this.txtbxScoreCount.TabIndex = 10;
            // 
            // txtbxAverage
            // 
            this.txtbxAverage.Location = new System.Drawing.Point(250, 263);
            this.txtbxAverage.Name = "txtbxAverage";
            this.txtbxAverage.ReadOnly = true;
            this.txtbxAverage.Size = new System.Drawing.Size(67, 20);
            this.txtbxAverage.TabIndex = 11;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 321);
            this.Controls.Add(this.txtbxAverage);
            this.Controls.Add(this.txtbxScoreCount);
            this.Controls.Add(this.txtboxScoreTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lstbxStudents);
            this.Controls.Add(this.label1);
            this.Name = "ViewForm";
            this.Text = "Student Scores";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstbxStudents;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxScoreTotal;
        private System.Windows.Forms.TextBox txtbxScoreCount;
        private System.Windows.Forms.TextBox txtbxAverage;
    }
}

