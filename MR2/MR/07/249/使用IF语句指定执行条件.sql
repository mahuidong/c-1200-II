GO
DECLARE @DEPT VARCHAR(20)
SET @DEPT = 'ϵͳ������'

IF (SELECT COUNT(*) FROM dbo.tb_�������ݱ� WHERE ��������=@DEPT)>0
BEGIN
    PRINT '�ò����Ѿ���������'
END
ELSE
BEGIN
    PRINT '�ò���û�з�������'
END