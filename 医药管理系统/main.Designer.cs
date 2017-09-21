namespace 医药管理系统
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.tabcontrol = new DevExpress.XtraTab.XtraTabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.advTree1 = new DevComponents.AdvTree.AdvTree();
            this.node1 = new DevComponents.AdvTree.Node();
            this.node9 = new DevComponents.AdvTree.Node();
            this.node10 = new DevComponents.AdvTree.Node();
            this.node2 = new DevComponents.AdvTree.Node();
            this.node11 = new DevComponents.AdvTree.Node();
            this.node12 = new DevComponents.AdvTree.Node();
            this.node13 = new DevComponents.AdvTree.Node();
            this.node16 = new DevComponents.AdvTree.Node();
            this.node15 = new DevComponents.AdvTree.Node();
            this.node33 = new DevComponents.AdvTree.Node();
            this.node3 = new DevComponents.AdvTree.Node();
            this.node17 = new DevComponents.AdvTree.Node();
            this.node18 = new DevComponents.AdvTree.Node();
            this.node19 = new DevComponents.AdvTree.Node();
            this.node20 = new DevComponents.AdvTree.Node();
            this.node4 = new DevComponents.AdvTree.Node();
            this.node21 = new DevComponents.AdvTree.Node();
            this.node22 = new DevComponents.AdvTree.Node();
            this.node23 = new DevComponents.AdvTree.Node();
            this.node24 = new DevComponents.AdvTree.Node();
            this.node25 = new DevComponents.AdvTree.Node();
            this.node5 = new DevComponents.AdvTree.Node();
            this.node26 = new DevComponents.AdvTree.Node();
            this.node27 = new DevComponents.AdvTree.Node();
            this.node6 = new DevComponents.AdvTree.Node();
            this.node28 = new DevComponents.AdvTree.Node();
            this.node100 = new DevComponents.AdvTree.Node();
            this.node7 = new DevComponents.AdvTree.Node();
            this.node29 = new DevComponents.AdvTree.Node();
            this.node30 = new DevComponents.AdvTree.Node();
            this.node8 = new DevComponents.AdvTree.Node();
            this.node31 = new DevComponents.AdvTree.Node();
            this.node32 = new DevComponents.AdvTree.Node();
            this.exit = new DevComponents.AdvTree.Node();
            this.node34 = new DevComponents.AdvTree.Node();
            this.node35 = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.tabcontrol)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // tabcontrol
            // 
            this.tabcontrol.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.tabcontrol.HeaderButtons = ((DevExpress.XtraTab.TabButtons)((DevExpress.XtraTab.TabButtons.Close | DevExpress.XtraTab.TabButtons.Default)));
            this.tabcontrol.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.WhenNeeded;
            this.tabcontrol.Location = new System.Drawing.Point(167, 82);
            this.tabcontrol.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.tabcontrol.Size = new System.Drawing.Size(931, 529);
            this.tabcontrol.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.advTree1);
            this.panel1.Location = new System.Drawing.Point(1, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 524);
            this.panel1.TabIndex = 2;
            // 
            // advTree1
            // 
            this.advTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.advTree1.AllowDrop = true;
            this.advTree1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTree1.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTree1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.advTree1.Location = new System.Drawing.Point(3, 0);
            this.advTree1.Name = "advTree1";
            this.advTree1.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node1,
            this.node2,
            this.node3,
            this.node4,
            this.node5,
            this.node6,
            this.node7,
            this.node8,
            this.exit,
            this.node35});
            this.advTree1.NodesConnector = this.nodeConnector1;
            this.advTree1.NodeStyle = this.elementStyle1;
            this.advTree1.PathSeparator = ";";
            this.advTree1.Size = new System.Drawing.Size(155, 521);
            this.advTree1.Styles.Add(this.elementStyle1);
            this.advTree1.TabIndex = 0;
            this.advTree1.Text = "advTree1";
            this.advTree1.Click += new System.EventHandler(this.advTree1_Click);
            // 
            // node1
            // 
            this.node1.Name = "node1";
            this.node1.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node9,
            this.node10});
            this.node1.Text = "商品管理";
            // 
            // node9
            // 
            this.node9.Expanded = true;
            this.node9.Name = "node9";
            this.node9.Text = "商品管理";
            // 
            // node10
            // 
            this.node10.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.node10.Expanded = true;
            this.node10.Name = "node10";
            this.node10.Text = "新增商品";
            // 
            // node2
            // 
            this.node2.Expanded = true;
            this.node2.Name = "node2";
            this.node2.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node11,
            this.node12,
            this.node13,
            this.node16,
            this.node15,
            this.node33});
            this.node2.Text = "库存管理";
            // 
            // node11
            // 
            this.node11.Expanded = true;
            this.node11.Name = "node11";
            this.node11.Text = "库存管理";
            // 
            // node12
            // 
            this.node12.Expanded = true;
            this.node12.Name = "node12";
            this.node12.Text = "入库管理";
            // 
            // node13
            // 
            this.node13.Expanded = true;
            this.node13.Name = "node13";
            this.node13.Text = "出库管理";
            // 
            // node16
            // 
            this.node16.Expanded = true;
            this.node16.Name = "node16";
            this.node16.Text = "出库审核";
            // 
            // node15
            // 
            this.node15.Expanded = true;
            this.node15.Name = "node15";
            this.node15.Text = "库存预警";
            // 
            // node33
            // 
            this.node33.Expanded = true;
            this.node33.Name = "node33";
            this.node33.Text = "退货/单审核";
            // 
            // node3
            // 
            this.node3.Name = "node3";
            this.node3.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node17,
            this.node18,
            this.node19,
            this.node20});
            this.node3.Text = "销售管理";
            // 
            // node17
            // 
            this.node17.Expanded = true;
            this.node17.Name = "node17";
            this.node17.Text = "销售管理";
            // 
            // node18
            // 
            this.node18.Expanded = true;
            this.node18.Name = "node18";
            this.node18.Text = "新建销售单";
            // 
            // node19
            // 
            this.node19.Expanded = true;
            this.node19.Name = "node19";
            this.node19.Text = "退单管理";
            // 
            // node20
            // 
            this.node20.Expanded = true;
            this.node20.Name = "node20";
            this.node20.Text = "退货管理";
            // 
            // node4
            // 
            this.node4.Name = "node4";
            this.node4.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node21,
            this.node22,
            this.node23,
            this.node24,
            this.node25});
            this.node4.Text = "统计报表";
            // 
            // node21
            // 
            this.node21.Expanded = true;
            this.node21.Name = "node21";
            this.node21.Text = "入库报表";
            // 
            // node22
            // 
            this.node22.Expanded = true;
            this.node22.Name = "node22";
            this.node22.Text = "出库报表";
            // 
            // node23
            // 
            this.node23.Expanded = true;
            this.node23.Name = "node23";
            this.node23.Text = "销售报表";
            // 
            // node24
            // 
            this.node24.Expanded = true;
            this.node24.Name = "node24";
            this.node24.Text = "退货报表";
            // 
            // node25
            // 
            this.node25.Expanded = true;
            this.node25.Name = "node25";
            this.node25.Text = "退单报表";
            // 
            // node5
            // 
            this.node5.Name = "node5";
            this.node5.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node26,
            this.node27});
            this.node5.Text = "客户管理";
            // 
            // node26
            // 
            this.node26.Expanded = true;
            this.node26.Name = "node26";
            this.node26.Text = "客户管理";
            // 
            // node27
            // 
            this.node27.Expanded = true;
            this.node27.Name = "node27";
            this.node27.Text = "新增客户";
            // 
            // node6
            // 
            this.node6.Name = "node6";
            this.node6.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node28,
            this.node100});
            this.node6.Text = "药品检验";
            // 
            // node28
            // 
            this.node28.Name = "node28";
            this.node28.Text = "药品检验";
            // 
            // node100
            // 
            this.node100.Expanded = true;
            this.node100.Name = "node100";
            this.node100.Text = "药品检验管理";
            // 
            // node7
            // 
            this.node7.Name = "node7";
            this.node7.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node29,
            this.node30});
            this.node7.Text = "员工管理";
            // 
            // node29
            // 
            this.node29.Expanded = true;
            this.node29.Name = "node29";
            this.node29.Text = "员工管理";
            // 
            // node30
            // 
            this.node30.Expanded = true;
            this.node30.Name = "node30";
            this.node30.Text = "员工入职";
            // 
            // node8
            // 
            this.node8.Name = "node8";
            this.node8.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node31,
            this.node32});
            this.node8.Text = "角色管理";
            // 
            // node31
            // 
            this.node31.Expanded = true;
            this.node31.Name = "node31";
            this.node31.Text = "角色管理";
            // 
            // node32
            // 
            this.node32.Expanded = true;
            this.node32.Name = "node32";
            this.node32.Text = "新建角色";
            // 
            // exit
            // 
            this.exit.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.exit.Expanded = true;
            this.exit.Name = "exit";
            this.exit.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node34});
            this.exit.Text = "退出系统";
            // 
            // node34
            // 
            this.node34.Expanded = true;
            this.node34.Name = "node34";
            this.node34.Text = "退出系统";
            // 
            // node35
            // 
            this.node35.Expanded = true;
            this.node35.Name = "node35";
            this.node35.Text = "切换用户";
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.Color.White;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 76);
            this.panel2.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 614);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1119, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 636);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabcontrol)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private DevExpress.XtraTab.XtraTabControl tabcontrol;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.AdvTree.AdvTree advTree1;
        private DevComponents.AdvTree.Node node1;
        private DevComponents.AdvTree.Node node9;
        private DevComponents.AdvTree.Node node10;
        private DevComponents.AdvTree.Node node2;
        private DevComponents.AdvTree.Node node11;
        private DevComponents.AdvTree.Node node12;
        private DevComponents.AdvTree.Node node13;
        private DevComponents.AdvTree.Node node16;
        private DevComponents.AdvTree.Node node14;
        private DevComponents.AdvTree.Node node15;
        private DevComponents.AdvTree.Node node3;
        private DevComponents.AdvTree.Node node17;
        private DevComponents.AdvTree.Node node18;
        private DevComponents.AdvTree.Node node19;
        private DevComponents.AdvTree.Node node20;
        private DevComponents.AdvTree.Node node4;
        private DevComponents.AdvTree.Node node21;
        private DevComponents.AdvTree.Node node22;
        private DevComponents.AdvTree.Node node23;
        private DevComponents.AdvTree.Node node24;
        private DevComponents.AdvTree.Node node25;
        private DevComponents.AdvTree.Node node5;
        private DevComponents.AdvTree.Node node26;
        private DevComponents.AdvTree.Node node27;
        private DevComponents.AdvTree.Node node6;
        private DevComponents.AdvTree.Node node28;
        private DevComponents.AdvTree.Node node100;
        private DevComponents.AdvTree.Node node7;
        private DevComponents.AdvTree.Node node8;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.AdvTree.Node node29;
        private DevComponents.AdvTree.Node node30;
        private DevComponents.AdvTree.Node node31;
        private DevComponents.AdvTree.Node node32;
        private DevComponents.AdvTree.Node exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private DevComponents.AdvTree.Node node34;
        private DevComponents.AdvTree.Node node35;
        private DevComponents.AdvTree.Node node33;
    }
}