namespace BrickBreaker
{
    partial class Owner
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
            this.B_Shokyu = new System.Windows.Forms.Button();
            this.B_Chukyu = new System.Windows.Forms.Button();
            this.B_Jyokyu = new System.Windows.Forms.Button();
            this.B_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Shokyu
            // 
            this.B_Shokyu.AutoSize = true;
            this.B_Shokyu.Location = new System.Drawing.Point(276, 27);
            this.B_Shokyu.Name = "B_Shokyu";
            this.B_Shokyu.Size = new System.Drawing.Size(146, 53);
            this.B_Shokyu.TabIndex = 0;
            this.B_Shokyu.Text = "初級";
            this.B_Shokyu.UseVisualStyleBackColor = true;
            this.B_Shokyu.Click += new System.EventHandler(this.B_Shokyu_Click);
            // 
            // B_Chukyu
            // 
            this.B_Chukyu.Location = new System.Drawing.Point(276, 103);
            this.B_Chukyu.Name = "B_Chukyu";
            this.B_Chukyu.Size = new System.Drawing.Size(146, 54);
            this.B_Chukyu.TabIndex = 1;
            this.B_Chukyu.Text = "中級";
            this.B_Chukyu.UseVisualStyleBackColor = true;
            this.B_Chukyu.Click += new System.EventHandler(this.B_Chukyu_Click);
            // 
            // B_Jyokyu
            // 
            this.B_Jyokyu.Location = new System.Drawing.Point(276, 179);
            this.B_Jyokyu.Name = "B_Jyokyu";
            this.B_Jyokyu.Size = new System.Drawing.Size(146, 52);
            this.B_Jyokyu.TabIndex = 2;
            this.B_Jyokyu.Text = "上級";
            this.B_Jyokyu.UseVisualStyleBackColor = true;
            this.B_Jyokyu.Click += new System.EventHandler(this.B_Jyokyu_Click);
            // 
            // B_Close
            // 
            this.B_Close.Location = new System.Drawing.Point(276, 264);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(146, 58);
            this.B_Close.TabIndex = 3;
            this.B_Close.Text = "終了";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.B_Jyokyu);
            this.Controls.Add(this.B_Chukyu);
            this.Controls.Add(this.B_Shokyu);
            this.Name = "Owner";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Owner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button B_Shokyu;
        private Button B_Chukyu;
        private Button B_Jyokyu;
        private Button B_Close;
    }
}