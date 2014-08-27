SELECT 学生姓名,年龄,性别,家庭住址 FROM tb_Student where 年龄=24;--132
SELECT 学生姓名,年龄,性别,家庭住址 FROM tb_Student WHERE 学生姓名='王*立';--133
SELECT 学生姓名,年龄,性别,出生年月 FROM tb_Student WHERE 出生年月 = '1980-12-24';--134
SELECT 学生姓名,年龄,性别,统招否,家庭住址 FROM tb_Student WHERE 统招否='true';--135
SELECT 学生姓名,年龄,性别,家庭住址 FROM tb_Student WHERE 家庭住址 IS NULL OR 家庭住址='';--136