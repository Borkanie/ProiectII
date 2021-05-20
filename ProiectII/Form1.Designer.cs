
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
            this.SuspendLayout();
            // 
            // btnCloseReciept
            // 
            this.btnCloseReciept.Location = new System.Drawing.Point(942, 494);
            this.btnCloseReciept.Name = "btnCloseReciept";
            this.btnCloseReciept.Size = new System.Drawing.Size(207, 31);
            this.btnCloseReciept.TabIndex = 0;
            this.btnCloseReciept.TabStop = false;
            this.btnCloseReciept.Text = "Close Reciept";
            this.btnCloseReciept.UseVisualStyleBackColor = true;
            this.btnCloseReciept.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoadRestaurant
            // 
            this.btnLoadRestaurant.Location = new System.Drawing.Point(942, 531);
            this.btnLoadRestaurant.Name = "btnLoadRestaurant";
            this.btnLoadRestaurant.Size = new System.Drawing.Size(207, 28);
            this.btnLoadRestaurant.TabIndex = 2;
            this.btnLoadRestaurant.Text = "Load Restaurant Data";
            this.btnLoadRestaurant.UseVisualStyleBackColor = true;
            this.btnLoadRestaurant.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.Location = new System.Drawing.Point(942, 424);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(207, 29);
            this.btnAddItems.TabIndex = 5;
            this.btnAddItems.Text = "AddItems";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(942, 24);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(207, 381);
            this.lstItems.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 571);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.btnLoadRestaurant);
            this.Controls.Add(this.btnCloseReciept);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCloseReciept;
        private System.Windows.Forms.Button btnLoadRestaurant;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.ListBox lstItems;
    }
}

