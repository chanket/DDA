namespace DiscreteDeviceAssigner
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderDevice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vMNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其它toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowMemoryMappedIoSpaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LMMIOtoolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.highMemoryMappedIoSpaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HMMIOtoolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.GCCTtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.添加设备ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移除设备ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制地址toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.刷新列表toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDevice,
            this.columnHeaderClass,
            this.columnHeaderLocation});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(815, 507);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeaderDevice
            // 
            this.columnHeaderDevice.Text = "设备";
            this.columnHeaderDevice.Width = 258;
            // 
            // columnHeaderClass
            // 
            this.columnHeaderClass.Text = "类型";
            this.columnHeaderClass.Width = 86;
            // 
            // columnHeaderLocation
            // 
            this.columnHeaderLocation.Text = "地址";
            this.columnHeaderLocation.Width = 418;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vMNameToolStripMenuItem,
            this.其它toolStripMenuItem,
            this.toolStripSeparator2,
            this.添加设备ToolStripMenuItem,
            this.移除设备ToolStripMenuItem,
            this.复制地址toolStripMenuItem,
            this.toolStripSeparator1,
            this.刷新列表toolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(132, 148);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // vMNameToolStripMenuItem
            // 
            this.vMNameToolStripMenuItem.Enabled = false;
            this.vMNameToolStripMenuItem.Name = "vMNameToolStripMenuItem";
            this.vMNameToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.vMNameToolStripMenuItem.Text = "VMName";
            // 
            // 其它toolStripMenuItem
            // 
            this.其它toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowMemoryMappedIoSpaceToolStripMenuItem,
            this.LMMIOtoolStripTextBox,
            this.toolStripSeparator4,
            this.highMemoryMappedIoSpaceToolStripMenuItem,
            this.HMMIOtoolStripTextBox,
            this.toolStripSeparator5,
            this.GCCTtoolStripMenuItem});
            this.其它toolStripMenuItem.Name = "其它toolStripMenuItem";
            this.其它toolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.其它toolStripMenuItem.Text = "其它";
            // 
            // lowMemoryMappedIoSpaceToolStripMenuItem
            // 
            this.lowMemoryMappedIoSpaceToolStripMenuItem.Enabled = false;
            this.lowMemoryMappedIoSpaceToolStripMenuItem.Name = "lowMemoryMappedIoSpaceToolStripMenuItem";
            this.lowMemoryMappedIoSpaceToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.lowMemoryMappedIoSpaceToolStripMenuItem.Text = "LowMemoryMappedIoSpace(MB)";
            // 
            // LMMIOtoolStripTextBox
            // 
            this.LMMIOtoolStripTextBox.MaxLength = 4;
            this.LMMIOtoolStripTextBox.Name = "LMMIOtoolStripTextBox";
            this.LMMIOtoolStripTextBox.Size = new System.Drawing.Size(100, 23);
            this.LMMIOtoolStripTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LMMIOtoolStripTextBox_KeyDown);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(274, 6);
            // 
            // highMemoryMappedIoSpaceToolStripMenuItem
            // 
            this.highMemoryMappedIoSpaceToolStripMenuItem.Enabled = false;
            this.highMemoryMappedIoSpaceToolStripMenuItem.Name = "highMemoryMappedIoSpaceToolStripMenuItem";
            this.highMemoryMappedIoSpaceToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.highMemoryMappedIoSpaceToolStripMenuItem.Text = "HighMemoryMappedIoSpace(MB)";
            // 
            // HMMIOtoolStripTextBox
            // 
            this.HMMIOtoolStripTextBox.MaxLength = 5;
            this.HMMIOtoolStripTextBox.Name = "HMMIOtoolStripTextBox";
            this.HMMIOtoolStripTextBox.Size = new System.Drawing.Size(100, 23);
            this.HMMIOtoolStripTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HMMIOtoolStripTextBox_KeyDown);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(274, 6);
            // 
            // GCCTtoolStripMenuItem
            // 
            this.GCCTtoolStripMenuItem.Checked = true;
            this.GCCTtoolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GCCTtoolStripMenuItem.Name = "GCCTtoolStripMenuItem";
            this.GCCTtoolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.GCCTtoolStripMenuItem.Text = "GuestControlledCacheTypes";
            this.GCCTtoolStripMenuItem.Click += new System.EventHandler(this.GCCTtoolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(128, 6);
            // 
            // 添加设备ToolStripMenuItem
            // 
            this.添加设备ToolStripMenuItem.Name = "添加设备ToolStripMenuItem";
            this.添加设备ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.添加设备ToolStripMenuItem.Text = "添加设备";
            this.添加设备ToolStripMenuItem.Click += new System.EventHandler(this.添加设备ToolStripMenuItem_Click);
            // 
            // 移除设备ToolStripMenuItem
            // 
            this.移除设备ToolStripMenuItem.Name = "移除设备ToolStripMenuItem";
            this.移除设备ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.移除设备ToolStripMenuItem.Text = "移除设备";
            this.移除设备ToolStripMenuItem.Click += new System.EventHandler(this.移除设备ToolStripMenuItem_Click);
            // 
            // 复制地址toolStripMenuItem
            // 
            this.复制地址toolStripMenuItem.Name = "复制地址toolStripMenuItem";
            this.复制地址toolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.复制地址toolStripMenuItem.Text = "复制地址";
            this.复制地址toolStripMenuItem.Click += new System.EventHandler(this.复制地址ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // 刷新列表toolStripMenuItem
            // 
            this.刷新列表toolStripMenuItem.Name = "刷新列表toolStripMenuItem";
            this.刷新列表toolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.刷新列表toolStripMenuItem.Text = "刷新列表";
            this.刷新列表toolStripMenuItem.Click += new System.EventHandler(this.刷新列表ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 531);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discrete Device Assigner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderDevice;
        private System.Windows.Forms.ColumnHeader columnHeaderLocation;
        private System.Windows.Forms.ColumnHeader columnHeaderClass;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem vMNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加设备ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移除设备ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 刷新列表toolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 复制地址toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其它toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowMemoryMappedIoSpaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox LMMIOtoolStripTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem highMemoryMappedIoSpaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox HMMIOtoolStripTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem GCCTtoolStripMenuItem;
    }
}

