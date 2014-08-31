﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;

namespace UseView
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-GI7E47AND9R\\LS;Database=db_TomeTwo;Uid=sa;Pwd=");//连接数据库
            SqlDataAdapter dap = new SqlDataAdapter("select * from V_SaleDetail", con);//查询视图
            DataSet ds = new DataSet();//创建DataSet对象
            dap.Fill(ds);//填充DataSet数据集
            dataGridView1.DataSource = ds.Tables[0].DefaultView;//显示查询后的数据
        }
    }
}