﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;

namespace GetAllView
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Database=db_TomeTwo;Uid=sa;Pwd=6221131");//连接数据库
            //获取所有视图
            SqlDataAdapter dap = new SqlDataAdapter("select name as 视图名称,crdate as 创建日期,refDate as 最后修改时间 from sysobjects where xtype='v'", con);
            DataSet ds = new DataSet();//创建DataSet对象
            dap.Fill(ds);//填充DataSet数据集
            dataGridView1.DataSource = ds.Tables[0].DefaultView;//显示查询后的数据
        }
    }
}