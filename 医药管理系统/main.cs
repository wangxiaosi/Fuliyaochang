using InventoryManagentSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using 医药管理系统.customer;
using 医药管理系统.drug;
using 医药管理系统.kucun;
using 医药管理系统.test;

namespace 医药管理系统
{
    public partial class main : Form
    {
        List<String> list;
        sale s_17 = new sale();
        sale_Add s_18 = new sale_Add();
        sale_Del s_19 = new sale_Del();
        Good_Del s_20 = new Good_Del();
        addDrug s_10 = new addDrug();
        queryDrug s_9 = new queryDrug();
        Form_InventoryWarning s_15 = new Form_InventoryWarning();
        Form_StockIn s_12 = new Form_StockIn();
        Form_StockOut s_13 = new Form_StockOut();
        Form_StockOutCheck s_16 = new Form_StockOutCheck();
        Form_WarehouseManage s_11 = new Form_WarehouseManage();
        Form_MedicineCheck s_28 = new Form_MedicineCheck();
        Form_MCManage s_100 = new Form_MCManage();
        Form_CustomerManage s_26 = new Form_CustomerManage();
        Form_CustomerAdd s_27 = new Form_CustomerAdd();
        Limits.limitList s_31 = new Limits.limitList();
        Limits.addLimits s_32 = new Limits.addLimits();
        good_sale_delete s_33 = new good_sale_delete();
        public main()
        {
            
            InitializeComponent();
            this.skinEngine1.SkinFile = "MacOS.ssk";
            this.Text = "石家庄市长安福利药化工厂仓库管理系统";
            this.Show();
            this.tabcontrol.CloseButtonClick += new EventHandler(close_click);
            this.advTree1.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(select);
            this.FormClosing += new FormClosingEventHandler(close_clicked);
        }
        public void select(object o, DevComponents.AdvTree.TreeNodeMouseEventArgs d)
        {
            if (this.advTree1.SelectedIndex == 35)
            {
                if (MessageBox.Show("是否确定退出？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else if (this.advTree1.SelectedIndex == 36)
            {
                if (MessageBox.Show("是否确定切换用户？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Login l = new Login();
                    this.Close();
                }
            }
            else if (this.advTree1.SelectedNode == this.node17)
            {
                if (this.tabcontrol.TabPages.Contains(s_17) == false)
                {
                    this.tabcontrol.TabPages.Add(s_17);
                }
                this.tabcontrol.SelectedTabPage = s_17;
            }
            else if (this.advTree1.SelectedNode == this.node33)
            {
                if (this.tabcontrol.TabPages.Contains(s_33) == false)
                {
                    this.tabcontrol.TabPages.Add(s_33);
                }
                this.tabcontrol.SelectedTabPage = s_33;
            }
            else if (this.advTree1.SelectedNode == this.node31)
            {
                if (this.tabcontrol.TabPages.Contains(s_31) == false)
                {
                    this.tabcontrol.TabPages.Add(s_31);
                }
                this.tabcontrol.SelectedTabPage = s_31;
            }
            else if (this.advTree1.SelectedNode == this.node32)
            {
                if (this.tabcontrol.TabPages.Contains(s_32) == false)
                {
                    this.tabcontrol.TabPages.Add(s_32);
                }
                this.tabcontrol.SelectedTabPage = s_32;
            }
            else if (this.advTree1.SelectedNode == this.node26)
            {
                if (this.tabcontrol.TabPages.Contains(s_26) == false)
                {
                    this.tabcontrol.TabPages.Add(s_26);
                }
                this.tabcontrol.SelectedTabPage = s_26;
            }
            else if (this.advTree1.SelectedNode == this.node27)
            {
                if (this.tabcontrol.TabPages.Contains(s_27) == false)
                {
                    this.tabcontrol.TabPages.Add(s_27);
                }
                this.tabcontrol.SelectedTabPage = s_27;
            }
            else if (this.advTree1.SelectedNode == this.node18)
            {
                if (this.tabcontrol.TabPages.Contains(s_18) == false)
                {
                    this.tabcontrol.TabPages.Add(s_18);
                }
                this.tabcontrol.SelectedTabPage = s_18;
            }
            else if (this.advTree1.SelectedNode == this.node100)
            {
                if (this.tabcontrol.TabPages.Contains(s_100) == false)
                {
                    this.tabcontrol.TabPages.Add(s_100);
                }
                this.tabcontrol.SelectedTabPage = s_100;
            }
            else if (this.advTree1.SelectedNode == this.node11)
            {
                if (this.tabcontrol.TabPages.Contains(s_11) == false)
                {
                    this.tabcontrol.TabPages.Add(s_11);
                }
                this.tabcontrol.SelectedTabPage = s_11;
            }
            else if (this.advTree1.SelectedNode == this.node16)
            {
                if (this.tabcontrol.TabPages.Contains(s_16) == false)
                {
                    this.tabcontrol.TabPages.Add(s_16);
                }
                this.tabcontrol.SelectedTabPage = s_16;
            }
            else if (this.advTree1.SelectedNode == this.node19)
            {
                if (this.tabcontrol.TabPages.Contains(s_19) == false)
                {
                    this.tabcontrol.TabPages.Add(s_19);
                }
                this.tabcontrol.SelectedTabPage = s_19;
            }
            else if (this.advTree1.SelectedNode == this.node13)
            {
                if (this.tabcontrol.TabPages.Contains(s_13) == false)
                {
                    this.tabcontrol.TabPages.Add(s_13);
                }
                this.tabcontrol.SelectedTabPage = s_13;
            }
            else if (this.advTree1.SelectedNode == this.node28)
            {
                if (this.tabcontrol.TabPages.Contains(s_28) == false)
                {
                    this.tabcontrol.TabPages.Add(s_28);
                }
                this.tabcontrol.SelectedTabPage = s_28;
            }
            else if (this.advTree1.SelectedNode == this.node20)
            {
                if (this.tabcontrol.TabPages.Contains(s_20) == false)
                {
                    this.tabcontrol.TabPages.Add(s_20);
                }
                this.tabcontrol.SelectedTabPage = s_20;
            }
            else if (this.advTree1.SelectedNode == this.node10)
            {
                if (this.tabcontrol.TabPages.Contains(s_10) == false)
                {
                    this.tabcontrol.TabPages.Add(s_10);
                }
                this.tabcontrol.SelectedTabPage = s_10;
            }
            else if (this.advTree1.SelectedNode == this.node9)
            {
                if (this.tabcontrol.TabPages.Contains(s_9) == false)
                {
                    this.tabcontrol.TabPages.Add(s_9);
                }
                this.tabcontrol.SelectedTabPage = s_9;
            }
            else if (this.advTree1.SelectedNode == this.node15)
            {
                if (this.tabcontrol.TabPages.Contains(s_15) == false)
                {
                    this.tabcontrol.TabPages.Add(s_15);
                }
                this.tabcontrol.SelectedTabPage = s_15;
            }
            else if (this.advTree1.SelectedNode == this.node12)
            {
                if (this.tabcontrol.TabPages.Contains(s_12) == false)
                {
                    this.tabcontrol.TabPages.Add(s_12);
                }
                this.tabcontrol.SelectedTabPage = s_12;
            }
        }
        public void close_click(object o, EventArgs e)
        {
            this.tabcontrol.TabPages.Remove(this.tabcontrol.SelectedTabPage);
        }
        public void close_clicked(Object o, FormClosingEventArgs e)
        {
            if (e.CloseReason==CloseReason.UserClosing)
            {
                if (MessageBox.Show("是否确定退出？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel=true;
                }
            }
        }
        public void setlist(List<String> l)
        {
            list = l;
            this.toolStripStatusLabel1.Text = "欢迎登陆："+list[0];
            this.toolStripStatusLabel2.Text = "就绪";
        }
        public void setstatus(int time)
        {
            this.toolStripStatusLabel2.Text = "加载中";
           // this.toolStripProgressBar1.
        }
        private void main_Load(object sender, EventArgs e)
        {

        }

        private void advTree1_Click(object sender, EventArgs e)
        {

        }
    }
}
