GO
DECLARE @NAME VARCHAR(10)
DECLARE @DEPT VARCHAR(20)
SET @NAME = '高岩'
SET @DEPT = '系统分析部'
IF EXISTS (SELECT * FROM dbo.tb_工资数据表 WHERE 人员姓名=@NAME AND 部门名称=@DEPT)
BEGIN
    PRINT '存在该人员的工资'
END
ELSE IF NOT EXISTS (SELECT * FROM dbo.tb_工资数据表 WHERE 人员姓名=@NAME AND 部门名称=@DEPT)
BEGIN
    PRINT '不存在该人员的工资'
END
