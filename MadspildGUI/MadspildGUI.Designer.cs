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
            this.husholdningTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.funktionsKnapperHus = new System.Windows.Forms.FlowLayoutPanel();
            this.tilfoejVareKnapHus = new System.Windows.Forms.Button();
            this.sletVareKnapHus = new System.Windows.Forms.Button();
            this.ListBoxVarerIHus = new System.Windows.Forms.ListBox();
            this.indkoeb = new System.Windows.Forms.TabPage();
            this.ListBoxIndkoeb = new System.Windows.Forms.ListBox();
            this.FunktionsKnapperIndKoeb = new System.Windows.Forms.FlowLayoutPanel();
            this.TilfoejVareKnapIndkoeb = new System.Windows.Forms.Button();
            this.SletVareKnapIndkoeb = new System.Windows.Forms.Button();
            this.TilfoejTilBeholdningKnap = new System.Windows.Forms.Button();
            this.opskrifter = new System.Windows.Forms.TabPage();
            this.ydreTablePanelOpskrifter = new System.Windows.Forms.TableLayoutPanel();
            this.indreTopTablePanelOpskrifter = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxOpskrifter = new System.Windows.Forms.ListBox();
            this.listBoxOpskriftInfo = new System.Windows.Forms.ListBox();
            this.funktionsKnapperOpskrifter = new System.Windows.Forms.FlowLayoutPanel();
            this.tilfoejOpskriftKnap = new System.Windows.Forms.Button();
            this.foreslaaOpskrifterEfterBeholdningKnap = new System.Windows.Forms.Button();
            this.navBar.SuspendLayout();
            this.husbeholdning.SuspendLayout();
            this.husholdningTablePanel.SuspendLayout();
            this.funktionsKnapperHus.SuspendLayout();
            this.indkoeb.SuspendLayout();
            this.FunktionsKnapperIndKoeb.SuspendLayout();
            this.opskrifter.SuspendLayout();
            this.ydreTablePanelOpskrifter.SuspendLayout();
            this.indreTopTablePanelOpskrifter.SuspendLayout();
            this.funktionsKnapperOpskrifter.SuspendLayout();
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
            // funktionsKnapperHus
            // 
            this.funktionsKnapperHus.Controls.Add(this.tilfoejVareKnapHus);
            this.funktionsKnapperHus.Controls.Add(this.sletVareKnapHus);
            this.funktionsKnapperHus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.funktionsKnapperHus.Location = new System.Drawing.Point(3, 266);
            this.funktionsKnapperHus.Name = "funktionsKnapperHus";
            this.funktionsKnapperHus.Size = new System.Drawing.Size(388, 28);
            this.funktionsKnapperHus.TabIndex = 1;
            // 
            // tilfoejVareKnapHus
            // 
            this.tilfoejVareKnapHus.Location = new System.Drawing.Point(3, 3);
            this.tilfoejVareKnapHus.Name = "tilfoejVareKnapHus";
            this.tilfoejVareKnapHus.Size = new System.Drawing.Size(75, 23);
            this.tilfoejVareKnapHus.TabIndex = 0;
            this.tilfoejVareKnapHus.Text = "Tilføj Vare";
            this.tilfoejVareKnapHus.UseVisualStyleBackColor = true;
            this.tilfoejVareKnapHus.Click += new System.EventHandler(this.tilfoejVareKnap_Click);
            // 
            // sletVareKnapHus
            // 
            this.sletVareKnapHus.Location = new System.Drawing.Point(84, 3);
            this.sletVareKnapHus.Name = "sletVareKnapHus";
            this.sletVareKnapHus.Size = new System.Drawing.Size(75, 23);
            this.sletVareKnapHus.TabIndex = 1;
            this.sletVareKnapHus.Text = "Slet Vare";
            this.sletVareKnapHus.UseVisualStyleBackColor = true;
            this.sletVareKnapHus.Click += new System.EventHandler(this.sletVareKnap_Click);
            // 
            // ListBoxVarerIHus
            // 
            this.ListBoxVarerIHus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxVarerIHus.FormattingEnabled = true;
            this.ListBoxVarerIHus.Location = new System.Drawing.Point(3, 3);
            this.ListBoxVarerIHus.Name = "ListBoxVarerIHus";
            this.ListBoxVarerIHus.Size = new System.Drawing.Size(388, 257);
            this.ListBoxVarerIHus.TabIndex = 0;
            this.ListBoxVarerIHus.DoubleClick += new System.EventHandler(this.ListBoxVarerIHus_DoubleClick);
            // 
            // indkoeb
            // 
            this.indkoeb.Controls.Add(this.ListBoxIndkoeb);
            this.indkoeb.Controls.Add(this.FunktionsKnapperIndKoeb);
            this.indkoeb.Location = new System.Drawing.Point(4, 22);
            this.indkoeb.Name = "indkoeb";
            this.indkoeb.Padding = new System.Windows.Forms.Padding(3);
            this.indkoeb.Size = new System.Drawing.Size(400, 303);
            this.indkoeb.TabIndex = 0;
            this.indkoeb.Tag = "";
            this.indkoeb.Text = "Indkøbskurv";
            this.indkoeb.UseVisualStyleBackColor = true;
            // 
            // ListBoxIndkoeb
            // 
            this.ListBoxIndkoeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxIndkoeb.FormattingEnabled = true;
            this.ListBoxIndkoeb.Location = new System.Drawing.Point(3, 3);
            this.ListBoxIndkoeb.Name = "ListBoxIndkoeb";
            this.ListBoxIndkoeb.Size = new System.Drawing.Size(394, 270);
            this.ListBoxIndkoeb.TabIndex = 3;
            this.ListBoxIndkoeb.SelectedIndexChanged += new System.EventHandler(this.ListBoxIndkoeb_SelectedIndexChanged);
            this.ListBoxIndkoeb.DoubleClick += new System.EventHandler(this.ListBoxIndkoeb_Doubleclick);
            // 
            // FunktionsKnapperIndKoeb
            // 
            this.FunktionsKnapperIndKoeb.Controls.Add(this.TilfoejVareKnapIndkoeb);
            this.FunktionsKnapperIndKoeb.Controls.Add(this.SletVareKnapIndkoeb);
            this.FunktionsKnapperIndKoeb.Controls.Add(this.TilfoejTilBeholdningKnap);
            this.FunktionsKnapperIndKoeb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FunktionsKnapperIndKoeb.Location = new System.Drawing.Point(3, 273);
            this.FunktionsKnapperIndKoeb.Name = "FunktionsKnapperIndKoeb";
            this.FunktionsKnapperIndKoeb.Size = new System.Drawing.Size(394, 27);
            this.FunktionsKnapperIndKoeb.TabIndex = 2;
            // 
            // TilfoejVareKnapIndkoeb
            // 
            this.TilfoejVareKnapIndkoeb.Location = new System.Drawing.Point(3, 3);
            this.TilfoejVareKnapIndkoeb.Name = "TilfoejVareKnapIndkoeb";
            this.TilfoejVareKnapIndkoeb.Size = new System.Drawing.Size(75, 23);
            this.TilfoejVareKnapIndkoeb.TabIndex = 0;
            this.TilfoejVareKnapIndkoeb.Text = "Tilføj Vare";
            this.TilfoejVareKnapIndkoeb.UseVisualStyleBackColor = true;
            this.TilfoejVareKnapIndkoeb.Click += new System.EventHandler(this.TilfoejVareKnapIndkoeb_Click);
            // 
            // SletVareKnapIndkoeb
            // 
            this.SletVareKnapIndkoeb.Location = new System.Drawing.Point(84, 3);
            this.SletVareKnapIndkoeb.Name = "SletVareKnapIndkoeb";
            this.SletVareKnapIndkoeb.Size = new System.Drawing.Size(75, 23);
            this.SletVareKnapIndkoeb.TabIndex = 3;
            this.SletVareKnapIndkoeb.Text = "Slet Vare";
            this.SletVareKnapIndkoeb.UseVisualStyleBackColor = true;
            this.SletVareKnapIndkoeb.Click += new System.EventHandler(this.SletVareKnapIndkoeb_Click);
            // 
            // TilfoejTilBeholdningKnap
            // 
            this.TilfoejTilBeholdningKnap.Location = new System.Drawing.Point(165, 3);
            this.TilfoejTilBeholdningKnap.Name = "TilfoejTilBeholdningKnap";
            this.TilfoejTilBeholdningKnap.Size = new System.Drawing.Size(125, 23);
            this.TilfoejTilBeholdningKnap.TabIndex = 4;
            this.TilfoejTilBeholdningKnap.Text = "Tilføj til husbeholdning";
            this.TilfoejTilBeholdningKnap.UseVisualStyleBackColor = true;
            this.TilfoejTilBeholdningKnap.Click += new System.EventHandler(this.TiljoejTilBeholdningKnap_Click);
            // 
            // opskrifter
            // 
            this.opskrifter.Controls.Add(this.ydreTablePanelOpskrifter);
            this.opskrifter.Location = new System.Drawing.Point(4, 22);
            this.opskrifter.Name = "opskrifter";
            this.opskrifter.Padding = new System.Windows.Forms.Padding(3);
            this.opskrifter.Size = new System.Drawing.Size(400, 303);
            this.opskrifter.TabIndex = 2;
            this.opskrifter.Text = "Opskrifter";
            this.opskrifter.UseVisualStyleBackColor = true;
            // 
            // ydreTablePanelOpskrifter
            // 
            this.ydreTablePanelOpskrifter.ColumnCount = 1;
            this.ydreTablePanelOpskrifter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ydreTablePanelOpskrifter.Controls.Add(this.indreTopTablePanelOpskrifter, 0, 0);
            this.ydreTablePanelOpskrifter.Controls.Add(this.funktionsKnapperOpskrifter, 0, 1);
            this.ydreTablePanelOpskrifter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ydreTablePanelOpskrifter.Location = new System.Drawing.Point(3, 3);
            this.ydreTablePanelOpskrifter.Margin = new System.Windows.Forms.Padding(0);
            this.ydreTablePanelOpskrifter.Name = "ydreTablePanelOpskrifter";
            this.ydreTablePanelOpskrifter.RowCount = 2;
            this.ydreTablePanelOpskrifter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.21549F));
            this.ydreTablePanelOpskrifter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.78451F));
            this.ydreTablePanelOpskrifter.Size = new System.Drawing.Size(394, 297);
            this.ydreTablePanelOpskrifter.TabIndex = 2;
            // 
            // indreTopTablePanelOpskrifter
            // 
            this.indreTopTablePanelOpskrifter.ColumnCount = 2;
            this.indreTopTablePanelOpskrifter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.20618F));
            this.indreTopTablePanelOpskrifter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.79382F));
            this.indreTopTablePanelOpskrifter.Controls.Add(this.listBoxOpskrifter, 0, 0);
            this.indreTopTablePanelOpskrifter.Controls.Add(this.listBoxOpskriftInfo, 1, 0);
            this.indreTopTablePanelOpskrifter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.indreTopTablePanelOpskrifter.Location = new System.Drawing.Point(0, 0);
            this.indreTopTablePanelOpskrifter.Margin = new System.Windows.Forms.Padding(0);
            this.indreTopTablePanelOpskrifter.Name = "indreTopTablePanelOpskrifter";
            this.indreTopTablePanelOpskrifter.RowCount = 1;
            this.indreTopTablePanelOpskrifter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.indreTopTablePanelOpskrifter.Size = new System.Drawing.Size(394, 262);
            this.indreTopTablePanelOpskrifter.TabIndex = 0;
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
            this.tilfoejOpskriftKnap.Click += new System.EventHandler(this.tilfoejOpskriftKnap_Click);
            // 
            // foreslaaOpskrifterEfterBeholdningKnap
            // 
            this.foreslaaOpskrifterEfterBeholdningKnap.Location = new System.Drawing.Point(84, 3);
            this.foreslaaOpskrifterEfterBeholdningKnap.Name = "foreslaaOpskrifterEfterBeholdningKnap";
            this.foreslaaOpskrifterEfterBeholdningKnap.Size = new System.Drawing.Size(133, 23);
            this.foreslaaOpskrifterEfterBeholdningKnap.TabIndex = 1;
            this.foreslaaOpskrifterEfterBeholdningKnap.Text = "Foreslå efter husholdning";
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
            this.husholdningTablePanel.ResumeLayout(false);
            this.funktionsKnapperHus.ResumeLayout(false);
            this.indkoeb.ResumeLayout(false);
            this.FunktionsKnapperIndKoeb.ResumeLayout(false);
            this.opskrifter.ResumeLayout(false);
            this.ydreTablePanelOpskrifter.ResumeLayout(false);
            this.indreTopTablePanelOpskrifter.ResumeLayout(false);
            this.funktionsKnapperOpskrifter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl navBar;
        private System.Windows.Forms.TabPage indkoeb;
        public System.Windows.Forms.TabPage husbeholdning;
        public System.Windows.Forms.ListBox ListBoxVarerIHus;
        private System.Windows.Forms.FlowLayoutPanel funktionsKnapperHus;
        private System.Windows.Forms.Button tilfoejVareKnapHus;
        private System.Windows.Forms.Button sletVareKnapHus;

        private System.Windows.Forms.FlowLayoutPanel FunktionsKnapperIndKoeb;
        private System.Windows.Forms.Button TilfoejVareKnapIndkoeb;
        private System.Windows.Forms.Button SletVareKnapIndkoeb;
        private System.Windows.Forms.Button TilfoejTilBeholdningKnap;
        public System.Windows.Forms.ListBox ListBoxIndkoeb;
        public System.Collections.Generic.List<Vare> Indkoebskurv = new System.Collections.Generic.List<Vare>();

        private System.Windows.Forms.TabPage opskrifter;
        private System.Windows.Forms.TableLayoutPanel ydreTablePanelOpskrifter;
        private System.Windows.Forms.TableLayoutPanel indreTopTablePanelOpskrifter;
        private System.Windows.Forms.ListBox listBoxOpskriftInfo;
        public System.Windows.Forms.ListBox listBoxOpskrifter;
        private System.Windows.Forms.FlowLayoutPanel funktionsKnapperOpskrifter;
        private System.Windows.Forms.Button tilfoejOpskriftKnap;
        private System.Windows.Forms.TableLayoutPanel husholdningTablePanel;
        private System.Windows.Forms.Button foreslaaOpskrifterEfterBeholdningKnap;
    }
}

