USE db_TomeTwo
GO
DECLARE ���տƼ� CURSOR KEYSET FOR    --�����α�
SELECT ͼ����� FROM tb_Csharpbook
WHERE ͼ�����  LIKE '������'
OPEN ���տƼ�    --���α�
DECLARE @x CURSOR    --����һ���α����
EXEC sp_describe_cursor @cursor_return = @x OUTPUT,
       @cursor_source = N'global', @cursor_identity = N'���տƼ�'  
FETCH NEXT from @x    --�α�ָ������һ��
WHILE (@@FETCH_STATUS <> -1)    --���FETCH���ִ�гɹ�
BEGIN
   FETCH NEXT from @x    --�α���������ƶ�
END
CLOSE @x                --�ر��α�
DEALLOCATE @x           --�ͷ��α�
GO
CLOSE ���տƼ�         --�ر��α�
DEALLOCATE ���տƼ�    --�ͷ��α�
