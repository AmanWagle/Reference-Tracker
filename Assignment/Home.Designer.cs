namespace Assignment
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ojjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReferecesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportRefetencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMyTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combo_style = new System.Windows.Forms.ComboBox();
            this.combo_sorting = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.ojjToolStripMenuItem,
            this.tagsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1534, 51);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(84, 47);
            this.userToolStripMenuItem.Text = "User";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(202, 48);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(202, 48);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // ojjToolStripMenuItem
            // 
            this.ojjToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReferenceToolStripMenuItem,
            this.viewReferecesToolStripMenuItem,
            this.exportRefetencesToolStripMenuItem});
            this.ojjToolStripMenuItem.Name = "ojjToolStripMenuItem";
            this.ojjToolStripMenuItem.Size = new System.Drawing.Size(155, 47);
            this.ojjToolStripMenuItem.Text = "References";
            // 
            // addReferenceToolStripMenuItem
            // 
            this.addReferenceToolStripMenuItem.Name = "addReferenceToolStripMenuItem";
            this.addReferenceToolStripMenuItem.Size = new System.Drawing.Size(319, 48);
            this.addReferenceToolStripMenuItem.Text = "Add References";
            this.addReferenceToolStripMenuItem.Click += new System.EventHandler(this.addReferenceToolStripMenuItem_Click);
            // 
            // viewReferecesToolStripMenuItem
            // 
            this.viewReferecesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMyToolStripMenuItem,
            this.viewAllToolStripMenuItem});
            this.viewReferecesToolStripMenuItem.Name = "viewReferecesToolStripMenuItem";
            this.viewReferecesToolStripMenuItem.Size = new System.Drawing.Size(319, 48);
            this.viewReferecesToolStripMenuItem.Text = "View References";
            // 
            // viewMyToolStripMenuItem
            // 
            this.viewMyToolStripMenuItem.Name = "viewMyToolStripMenuItem";
            this.viewMyToolStripMenuItem.Size = new System.Drawing.Size(342, 48);
            this.viewMyToolStripMenuItem.Text = "View My References";
            this.viewMyToolStripMenuItem.Click += new System.EventHandler(this.viewMyToolStripMenuItem_Click);
            // 
            // viewAllToolStripMenuItem
            // 
            this.viewAllToolStripMenuItem.Name = "viewAllToolStripMenuItem";
            this.viewAllToolStripMenuItem.Size = new System.Drawing.Size(342, 48);
            this.viewAllToolStripMenuItem.Text = "View All References";
            this.viewAllToolStripMenuItem.Click += new System.EventHandler(this.viewAllToolStripMenuItem_Click);
            // 
            // exportRefetencesToolStripMenuItem
            // 
            this.exportRefetencesToolStripMenuItem.Name = "exportRefetencesToolStripMenuItem";
            this.exportRefetencesToolStripMenuItem.Size = new System.Drawing.Size(319, 48);
            this.exportRefetencesToolStripMenuItem.Text = "Export References";
            this.exportRefetencesToolStripMenuItem.Click += new System.EventHandler(this.exportRefetencesToolStripMenuItem_Click);
            // 
            // tagsToolStripMenuItem
            // 
            this.tagsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTagsToolStripMenuItem,
            this.viewTagsToolStripMenuItem});
            this.tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            this.tagsToolStripMenuItem.Size = new System.Drawing.Size(85, 47);
            this.tagsToolStripMenuItem.Text = "Tags";
            // 
            // addTagsToolStripMenuItem
            // 
            this.addTagsToolStripMenuItem.Name = "addTagsToolStripMenuItem";
            this.addTagsToolStripMenuItem.Size = new System.Drawing.Size(225, 48);
            this.addTagsToolStripMenuItem.Text = "Add Tags";
            this.addTagsToolStripMenuItem.Click += new System.EventHandler(this.addTagsToolStripMenuItem_Click);
            // 
            // viewTagsToolStripMenuItem
            // 
            this.viewTagsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMyTagsToolStripMenuItem,
            this.viewAllTagsToolStripMenuItem});
            this.viewTagsToolStripMenuItem.Name = "viewTagsToolStripMenuItem";
            this.viewTagsToolStripMenuItem.Size = new System.Drawing.Size(225, 48);
            this.viewTagsToolStripMenuItem.Text = "View Tags";
            // 
            // viewMyTagsToolStripMenuItem
            // 
            this.viewMyTagsToolStripMenuItem.Name = "viewMyTagsToolStripMenuItem";
            this.viewMyTagsToolStripMenuItem.Size = new System.Drawing.Size(272, 48);
            this.viewMyTagsToolStripMenuItem.Text = "View My Tags";
            this.viewMyTagsToolStripMenuItem.Click += new System.EventHandler(this.viewMyTagsToolStripMenuItem_Click);
            // 
            // viewAllTagsToolStripMenuItem
            // 
            this.viewAllTagsToolStripMenuItem.Name = "viewAllTagsToolStripMenuItem";
            this.viewAllTagsToolStripMenuItem.Size = new System.Drawing.Size(272, 48);
            this.viewAllTagsToolStripMenuItem.Text = "View All Tags";
            this.viewAllTagsToolStripMenuItem.Click += new System.EventHandler(this.viewAllTagsToolStripMenuItem_Click);
            // 
            // combo_style
            // 
            this.combo_style.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_style.FormattingEnabled = true;
            this.combo_style.Location = new System.Drawing.Point(1243, 12);
            this.combo_style.Name = "combo_style";
            this.combo_style.Size = new System.Drawing.Size(269, 39);
            this.combo_style.TabIndex = 1;
            this.combo_style.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // combo_sorting
            // 
            this.combo_sorting.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_sorting.FormattingEnabled = true;
            this.combo_sorting.Items.AddRange(new object[] {
            "Title",
            "Journal",
            "Year",
            "Author\'s First Name",
            "Author\'s Surname"});
            this.combo_sorting.Location = new System.Drawing.Point(874, 57);
            this.combo_sorting.Name = "combo_sorting";
            this.combo_sorting.Size = new System.Drawing.Size(229, 38);
            this.combo_sorting.TabIndex = 4;
            this.combo_sorting.Text = "Choose Sorting Style";
            this.combo_sorting.SelectedIndexChanged += new System.EventHandler(this.combo_sorting_SelectedIndexChanged_1);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1521, 602);
            this.panel1.TabIndex = 7;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(1146, 57);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(266, 38);
            this.txt_search.TabIndex = 8;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(1418, 57);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(94, 38);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 732);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.combo_sorting);
            this.Controls.Add(this.combo_style);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ojjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReferecesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTagsToolStripMenuItem;
        private System.Windows.Forms.ComboBox combo_style;
        private System.Windows.Forms.ComboBox combo_sorting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ToolStripMenuItem exportRefetencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMyTagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllTagsToolStripMenuItem;
    }
}