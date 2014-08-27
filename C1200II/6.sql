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