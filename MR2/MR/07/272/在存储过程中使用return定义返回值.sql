--�ж��Ƿ������Ҫ�����Ĵ洢��������
IF EXISTS(SELECT name 
   FROM sysobjects 
 WHERE name='Proc_Return'
AND type='P')
--������Ҫ�����Ĵ洢������ɾ��
DROP PROCEDURE Proc_Return
GO
CREATE PROCEDURE Proc_Return 
@ID varchar(20),
@Name  varchar(20)
AS
--ִ��SELECT���
SELECT * FROM tb_Employee WHERE ID = @ID
Return @@Error
GO
--ִ�д洢����
DECLARE @Int int
EXEC @Int=Proc_Return 'YGBH0001','С��'--������ֵ����@Int����
Select @Int as '����ֵ'    --��ʾ������Ϣ
