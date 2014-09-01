﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UseABS
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
            dgv_Message.Columns[0].Width = 300;//设置列宽度
        }

        private void btn_Get_Click(object sender, EventArgs e)
        {
            dgv_Message.DataSource = GetABS();//设置数据源
            dgv_Message.Columns[0].Width = 150;//设置列宽度
        }

        /// <summary>
        /// 查询数据库信息
        /// </summary>
        /// <returns>方法返回DataTable对象</returns>
        private DataTable GetABS()
        {
            string P_Str_ConnectionStr = string.Format(//创建数据库连接字符串
                @"server=(local);database=db_TomeTwo;uid=sa;Pwd=6221131");
            string P_Str_SqlStr = string.Format(//创建SQL查询字符串
                "SELECT myvalue as 数值,ABS(myvalue) AS 求绝对值后 FROM tb_Value");
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
                "SELECT myvalue as 数值 FROM tb_Value");
            SqlDataAdapter P_SqlDataAdapter = new SqlDataAdapter(//创建数据适配器
                P_Str_SqlStr, P_Str_ConnectionStr);
            DataTable P_dt = new DataTable();//创建数据表
            P_SqlDataAdapter.Fill(P_dt);//填充数据表
            return P_dt;//返回数据表
        }

    }
}
