namespace MadspildGUI
{
    partial class MadspildGUI
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
            this.navBar = new System.Windows.Forms.TabControl();
            this.indkoeb = new System.Windows.Forms.TabPage();
            this.husbeholdning = new System.Windows.Forms.TabPage();
            this.funktionsKnapper = new System.Windows.Forms.FlowLayoutPanel();
            this.tilfoejVareKnap = new System.Windows.Forms.Button();
            this.sletVareKnap = new System.Windows.Forms.Button();
            this.ListBoxVarerIHus = new System.Windows.Forms.ListBox();
            this.opskrifter = new System.Windows.Forms.TabPage();
            this.navBar.SuspendLayout();
            this.husbeholdning.SuspendLayout();
            this.funktionsKnapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.Controls.Add(this.husbeholdning);
            this.navBar.Controls.Add(this.indkoeb);
            this.navBar.Controls.Add(this.opskrifter);
            this.navBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.SelectedIndex = 0;
            this.navBar.Size = new System.Drawing.Size(408, 329);
            this.navBar.TabIndex = 0;
            // 
            // indkoeb
            // 
            this.indkoeb.Location = new System.Drawing.Point(4, 22);
            this.indkoeb.Name = "indkoeb";
            this.indkoeb.Padding = new System.Windows.Forms.Padding(3);
            this.indkoeb.Size = new System.Drawing.Size(400, 303);
            this.indkoeb.TabIndex = 0;
            this.indkoeb.Tag = "";
            this.indkoeb.Text = "Indkøbskurv";
            this.indkoeb.UseVisualStyleBackColor = true;
            // 
            // husbeholdning
            // 
            this.husbeholdning.Controls.Add(this.funktionsKnapper);
            this.husbeholdning.Controls.Add(this.ListBoxVarerIHus);
            this.husbeholdning.Location = new System.Drawing.Point(4, 22);
            this.husbeholdning.Name = "husbeholdning";
            this.husbeholdning.Padding = new System.Windows.Forms.Padding(3);
            this.husbeholdning.Size = new System.Drawing.Size(400, 303);
            this.husbeholdning.TabIndex = 1;
            this.husbeholdning.Text = "Husbeholdning";
            this.husbeholdning.UseVisualStyleBackColor = true;
            // 
            // funktionsKnapper
            // 
            this.funktionsKnapper.Controls.Add(this.tilfoejVareKnap);
            this.funktionsKnapper.Controls.Add(this.sletVareKnap);
            this.funktionsKnapper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.funktionsKnapper.Location = new System.Drawing.Point(3, 271);
            this.funktionsKnapper.Name = "funktionsKnapper";
            this.funktionsKnapper.Size = new System.Drawing.Size(394, 29);
            this.funktionsKnapper.TabIndex = 1;
            // 
            // tilfoejVareKnap
            // 
            this.tilfoejVareKnap.Location = new System.Drawing.Point(3, 3);
            this.tilfoejVareKnap.Name = "tilfoejVareKnap";
            this.tilfoejVareKnap.Size = new System.Drawing.Size(75, 23);
            this.tilfoejVareKnap.TabIndex = 0;
            this.tilfoejVareKnap.Text = "Tilføj Vare";
            this.tilfoejVareKnap.UseVisualStyleBackColor = true;
            this.tilfoejVareKnap.Click += new System.EventHandler(this.tilfoejVareKnap_Click);
            // 
            // sletVareKnap
            // 
            this.sletVareKnap.Location = new System.Drawing.Point(84, 3);
            this.sletVareKnap.Name = "sletVareKnap";
            this.sletVareKnap.Size = new System.Drawing.Size(75, 23);
            this.sletVareKnap.TabIndex = 1;
            this.sletVareKnap.Text = "Slet Vare";
            this.sletVareKnap.UseVisualStyleBackColor = true;
            this.sletVareKnap.Click += new System.EventHandler(this.sletVareKnap_Click);
            // 
            // ListBoxVarerIHus
            // 
            this.ListBoxVarerIHus.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListBoxVarerIHus.FormattingEnabled = true;
            this.ListBoxVarerIHus.Location = new System.Drawing.Point(3, 3);
            this.ListBoxVarerIHus.Name = "ListBoxVarerIHus";
            this.ListBoxVarerIHus.Size = new System.Drawing.Size(394, 264);
            this.ListBoxVarerIHus.TabIndex = 0;
            this.ListBoxVarerIHus.DoubleClick += new System.EventHandler(this.ListBoxVarerIHus_DoubleClick);
            // 
            // opskrifter
            // 
            this.opskrifter.Location = new System.Drawing.Point(4, 22);
            this.opskrifter.Name = "opskrifter";
            this.opskrifter.Size = new System.Drawing.Size(400, 303);
            this.opskrifter.TabIndex = 2;
            this.opskrifter.Text = "Opskrifter";
            this.opskrifter.UseVisualStyleBackColor = true;
            // 
            // MadspildGUI
            // 
            this.ClientSize = new System.Drawing.Size(408, 329);
            this.Controls.Add(this.navBar);
            this.Name = "MadspildGUI";
            this.Shown += new System.EventHandler(this.MadspildGUI_Shown);
            this.navBar.ResumeLayout(false);
            this.husbeholdning.ResumeLayout(false);
            this.funktionsKnapper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl navBar;
        private System.Windows.Forms.TabPage indkoeb;
        public System.Windows.Forms.TabPage husbeholdning;
        public System.Windows.Forms.ListBox ListBoxVarerIHus;
        private System.Windows.Forms.TabPage opskrifter;
        private System.Windows.Forms.FlowLayoutPanel funktionsKnapper;
        private System.Windows.Forms.Button tilfoejVareKnap;
        private System.Windows.Forms.Button sletVareKnap;
    }
}

