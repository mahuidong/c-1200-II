GO
if exists (select * from dbo.sysobjects 
           where id = object_id(N'[dbo].[PERSONSEL]') 
             and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[PERSONSEL]
GO
CREATE PROCEDURE PERSONSEL @NAME VARCHAR(10),@DEPT VARCHAR(20)
AS
IF EXISTS(SELECT * FROM dbo.tb_�������ݱ� WHERE ��Ա����=@NAME AND ��������=@DEPT)
BEGIN
    RETURN 1
END
ELSE
BEGIN
    RETURN 0
END
GO
DECLARE @RETURN INT
EXEC @RETURN = PERSONSEL '���','ϵͳ������'
PRINT @RETURN
