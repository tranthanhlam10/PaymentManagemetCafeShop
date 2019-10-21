namespace Setting
{
    partial class Setting
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
            this.Login = new System.Windows.Forms.Button();
            this.CheckBill = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.LightCoral;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login.Location = new System.Drawing.Point(121, 173);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(160, 115);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            // 
            // CheckBill
            // 
            this.CheckBill.BackColor = System.Drawing.Color.LightCoral;
            this.CheckBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckBill.Location = new System.Drawing.Point(498, 173);
            this.CheckBill.Name = "CheckBill";
            this.CheckBill.Size = new System.Drawing.Size(160, 115);
            this.CheckBill.TabIndex = 1;
            this.CheckBill.Text = "Check bill";
            this.CheckBill.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CheckBill);
            this.Controls.Add(this.Login);
            this.Name = "Form1";
            this.Text = "Setting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button CheckBill;
        private System.Windows.Forms.Button button3;
    }
}

