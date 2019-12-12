using CefSharp;
using CefSharp.WinForms;
using DownLoadMP3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownLoadMP3App
{
    public partial class MainForm : Form
    {
        private ChromiumWebBrowser browser = null;

        public MainForm()
        {
            InitializeComponent();

            var settings = new CefSettings();
            settings.Locale = "zh-CN";
            //去掉gpu，否则chrome显示有问题
            settings.CefCommandLineArgs.Add("disable-gpu", "1");
            //去掉代理，增加加载网页速度
            settings.CefCommandLineArgs.Add("proxy-auto-detect", "0");
            settings.CefCommandLineArgs.Add("no-proxy-serve", "1");
            Cef.Initialize(settings);

            if (browser == null)
            {
                browser = new ChromiumWebBrowser("about:blank");
            }
            this.tableLayoutPanel1.Controls.Add(this.browser, 1, 2);
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(3, 455);
            this.browser.Name = "textBox1";
            this.browser.Size = new System.Drawing.Size(896, 25);
            this.browser.TabIndex = 4;
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MusicEntities db = new MusicEntities();
            IQueryable<Music> query = db.Music;

            var keyWord = txtSearch.Text.Trim();
            string[] keyWords = keyWord.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            Expression<Func<Music, bool>> expression = exp => true;
            foreach (var kw in keyWords)
            {
                query = query.Where(exp => exp.Name.Contains(kw));
            }
            var result = query.Take(50).ToList();

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = result;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDownLoad" && e.RowIndex >= 0)
            {
                //点击button按钮事件

                var data = dataGridView1.CurrentRow.DataBoundItem as Music;

                DownLoadMP3.DownLoadHelper.DownLoadMusic(data, this.txtFolder.Text.Trim());

                MessageBox.Show(string.Format("下载[{0}]成功", data.Name));
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnListen" && e.RowIndex >= 0)
            {
                var data = dataGridView1.CurrentRow.DataBoundItem as Music;

                Process.Start(data.DownLoadUrl);
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnListen1" && e.RowIndex >= 0)
            {
                var data = dataGridView1.CurrentRow.DataBoundItem as Music;
                browser.Load(data.DownLoadUrl);
            }
        }


    }
}
