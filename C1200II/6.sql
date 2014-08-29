--6.1 SELECT字句
SELECT 学生编号,学生姓名,性别,年龄,家庭住址 FROM tb_Student;--128
SELECT 学生姓名 as 姓名,年龄 as 学生年龄,性别 as 学生性别 from tb_Student;--129
SELECT 学生编号,学生姓名,高数+外语 AS 高数加外语的分数 FROM tb_Grade;--130
SELECT 学生编号,学生姓名,年龄,性别 FROM tb_Student where LEN(学生姓名)=3;--131

--6.2 查询常量
SELECT 学生姓名,年龄,性别,家庭住址 FROM tb_Student where 年龄=24;--132
SELECT 学生姓名,年龄,性别,家庭住址 FROM tb_Student WHERE 学生姓名='王*立';--133
SELECT 学生姓名,年龄,性别,出生年月 FROM tb_Student WHERE 出生年月 = '1980-12-24';--134
SELECT 学生姓名,年龄,性别,统招否,家庭住址 FROM tb_Student WHERE 统招否='true';--135
SELECT 学生姓名,年龄,性别,家庭住址 FROM tb_Student WHERE 家庭住址 IS NULL OR 家庭住址='';--136

--6.3 查询变量
SELECT 学生姓名,年龄,性别,家庭住址 FROM tb_Student WHERE 学生姓名='李*灵';--137
SELECT 学生姓名,年龄,性别,家庭住址 FROM tb_Student WHERE 年龄=24;--138
SELECT 学生姓名,年龄,性别,出生年月 FROM tb_Student WHERE 出生年月 = '1980-12-24';--139

--6.4 模糊查询
SELECT 学生姓名,年龄,性别,家庭住址 FROM tb_Student WHERE 学生姓名 LIKE '王__';--140
SELECT 学生姓名,年龄,性别,家庭住址 FROM tb_Student WHERE 学生姓名 LIKE '张%';--141
SELECT 学生姓名,年龄,性别,家庭住址 FROM tb_Student WHERE 年龄 Like '2[0-9]';--142
SELECT 学生姓名,年龄,性别,家庭住址 FROM tb_Student WHERE 学生姓名 LIKE '[^李]%'; --143
SELECT 学生姓名,年龄,性别,家庭住址 FROM tb_Student    WHERE 学生姓名 LIKE '李%' and 年龄 LIKE '2%' and 家庭住址 LIKE '吉林%';--144

--6.5 Top和Percent限制查询结果
SELECT Top 10 学生编号,学生姓名,年龄,性别,家庭住址 FROM tb_Student ORDER BY 学生编号 ASC;--145
SELECT Top 10 学生编号,学生姓名,高数,外语,软件工程 FROM tb_Grade ORDER BY 高数+外语+软件工程 ASC;--146
SELECT TOP 10 * FROM (SELECT TOP 20 * FROM tb_Grade ORDER BY 总分 DESC) AS st ORDER BY 总分 ASC;--147
SELECT TOP 50 PERCENT 书号,书名,sum(销售数量)as 合计销售数量 FROM tb_Book group by 书号,书名,作者 order by 3 desc;--148
SELECT TOP 20 PERCENT * FROM tb_BookMessage ORDER BY 现存数量 ASC;--149


--6.6 数值查询
SELECT 学生姓名,ISNUMERIC(年龄) FROM tb_Student;--150
SELECT dm AS 数值取整前,CEILING(dm) AS 数值取整后 FROM tb_Money;--151 进一取整
SELECT dm AS 四舍五入前, ROUND(dm,1) as 四舍五入后 FROM tb_Money;--152 四舍五入
SELECT angle as 角度, SIN(ANGLE*PI()/180) AS 正弦值 FROM tb_Angle;--153
SELECT myvalue as 数值,ABS(myvalue) AS 求绝对值后 FROM tb_Value;--154
SELECT * FROM tb_Student WHERE 学生编号=22050110+FLOOR(RAND()*10);--155
SELECT myvalue AS 数值 ,SIGN(myvalue) AS 判断数字的值 FROM tb_value;--156 判断正负数

--6.7 字符串查询
SELECT friendname AS 字符串,LOWER(friendname)AS 全部转换为小写,UPPER(friendname) AS 全部转换为大写 FROM tb_string;--157
SELECT friendname AS 字符串, (LEN(friendname)-LEN(REPLACE(friendname,'i','')))/LEN('i') as 出现指定字符的次数 FROM tb_string;--158
SELECT 学生姓名,所在学院,SUBSTRING(所在学院,2,3) AS 所在学院的子串 FROM tb_student;--159
SELECT 所在学院 AS 删除字符串前,STUFF(所在学院,2,1,'') as 删除字符串后 from tb_Student;--160
SELECT 所在学院 , CHARINDEX('学院' , 所在学院) AS 索引位置 FROM tb_Student;--161
SELECT 所在学院 , REPLACE(所在学院,'学院','XueYuan') AS 替换后的信息 FROM tb_Student;--161
SELECT 学生姓名,CASE WHEN 所在学院 = '计算机学院' THEN '计算机学院学生' ELSE '否' END AS 是否为计算机学院学生 FROM tb_Student;--162

--6.8 周期，日期查询
SELECT 学生编号,学生姓名,CASE WHEN ISDATE(出生年月)=1 THEN '是日期信息' ELSE '非日期信息' END AS 生日字段是否为日期信息 FROM tb_Student;--163
SELECT 学生编号,学生姓名,年龄,性别,出生年月,家庭住址 FROM tb_Student WHERE 出生年月='1980/12/24';--164
SELECT * FROM tb_Book WHERE 日期 BETWEEN '2005/8/27 21:01:35' AND '2014/8/27 21:01:35';--165
SELECT 书号,书名,销售数量,日期 FROM tb_Book WHERE YEAR(日期)='2005'AND MONTH(日期)='10'AND DAY(日期)='6';--166
SELECT GETDATE() AS 当前日期时间,DATENAME(WEEKDAY,GETDATE()) AS 星期;--167
SELECT 学生姓名,出生年月,DATEDIFF(YEAR,出生年月,GETDATE()) AS 学生年龄 FROM tb_Student;--168

--6.9 比较,逻辑,重复查询
SELECT * FROM tb_Student WHERE 学生编号 Like '%%';--169
SELECT * FROM tb_Grade WHERE 高数>80;--170
SELECT * FROM tb_Grade WHERE 数据结构<60;--170
SELECT * FROM tb_Grade WHERE 软件工程>90 AND 外语 NOT BETWEEN 70 AND 85;--170
SELECT DISTINCT 书号,条形码,书名,作者,出版社 FROM tb_Book;--171
SELECT COUNT(书号)AS 记录条数, 书号,书名,作者 FROM
tb_Book GROUP BY 书号,书名,作者 HAVING COUNT(书号)>1;--172

--6.10 在查询中使用OR和AND运算符
SELECT * FROM tb_Grade WHERE 外语 > 90 OR 高数 > 90;--173
SELECT * FROM tb_Grade WHERE 外语>80 AND 高数>80;--174
SELECT * FROM tb_Grade WHERE (外语>80 OR 高数>80) AND 软件工程>80;--175

--6.11 排序，分组统计
SELECT 出版社,SUM(金额) as 总金额 FROM tb_Book GROUP BY 出版社;--176
SELECT 书名,出版社,SUM(金额) AS 总金额 
FROM tb_Book WHERE 出版社='人邮' GROUP BY ALL 书名,出版社;--177
SELECT 所属部门,性别,AVG(工资) AS 平均工资 FROM
tb_Employee GROUP BY 所属部门,性别 WITH CUBE;--178
SELECT 所属部门,性别, AVG(工资) AS 平均工资 FROM 
tb_Employee GROUP BY 所属部门,性别 WITH ROLLUP;--179
SELECT 学生编号,学生姓名,(高数+外语+文化基础+马经+数据库管理+
数据结构+软件工程) AS 总成绩 FROM tb_Grade ORDER BY (高数+外语+文化基础+马经+
数据库管理+数据结构+软件工程) DESC;--180
SELECT * FROM tb_Grade ORDER BY 马经 ASC,高数 DESC;--181
SELECT TOP 5 书号,书名,作者,出版社,SUM(销售数量) AS 合计销售数量 FROM
tb_Book  GROUP BY 书号,书名,作者,出版社  ORDER BY SUM(销售数量) DESC;--182
SELECT 学生姓名,性别,年龄,所在学院 FROM tb_Student 
            ORDER BY 学生姓名 COLLATE chinese_prc_stroke_cs_as_ks_ws;--183
SELECT 学生姓名,性别,年龄,所在学院 FROM tb_Student
ORDER BY 学生姓名 COLLATE chinese_prc_cs_as;--184
SELECT 存放位置,书名,SUM(库存数量) AS 合计库存数量  FROM
tb_Depot GROUP BY 存放位置,书名 ORDER BY SUM(库存数量) DESC;--185
SELECT k.书号,k.书名,x.作者, SUM(k.现存数量) AS 
现存数量 ,SUM(x.销售数量) AS 销售数量 FROM tb_Vendition AS x ,
tb_BookMessage AS k where x.书号=k.书号  GROUP BY k.书号,
k.书名,x.作者, k.现存数量 ORDER BY 书号;--186
SELECT * FROM tb_Employee ORDER BY 所属部门 COMPUTE SUM(工资);--187
SELECT * FROM tb_Employee ORDER BY 所属部门 COMPUTE SUM(工资) BY 所属部门;--188

--6.12 聚合函数
SELECT SUM(销售数量) AS 总数量 ,SUM(金额) AS 总金额 FROM tb_Book;--189
SELECT AVG(年龄) AS 平均年龄 FROM tb_Student;--190
SELECT * FROM tb_Ware WHERE 销价 IN(SELECT MIN(销价) FROM tb_Ware);--191
SELECT * FROM tb_SellWare WHERE 销售额 IN(SELECT MAX(销售额) FROM tb_SellWare);--192
SELECT COUNT(DISTINCT 商品名称) AS 商品数 FROM tb_Ware WHERE 销价 >1000;--193
SELECT 所在学院 ,COUNT(所在学院) AS 学生数量
FROM tb_Student GROUP BY 所在学院;--195
SELECT 学生编号,学生姓名,高数 FROM tb_Grade WHERE 
高数>(SELECT AVG(高数) FROM tb_Grade);--196
SELECT COUNT( 家庭住址) FROM tb_Student WHERE
NOT (家庭住址 IS NULL OR 家庭住址='');--197
SELECT COUNT(学生编号) AS 学生数量,SUM(高数) AS 高数总分数 FROM tb_Grade
WHERE 学生编号 IN (SELECT FLOOR(RAND()*10)+22050110 as 随机数
UNION SELECT FLOOR(RAND()*10)+22050110 UNION SELECT FLOOR(RAND()*10)+22050110);--198
SELECT COUNT(*) AS 学生数量 FROM tb_Student WHERE 年龄=24;--199

--6.13 多表查询
SELECT s.学生编号,s.学生姓名,s.性别,s.出生年月,s.年龄,
s.所在学院,s.所学专业,m.高数 FROM tb_Student s ,tb_Grade m WHERE s.学生编号=m.学生编号 AND m.高数 >85;--200
SELECT S.学生编号,S.学生姓名,M.高数,M.外语,M.马经,S.所在学院 FROM
tb_Student AS S,tb_Grade AS M where S.学生编号 = M.学生编号 AND S.所在学院 = '计算机学院';--201
SELECT 顾客编号 AS 编号,顾客姓名 AS 姓名,所在城市,邮编 FROM tb_Buyer
UNION SELECT 雇员编号,雇员名称,家庭住址,邮编 FROM tb_Salesman;--202
SELECT st.学生姓名,st.性别,st.年龄,gr.高数,gr.外语,
gr.软件工程 FROM tb_Student AS st,tb_Grade AS gr;--203

--6.14 嵌套查询
SELECT 学生姓名,学生编号, 性别,出生年月,年龄,所在学院,所学专业 FROM
tb_Student WHERE 学生编号 IN (SELECT  学生编号 FROM  tb_Grade WHERE 总分>=580);--204
SELECT * FROM tb_EmployeeLaborage WHERE 工资月份=10 AND 人员姓名 IN(
SELECT 负责人 FROM tb_EmployeeDepartment WHERE 负责人 IN
(SELECT 人员姓名 FROM tb_EmployeePerson WHERE 学历='本科')) ORDER BY 人员编号;--205
select * from tb_Grade where 高数 < ANY(select 高数 from tb_Grade where 学生姓名 in('王*立','李*丽'));--206

--6.15 子查询
--207
SELECT * FROM (SELECT * FROM tb_Student 
WHERE 学生编号 in(SELECT 学生编号 FROM 
tb_grade WHERE 软件工程>(SELECT 软件工程 
FROM tb_Grade WHERE 学生姓名='王*亮'))) AS stu
ORDER BY stu.学生编号 ;
--208
SELECT * FROM tb_Student WHERE 学生编号 IN 
(SELECT 学生编号 FROM tb_Grade WHERE 高数 > (SELECT AVG(高数) FROM tb_Grade));
--209
SELECT st.*,gr.总分 
FROM
tb_Student AS st INNER JOIN tb_Grade AS gr ON st.学生编号 = gr.学生编号 
WHERE 所在学院 = '理学院' AND gr.总分 > 
ALL 
(
SELECT gr.总分 
FROM tb_Grade AS gr INNER JOIN tb_Student AS st ON st.学生编号 = gr.学生编号
WHERE st.所在学院 = '管理学院'
);
--210
SELECT st.*,gr.总分 
FROM
tb_Student AS st INNER JOIN tb_Grade AS gr ON st.学生编号 = gr.学生编号 
WHERE 所在学院 = '理学院' AND gr.总分 > 
ANY
(
SELECT AVG(CONVERT(INT,总分))
FROM tb_Grade
);
--211
SELECT * 
FROM tb_Student AS st
WHERE
EXISTS
(
SELECT *
FROM tb_Grade as gr
WHERE st.学生编号 = gr.学生编号
AND gr.总分 > 580
);
--212
SELECT 所在学院,学生姓名,年龄,(SELECT AVG(年龄) FROM tb_Student) AS 平均年龄
FROM tb_Student
GROUP BY 所在学院,学生姓名,年龄
HAVING 年龄>(SELECT AVG(年龄) FROM tb_Student);

--6.16 组合语句
--215
SELECT 学生编号,学生姓名,性别,年龄 FROM tb_Student WHERE 所在学院='理学院' UNION 
SELECT 学生编号,学生姓名,性别,年龄 FROM tb_Student WHERE 学生编号 IN (SELECT 学生编号 FROM tb_Grade
WHERE 总分 >600);
--216
SELECT 学生姓名 FROM tb_Student UNION SELECT CONVERT(VARCHAR(20),总分)
FROM tb_grade WHERE 总分>570
UNION SELECT 课程名称 FROM tb_Course;
--217
SELECT 年龄 AS 信息 FROM tb_Student UNION 
SELECT 总分 FROM tb_grade UNION SELECT 课程编号 FROM tb_course ORDER BY 信息 ASC;
--218 交集
SELECT 学生编号,学生姓名 FROM tb_Student
INTERSECT
SELECT 学生编号,学生姓名 FROM tb_Grade;
--219 差集
SELECT 学生编号,学生姓名 FROM tb_Student
EXCEPT
SELECT 学生编号,学生姓名 FROM tb_Grade;


--6.17 内连接查询
--220
SELECT tb_Student.学生姓名,tb_Student.性别,tb_Student.年龄,tb_Grade.总分 FROM
tb_Student INNER JOIN tb_Grade ON tb_Student.学生编号=tb_Grade.学生编号;
--221
SELECT st.学生姓名,st.性别,st.年龄,gr.总分,tc.出勤率 FROM
tb_Student AS st INNER JOIN tb_grade AS gr ON st.学生编号 = gr.学生编号
INNER JOIN tb_StudentTimeCard AS tc ON st.学生编号 = tc.学生编号;
--222
SELECT st1.* FROM tb_Student AS st1 INNER JOIN tb_Student AS st2
ON st1.所在学院=st2.所在学院 and st2.学生姓名='李*灵';
--223
SELECT st.*,gr.* 
FROM tb_Student AS st 
INNER JOIN tb_Grade AS gr 
ON st.学生编号 = gr.学生编号;
--224 查询除李*灵所在院系外所有院系学生的信息
SELECT st1.* FROM tb_Student AS st1 INNER JOIN tb_Student AS st2
ON st1.所在学院<>st2.所在学院 and st2.学生姓名='李*灵';
--225
SELECT 员工信息表.人员编号, 员工信息表.人员姓名 
FROM 
tb_employeeperson AS 员工信息表 
INNER JOIN 
tb_EmployeeLaborage AS 员工工资表 
ON 
员工信息表.人员编号 = 员工工资表.人员编号;

--6.18 外连接查询
--226
SELECT st.学生姓名,st.性别,st.年龄,gr.总分 FROM
tb_Student AS st LEFT OUTER JOIN tb_grade AS gr ON st.学生编号 = gr.学生编号;
--227
SELECT st.学生姓名,st.性别,st.年龄,gr.总分 FROM
tb_Student AS st RIGHT OUTER JOIN tb_Grade AS gr ON st.学生编号 = gr.学生编号;
--228
SELECT st.学生姓名,st.性别,st.年龄,gr.总分,tc.出勤率 FROM
tb_Student AS st LEFT OUTER JOIN tb_Grade AS gr ON st.学生编号 = gr.学生编号
LEFT OUTER JOIN tb_StudentTimeCard AS tc ON st.学生编号 = tc.学生编号;

--6.19 利用IN进行查询
--229
SELECT 学生姓名,性别,年龄 FROM tb_Student WHERE
学生编号 IN (SELECT 学生编号 FROM tb_Grade WHERE 总分>600);
--231
SELECT 学生姓名,性别,年龄 FROM tb_Student WHERE 学生编号 NOT IN 
(SELECT 学生编号 FROM tb_Grade WHERE 总分>500 AND 总分<600);

--6.20 交叉表查询

--6.21 函数查询

--6.22 索引查询
--239
CREATE UNIQUE INDEX index_Student
ON tb_Student(学生编号);
DROP INDEX tb_Student.index_Student;
--240
CREATE CLUSTERED INDEX index_Student
ON tb_Student(学生编号);
DROP INDEX tb_Student.index_Student;
--241
SET NUMERIC_ROUNDABORT OFF
SET ANSI_PADDING,ANSI_WARNINGS,CONCAT_NULL_YIELDS_NULL,
ARITHABORT,QUOTED_IDENTIFIER,ANSI_NULLS ON;
CREATE VIEW VIEW_Student
WITH SCHEMABINDING
AS
SELECT
st.所在学院,
SUM(CONVERT(INT,总分)) AS 学院总分,
COUNT_BIG(*) AS 学生数量
FROM
dbo.tb_Student AS st,
dbo.tb_Grade AS gr
WHERE
st.学生编号=gr.学生编号
GROUP BY
所在学院;
DROP VIEW VIEW_Student ;
DROP INDEX tb_Student.INDEX_VIEW;
--242
CREATE INDEX index_Grade1
ON tb_Grade(学生编号);
DROP INDEX tb_Grade.index_Grade1;

--6.23 应用存储过程
--243
SELECT CASE WHEN EXISTS
(SELECT * FROM sysobjects WHERE id=object_id('dbo.proc_GetStudent') 
AND XTYPE='p')
THEN '存在' 
ELSE '不存在' 
END;
CREATE PROC proc_GetStudent
AS
SELECT st.学生编号,st.学生姓名,st.年龄,gr.总分 
FROM tb_Student AS st
INNER JOIN tb_Grade AS gr
ON st.学生编号 = gr.学生编号;
drop proc proc_GetStudent;
--244
SELECT CASE WHEN EXISTS
(SELECT * FROM sysobjects WHERE id=object_id('dbo.proc_InsertStudent') 
AND XTYPE='p')
THEN '存在' 
ELSE '不存在' 
END;
CREATE PROC proc_InsertStudent
@学生编号	int,
@学生姓名	nvarchar(50),
@性别	nvarchar(50),
@出生年月	smalldatetime,
@年龄	int,
@所在学院	nvarchar(50),
@所学专业	nvarchar(50),
@家庭住址	nvarchar(50),
@统招否	bit,
@备注信息	nvarchar(50)
AS
INSERT INTO tb_Student(学生编号,学生姓名,性别,出生年月,年龄,所在学院,所学专业,家庭住址,统招否,备注信息)
values(@学生编号,@学生姓名,@性别,@出生年月,@年龄,@所在学院,@所学专业,@家庭住址,@统招否,@备注信息);
drop proc proc_InsertStudent;

--6.24 HAVING语句应用
--246
SELECT 所在学院,COUNT(*) AS 人数,AVG(年龄) AS 平均年龄
FROM tb_Student GROUP BY 所在学院 HAVING AVG(年龄) > 22;
--247
SELECT 所在学院,COUNT(*) AS 人数,MAX(高数) AS 最高成绩,AVG(高数) AS 高数平均成绩 
FROM
tb_student AS st 
JOIN tb_grade AS gr 
ON 
st.学生编号 = gr.学生编号
GROUP BY 所在学院 
HAVING AVG(高数) > 60;


