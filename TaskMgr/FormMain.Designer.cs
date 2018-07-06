﻿namespace TaskMgr
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageProcCtl = new System.Windows.Forms.TabPage();
            this.spl1 = new System.Windows.Forms.PictureBox();
            this.lbShowDetals = new System.Windows.Forms.LinkLabel();
            this.btnEndProcess = new System.Windows.Forms.Button();
            this.lbProcessCount = new System.Windows.Forms.Label();
            this.listProcess = new TaskMgr.Ctls.TaskMgrList();
            this.tabPageKernelCtl = new System.Windows.Forms.TabPage();
            this.lbDriversCount = new System.Windows.Forms.Label();
            this.listDrivers = new TaskMgr.Ctls.TaskMgrList();
            this.tabPageSysCtl = new System.Windows.Forms.TabPage();
            this.tabPageScCtl = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkOpenScMsc = new System.Windows.Forms.LinkLabel();
            this.lbServicesCount = new System.Windows.Forms.Label();
            this.listService = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageStartCtl = new System.Windows.Forms.TabPage();
            this.tabPageFileCtl = new System.Windows.Forms.TabPage();
            this.lbFileMgrStatus = new System.Windows.Forms.Label();
            this.btnFmAddGoto = new System.Windows.Forms.Button();
            this.textBoxFmCurrent = new System.Windows.Forms.TextBox();
            this.splitContainerFm = new System.Windows.Forms.SplitContainer();
            this.treeFmLeft = new System.Windows.Forms.TreeView();
            this.imageListFileMgrLeft = new System.Windows.Forms.ImageList(this.components);
            this.listFm = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListFileTypeList = new System.Windows.Forms.ImageList(this.components);
            this.spBottom = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.tabControlMain.SuspendLayout();
            this.tabPageProcCtl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spl1)).BeginInit();
            this.tabPageKernelCtl.SuspendLayout();
            this.tabPageScCtl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageFileCtl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFm)).BeginInit();
            this.splitContainerFm.Panel1.SuspendLayout();
            this.splitContainerFm.Panel2.SuspendLayout();
            this.splitContainerFm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageProcCtl);
            this.tabControlMain.Controls.Add(this.tabPageKernelCtl);
            this.tabControlMain.Controls.Add(this.tabPageSysCtl);
            this.tabControlMain.Controls.Add(this.tabPageScCtl);
            this.tabControlMain.Controls.Add(this.tabPageStartCtl);
            this.tabControlMain.Controls.Add(this.tabPageFileCtl);
            this.tabControlMain.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(909, 594);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlMain_Selected);
            // 
            // tabPageProcCtl
            // 
            this.tabPageProcCtl.Controls.Add(this.spl1);
            this.tabPageProcCtl.Controls.Add(this.lbShowDetals);
            this.tabPageProcCtl.Controls.Add(this.btnEndProcess);
            this.tabPageProcCtl.Controls.Add(this.lbProcessCount);
            this.tabPageProcCtl.Controls.Add(this.listProcess);
            this.tabPageProcCtl.Location = new System.Drawing.Point(4, 26);
            this.tabPageProcCtl.Name = "tabPageProcCtl";
            this.tabPageProcCtl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcCtl.Size = new System.Drawing.Size(901, 564);
            this.tabPageProcCtl.TabIndex = 0;
            this.tabPageProcCtl.Text = "进程管理";
            this.tabPageProcCtl.UseVisualStyleBackColor = true;
            // 
            // spl1
            // 
            this.spl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.spl1.Location = new System.Drawing.Point(163, 537);
            this.spl1.Name = "spl1";
            this.spl1.Size = new System.Drawing.Size(1, 14);
            this.spl1.TabIndex = 7;
            this.spl1.TabStop = false;
            this.spl1.Visible = false;
            // 
            // lbShowDetals
            // 
            this.lbShowDetals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbShowDetals.DisabledLinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbShowDetals.Image = global::TaskMgr.Properties.Resources.application_view_list;
            this.lbShowDetals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbShowDetals.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbShowDetals.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbShowDetals.Location = new System.Drawing.Point(594, 531);
            this.lbShowDetals.Name = "lbShowDetals";
            this.lbShowDetals.Size = new System.Drawing.Size(150, 17);
            this.lbShowDetals.TabIndex = 2;
            this.lbShowDetals.TabStop = true;
            this.lbShowDetals.Text = "打开进程详细信息窗口";
            this.lbShowDetals.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbShowDetals.Visible = false;
            this.lbShowDetals.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShowDetals_LinkClicked);
            // 
            // btnEndProcess
            // 
            this.btnEndProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndProcess.Enabled = false;
            this.btnEndProcess.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEndProcess.Location = new System.Drawing.Point(806, 531);
            this.btnEndProcess.Name = "btnEndProcess";
            this.btnEndProcess.Size = new System.Drawing.Size(85, 24);
            this.btnEndProcess.TabIndex = 0;
            this.btnEndProcess.Text = "结束进程(E)";
            this.btnEndProcess.UseVisualStyleBackColor = true;
            this.btnEndProcess.Click += new System.EventHandler(this.btnEndProcess_Click);
            // 
            // lbProcessCount
            // 
            this.lbProcessCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbProcessCount.AutoSize = true;
            this.lbProcessCount.Location = new System.Drawing.Point(8, 535);
            this.lbProcessCount.Name = "lbProcessCount";
            this.lbProcessCount.Size = new System.Drawing.Size(66, 17);
            this.lbProcessCount.TabIndex = 5;
            this.lbProcessCount.Text = "进程数：--";
            // 
            // listProcess
            // 
            this.listProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listProcess.BackColor = System.Drawing.SystemColors.Window;
            this.listProcess.FocusedType = false;
            this.listProcess.Icons = null;
            this.listProcess.ListViewItemSorter = null;
            this.listProcess.Location = new System.Drawing.Point(0, 0);
            this.listProcess.Name = "listProcess";
            this.listProcess.ShowGroup = false;
            this.listProcess.Size = new System.Drawing.Size(901, 520);
            this.listProcess.TabIndex = 1;
            this.listProcess.Value = 0D;
            this.listProcess.XOffest = 0;
            this.listProcess.SelectItemChanged += new System.EventHandler(this.listProcess_SelectItemChanged);
            this.listProcess.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listProcess_MouseDown);
            this.listProcess.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listProcess_MouseUp);
            // 
            // tabPageKernelCtl
            // 
            this.tabPageKernelCtl.Controls.Add(this.lbDriversCount);
            this.tabPageKernelCtl.Controls.Add(this.listDrivers);
            this.tabPageKernelCtl.Location = new System.Drawing.Point(4, 26);
            this.tabPageKernelCtl.Name = "tabPageKernelCtl";
            this.tabPageKernelCtl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKernelCtl.Size = new System.Drawing.Size(901, 564);
            this.tabPageKernelCtl.TabIndex = 1;
            this.tabPageKernelCtl.Text = "内核管理";
            this.tabPageKernelCtl.UseVisualStyleBackColor = true;
            // 
            // lbDriversCount
            // 
            this.lbDriversCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDriversCount.AutoSize = true;
            this.lbDriversCount.Location = new System.Drawing.Point(8, 535);
            this.lbDriversCount.Name = "lbDriversCount";
            this.lbDriversCount.Size = new System.Drawing.Size(66, 17);
            this.lbDriversCount.TabIndex = 6;
            this.lbDriversCount.Text = "驱动数：--";
            // 
            // listDrivers
            // 
            this.listDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listDrivers.BackColor = System.Drawing.SystemColors.Window;
            this.listDrivers.FocusedType = false;
            this.listDrivers.ListViewItemSorter = null;
            this.listDrivers.Location = new System.Drawing.Point(1, 1);
            this.listDrivers.Name = "listDrivers";
            this.listDrivers.ShowGroup = false;
            this.listDrivers.Size = new System.Drawing.Size(898, 519);
            this.listDrivers.TabIndex = 0;
            this.listDrivers.Text = "taskMgrList1";
            this.listDrivers.Value = 0D;
            this.listDrivers.XOffest = 0;
            // 
            // tabPageSysCtl
            // 
            this.tabPageSysCtl.Location = new System.Drawing.Point(4, 26);
            this.tabPageSysCtl.Name = "tabPageSysCtl";
            this.tabPageSysCtl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSysCtl.Size = new System.Drawing.Size(901, 564);
            this.tabPageSysCtl.TabIndex = 2;
            this.tabPageSysCtl.Text = "系统管理";
            this.tabPageSysCtl.UseVisualStyleBackColor = true;
            // 
            // tabPageScCtl
            // 
            this.tabPageScCtl.Controls.Add(this.pictureBox1);
            this.tabPageScCtl.Controls.Add(this.linkOpenScMsc);
            this.tabPageScCtl.Controls.Add(this.lbServicesCount);
            this.tabPageScCtl.Controls.Add(this.listService);
            this.tabPageScCtl.Location = new System.Drawing.Point(4, 26);
            this.tabPageScCtl.Name = "tabPageScCtl";
            this.tabPageScCtl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScCtl.Size = new System.Drawing.Size(901, 564);
            this.tabPageScCtl.TabIndex = 3;
            this.tabPageScCtl.Text = "服务管理";
            this.tabPageScCtl.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.pictureBox1.Location = new System.Drawing.Point(87, 537);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 14);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // linkOpenScMsc
            // 
            this.linkOpenScMsc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkOpenScMsc.DisabledLinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkOpenScMsc.Image = ((System.Drawing.Image)(resources.GetObject("linkOpenScMsc.Image")));
            this.linkOpenScMsc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkOpenScMsc.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkOpenScMsc.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkOpenScMsc.Location = new System.Drawing.Point(94, 535);
            this.linkOpenScMsc.Name = "linkOpenScMsc";
            this.linkOpenScMsc.Size = new System.Drawing.Size(79, 17);
            this.linkOpenScMsc.TabIndex = 8;
            this.linkOpenScMsc.TabStop = true;
            this.linkOpenScMsc.Text = "打开服务";
            this.linkOpenScMsc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkOpenScMsc.Visible = false;
            this.linkOpenScMsc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOpenScMsc_LinkClicked);
            // 
            // lbServicesCount
            // 
            this.lbServicesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbServicesCount.AutoSize = true;
            this.lbServicesCount.Location = new System.Drawing.Point(11, 535);
            this.lbServicesCount.Name = "lbServicesCount";
            this.lbServicesCount.Size = new System.Drawing.Size(66, 17);
            this.lbServicesCount.TabIndex = 7;
            this.lbServicesCount.Text = "服务数：--";
            // 
            // listService
            // 
            this.listService.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listService.FullRowSelect = true;
            this.listService.Location = new System.Drawing.Point(0, 0);
            this.listService.Name = "listService";
            this.listService.Size = new System.Drawing.Size(901, 520);
            this.listService.TabIndex = 0;
            this.listService.UseCompatibleStateImageBehavior = false;
            this.listService.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "名称";
            this.columnHeader7.Width = 222;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "PID";
            this.columnHeader8.Width = 50;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "描述";
            this.columnHeader9.Width = 334;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "状态";
            this.columnHeader10.Width = 79;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "组";
            this.columnHeader11.Width = 133;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "启动类型";
            // 
            // tabPageStartCtl
            // 
            this.tabPageStartCtl.Location = new System.Drawing.Point(4, 26);
            this.tabPageStartCtl.Name = "tabPageStartCtl";
            this.tabPageStartCtl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStartCtl.Size = new System.Drawing.Size(901, 564);
            this.tabPageStartCtl.TabIndex = 4;
            this.tabPageStartCtl.Text = "启动项管理";
            this.tabPageStartCtl.UseVisualStyleBackColor = true;
            // 
            // tabPageFileCtl
            // 
            this.tabPageFileCtl.Controls.Add(this.lbFileMgrStatus);
            this.tabPageFileCtl.Controls.Add(this.btnFmAddGoto);
            this.tabPageFileCtl.Controls.Add(this.textBoxFmCurrent);
            this.tabPageFileCtl.Controls.Add(this.splitContainerFm);
            this.tabPageFileCtl.Location = new System.Drawing.Point(4, 26);
            this.tabPageFileCtl.Name = "tabPageFileCtl";
            this.tabPageFileCtl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFileCtl.Size = new System.Drawing.Size(901, 564);
            this.tabPageFileCtl.TabIndex = 5;
            this.tabPageFileCtl.Text = "文件管理";
            this.tabPageFileCtl.UseVisualStyleBackColor = true;
            // 
            // lbFileMgrStatus
            // 
            this.lbFileMgrStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbFileMgrStatus.AutoSize = true;
            this.lbFileMgrStatus.Location = new System.Drawing.Point(16, 532);
            this.lbFileMgrStatus.Name = "lbFileMgrStatus";
            this.lbFileMgrStatus.Size = new System.Drawing.Size(32, 17);
            this.lbFileMgrStatus.TabIndex = 6;
            this.lbFileMgrStatus.Text = "就绪";
            // 
            // btnFmAddGoto
            // 
            this.btnFmAddGoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFmAddGoto.Image = ((System.Drawing.Image)(resources.GetObject("btnFmAddGoto.Image")));
            this.btnFmAddGoto.Location = new System.Drawing.Point(875, 4);
            this.btnFmAddGoto.Name = "btnFmAddGoto";
            this.btnFmAddGoto.Size = new System.Drawing.Size(20, 20);
            this.btnFmAddGoto.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnFmAddGoto, "跳转到");
            this.btnFmAddGoto.UseVisualStyleBackColor = true;
            this.btnFmAddGoto.Click += new System.EventHandler(this.btnFmAddGoto_Click);
            // 
            // textBoxFmCurrent
            // 
            this.textBoxFmCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFmCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFmCurrent.Location = new System.Drawing.Point(3, 6);
            this.textBoxFmCurrent.Name = "textBoxFmCurrent";
            this.textBoxFmCurrent.Size = new System.Drawing.Size(866, 16);
            this.textBoxFmCurrent.TabIndex = 2;
            this.textBoxFmCurrent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFmCurrent_KeyDown);
            // 
            // splitContainerFm
            // 
            this.splitContainerFm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerFm.Location = new System.Drawing.Point(1, 28);
            this.splitContainerFm.Name = "splitContainerFm";
            // 
            // splitContainerFm.Panel1
            // 
            this.splitContainerFm.Panel1.Controls.Add(this.treeFmLeft);
            // 
            // splitContainerFm.Panel2
            // 
            this.splitContainerFm.Panel2.Controls.Add(this.listFm);
            this.splitContainerFm.Size = new System.Drawing.Size(900, 488);
            this.splitContainerFm.SplitterDistance = 226;
            this.splitContainerFm.TabIndex = 1;
            // 
            // treeFmLeft
            // 
            this.treeFmLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeFmLeft.FullRowSelect = true;
            this.treeFmLeft.ImageIndex = 0;
            this.treeFmLeft.ImageList = this.imageListFileMgrLeft;
            this.treeFmLeft.Location = new System.Drawing.Point(0, 0);
            this.treeFmLeft.Name = "treeFmLeft";
            this.treeFmLeft.SelectedImageIndex = 0;
            this.treeFmLeft.Size = new System.Drawing.Size(226, 488);
            this.treeFmLeft.TabIndex = 0;
            this.treeFmLeft.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeFmLeft_BeforeExpand);
            this.treeFmLeft.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeFmLeft_NodeMouseClick);
            // 
            // imageListFileMgrLeft
            // 
            this.imageListFileMgrLeft.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFileMgrLeft.ImageStream")));
            this.imageListFileMgrLeft.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFileMgrLeft.Images.SetKeyName(0, "sec");
            this.imageListFileMgrLeft.Images.SetKeyName(1, "loading");
            this.imageListFileMgrLeft.Images.SetKeyName(2, "err");
            // 
            // listFm
            // 
            this.listFm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listFm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listFm.FullRowSelect = true;
            this.listFm.Location = new System.Drawing.Point(0, 0);
            this.listFm.Name = "listFm";
            this.listFm.ShowItemToolTips = true;
            this.listFm.Size = new System.Drawing.Size(670, 488);
            this.listFm.SmallImageList = this.imageListFileTypeList;
            this.listFm.TabIndex = 0;
            this.listFm.UseCompatibleStateImageBehavior = false;
            this.listFm.View = System.Windows.Forms.View.Details;
            this.listFm.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listFm_AfterLabelEdit);
            this.listFm.SelectedIndexChanged += new System.EventHandler(this.listFm_SelectedIndexChanged);
            this.listFm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listFm_MouseClick);
            this.listFm.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listFm_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "文件名";
            this.columnHeader1.Width = 196;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "文件类型";
            this.columnHeader3.Width = 63;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "大小";
            this.columnHeader2.Width = 63;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "创建时间";
            this.columnHeader4.Width = 127;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "修改时间";
            this.columnHeader5.Width = 119;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "属性";
            this.columnHeader6.Width = 83;
            // 
            // imageListFileTypeList
            // 
            this.imageListFileTypeList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFileTypeList.ImageStream")));
            this.imageListFileTypeList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFileTypeList.Images.SetKeyName(0, "err");
            // 
            // spBottom
            // 
            this.spBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spBottom.BackColor = System.Drawing.Color.DarkGray;
            this.spBottom.Location = new System.Drawing.Point(0, 545);
            this.spBottom.Name = "spBottom";
            this.spBottom.Size = new System.Drawing.Size(907, 1);
            this.spBottom.TabIndex = 1;
            this.spBottom.TabStop = false;
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            this.fileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Created);
            this.fileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Deleted);
            this.fileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher_Renamed);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(907, 593);
            this.Controls.Add(this.spBottom);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "任务管理器";
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.Deactivate += new System.EventHandler(this.FormMain_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageProcCtl.ResumeLayout(false);
            this.tabPageProcCtl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spl1)).EndInit();
            this.tabPageKernelCtl.ResumeLayout(false);
            this.tabPageKernelCtl.PerformLayout();
            this.tabPageScCtl.ResumeLayout(false);
            this.tabPageScCtl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageFileCtl.ResumeLayout(false);
            this.tabPageFileCtl.PerformLayout();
            this.splitContainerFm.Panel1.ResumeLayout(false);
            this.splitContainerFm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFm)).EndInit();
            this.splitContainerFm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageProcCtl;
        private System.Windows.Forms.TabPage tabPageKernelCtl;
        private System.Windows.Forms.TabPage tabPageSysCtl;
        private System.Windows.Forms.PictureBox spBottom;
        private System.Windows.Forms.Button btnEndProcess;
        private Ctls.TaskMgrList listProcess;
        private System.Windows.Forms.Label lbProcessCount;
        private Ctls.TaskMgrList listDrivers;
        private System.Windows.Forms.PictureBox spl1;
        private System.Windows.Forms.LinkLabel lbShowDetals;
        private System.Windows.Forms.Label lbDriversCount;
        private System.Windows.Forms.TabPage tabPageScCtl;
        private System.Windows.Forms.TabPage tabPageStartCtl;
        private System.Windows.Forms.TabPage tabPageFileCtl;
        private System.Windows.Forms.SplitContainer splitContainerFm;
        private System.Windows.Forms.TreeView treeFmLeft;
        private System.Windows.Forms.ListView listFm;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ImageList imageListFileMgrLeft;
        private System.Windows.Forms.TextBox textBoxFmCurrent;
        private System.Windows.Forms.ImageList imageListFileTypeList;
        private System.Windows.Forms.Button btnFmAddGoto;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lbFileMgrStatus;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.ListView listService;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkOpenScMsc;
        private System.Windows.Forms.Label lbServicesCount;
    }
}
