namespace DownLoadMP3App
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Singer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDownLoad = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnListen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnListen1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFolder, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1035, 532);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSearch.Location = new System.Drawing.Point(4, 4);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(777, 53);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(789, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(242, 54);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SongName,
            this.Singer,
            this.Album,
            this.btnDownLoad,
            this.btnListen,
            this.btnListen1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(777, 432);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SongName
            // 
            this.SongName.DataPropertyName = "Name";
            this.SongName.HeaderText = "歌名";
            this.SongName.MinimumWidth = 6;
            this.SongName.Name = "SongName";
            this.SongName.ReadOnly = true;
            this.SongName.Width = 300;
            // 
            // Singer
            // 
            this.Singer.DataPropertyName = "Singer";
            this.Singer.HeaderText = "歌手";
            this.Singer.MinimumWidth = 6;
            this.Singer.Name = "Singer";
            this.Singer.ReadOnly = true;
            this.Singer.Width = 125;
            // 
            // Album
            // 
            this.Album.DataPropertyName = "Album";
            this.Album.HeaderText = "专辑";
            this.Album.MinimumWidth = 6;
            this.Album.Name = "Album";
            this.Album.ReadOnly = true;
            this.Album.Width = 150;
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.HeaderText = "下载";
            this.btnDownLoad.MinimumWidth = 6;
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.ReadOnly = true;
            this.btnDownLoad.Text = "下载";
            this.btnDownLoad.ToolTipText = "下载";
            this.btnDownLoad.UseColumnTextForButtonValue = true;
            this.btnDownLoad.Width = 80;
            // 
            // btnListen
            // 
            this.btnListen.HeaderText = "试听";
            this.btnListen.MinimumWidth = 6;
            this.btnListen.Name = "btnListen";
            this.btnListen.ReadOnly = true;
            this.btnListen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnListen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnListen.Text = "试听";
            this.btnListen.ToolTipText = "试听";
            this.btnListen.UseColumnTextForButtonValue = true;
            this.btnListen.Width = 80;
            // 
            // btnListen1
            // 
            this.btnListen1.HeaderText = "试听1";
            this.btnListen1.MinimumWidth = 6;
            this.btnListen1.Name = "btnListen1";
            this.btnListen1.ReadOnly = true;
            this.btnListen1.Text = "试听1";
            this.btnListen1.ToolTipText = "试听1";
            this.btnListen1.UseColumnTextForButtonValue = true;
            this.btnListen1.Width = 125;
            // 
            // txtFolder
            // 
            this.txtFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFolder.Location = new System.Drawing.Point(4, 66);
            this.txtFolder.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(777, 25);
            this.txtFolder.TabIndex = 3;
            this.txtFolder.Text = "C:\\Users\\StoneLi\\Music";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MP3下载器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Singer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewButtonColumn btnDownLoad;
        private System.Windows.Forms.DataGridViewButtonColumn btnListen;
        private System.Windows.Forms.DataGridViewButtonColumn btnListen1;
    }
}

