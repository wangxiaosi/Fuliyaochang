using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 医药管理系统
{
    class login_class
    {
        List<String> list;
        public int login(String username,String ps)
        {
            
            int flag=0;
            MySqlConnection con = new sql_conn().getconn();
            MySqlDataReader reader = null;
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from user", con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == username) 
                    {
                        flag = 1;
                        if (reader[1].ToString()==ps)
                        {
                            flag = 2;
                            user_qx user=new user_qx();
                            user.init(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
                            list = user.getList();
                            break;
                        }
                    }
                }
                con.Close();
                reader.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("数据库连接失败，请检查网络连接后重试");
                flag = -1;
            }
            finally
            {

            }
            return flag;
            
        }
        public List<String> getList()
        {
            return list;
        }
    }
}
