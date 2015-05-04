namespace MadspildGUI
{
    partial class TilfoejOpskriftPrompt
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
            this.retNavnBox = new System.Windows.Forms.TextBox();
            this.ingrediensVolumenBox = new System.Windows.Forms.TextBox();
            this.instruktionerBox = new System.Windows.Forms.TextBox();
            this.tilfoejKnap = new System.Windows.Forms.Button();
            this.ingrediensNavnBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // retNavnBox
            // 
            this.retNavnBox.Location = new System.Drawing.Point(12, 12);
            this.retNavnBox.Name = "retNavnBox";
            this.retNavnBox.Size = new System.Drawing.Size(265, 20);
            this.retNavnBox.TabIndex = 0;
            this.retNavnBox.Text = "Indtast rettens navn";
            // 
            // ingrediensVolumenBox
            // 
            this.ingrediensVolumenBox.Location = new System.Drawing.Point(13, 38);
            this.ingrediensVolumenBox.Multiline = true;
            this.ingrediensVolumenBox.Name = "ingrediensVolumenBox";
            this.ingrediensVolumenBox.Size = new System.Drawing.Size(74, 103);
            this.ingrediensVolumenBox.TabIndex = 1;
            this.ingrediensVolumenBox.Text = "Indtast ingrediensers volumen\r\n(1 per linje)\r\nfx 450 g\r\n";
            // 
            // instruktionerBox
            // 
            this.instruktionerBox.Location = new System.Drawing.Point(12, 147);
            this.instruktionerBox.Multiline = true;
            this.instruktionerBox.Name = "instruktionerBox";
            this.instruktionerBox.Size = new System.Drawing.Size(265, 139);
            this.instruktionerBox.TabIndex = 2;
            this.instruktionerBox.Text = "Indtast instruktioner (1 per linje)";
            // 
            // tilfoejKnap
            // 
            this.tilfoejKnap.Location = new System.Drawing.Point(12, 292);
            this.tilfoejKnap.Name = "tilfoejKnap";
            this.tilfoejKnap.Size = new System.Drawing.Size(75, 23);
            this.tilfoejKnap.TabIndex = 3;
            this.tilfoejKnap.Text = "Tilføj opskrift";
            this.tilfoejKnap.UseVisualStyleBackColor = true;
            this.tilfoejKnap.Click += new System.EventHandler(this.tilfoejKnap_Click);
            // 
            // ingrediensNavnBox
            // 
            this.ingrediensNavnBox.Location = new System.Drawing.Point(93, 39);
            this.ingrediensNavnBox.Multiline = true;
            this.ingrediensNavnBox.Name = "ingrediensNavnBox";
            this.ingrediensNavnBox.Size = new System.Drawing.Size(184, 102);
            this.ingrediensNavnBox.TabIndex = 4;
            this.ingrediensNavnBox.Text = "Indtast ingrediensers navn\r\n(1 per linje)\r\nfx hakket oksekød\r\n";
            // 
            // TilfoejOpskriftPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 327);
            this.Controls.Add(this.ingrediensNavnBox);
            this.Controls.Add(this.tilfoejKnap);
            this.Controls.Add(this.instruktionerBox);
            this.Controls.Add(this.ingrediensVolumenBox);
            this.Controls.Add(this.retNavnBox);
            this.Name = "TilfoejOpskriftPrompt";
            this.Text = "TilfoejOpskriftPrompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox retNavnBox;
        private System.Windows.Forms.TextBox ingrediensVolumenBox;
        private System.Windows.Forms.TextBox instruktionerBox;
        private System.Windows.Forms.Button tilfoejKnap;
        private System.Windows.Forms.TextBox ingrediensNavnBox;
    }
}