
namespace CKK.UI
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            UsernameTextBox = new System.Windows.Forms.TextBox();
            PasswordTextBox = new System.Windows.Forms.TextBox();
            LoginButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(76, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(506, 125);
            label1.TabIndex = 0;
            label1.Text = "C Dubs BoardShop";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            UsernameTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            UsernameTextBox.Location = new System.Drawing.Point(148, 143);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.PlaceholderText = "Username";
            UsernameTextBox.Size = new System.Drawing.Size(351, 43);
            UsernameTextBox.TabIndex = 1;
            UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            UsernameTextBox.Enter += TextBox_Enter;
            UsernameTextBox.Leave += TextBox_Leave;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PasswordTextBox.Location = new System.Drawing.Point(148, 195);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "Password";
            PasswordTextBox.Size = new System.Drawing.Size(351, 43);
            PasswordTextBox.TabIndex = 2;
            PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            PasswordTextBox.Enter += TextBox_Enter;
            PasswordTextBox.Leave += TextBox_Leave;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            LoginButton.BackColor = System.Drawing.Color.Transparent;
            LoginButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            LoginButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LoginButton.Location = new System.Drawing.Point(148, 255);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new System.Drawing.Size(351, 64);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Login!";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginForm
            // 
            AcceptButton = LoginButton;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(633, 411);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
    }
}

