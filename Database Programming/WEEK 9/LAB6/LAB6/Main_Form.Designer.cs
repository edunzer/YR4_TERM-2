
namespace LAB6
{
    partial class Main_Form
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
            this.lstvItems = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOpened = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateClosed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstvItems
            // 
            this.lstvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.ProductCode,
            this.DateOpened,
            this.DateClosed,
            this.Title});
            this.lstvItems.HideSelection = false;
            this.lstvItems.Location = new System.Drawing.Point(12, 12);
            this.lstvItems.Name = "lstvItems";
            this.lstvItems.Size = new System.Drawing.Size(650, 418);
            this.lstvItems.TabIndex = 0;
            this.lstvItems.UseCompatibleStateImageBehavior = false;
            this.lstvItems.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Technician";
            this.Name.Width = 111;
            // 
            // ProductCode
            // 
            this.ProductCode.Text = "Product";
            this.ProductCode.Width = 83;
            // 
            // DateOpened
            // 
            this.DateOpened.Text = "Date Opened";
            this.DateOpened.Width = 102;
            // 
            // DateClosed
            // 
            this.DateClosed.Text = "Date Closed";
            this.DateClosed.Width = 90;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 241;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 442);
            this.Controls.Add(this.lstvItems);
            this.Text = "Incidents by Technician";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstvItems;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader ProductCode;
        private System.Windows.Forms.ColumnHeader DateOpened;
        private System.Windows.Forms.ColumnHeader DateClosed;
        private System.Windows.Forms.ColumnHeader Title;
    }
}

