
namespace CKK.UI
{
    partial class InventoryManagementForm
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
            System.Windows.Forms.Label label1;
            SearchTextBox = new System.Windows.Forms.TextBox();
            SearchButton = new System.Windows.Forms.PictureBox();
            InventoryList = new System.Windows.Forms.ListBox();
            panel1 = new System.Windows.Forms.Panel();
            AddButton = new System.Windows.Forms.Button();
            EditButton = new System.Windows.Forms.Button();
            RemoveButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)SearchButton).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(755, 52);
            label1.TabIndex = 0;
            label1.Text = "C Dubs Inventory Management";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            SearchTextBox.Location = new System.Drawing.Point(0, 0);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderText = "Search";
            SearchTextBox.Size = new System.Drawing.Size(631, 34);
            SearchTextBox.TabIndex = 1;
            SearchTextBox.KeyDown += SearchTextBox_KeyDown;
            // 
            // SearchButton
            // 
            SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            SearchButton.Dock = System.Windows.Forms.DockStyle.Right;
            SearchButton.Image = Properties.Resources.searchIcon;
            SearchButton.InitialImage = Properties.Resources.searchIcon;
            SearchButton.Location = new System.Drawing.Point(631, 0);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new System.Drawing.Size(43, 33);
            SearchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            SearchButton.TabIndex = 2;
            SearchButton.TabStop = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // InventoryList
            // 
            InventoryList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            InventoryList.Cursor = System.Windows.Forms.Cursors.Hand;
            InventoryList.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            InventoryList.HorizontalScrollbar = true;
            InventoryList.ItemHeight = 18;
            InventoryList.Location = new System.Drawing.Point(48, 104);
            InventoryList.Name = "InventoryList";
            InventoryList.Size = new System.Drawing.Size(674, 202);
            InventoryList.TabIndex = 4;
            InventoryList.DoubleClick += EditButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.Controls.Add(SearchTextBox);
            panel1.Controls.Add(SearchButton);
            panel1.Location = new System.Drawing.Point(48, 55);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(674, 33);
            panel1.TabIndex = 5;
            // 
            // AddButton
            // 
            AddButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            AddButton.BackColor = System.Drawing.Color.Transparent;
            AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AddButton.Location = new System.Drawing.Point(48, 328);
            AddButton.Name = "AddButton";
            AddButton.Size = new System.Drawing.Size(117, 39);
            AddButton.TabIndex = 6;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // EditButton
            // 
            EditButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            EditButton.BackColor = System.Drawing.Color.Transparent;
            EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            EditButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            EditButton.Location = new System.Drawing.Point(171, 328);
            EditButton.Name = "EditButton";
            EditButton.Size = new System.Drawing.Size(117, 39);
            EditButton.TabIndex = 7;
            EditButton.Text = "Edit Item";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            RemoveButton.BackColor = System.Drawing.Color.Transparent;
            RemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            RemoveButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RemoveButton.Location = new System.Drawing.Point(605, 328);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new System.Drawing.Size(117, 39);
            RemoveButton.TabIndex = 8;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // InventoryManagementForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(755, 407);
            Controls.Add(RemoveButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(panel1);
            Controls.Add(InventoryList);
            Controls.Add(label1);
            MinimumSize = new System.Drawing.Size(544, 355);
            Name = "InventoryManagementForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)SearchButton).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.PictureBox SearchButton;
        private System.Windows.Forms.ListBox InventoryList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RemoveButton;
    }
}