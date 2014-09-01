﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectInitialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("使用对象初始化器创建对象并为其属性赋值\n");
            User P_user = new User() { Name = "刘老师", Age = 28 };//创建test对象P_Test并赋值
            Console.Write("用户名：" + P_user.Name + "   年龄：" + P_user.Age);//输出信息
            Console.ReadLine();
        }
    }
    class User
    {
        public string Name { get; set; }//自动实现属性
        public int Age { get; set; }//自动实现属性
    }
}
