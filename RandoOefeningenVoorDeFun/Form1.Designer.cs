
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
            this.SuspendLayout();
            // 
            // btnKnop
            // 
            this.btnKnop.Location = new System.Drawing.Point(323, 200);
            this.btnKnop.Name = "btnKnop";
            this.btnKnop.Size = new System.Drawing.Size(120, 20);
            this.btnKnop.TabIndex = 0;
            this.btnKnop.Text = "Color Fun";
            this.btnKnop.UseVisualStyleBackColor = true;
            this.btnKnop.Click += new System.EventHandler(this.btnKnop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnKnop);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKnop;
    }
}

