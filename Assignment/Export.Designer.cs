namespace Assignment
{
    partial class Export
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.export_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.combo_Export = new System.Windows.Forms.ComboBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.export_check});
            this.dataGridView1.Location = new System.Drawing.Point(0, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1104, 490);
            this.dataGridView1.TabIndex = 0;
            // 
            // export_check
            // 
            this.export_check.HeaderText = "";
            this.export_check.Name = "export_check";
            // 
            // combo_Export
            // 
            this.combo_Export.FormattingEnabled = true;
            this.combo_Export.Location = new System.Drawing.Point(34, 87);
            this.combo_Export.Name = "combo_Export";
            this.combo_Export.Size = new System.Drawing.Size(216, 24);
            this.combo_Export.TabIndex = 1;
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(920, 79);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(149, 39);
            this.btn_export.TabIndex = 2;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 55);
            this.btnBack.TabIndex = 92;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 628);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.combo_Export);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Export";
            this.Text = "Export";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Export_FormClosing);
            this.Load += new System.EventHandler(this.Export_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combo_Export;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.DataGridViewCheckBoxColumn export_check;
        private System.Windows.Forms.Button btnBack;
    }
}