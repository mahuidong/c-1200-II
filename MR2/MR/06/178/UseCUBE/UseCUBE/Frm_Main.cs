﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UseCUBE
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
            dgv_Message.DataSource = GetEmployee();//设置数据源
            dgv_Message.Columns[2].Width = 200;//设置列宽度
        }

        /// <summary>
        /// 查询数据库信息
        /// </summary>
        /// <returns>方法返回DataTable对象</returns>
        private DataTable GetEmployee()
        {
            string P_Str_ConnectionStr = string.Format(//创建数据库连接字符串
                @"server=(local);database=db_TomeTwo;uid=sa;pwd=6221131");
            string P_Str_SqlStr = string.Format(//创建SQL查询字符串
                @"SELECT 所属部门,性别,AVG(工资) AS 平均工资 FROM
tb_Employee GROUP BY 所属部门,性别 WITH CUBE");
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
                @"server=(local);database=db_TomeTwo;uid=sa;pwd=6221131");
            string P_Str_SqlStr = string.Format(//创建SQL查询字符串
                "SELECT * FROM tb_Employee");
            SqlDataAdapter P_SqlDataAdapter = new SqlDataAdapter(//创建数据适配器
                P_Str_SqlStr, P_Str_ConnectionStr);
            DataTable P_dt = new DataTable();//创建数据表
            P_SqlDataAdapter.Fill(P_dt);//填充数据表
            return P_dt;//返回数据表
        }

    }
}
