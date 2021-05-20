
namespace ProiectII
{
    partial class AddItemsForms
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
            this.components = new System.ComponentModel.Container();
            this.lstItems = new System.Windows.Forms.ListView();
            this.lstImages = new System.Windows.Forms.ImageList(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.lstReciept = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstItems
            // 
            this.lstItems.HideSelection = false;
            this.lstItems.Location = new System.Drawing.Point(12, 12);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(589, 426);
            this.lstItems.TabIndex = 0;
            this.lstItems.UseCompatibleStateImageBehavior = false;
            this.lstItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstItems_MouseClick);
            // 
            // lstImages
            // 
            this.lstImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.lstImages.ImageSize = new System.Drawing.Size(16, 16);
            this.lstImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(607, 295);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(181, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(607, 321);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(181, 35);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(607, 403);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(181, 35);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lstReciept
            // 
            this.lstReciept.FormattingEnabled = true;
            this.lstReciept.Location = new System.Drawing.Point(607, 12);
            this.lstReciept.Name = "lstReciept";
            this.lstReciept.Size = new System.Drawing.Size(181, 277);
            this.lstReciept.TabIndex = 7;
            this.lstReciept.SelectedIndexChanged += new System.EventHandler(this.lstReciept_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(607, 362);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(181, 35);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // AddItemsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstReciept);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lstItems);
            this.Name = "AddItemsForms";
            this.Text = "AddItemsForms";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstItems;
        private System.Windows.Forms.ImageList lstImages;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ListBox lstReciept;
        private System.Windows.Forms.Button btnRemove;
    }
}