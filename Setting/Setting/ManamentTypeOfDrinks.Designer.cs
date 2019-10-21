namespace Setting
{
    partial class ManamentTypeOfDrinks
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
            this.button1 = new System.Windows.Forms.Button();
            this.Cafebtn = new System.Windows.Forms.Button();
            this.Teabtn = new System.Windows.Forms.Button();
            this.IceBlendedbtn = new System.Windows.Forms.Button();
            this.Cookietbn = new System.Windows.Forms.Button();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Cafebtn
            // 
            this.Cafebtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Cafebtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Cafebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cafebtn.Location = new System.Drawing.Point(102, 95);
            this.Cafebtn.Name = "Cafebtn";
            this.Cafebtn.Size = new System.Drawing.Size(136, 91);
            this.Cafebtn.TabIndex = 1;
            this.Cafebtn.Text = "Cafe";
            this.Cafebtn.UseVisualStyleBackColor = false;
            // 
            // Teabtn
            // 
            this.Teabtn.BackColor = System.Drawing.Color.Aqua;
            this.Teabtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Teabtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Teabtn.Location = new System.Drawing.Point(353, 95);
            this.Teabtn.Name = "Teabtn";
            this.Teabtn.Size = new System.Drawing.Size(136, 91);
            this.Teabtn.TabIndex = 2;
            this.Teabtn.Text = "Tea";
            this.Teabtn.UseVisualStyleBackColor = false;
            // 
            // IceBlendedbtn
            // 
            this.IceBlendedbtn.BackColor = System.Drawing.Color.LightCoral;
            this.IceBlendedbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.IceBlendedbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IceBlendedbtn.Location = new System.Drawing.Point(102, 256);
            this.IceBlendedbtn.Name = "IceBlendedbtn";
            this.IceBlendedbtn.Size = new System.Drawing.Size(136, 91);
            this.IceBlendedbtn.TabIndex = 3;
            this.IceBlendedbtn.Text = "IcedBlended";
            this.IceBlendedbtn.UseVisualStyleBackColor = false;
            // 
            // Cookietbn
            // 
            this.Cookietbn.BackColor = System.Drawing.Color.Yellow;
            this.Cookietbn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Cookietbn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cookietbn.Location = new System.Drawing.Point(353, 256);
            this.Cookietbn.Name = "Cookietbn";
            this.Cookietbn.Size = new System.Drawing.Size(136, 91);
            this.Cookietbn.TabIndex = 4;
            this.Cookietbn.Text = "Cookie";
            this.Cookietbn.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Setting.Properties.Resources.Capture1;
            this.button3.Location = new System.Drawing.Point(742, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 51);
            this.button3.TabIndex = 6;
            this.button3.Text = " ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Setting.Properties.Resources.Capture;
            this.button2.Location = new System.Drawing.Point(742, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 44);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ManamentTypeOfDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Cookietbn);
            this.Controls.Add(this.IceBlendedbtn);
            this.Controls.Add(this.Teabtn);
            this.Controls.Add(this.Cafebtn);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "ManamentTypeOfDrinks";
            this.Text = "ManamentTypeOfDrinks";
            this.Load += new System.EventHandler(this.ManamentTypeOfDrinks_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Cafebtn;
        private System.Windows.Forms.Button Teabtn;
        private System.Windows.Forms.Button IceBlendedbtn;
        private System.Windows.Forms.Button Cookietbn;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}