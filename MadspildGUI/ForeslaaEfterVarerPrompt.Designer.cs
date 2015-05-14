namespace MadspildGUI
{
    partial class ForeslaaEfterVarerPrompt
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
            this.vareBox = new System.Windows.Forms.TextBox();
            this.givForslagKnap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vareBox
            // 
            this.vareBox.Location = new System.Drawing.Point(12, 12);
            this.vareBox.Multiline = true;
            this.vareBox.Name = "vareBox";
            this.vareBox.Size = new System.Drawing.Size(143, 238);
            this.vareBox.TabIndex = 0;
            this.vareBox.Text = "Indtast dine varer her";
            // 
            // givForslagKnap
            // 
            this.givForslagKnap.Location = new System.Drawing.Point(181, 124);
            this.givForslagKnap.Name = "givForslagKnap";
            this.givForslagKnap.Size = new System.Drawing.Size(75, 23);
            this.givForslagKnap.TabIndex = 1;
            this.givForslagKnap.Text = "Giv forslag";
            this.givForslagKnap.UseVisualStyleBackColor = true;
            this.givForslagKnap.Click += new System.EventHandler(this.givForslagKnap_Click);
            // 
            // ForeslaaEfterVarerPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.givForslagKnap);
            this.Controls.Add(this.vareBox);
            this.Name = "ForeslaaEfterVarerPrompt";
            this.Text = "ForeslåEfterVarerPrompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vareBox;
        private System.Windows.Forms.Button givForslagKnap;
    }
}