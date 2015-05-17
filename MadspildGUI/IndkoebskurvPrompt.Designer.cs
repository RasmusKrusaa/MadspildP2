namespace MadspildGUI
{
    partial class IndkoebskurvPrompt
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxIndkoebProduktKatalog = new System.Windows.Forms.ListBox();
            this.listBoxIndkoebIndkoebskurv = new System.Windows.Forms.ListBox();
            this.IndkoebskurvTilfoejtilMidlertidigIndkoebskurv = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listBoxIndkoebProduktKatalog, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxIndkoebIndkoebskurv, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.IndkoebskurvTilfoejtilMidlertidigIndkoebskurv, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.58798F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.41202F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(291, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listBoxIndkoebProduktKatalog
            // 
            this.listBoxIndkoebProduktKatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxIndkoebProduktKatalog.FormattingEnabled = true;
            this.listBoxIndkoebProduktKatalog.Location = new System.Drawing.Point(3, 30);
            this.listBoxIndkoebProduktKatalog.Name = "listBoxIndkoebProduktKatalog";
            this.listBoxIndkoebProduktKatalog.Size = new System.Drawing.Size(139, 200);
            this.listBoxIndkoebProduktKatalog.TabIndex = 0;
            this.listBoxIndkoebProduktKatalog.SelectedIndexChanged += new System.EventHandler(this.listBoxIndkoebProduktKatalog_SelectedIndexChanged);
            // 
            // listBoxIndkoebIndkoebskurv
            // 
            this.listBoxIndkoebIndkoebskurv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxIndkoebIndkoebskurv.FormattingEnabled = true;
            this.listBoxIndkoebIndkoebskurv.Location = new System.Drawing.Point(148, 30);
            this.listBoxIndkoebIndkoebskurv.Name = "listBoxIndkoebIndkoebskurv";
            this.listBoxIndkoebIndkoebskurv.Size = new System.Drawing.Size(140, 200);
            this.listBoxIndkoebIndkoebskurv.TabIndex = 1;
            this.listBoxIndkoebIndkoebskurv.SelectedIndexChanged += new System.EventHandler(this.listBoxIndkoebIndkoebskurv_SelectedIndexChanged);
            // 
            // IndkoebskurvTilfoejtilMidlertidigIndkoebskurv
            // 
            this.IndkoebskurvTilfoejtilMidlertidigIndkoebskurv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IndkoebskurvTilfoejtilMidlertidigIndkoebskurv.Location = new System.Drawing.Point(3, 236);
            this.IndkoebskurvTilfoejtilMidlertidigIndkoebskurv.Name = "IndkoebskurvTilfoejtilMidlertidigIndkoebskurv";
            this.IndkoebskurvTilfoejtilMidlertidigIndkoebskurv.Size = new System.Drawing.Size(139, 22);
            this.IndkoebskurvTilfoejtilMidlertidigIndkoebskurv.TabIndex = 3;
            this.IndkoebskurvTilfoejtilMidlertidigIndkoebskurv.Text = "Tilføj Vare";
            this.IndkoebskurvTilfoejtilMidlertidigIndkoebskurv.UseVisualStyleBackColor = true;
            this.IndkoebskurvTilfoejtilMidlertidigIndkoebskurv.Click += new System.EventHandler(this.IndkoebskurvTilfoejtilMidlertidigIndkoebskurv_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Søg";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_TextEnter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_TextLeave);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(148, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 22);
            this.button1.TabIndex = 5;
            this.button1.Text = "Slet Vare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.InkoebskurvSletVareMidlertidigIndkoebskurv_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 21);
            this.button2.TabIndex = 6;
            this.button2.Text = "Tilføj til Indkøbskurv";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.TilføjTilInkoebskruv_Click);
            // 
            // IndkoebskurvPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "IndkoebskurvPrompt";
            this.Text = "Indkøbskurv";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBoxIndkoebProduktKatalog;
        private System.Windows.Forms.ListBox listBoxIndkoebIndkoebskurv;
        private System.Windows.Forms.Button IndkoebskurvTilfoejtilMidlertidigIndkoebskurv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button button2;
    }
}