GO
DECLARE @NAME VARCHAR(10)
DECLARE @DEPT VARCHAR(20)
SET @NAME = '����'
SET @DEPT = 'ϵͳ������'
IF EXISTS (SELECT * FROM dbo.tb_�������ݱ� WHERE ��Ա����=@NAME AND ��������=@DEPT)
BEGIN
    PRINT '���ڸ���Ա�Ĺ���'
END
ELSE IF NOT EXISTS (SELECT * FROM dbo.tb_�������ݱ� WHERE ��Ա����=@NAME AND ��������=@DEPT)
BEGIN
    PRINT '�����ڸ���Ա�Ĺ���'
END
