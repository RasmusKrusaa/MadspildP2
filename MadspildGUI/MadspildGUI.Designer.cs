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
            this.visOpskrifterKnap = new System.Windows.Forms.Button();
            this.foreslaaEfterVarerKnap = new System.Windows.Forms.Button();
            this.TilføjOpskriftsIngredienserTilInkoebskurvClick = new System.Windows.Forms.Button();
            this.Opskriften_er_Lavet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.navBar.Size = new System.Drawing.Size(573, 372);
            this.navBar.TabIndex = 0;
            // 
            // husbeholdning
            // 
            this.husbeholdning.Controls.Add(this.husholdningTablePanel);
            this.husbeholdning.Location = new System.Drawing.Point(4, 22);
            this.husbeholdning.Name = "husbeholdning";
            this.husbeholdning.Padding = new System.Windows.Forms.Padding(3);
            this.husbeholdning.Size = new System.Drawing.Size(565, 346);
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
            this.husholdningTablePanel.Size = new System.Drawing.Size(559, 340);
            this.husholdningTablePanel.TabIndex = 2;
            // 
            // funktionsKnapperHus
            // 
            this.funktionsKnapperHus.Controls.Add(this.tilfoejVareKnapHus);
            this.funktionsKnapperHus.Controls.Add(this.sletVareKnapHus);
            this.funktionsKnapperHus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.funktionsKnapperHus.Location = new System.Drawing.Point(3, 304);
            this.funktionsKnapperHus.Name = "funktionsKnapperHus";
            this.funktionsKnapperHus.Size = new System.Drawing.Size(553, 33);
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
            this.ListBoxVarerIHus.Size = new System.Drawing.Size(553, 295);
            this.ListBoxVarerIHus.TabIndex = 0;
            this.ListBoxVarerIHus.SelectedIndexChanged += new System.EventHandler(this.ListBoxVarerIHus_SelectedIndexChanged);
            this.ListBoxVarerIHus.DoubleClick += new System.EventHandler(this.ListBoxVarerIHus_DoubleClick);
            // 
            // indkoeb
            // 
            this.indkoeb.Controls.Add(this.ListBoxIndkoeb);
            this.indkoeb.Controls.Add(this.FunktionsKnapperIndKoeb);
            this.indkoeb.Location = new System.Drawing.Point(4, 22);
            this.indkoeb.Name = "indkoeb";
            this.indkoeb.Padding = new System.Windows.Forms.Padding(3);
            this.indkoeb.Size = new System.Drawing.Size(565, 346);
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
            this.ListBoxIndkoeb.Size = new System.Drawing.Size(559, 313);
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
            this.FunktionsKnapperIndKoeb.Location = new System.Drawing.Point(3, 316);
            this.FunktionsKnapperIndKoeb.Name = "FunktionsKnapperIndKoeb";
            this.FunktionsKnapperIndKoeb.Size = new System.Drawing.Size(559, 27);
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
            this.opskrifter.Size = new System.Drawing.Size(565, 346);
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
            this.ydreTablePanelOpskrifter.Size = new System.Drawing.Size(559, 340);
            this.ydreTablePanelOpskrifter.TabIndex = 2;
            // 
            // indreTopTablePanelOpskrifter
            // 
            this.indreTopTablePanelOpskrifter.ColumnCount = 2;
            this.indreTopTablePanelOpskrifter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.20618F));
            this.indreTopTablePanelOpskrifter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.79382F));
            this.indreTopTablePanelOpskrifter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.indreTopTablePanelOpskrifter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.indreTopTablePanelOpskrifter.Controls.Add(this.listBoxOpskrifter, 0, 0);
            this.indreTopTablePanelOpskrifter.Controls.Add(this.listBoxOpskriftInfo, 1, 0);
            this.indreTopTablePanelOpskrifter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.indreTopTablePanelOpskrifter.Location = new System.Drawing.Point(0, 0);
            this.indreTopTablePanelOpskrifter.Margin = new System.Windows.Forms.Padding(0);
            this.indreTopTablePanelOpskrifter.Name = "indreTopTablePanelOpskrifter";
            this.indreTopTablePanelOpskrifter.RowCount = 1;
            this.indreTopTablePanelOpskrifter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.indreTopTablePanelOpskrifter.Size = new System.Drawing.Size(559, 299);
            this.indreTopTablePanelOpskrifter.TabIndex = 0;
            // 
            // listBoxOpskrifter
            // 
            this.listBoxOpskrifter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOpskrifter.FormattingEnabled = true;
            this.listBoxOpskrifter.Location = new System.Drawing.Point(3, 3);
            this.listBoxOpskrifter.Name = "listBoxOpskrifter";
            this.listBoxOpskrifter.Size = new System.Drawing.Size(218, 293);
            this.listBoxOpskrifter.TabIndex = 0;
            this.listBoxOpskrifter.SelectedIndexChanged += new System.EventHandler(this.listBoxOpskrifter_SelectedIndexChanged);
            this.listBoxOpskrifter.DoubleClick += new System.EventHandler(this.listBoxOpskrifter_DoubleClick);
            // 
            // listBoxOpskriftInfo
            // 
            this.listBoxOpskriftInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOpskriftInfo.FormattingEnabled = true;
            this.listBoxOpskriftInfo.HorizontalScrollbar = true;
            this.listBoxOpskriftInfo.Location = new System.Drawing.Point(227, 3);
            this.listBoxOpskriftInfo.Name = "listBoxOpskriftInfo";
            this.listBoxOpskriftInfo.Size = new System.Drawing.Size(329, 293);
            this.listBoxOpskriftInfo.TabIndex = 1;
            // 
            // funktionsKnapperOpskrifter
            // 
            this.funktionsKnapperOpskrifter.Controls.Add(this.tilfoejOpskriftKnap);
            this.funktionsKnapperOpskrifter.Controls.Add(this.foreslaaOpskrifterEfterBeholdningKnap);
            this.funktionsKnapperOpskrifter.Controls.Add(this.visOpskrifterKnap);
            this.funktionsKnapperOpskrifter.Controls.Add(this.foreslaaEfterVarerKnap);
            this.funktionsKnapperOpskrifter.Controls.Add(this.TilføjOpskriftsIngredienserTilInkoebskurvClick);
            this.funktionsKnapperOpskrifter.Controls.Add(this.Opskriften_er_Lavet);
            this.funktionsKnapperOpskrifter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.funktionsKnapperOpskrifter.Location = new System.Drawing.Point(3, 302);
            this.funktionsKnapperOpskrifter.Name = "funktionsKnapperOpskrifter";
            this.funktionsKnapperOpskrifter.Size = new System.Drawing.Size(553, 35);
            this.funktionsKnapperOpskrifter.TabIndex = 1;
            this.funktionsKnapperOpskrifter.Paint += new System.Windows.Forms.PaintEventHandler(this.funktionsKnapperOpskrifter_Paint);
            // 
            // tilfoejOpskriftKnap
            // 
            this.tilfoejOpskriftKnap.Location = new System.Drawing.Point(3, 3);
            this.tilfoejOpskriftKnap.Name = "tilfoejOpskriftKnap";
            this.tilfoejOpskriftKnap.Size = new System.Drawing.Size(75, 30);
            this.tilfoejOpskriftKnap.TabIndex = 0;
            this.tilfoejOpskriftKnap.Text = "Tilføj opskrift";
            this.tilfoejOpskriftKnap.UseVisualStyleBackColor = true;
            this.tilfoejOpskriftKnap.Click += new System.EventHandler(this.tilfoejOpskriftKnap_Click);
            // 
            // foreslaaOpskrifterEfterBeholdningKnap
            // 
            this.foreslaaOpskrifterEfterBeholdningKnap.Location = new System.Drawing.Point(84, 3);
            this.foreslaaOpskrifterEfterBeholdningKnap.Name = "foreslaaOpskrifterEfterBeholdningKnap";
            this.foreslaaOpskrifterEfterBeholdningKnap.Size = new System.Drawing.Size(109, 30);
            this.foreslaaOpskrifterEfterBeholdningKnap.TabIndex = 1;
            this.foreslaaOpskrifterEfterBeholdningKnap.Text = "Foreslå efter husholdning";
            this.foreslaaOpskrifterEfterBeholdningKnap.UseVisualStyleBackColor = true;
            this.foreslaaOpskrifterEfterBeholdningKnap.Click += new System.EventHandler(this.foreslaaOpskrifterEfterBeholdningKnap_Click);
            // 
            // visOpskrifterKnap
            // 
            this.visOpskrifterKnap.Location = new System.Drawing.Point(199, 3);
            this.visOpskrifterKnap.Name = "visOpskrifterKnap";
            this.visOpskrifterKnap.Size = new System.Drawing.Size(80, 30);
            this.visOpskrifterKnap.TabIndex = 2;
            this.visOpskrifterKnap.Text = "Vis Opskrifter";
            this.visOpskrifterKnap.UseVisualStyleBackColor = true;
            this.visOpskrifterKnap.Click += new System.EventHandler(this.visOpskrifterKnap_Click);
            // 
            // foreslaaEfterVarerKnap
            // 
            this.foreslaaEfterVarerKnap.Location = new System.Drawing.Point(285, 3);
            this.foreslaaEfterVarerKnap.Name = "foreslaaEfterVarerKnap";
            this.foreslaaEfterVarerKnap.Size = new System.Drawing.Size(103, 30);
            this.foreslaaEfterVarerKnap.TabIndex = 3;
            this.foreslaaEfterVarerKnap.Text = "Foreslå efter varer";
            this.foreslaaEfterVarerKnap.UseVisualStyleBackColor = true;
            this.foreslaaEfterVarerKnap.Click += new System.EventHandler(this.foreslaaEfterVarerKnap_Click);
            // 
            // TilføjOpskriftsIngredienserTilInkoebskurvClick
            // 
            this.TilføjOpskriftsIngredienserTilInkoebskurvClick.Location = new System.Drawing.Point(394, 3);
            this.TilføjOpskriftsIngredienserTilInkoebskurvClick.Name = "TilføjOpskriftsIngredienserTilInkoebskurvClick";
            this.TilføjOpskriftsIngredienserTilInkoebskurvClick.Size = new System.Drawing.Size(75, 30);
            this.TilføjOpskriftsIngredienserTilInkoebskurvClick.TabIndex = 4;
            this.TilføjOpskriftsIngredienserTilInkoebskurvClick.Text = "Inkøbskurv";
            this.TilføjOpskriftsIngredienserTilInkoebskurvClick.UseVisualStyleBackColor = true;
            this.TilføjOpskriftsIngredienserTilInkoebskurvClick.Click += new System.EventHandler(this.Tilføj_Opskrifts_Ingredienser_Til_Inkoebskurv_Click);
            // 
            // Opskriften_er_Lavet
            // 
            this.Opskriften_er_Lavet.Location = new System.Drawing.Point(475, 3);
            this.Opskriften_er_Lavet.Name = "Opskriften_er_Lavet";
            this.Opskriften_er_Lavet.Size = new System.Drawing.Size(75, 30);
            this.Opskriften_er_Lavet.TabIndex = 5;
            this.Opskriften_er_Lavet.Text = "Lavet";
            this.Opskriften_er_Lavet.UseVisualStyleBackColor = true;
            this.Opskriften_er_Lavet.Click += new System.EventHandler(this.Opskriften_Er_Lavet_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tilføj til Inkøbskurv";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Tilføj_Opskrifts_Ingredienser_Til_Inkoebskurv_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Opskrift Udført";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Opskriften_Er_Lavet_Click);
            // 
            // MadspildGUI
            // 
            this.ClientSize = new System.Drawing.Size(573, 372);
            this.Controls.Add(this.navBar);
            this.Name = "MadspildGUI";
            this.Load += new System.EventHandler(this.MadspildGUI_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button visOpskrifterKnap;
        private System.Windows.Forms.Button foreslaaEfterVarerKnap;
        private System.Windows.Forms.Button TilføjOpskriftsIngredienserTilInkoebskurvClick;
        private System.Windows.Forms.Button Opskriften_er_Lavet;

    }
}

