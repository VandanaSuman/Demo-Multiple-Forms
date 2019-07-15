namespace COMP123_s2019_Lab10_301045522
{
    partial class EndForm
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
            this.EndFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EndFormButton
            // 
            this.EndFormButton.Location = new System.Drawing.Point(114, 80);
            this.EndFormButton.Name = "EndFormButton";
            this.EndFormButton.Size = new System.Drawing.Size(180, 41);
            this.EndFormButton.TabIndex = 0;
            this.EndFormButton.Text = "BackButton";
            this.EndFormButton.UseVisualStyleBackColor = true;
            this.EndFormButton.Click += new System.EventHandler(this.EndFormButton_Click);
            // 
            // EndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.EndFormButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "EndForm";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EndForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EndFormButton;
    }
}