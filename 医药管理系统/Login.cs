using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 医药管理系统
{
    public partial class Login : Form
    {
        List<String> list;
        public Login()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "MacOS.ssk";
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                login_class l=new login_class();
                int flag = l.login(textBox1.Text,textBox2.Text);
                if (flag == 2)
                {
                    main m = new main();
                    m.setlist(l.getList());
                    this.Close();
                }
                else if(flag==1)
                {
                    MessageBox.Show("密码错误，请重新输入");
                }
                else if (flag == 0)
                {
                    MessageBox.Show("用户名不存在");
                }
                else
                { 
                }
            }
            else
            {
                MessageBox.Show("请输入用户名和密码");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
