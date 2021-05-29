
namespace ProiectII
{
    partial class Form1
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
            this.btnCloseReciept = new System.Windows.Forms.Button();
            this.btnLoadRestaurant = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCloseReciept
            // 
            this.btnCloseReciept.Location = new System.Drawing.Point(1256, 556);
            this.btnCloseReciept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCloseReciept.Name = "btnCloseReciept";
            this.btnCloseReciept.Size = new System.Drawing.Size(276, 38);
            this.btnCloseReciept.TabIndex = 0;
            this.btnCloseReciept.TabStop = false;
            this.btnCloseReciept.Text = "Close Reciept";
            this.btnCloseReciept.UseVisualStyleBackColor = true;
            this.btnCloseReciept.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoadRestaurant
            // 
            this.btnLoadRestaurant.Location = new System.Drawing.Point(1256, 602);
            this.btnLoadRestaurant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadRestaurant.Name = "btnLoadRestaurant";
            this.btnLoadRestaurant.Size = new System.Drawing.Size(276, 34);
            this.btnLoadRestaurant.TabIndex = 2;
            this.btnLoadRestaurant.Text = "Load Restaurant Data";
            this.btnLoadRestaurant.UseVisualStyleBackColor = true;
            this.btnLoadRestaurant.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.Location = new System.Drawing.Point(1256, 512);
            this.btnAddItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(276, 36);
            this.btnAddItems.TabIndex = 5;
            this.btnAddItems.Text = "AddItems";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 16;
            this.lstItems.Location = new System.Drawing.Point(1256, 30);
            this.lstItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(275, 468);
            this.lstItems.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1256, 643);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back to Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 703);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.btnLoadRestaurant);
            this.Controls.Add(this.btnCloseReciept);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCloseReciept;
        private System.Windows.Forms.Button btnLoadRestaurant;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button button1;
    }
}

