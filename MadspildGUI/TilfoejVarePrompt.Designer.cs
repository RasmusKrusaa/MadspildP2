namespace MadspildGUI
{
    partial class TilfoejVarePrompt
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
            this.tilfoejKnap = new System.Windows.Forms.Button();
            this.volumenBox = new System.Windows.Forms.TextBox();
            this.navnBox = new System.Windows.Forms.TextBox();
            this.datoVaelger = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sidsteAnvKnap = new System.Windows.Forms.RadioButton();
            this.mindstHoldbarKnap = new System.Windows.Forms.RadioButton();
            this.vaegtKnap = new System.Windows.Forms.RadioButton();
            this.stkKnap = new System.Windows.Forms.RadioButton();
            this.topLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.bundLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.topLayout.SuspendLayout();
            this.bundLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tilfoejKnap
            // 
            this.tilfoejKnap.Location = new System.Drawing.Point(3, 115);
            this.tilfoejKnap.Name = "tilfoejKnap";
            this.tilfoejKnap.Size = new System.Drawing.Size(75, 23);
            this.tilfoejKnap.TabIndex = 0;
            this.tilfoejKnap.Text = "Tilføj";
            this.tilfoejKnap.UseVisualStyleBackColor = true;
            this.tilfoejKnap.Click += new System.EventHandler(this.tilfoejKnap_Click);
            // 
            // volumenBox
            // 
            this.volumenBox.Location = new System.Drawing.Point(3, 94);
            this.volumenBox.Multiline = true;
            this.volumenBox.Name = "volumenBox";
            this.volumenBox.Size = new System.Drawing.Size(100, 20);
            this.volumenBox.TabIndex = 2;
            this.volumenBox.Text = "Indtast volumen";
            // 
            // navnBox
            // 
            this.navnBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.navnBox.Location = new System.Drawing.Point(3, 3);
            this.navnBox.Name = "navnBox";
            this.navnBox.Size = new System.Drawing.Size(100, 20);
            this.navnBox.TabIndex = 3;
            this.navnBox.Text = "Indtast varenavn";
            // 
            // datoVaelger
            // 
            this.datoVaelger.Location = new System.Drawing.Point(3, 89);
            this.datoVaelger.Name = "datoVaelger";
            this.datoVaelger.Size = new System.Drawing.Size(200, 20);
            this.datoVaelger.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(246, 36);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Vælg mellem stk eller vægt og indtast derefter en værdi";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(246, 57);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Vælg mellem sidste anvendelses- eller mindst holdbarhedsdato og vælg derefter en " +
    "dato";
            // 
            // sidsteAnvKnap
            // 
            this.sidsteAnvKnap.AutoSize = true;
            this.sidsteAnvKnap.Location = new System.Drawing.Point(3, 66);
            this.sidsteAnvKnap.Name = "sidsteAnvKnap";
            this.sidsteAnvKnap.Size = new System.Drawing.Size(112, 17);
            this.sidsteAnvKnap.TabIndex = 10;
            this.sidsteAnvKnap.TabStop = true;
            this.sidsteAnvKnap.Text = "Sidste anvendelse";
            this.sidsteAnvKnap.UseVisualStyleBackColor = true;
            // 
            // mindstHoldbarKnap
            // 
            this.mindstHoldbarKnap.AutoSize = true;
            this.mindstHoldbarKnap.Location = new System.Drawing.Point(121, 66);
            this.mindstHoldbarKnap.Name = "mindstHoldbarKnap";
            this.mindstHoldbarKnap.Size = new System.Drawing.Size(112, 17);
            this.mindstHoldbarKnap.TabIndex = 11;
            this.mindstHoldbarKnap.TabStop = true;
            this.mindstHoldbarKnap.Text = "Mindst holdbarhed";
            this.mindstHoldbarKnap.UseVisualStyleBackColor = true;
            // 
            // vaegtKnap
            // 
            this.vaegtKnap.AutoSize = true;
            this.vaegtKnap.Location = new System.Drawing.Point(3, 71);
            this.vaegtKnap.Name = "vaegtKnap";
            this.vaegtKnap.Size = new System.Drawing.Size(51, 17);
            this.vaegtKnap.TabIndex = 12;
            this.vaegtKnap.TabStop = true;
            this.vaegtKnap.Text = "Vægt";
            this.vaegtKnap.UseVisualStyleBackColor = true;
            // 
            // stkKnap
            // 
            this.stkKnap.AutoSize = true;
            this.topLayout.SetFlowBreak(this.stkKnap, true);
            this.stkKnap.Location = new System.Drawing.Point(60, 71);
            this.stkKnap.Name = "stkKnap";
            this.stkKnap.Size = new System.Drawing.Size(41, 17);
            this.stkKnap.TabIndex = 13;
            this.stkKnap.TabStop = true;
            this.stkKnap.Text = "Stk";
            this.stkKnap.UseVisualStyleBackColor = true;
            // 
            // topLayout
            // 
            this.topLayout.Controls.Add(this.navnBox);
            this.topLayout.Controls.Add(this.textBox1);
            this.topLayout.Controls.Add(this.vaegtKnap);
            this.topLayout.Controls.Add(this.stkKnap);
            this.topLayout.Controls.Add(this.volumenBox);
            this.topLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLayout.Location = new System.Drawing.Point(0, 0);
            this.topLayout.Name = "topLayout";
            this.topLayout.Size = new System.Drawing.Size(277, 122);
            this.topLayout.TabIndex = 14;
            // 
            // bundLayout
            // 
            this.bundLayout.Controls.Add(this.textBox2);
            this.bundLayout.Controls.Add(this.sidsteAnvKnap);
            this.bundLayout.Controls.Add(this.mindstHoldbarKnap);
            this.bundLayout.Controls.Add(this.datoVaelger);
            this.bundLayout.Controls.Add(this.tilfoejKnap);
            this.bundLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bundLayout.Location = new System.Drawing.Point(0, 125);
            this.bundLayout.Name = "bundLayout";
            this.bundLayout.Size = new System.Drawing.Size(277, 139);
            this.bundLayout.TabIndex = 15;
            // 
            // TilfoejVarePrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 264);
            this.Controls.Add(this.topLayout);
            this.Controls.Add(this.bundLayout);
            this.Name = "TilfoejVarePrompt";
            this.Text = "Tilføj Vare";
            this.topLayout.ResumeLayout(false);
            this.topLayout.PerformLayout();
            this.bundLayout.ResumeLayout(false);
            this.bundLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tilfoejKnap;
        private System.Windows.Forms.TextBox volumenBox;
        private System.Windows.Forms.TextBox navnBox;
        private System.Windows.Forms.DateTimePicker datoVaelger;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton sidsteAnvKnap;
        private System.Windows.Forms.RadioButton mindstHoldbarKnap;
        private System.Windows.Forms.RadioButton vaegtKnap;
        private System.Windows.Forms.RadioButton stkKnap;
        private System.Windows.Forms.FlowLayoutPanel topLayout;
        private System.Windows.Forms.FlowLayoutPanel bundLayout;
    }
}