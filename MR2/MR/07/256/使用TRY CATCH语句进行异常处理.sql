use db_TomeTwo
BEGIN Try
    SELECT 1/0;
END Try
BEGIN catch
    SELECT
        ERROR_NUMBER() AS ErrorNumber,--���ش����
        ERROR_SEVERITY() AS ErrorSeverity,--����������
        ERROR_STATE() AS ErrorState,--���ش���״̬��
        ERROR_LINE() AS ErrorLine,--���ص��´���������е��к�
        ERROR_MESSAGE() AS ErrorMessage;--���ش�����Ϣ�������ı�
END catch;
GO
