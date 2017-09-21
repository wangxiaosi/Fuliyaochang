using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 医药管理系统
{
     class user_qx
    {
        private String username, ps, part, parts, customerinforAdd, customerInforDelete, customerInforUpdate, customerInforSelect;
        private String stockIn, stockOut, inventoryinfor, orderInsert, orderExamine, orderSelect, orderUpdate, returnOrderManage, returnGoodsManage, sendGoodsManage;
        private String inventoryStatistics, saleStatistics, returnOrderStatistics, returnGoodsStatistics, commodityAdd, commoditySpecificationAdd, commodityInforUpdate;
        private String commodityInforDelete, inventory, staffAdd, staffDelete, staffInforSelect, staffInforUpdate, powerUpdate, supplierAdd;
        private String supplierUpdate, supplierDelete, supplierSelect, saleExamination, age, phoneNumber;
        private List<String> list;
        public void init(String username, String ps, String part)
        {
            this.username = username;
            this.ps = ps;
            this.part = part;
            assignment();
        }
        public void assignment()
        {
            MySqlDataReader reader = null;
            MySqlConnection conn = new sql_conn().getconn();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from part where id = " + this.part,conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.parts = reader[1].ToString();
                    this.customerinforAdd = reader[2].ToString();
                    this.customerInforDelete = reader[3].ToString();
                    this.customerInforUpdate = reader[4].ToString();
                    this.customerInforSelect = reader[5].ToString();
                    this.stockIn = reader[6].ToString();
                    this.stockOut = reader[7].ToString();
                    this.inventoryinfor = reader[8].ToString();
                    this.orderInsert = reader[9].ToString();
                    this.orderExamine = reader[10].ToString();
                    this.orderSelect = reader[11].ToString();
                    this.orderUpdate = reader[12].ToString();
                    this.returnOrderManage = reader[13].ToString();
                    this.returnGoodsManage = reader[14].ToString();
                    this.sendGoodsManage = reader[15].ToString();
                    this.inventoryStatistics = reader[16].ToString();
                    this.saleStatistics = reader[17].ToString();
                    this.returnOrderStatistics = reader[18].ToString();
                    this.returnGoodsStatistics = reader[19].ToString();
                    this.commodityAdd = reader[20].ToString();
                    this.commoditySpecificationAdd = reader[21].ToString();
                    this.commodityInforUpdate = reader[22].ToString();
                    this.commodityInforDelete = reader[23].ToString();
                    this.inventory = reader[24].ToString();
                    this.staffAdd = reader[25].ToString();
                    this.staffDelete = reader[26].ToString();
                    this.staffInforSelect = reader[27].ToString();
                    this.staffInforUpdate = reader[28].ToString();
                    this.powerUpdate = reader[29].ToString();
                    this.supplierAdd = reader[30].ToString();
                    this.supplierUpdate = reader[31].ToString();
                    this.supplierDelete = reader[32].ToString();
                    this.supplierSelect = reader[33].ToString();
                    this.saleExamination = reader[34].ToString();
                }
            }
            catch
            {
                MessageBox.Show("数据库连接失败，请重试");
            }
            finally
            {
                conn.Close();
                reader.Close();
                get();
            }
        }
        public void get()
        {
            list = new List<string>();
            list.Add(this.username);
            list.Add(this.ps);
            list.Add(this.parts);
            list.Add(parts );
            list.Add(customerinforAdd ) ;
            list.Add(customerInforDelete ) ;
            list.Add(customerInforUpdate ) ;
            list.Add(customerInforSelect ); 
            list.Add(stockIn ); 
            list.Add(stockOut ); 
            list.Add(inventoryinfor ); 
            list.Add(orderInsert ); 
            list.Add(orderExamine ); 
            list.Add(orderSelect ); 
            list.Add(orderUpdate ); 
            list.Add(returnOrderManage ); 
            list.Add(returnGoodsManage ); 
            list.Add(sendGoodsManage ); 
            list.Add(inventoryStatistics ); 
            list.Add(saleStatistics ); 
            list.Add(returnOrderStatistics ); 
            list.Add(returnGoodsStatistics ); 
            list.Add(commodityAdd ); 
            list.Add(commoditySpecificationAdd ); 
            list.Add(commodityInforUpdate ); 
            list.Add(customerInforDelete );
            list.Add(inventory ); 
            list.Add(staffAdd ); 
            list.Add(staffDelete ); 
            list.Add(staffInforSelect ); 
            list.Add(staffInforUpdate ); 
            list.Add(powerUpdate ); 
            list.Add(supplierAdd ); 
            list.Add(supplierUpdate ); 
            list.Add(supplierDelete ); 
            list.Add(supplierSelect ); 
            list.Add(saleExamination ); 
        }
        public List<String> getList()
        {
            return list;
        }
    }
}
