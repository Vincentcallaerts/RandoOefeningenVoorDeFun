
namespace RandoOefeningenVoorDeFun
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
            this.btnKnop = new System.Windows.Forms.Button();
            this.btnRainbow = new System.Windows.Forms.Button();
            this.btnActualRainbow = new System.Windows.Forms.Button();
            this.btnCookie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKnop
            // 
            this.btnKnop.Location = new System.Drawing.Point(12, 12);
            this.btnKnop.Name = "btnKnop";
            this.btnKnop.Size = new System.Drawing.Size(120, 20);
            this.btnKnop.TabIndex = 0;
            this.btnKnop.Text = "Color fun";
            this.btnKnop.UseVisualStyleBackColor = true;
            this.btnKnop.Click += new System.EventHandler(this.btnKnop_Click);
            // 
            // btnRainbow
            // 
            this.btnRainbow.Location = new System.Drawing.Point(12, 38);
            this.btnRainbow.Name = "btnRainbow";
            this.btnRainbow.Size = new System.Drawing.Size(120, 20);
            this.btnRainbow.TabIndex = 1;
            this.btnRainbow.Text = "Rainbow mode";
            this.btnRainbow.UseVisualStyleBackColor = true;
            this.btnRainbow.Click += new System.EventHandler(this.btnRainbow_Click);
            // 
            // btnActualRainbow
            // 
            this.btnActualRainbow.Location = new System.Drawing.Point(12, 64);
            this.btnActualRainbow.Name = "btnActualRainbow";
            this.btnActualRainbow.Size = new System.Drawing.Size(120, 20);
            this.btnActualRainbow.TabIndex = 2;
            this.btnActualRainbow.Text = "Actual Rainbow";
            this.btnActualRainbow.UseVisualStyleBackColor = true;
            this.btnActualRainbow.Click += new System.EventHandler(this.btnActualRainbow_Click);
            // 
            // btnCookie
            // 
            this.btnCookie.Location = new System.Drawing.Point(12, 90);
            this.btnCookie.Name = "btnCookie";
            this.btnCookie.Size = new System.Drawing.Size(120, 20);
            this.btnCookie.TabIndex = 3;
            this.btnCookie.Text = "Add Cookie";
            this.btnCookie.UseVisualStyleBackColor = true;
            this.btnCookie.Click += new System.EventHandler(this.btnCookie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnCookie);
            this.Controls.Add(this.btnActualRainbow);
            this.Controls.Add(this.btnRainbow);
            this.Controls.Add(this.btnKnop);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKnop;
        private System.Windows.Forms.Button btnRainbow;
        private System.Windows.Forms.Button btnActualRainbow;
        private System.Windows.Forms.Button btnCookie;
    }
}

