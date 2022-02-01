
namespace TestNo4
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
            this.buttonbea = new System.Windows.Forms.Button();
            this.labelbea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonbea
            // 
            this.buttonbea.Location = new System.Drawing.Point(170, 169);
            this.buttonbea.Name = "buttonbea";
            this.buttonbea.Size = new System.Drawing.Size(98, 42);
            this.buttonbea.TabIndex = 0;
            this.buttonbea.Text = "Kas tad tas?";
            this.buttonbea.UseVisualStyleBackColor = true;
            this.buttonbea.Click += new System.EventHandler(this.buttonbea_Click);
            // 
            // labelbea
            // 
            this.labelbea.AutoSize = true;
            this.labelbea.Location = new System.Drawing.Point(195, 214);
            this.labelbea.Name = "labelbea";
            this.labelbea.Size = new System.Drawing.Size(46, 17);
            this.labelbea.TabIndex = 1;
            this.labelbea.Text = "nekas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelbea);
            this.Controls.Add(this.buttonbea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonbea;
        private System.Windows.Forms.Label labelbea;
    }
}

