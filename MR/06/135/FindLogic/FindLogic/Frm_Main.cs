﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FindLogic
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            cbox_Bool.SelectedIndex = 0;//设置选中项
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            dgv_Message.DataSource =//设置数据源
                GetMessage(cbox_Bool.Text == "是" ? "true" : "false");
        }

        /// <summary>
        /// 查询数据库信息
        /// </summary>
        /// <returns>方法返回DataTable对象</returns>
        private DataTable GetMessage(string TongZhao)
        {
            string P_Str_ConnectionStr = string.Format(//创建数据库连接字符串
                @"server=(local)\sqlexpress;database=db_TomeTwo;uid=sa;pwd=6221131");
            string P_Str_SqlStr = string.Format(//创建SQL查询字符串
                "SELECT 学生姓名,年龄,性别,统招否,家庭住址 FROM tb_Student WHERE 统招否='{0}'",
                TongZhao);
            SqlDataAdapter P_SqlDataAdapter = new SqlDataAdapter(//创建数据适配器
                P_Str_SqlStr, P_Str_ConnectionStr);
            DataTable P_dt = new DataTable();//创建数据表
            P_SqlDataAdapter.Fill(P_dt);//填充数据表
            return P_dt;//返回数据表
        }
    }
}
