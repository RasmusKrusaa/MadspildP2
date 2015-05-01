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
            this.husbeholdning = new System.Windows.Forms.TabPage();
            this.funktionsKnapperHus = new System.Windows.Forms.FlowLayoutPanel();
            this.tilfoejVareKnap = new System.Windows.Forms.Button();
            this.sletVareKnap = new System.Windows.Forms.Button();
            this.ListBoxVarerIHus = new System.Windows.Forms.ListBox();
            this.indkoeb = new System.Windows.Forms.TabPage();
            this.opskrifter = new System.Windows.Forms.TabPage();
            this.ydreTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.indreTopTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxOpskrifter = new System.Windows.Forms.ListBox();
            this.listBoxOpskriftInfo = new System.Windows.Forms.ListBox();
            this.funktionsKnapperOpskrifter = new System.Windows.Forms.FlowLayoutPanel();
            this.tilfoejOpskriftKnap = new System.Windows.Forms.Button();
            this.husholdningTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.foreslaaOpskrifterEfterBeholdningKnap = new System.Windows.Forms.Button();
            this.navBar.SuspendLayout();
            this.husbeholdning.SuspendLayout();
            this.funktionsKnapperHus.SuspendLayout();
            this.opskrifter.SuspendLayout();
            this.ydreTablePanel.SuspendLayout();
            this.indreTopTablePanel.SuspendLayout();
            this.funktionsKnapperOpskrifter.SuspendLayout();
            this.husholdningTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.Controls.Add(this.husbeholdning);
            this.navBar.Controls.Add(this.indkoeb);
            this.navBar.Controls.Add(this.opskrifter);
            this.navBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Margin = new System.Windows.Forms.Padding(0);
            this.navBar.Name = "navBar";
            this.navBar.SelectedIndex = 0;
            this.navBar.Size = new System.Drawing.Size(408, 329);
            this.navBar.TabIndex = 0;
            // 
            // husbeholdning
            // 
            this.husbeholdning.Controls.Add(this.husholdningTablePanel);
            this.husbeholdning.Location = new System.Drawing.Point(4, 22);
            this.husbeholdning.Name = "husbeholdning";
            this.husbeholdning.Padding = new System.Windows.Forms.Padding(3);
            this.husbeholdning.Size = new System.Drawing.Size(400, 303);
            this.husbeholdning.TabIndex = 1;
            this.husbeholdning.Text = "Husbeholdning";
            this.husbeholdning.UseVisualStyleBackColor = true;
            // 
            // funktionsKnapperHus
            // 
            this.funktionsKnapperHus.Controls.Add(this.tilfoejVareKnap);
            this.funktionsKnapperHus.Controls.Add(this.sletVareKnap);
            this.funktionsKnapperHus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.funktionsKnapperHus.Location = new System.Drawing.Point(3, 266);
            this.funktionsKnapperHus.Name = "funktionsKnapperHus";
            this.funktionsKnapperHus.Size = new System.Drawing.Size(388, 28);
            this.funktionsKnapperHus.TabIndex = 1;
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
            this.ListBoxVarerIHus.FormattingEnabled = true;
            this.ListBoxVarerIHus.Location = new System.Drawing.Point(3, 3);
            this.ListBoxVarerIHus.Name = "ListBoxVarerIHus";
            this.ListBoxVarerIHus.Size = new System.Drawing.Size(388, 251);
            this.ListBoxVarerIHus.TabIndex = 0;
            this.ListBoxVarerIHus.DoubleClick += new System.EventHandler(this.ListBoxVarerIHus_DoubleClick);
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
            // opskrifter
            // 
            this.opskrifter.Controls.Add(this.ydreTablePanel);
            this.opskrifter.Location = new System.Drawing.Point(4, 22);
            this.opskrifter.Name = "opskrifter";
            this.opskrifter.Padding = new System.Windows.Forms.Padding(3);
            this.opskrifter.Size = new System.Drawing.Size(400, 303);
            this.opskrifter.TabIndex = 2;
            this.opskrifter.Text = "Opskrifter";
            this.opskrifter.UseVisualStyleBackColor = true;
            // 
            // ydreTablePanel
            // 
            this.ydreTablePanel.ColumnCount = 1;
            this.ydreTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ydreTablePanel.Controls.Add(this.indreTopTablePanel, 0, 0);
            this.ydreTablePanel.Controls.Add(this.funktionsKnapperOpskrifter, 0, 1);
            this.ydreTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ydreTablePanel.Location = new System.Drawing.Point(3, 3);
            this.ydreTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.ydreTablePanel.Name = "ydreTablePanel";
            this.ydreTablePanel.RowCount = 2;
            this.ydreTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.21549F));
            this.ydreTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.78451F));
            this.ydreTablePanel.Size = new System.Drawing.Size(394, 297);
            this.ydreTablePanel.TabIndex = 2;
            // 
            // indreTopTablePanel
            // 
            this.indreTopTablePanel.ColumnCount = 2;
            this.indreTopTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.20618F));
            this.indreTopTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.79382F));
            this.indreTopTablePanel.Controls.Add(this.listBoxOpskrifter, 0, 0);
            this.indreTopTablePanel.Controls.Add(this.listBoxOpskriftInfo, 1, 0);
            this.indreTopTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.indreTopTablePanel.Location = new System.Drawing.Point(0, 0);
            this.indreTopTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.indreTopTablePanel.Name = "indreTopTablePanel";
            this.indreTopTablePanel.RowCount = 1;
            this.indreTopTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.indreTopTablePanel.Size = new System.Drawing.Size(394, 262);
            this.indreTopTablePanel.TabIndex = 0;
            // 
            // listBoxOpskrifter
            // 
            this.listBoxOpskrifter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOpskrifter.FormattingEnabled = true;
            this.listBoxOpskrifter.Location = new System.Drawing.Point(3, 3);
            this.listBoxOpskrifter.Name = "listBoxOpskrifter";
            this.listBoxOpskrifter.Size = new System.Drawing.Size(152, 256);
            this.listBoxOpskrifter.TabIndex = 0;
            this.listBoxOpskrifter.DoubleClick += new System.EventHandler(this.listBoxOpskrifter_DoubleClick);
            // 
            // listBoxOpskriftInfo
            // 
            this.listBoxOpskriftInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOpskriftInfo.FormattingEnabled = true;
            this.listBoxOpskriftInfo.HorizontalScrollbar = true;
            this.listBoxOpskriftInfo.Location = new System.Drawing.Point(161, 3);
            this.listBoxOpskriftInfo.Name = "listBoxOpskriftInfo";
            this.listBoxOpskriftInfo.Size = new System.Drawing.Size(230, 256);
            this.listBoxOpskriftInfo.TabIndex = 1;
            // 
            // funktionsKnapperOpskrifter
            // 
            this.funktionsKnapperOpskrifter.Controls.Add(this.tilfoejOpskriftKnap);
            this.funktionsKnapperOpskrifter.Controls.Add(this.foreslaaOpskrifterEfterBeholdningKnap);
            this.funktionsKnapperOpskrifter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.funktionsKnapperOpskrifter.Location = new System.Drawing.Point(3, 265);
            this.funktionsKnapperOpskrifter.Name = "funktionsKnapperOpskrifter";
            this.funktionsKnapperOpskrifter.Size = new System.Drawing.Size(388, 29);
            this.funktionsKnapperOpskrifter.TabIndex = 1;
            // 
            // tilfoejOpskriftKnap
            // 
            this.tilfoejOpskriftKnap.Location = new System.Drawing.Point(3, 3);
            this.tilfoejOpskriftKnap.Name = "tilfoejOpskriftKnap";
            this.tilfoejOpskriftKnap.Size = new System.Drawing.Size(75, 23);
            this.tilfoejOpskriftKnap.TabIndex = 0;
            this.tilfoejOpskriftKnap.Text = "Tilføj opskrift";
            this.tilfoejOpskriftKnap.UseVisualStyleBackColor = true;
            // 
            // husholdningTablePanel
            // 
            this.husholdningTablePanel.ColumnCount = 1;
            this.husholdningTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.husholdningTablePanel.Controls.Add(this.funktionsKnapperHus, 0, 1);
            this.husholdningTablePanel.Controls.Add(this.ListBoxVarerIHus, 0, 0);
            this.husholdningTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.husholdningTablePanel.Location = new System.Drawing.Point(3, 3);
            this.husholdningTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.husholdningTablePanel.Name = "husholdningTablePanel";
            this.husholdningTablePanel.RowCount = 2;
            this.husholdningTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.81407F));
            this.husholdningTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.18593F));
            this.husholdningTablePanel.Size = new System.Drawing.Size(394, 297);
            this.husholdningTablePanel.TabIndex = 2;
            // 
            // foreslaaOpskrifterEfterBeholdningKnap
            // 
            this.foreslaaOpskrifterEfterBeholdningKnap.Location = new System.Drawing.Point(84, 3);
            this.foreslaaOpskrifterEfterBeholdningKnap.Name = "foreslaaOpskrifterEfterBeholdningKnap";
            this.foreslaaOpskrifterEfterBeholdningKnap.Size = new System.Drawing.Size(75, 23);
            this.foreslaaOpskrifterEfterBeholdningKnap.TabIndex = 1;
            this.foreslaaOpskrifterEfterBeholdningKnap.Text = "Foreslå1";
            this.foreslaaOpskrifterEfterBeholdningKnap.UseVisualStyleBackColor = true;
            this.foreslaaOpskrifterEfterBeholdningKnap.Click += new System.EventHandler(this.foreslaaOpskrifterEfterBeholdningKnap_Click);
            // 
            // MadspildGUI
            // 
            this.ClientSize = new System.Drawing.Size(408, 329);
            this.Controls.Add(this.navBar);
            this.Name = "MadspildGUI";
            this.Shown += new System.EventHandler(this.MadspildGUI_Shown);
            this.navBar.ResumeLayout(false);
            this.husbeholdning.ResumeLayout(false);
            this.funktionsKnapperHus.ResumeLayout(false);
            this.opskrifter.ResumeLayout(false);
            this.ydreTablePanel.ResumeLayout(false);
            this.indreTopTablePanel.ResumeLayout(false);
            this.funktionsKnapperOpskrifter.ResumeLayout(false);
            this.husholdningTablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl navBar;
        private System.Windows.Forms.TabPage indkoeb;
        public System.Windows.Forms.TabPage husbeholdning;
        public System.Windows.Forms.ListBox ListBoxVarerIHus;
        private System.Windows.Forms.FlowLayoutPanel funktionsKnapperHus;
        private System.Windows.Forms.Button tilfoejVareKnap;
        private System.Windows.Forms.Button sletVareKnap;
        private System.Windows.Forms.TabPage opskrifter;
        private System.Windows.Forms.TableLayoutPanel ydreTablePanel;
        private System.Windows.Forms.TableLayoutPanel indreTopTablePanel;
        private System.Windows.Forms.ListBox listBoxOpskriftInfo;
        public System.Windows.Forms.ListBox listBoxOpskrifter;
        private System.Windows.Forms.FlowLayoutPanel funktionsKnapperOpskrifter;
        private System.Windows.Forms.Button tilfoejOpskriftKnap;
        private System.Windows.Forms.TableLayoutPanel husholdningTablePanel;
        private System.Windows.Forms.Button foreslaaOpskrifterEfterBeholdningKnap;
    }
}

