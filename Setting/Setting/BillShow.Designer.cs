namespace Setting
{
    partial class BillShow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Cafetab = new System.Windows.Forms.TabPage();
            this.Teatab = new System.Windows.Forms.TabPage();
            this.IceBlendedtab = new System.Windows.Forms.TabPage();
            this.Cookietab = new System.Windows.Forms.TabPage();
            this.Totaltab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Cafetab);
            this.tabControl1.Controls.Add(this.Teatab);
            this.tabControl1.Controls.Add(this.IceBlendedtab);
            this.tabControl1.Controls.Add(this.Cookietab);
            this.tabControl1.Controls.Add(this.Totaltab);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // Cafetab
            // 
            this.Cafetab.Location = new System.Drawing.Point(4, 22);
            this.Cafetab.Name = "Cafetab";
            this.Cafetab.Padding = new System.Windows.Forms.Padding(3);
            this.Cafetab.Size = new System.Drawing.Size(794, 430);
            this.Cafetab.TabIndex = 0;
            this.Cafetab.Text = "Cafe";
            this.Cafetab.UseVisualStyleBackColor = true;
            this.Cafetab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Teatab
            // 
            this.Teatab.Location = new System.Drawing.Point(4, 22);
            this.Teatab.Name = "Teatab";
            this.Teatab.Padding = new System.Windows.Forms.Padding(3);
            this.Teatab.Size = new System.Drawing.Size(794, 430);
            this.Teatab.TabIndex = 1;
            this.Teatab.Text = "Tea";
            this.Teatab.UseVisualStyleBackColor = true;
            // 
            // IceBlendedtab
            // 
            this.IceBlendedtab.Location = new System.Drawing.Point(4, 22);
            this.IceBlendedtab.Name = "IceBlendedtab";
            this.IceBlendedtab.Padding = new System.Windows.Forms.Padding(3);
            this.IceBlendedtab.Size = new System.Drawing.Size(794, 430);
            this.IceBlendedtab.TabIndex = 2;
            this.IceBlendedtab.Text = "IceBlended";
            this.IceBlendedtab.UseVisualStyleBackColor = true;
            // 
            // Cookietab
            // 
            this.Cookietab.Location = new System.Drawing.Point(4, 22);
            this.Cookietab.Name = "Cookietab";
            this.Cookietab.Padding = new System.Windows.Forms.Padding(3);
            this.Cookietab.Size = new System.Drawing.Size(794, 430);
            this.Cookietab.TabIndex = 3;
            this.Cookietab.Text = "Cookie";
            this.Cookietab.UseVisualStyleBackColor = true;
            // 
            // Totaltab
            // 
            this.Totaltab.Location = new System.Drawing.Point(4, 22);
            this.Totaltab.Name = "Totaltab";
            this.Totaltab.Padding = new System.Windows.Forms.Padding(3);
            this.Totaltab.Size = new System.Drawing.Size(794, 430);
            this.Totaltab.TabIndex = 4;
            this.Totaltab.Text = "Total";
            this.Totaltab.UseVisualStyleBackColor = true;
            // 
            // BillShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "BillShow";
            this.Text = "BillShow";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Cafetab;
        private System.Windows.Forms.TabPage Teatab;
        private System.Windows.Forms.TabPage IceBlendedtab;
        private System.Windows.Forms.TabPage Cookietab;
        private System.Windows.Forms.TabPage Totaltab;
    }
}