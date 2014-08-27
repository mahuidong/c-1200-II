﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UseFunc
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            cbox_Count.SelectedIndex = 0;//设置选项索引
        }

        /// <summary>
        /// 查询数据库信息
        /// </summary>
        /// <returns>方法返回DataTable对象</returns>
        private DataTable GetMessage(string count)
        {
            string P_Str_ConnectionStr = string.Format(//创建数据库连接字符串
                @"server=(local);database=db_TomeTwo;uid=sa;pwd=6221131");
            string P_Str_SqlStr = string.Format(
                "SELECT 学生编号,学生姓名,年龄,性别 FROM tb_Student where LEN(学生姓名)={0}",
                count);
            SqlDataAdapter P_SqlDataAdapter = new SqlDataAdapter(//创建数据适配器
                P_Str_SqlStr, P_Str_ConnectionStr);
            DataTable P_dt = new DataTable();//创建数据表
            P_SqlDataAdapter.Fill(P_dt);//填充数据表
            return P_dt;//返回数据表
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            dgv_Message.DataSource = GetMessage(cbox_Count.Text);//绑定到DataTable对象
        }
    }

    class Student//定义Student类
    {
        public string Name { get; set; }//创建属性
        public override string ToString()//重写ToString方法
        {
            return Name;
        }
    }
}
