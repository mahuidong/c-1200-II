﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UseOrderBy
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
            dgv_Message.DataSource = GetBook();//设置数据源
        }

        /// <summary>
        /// 查询数据库信息
        /// </summary>
        /// <returns>方法返回DataTable对象</returns>
        private DataTable GetBook()
        {
            string P_Str_ConnectionStr = string.Format(//创建数据库连接字符串
                @"server=(local);database=db_TomeTwo;uid=sa;Pwd=6221131");
            string P_Str_SqlStr = string.Format(//创建SQL查询字符串
                @"SELECT TOP 5 书号,书名,作者,出版社,SUM(销售数量) AS 合计销售数量 FROM
tb_Book  GROUP BY 书号,书名,作者,出版社  ORDER BY SUM(销售数量) DESC");
            SqlDataAdapter P_SqlDataAdapter = new SqlDataAdapter(//创建数据适配器
                P_Str_SqlStr, P_Str_ConnectionStr);
            DataTable P_dt = new DataTable();//创建数据表
            P_SqlDataAdapter.Fill(P_dt);//填充数据表
            return P_dt;//返回数据表
        }

        /// <summary>
        /// 查询数据库信息
        /// </summary>
        /// <returns>方法返回DataTable对象</returns>
        private DataTable GetMessage()
        {
            string P_Str_ConnectionStr = string.Format(//创建数据库连接字符串
                @"server=(local);database=db_TomeTwo;uid=sa;Pwd=6221131");
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
