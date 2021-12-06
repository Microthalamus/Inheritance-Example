
namespace Inheritance_Example
{
    partial class Form1
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
            this.classLabel = new System.Windows.Forms.Label();
            this.warriorButton = new System.Windows.Forms.Button();
            this.magebutton = new System.Windows.Forms.Button();
            this.theifButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.classLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.classLabel.Location = new System.Drawing.Point(64, 27);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(670, 89);
            this.classLabel.TabIndex = 0;
            this.classLabel.Text = "Choose A Class";
          
            // 
            // warriorButton
            // 
            this.warriorButton.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.warriorButton.Location = new System.Drawing.Point(294, 134);
            this.warriorButton.Name = "warriorButton";
            this.warriorButton.Size = new System.Drawing.Size(192, 70);
            this.warriorButton.TabIndex = 1;
            this.warriorButton.Text = "Warrior";
            this.warriorButton.UseVisualStyleBackColor = true;
            this.warriorButton.Click += new System.EventHandler(this.warriorButton_Click);
            // 
            // magebutton
            // 
            this.magebutton.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.magebutton.Location = new System.Drawing.Point(294, 229);
            this.magebutton.Name = "magebutton";
            this.magebutton.Size = new System.Drawing.Size(192, 70);
            this.magebutton.TabIndex = 2;
            this.magebutton.Text = "Mage";
            this.magebutton.UseVisualStyleBackColor = true;
            this.magebutton.Click += new System.EventHandler(this.magebutton_Click);
            // 
            // theifButton
            // 
            this.theifButton.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.theifButton.Location = new System.Drawing.Point(294, 330);
            this.theifButton.Name = "theifButton";
            this.theifButton.Size = new System.Drawing.Size(192, 70);
            this.theifButton.TabIndex = 3;
            this.theifButton.Text = "Theif";
            this.theifButton.UseVisualStyleBackColor = true;
            this.theifButton.Click += new System.EventHandler(this.theifButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.theifButton);
            this.Controls.Add(this.magebutton);
            this.Controls.Add(this.warriorButton);
            this.Controls.Add(this.classLabel);
            this.Name = "Form1";
            this.Text = "Class Select ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Button warriorButton;
        private System.Windows.Forms.Button magebutton;
        private System.Windows.Forms.Button theifButton;
    }
}

