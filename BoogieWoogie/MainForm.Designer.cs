namespace BoogieWoogie
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GenerateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.Color.PaleGreen;
            this.GenerateButton.Location = new System.Drawing.Point(12, 12);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(121, 95);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Genereer een awesome Boogie Woogie!";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 1200);
            this.Controls.Add(this.GenerateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Boogie Woogie, it\'s like art             (c) JensDennisBV";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerateButton;


    }
}

