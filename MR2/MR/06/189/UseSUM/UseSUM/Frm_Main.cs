﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UseSUM
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            dgv_Message.DataSource = GetMessage();//设置数据源
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            DataSet P_ds = GetCount();//得到数据集
            txt_Count.Text = P_ds.Tables[0].Rows[0][0].ToString();//得到总数量
            txt_Money.Text = P_ds.Tables[0].Rows[0][1].ToString();//得到总金额
        }

        /// <summary>
        /// 查询图书数量及金额信息
        /// </summary>
        /// <returns>方法返回DataTable对象</returns>
        private DataSet GetCount()
        {
            string P_Str_ConnectionStr = string.Format(//创建数据库连接字符串
                @"server=(local)\sqlexpress;database=db_TomeTwo;uid=sa;pwd=6221131");
            string P_Str_SqlStr = string.Format(//创建SQL查询字符串
                "SELECT SUM(销售数量) AS 总数量 ,SUM(金额) AS 总金额 FROM tb_Book");
            SqlDataAdapter P_SqlDataAdapter = new SqlDataAdapter(//创建数据适配器
                P_Str_SqlStr, P_Str_ConnectionStr);
            DataSet P_ds = new DataSet();//创建数据集
            P_SqlDataAdapter.Fill(P_ds);//填充数据集
            return P_ds;//返回数据集
        }

        /// <summary>
        /// 查询数据库信息
        /// </summary>
        /// <returns>方法返回DataTable对象</returns>
        private DataTable GetMessage()
        {
            string P_Str_ConnectionStr = string.Format(//创建数据库连接字符串
                @"server=(local)\sqlexpress;database=db_TomeTwo;uid=sa;pwd=6221131");
            string P_Str_SqlStr = string.Format(//创建SQL查询字符串
                "SELECT * FROM tb_Book");
            SqlDataAdapter P_SqlDataAdapter = new SqlDataAdapter(//创建数据适配器
                P_Str_SqlStr, P_Str_ConnectionStr);
            DataTable P_dt = new DataTable();//创建数据表
            P_SqlDataAdapter.Fill(P_dt);//填充数据表
            return P_dt;//返回数据表
        }

    }
}