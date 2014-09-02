﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataSetAggregate
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            string conStr = "Data Source=(local);Database=db_TomeTwo;UID=sa;Pwd=;";//取连接字符串
            string sql = "select * from V_SaleInfo";//构造sql语句
            DataSet ds = new DataSet();//创建数据集
            using (SqlConnection con = new SqlConnection(conStr))//创建数据连接
            {
                SqlCommand cmd = new SqlCommand(sql, con);//创建Command对象
                SqlDataAdapter sda = new SqlDataAdapter(cmd);//创建DataAdapter对象
                sda.Fill(ds, "V_SaleInfo");//填充数据集
            }
            //使用LINQ统计每个客户的销售总额
            var query = from item in ds.Tables["V_SaleInfo"].AsEnumerable()
                        group item by item.Field<string>("ClientCode") into g
                        select new
                        {
                            客户代码 = g.Key,
                            客户名称 = g.Max(itm => itm.Field<string>("ClientName")),
                            销售总额 = g.Sum(itm => itm.Field<double>("Amount")).ToString("#,##0.00")
                        };
            dataGridView1.DataSource = query.ToList();//对dataGridView1进行数据绑定
        }
    }
}
