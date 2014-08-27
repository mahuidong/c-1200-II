﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CombineSelect
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            DataSet P_ds=GetMessage();//得到数据集
            dgv_Student.DataSource = P_ds.Tables[0];//设置数据源
            dgv_Grade.DataSource = P_ds.Tables[1];//设置数据源
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            dgv_Combine.DataSource = GetStudent();//设置数据源
        }

        /// <summary>
        /// 查询学生信息
        /// </summary>
        /// <returns>方法返回DataTable对象</returns>
        private DataTable GetStudent()
        {
            string P_Str_ConnectionStr = string.Format(//创建数据库连接字符串
                @"server=WIN-GI7E47AND9R\LS;database=db_TomeTwo;uid=sa;pwd=");
            string P_Str_SqlStr = string.Format(//创建SQL查询字符串
                @"SELECT 学生编号,学生姓名,性别,年龄 FROM tb_Student WHERE 所在学院='理学院' UNION 
SELECT 学生编号,学生姓名,性别,年龄 FROM tb_Student WHERE 学生编号 IN (SELECT 学生编号 FROM tb_Grade
WHERE 总分 >600)");
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
        private DataSet GetMessage()
        {
            string P_Str_ConnectionStr = string.Format(//创建数据库连接字符串
                @"server=WIN-GI7E47AND9R\LS;database=db_TomeTwo;uid=sa;pwd=");
            string P_Str_SqlStr = string.Format(//创建SQL查询字符串
                "select * from tb_Student select * from tb_Grade");
            SqlDataAdapter P_SqlDataAdapter = new SqlDataAdapter(//创建数据适配器
                P_Str_SqlStr, P_Str_ConnectionStr);
            DataSet P_ds = new DataSet();//创建数据表
            P_SqlDataAdapter.Fill(P_ds);//填充数据表
            return P_ds;//返回数据表
        }

    }
}
