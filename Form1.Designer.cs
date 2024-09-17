namespace WheelsWatchTech
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelside = new Panel();
            btnDownload = new Button();
            btnloaddata = new Button();
            btnupdatedata = new Button();
            panelheader = new Panel();
            btnclose = new Button();
            resultGrid = new DataGridView();
            panelside.SuspendLayout();
            panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultGrid).BeginInit();
            SuspendLayout();
            // 
            // panelside
            // 
            panelside.BackColor = SystemColors.ControlDarkDark;
            panelside.Controls.Add(btnDownload);
            panelside.Controls.Add(btnloaddata);
            panelside.Controls.Add(btnupdatedata);
            panelside.Dock = DockStyle.Left;
            panelside.Location = new Point(0, 31);
            panelside.Name = "panelside";
            panelside.Size = new Size(200, 507);
            panelside.TabIndex = 0;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.DimGray;
            btnDownload.BackgroundImageLayout = ImageLayout.Zoom;
            btnDownload.FlatStyle = FlatStyle.Flat;
            btnDownload.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDownload.ForeColor = SystemColors.ButtonHighlight;
            btnDownload.ImageAlign = ContentAlignment.BottomLeft;
            btnDownload.Location = new Point(0, 272);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(200, 36);
            btnDownload.TabIndex = 2;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click_1;
            // 
            // btnloaddata
            // 
            btnloaddata.BackColor = Color.DimGray;
            btnloaddata.BackgroundImageLayout = ImageLayout.Zoom;
            btnloaddata.FlatStyle = FlatStyle.Flat;
            btnloaddata.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnloaddata.ForeColor = SystemColors.ButtonHighlight;
            btnloaddata.ImageAlign = ContentAlignment.MiddleLeft;
            btnloaddata.Location = new Point(0, 148);
            btnloaddata.Name = "btnloaddata";
            btnloaddata.Size = new Size(200, 36);
            btnloaddata.TabIndex = 0;
            btnloaddata.Text = "Load Excel Data";
            btnloaddata.UseVisualStyleBackColor = false;
            btnloaddata.Click += btnloaddata_Click_1;
            // 
            // btnupdatedata
            // 
            btnupdatedata.BackColor = Color.DimGray;
            btnupdatedata.BackgroundImageLayout = ImageLayout.Zoom;
            btnupdatedata.FlatStyle = FlatStyle.Flat;
            btnupdatedata.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdatedata.ForeColor = SystemColors.ButtonHighlight;
            btnupdatedata.ImageAlign = ContentAlignment.MiddleLeft;
            btnupdatedata.Location = new Point(0, 208);
            btnupdatedata.Name = "btnupdatedata";
            btnupdatedata.Size = new Size(200, 36);
            btnupdatedata.TabIndex = 1;
            btnupdatedata.Text = "Update Data";
            btnupdatedata.UseVisualStyleBackColor = false;
            btnupdatedata.Click += btnupdatedata_Click_1;
            // 
            // panelheader
            // 
            panelheader.BackColor = SystemColors.GrayText;
            panelheader.Controls.Add(btnclose);
            panelheader.Dock = DockStyle.Top;
            panelheader.Location = new Point(0, 0);
            panelheader.Name = "panelheader";
            panelheader.Size = new Size(830, 31);
            panelheader.TabIndex = 1;
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.DimGray;
            btnclose.BackgroundImageLayout = ImageLayout.Zoom;
            btnclose.FlatStyle = FlatStyle.Flat;
            btnclose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclose.ForeColor = SystemColors.ButtonHighlight;
            btnclose.ImageAlign = ContentAlignment.MiddleLeft;
            btnclose.Location = new Point(757, 0);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(43, 30);
            btnclose.TabIndex = 1;
            btnclose.Text = "x";
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += button1_Click;
            // 
            // resultGrid
            // 
            resultGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultGrid.Dock = DockStyle.Fill;
            resultGrid.Location = new Point(200, 31);
            resultGrid.Name = "resultGrid";
            resultGrid.Size = new Size(630, 507);
            resultGrid.TabIndex = 3;
            resultGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 538);
            Controls.Add(resultGrid);
            Controls.Add(panelside);
            Controls.Add(panelheader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WheelsWatchTech";
            panelside.ResumeLayout(false);
            panelheader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resultGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelside;
        private Panel panelheader;
        private Button btnloaddata;
        private Button btnDownload;
        private Button btnupdatedata;
        private Button btnclose;
        private DataGridView resultGrid;
    }
}
