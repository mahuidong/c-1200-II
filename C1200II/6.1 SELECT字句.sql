SELECT 学生编号,学生姓名,性别,年龄,家庭住址 FROM tb_Student;--128
SELECT 学生姓名 as 姓名,年龄 as 学生年龄,性别 as 学生性别 from tb_Student;--129
SELECT 学生编号,学生姓名,高数+外语 AS 高数加外语的分数 FROM tb_Grade;--130
SELECT 学生编号,学生姓名,年龄,性别 FROM tb_Student where LEN(学生姓名)=3;--131