USE db_TomeTwo
GO
DECLARE ���ݵ��� CURSOR KEYSET FOR    --�����α�
SELECT �γ���� FROM course
WHERE �γ����  LIKE '������'
OPEN ���ݵ���    --���α�
DECLARE @x CURSOR    --����һ���α����
EXEC sp_cursor_list @cursor_return = @x OUTPUT,
      @cursor_scope = 2    --ʹ��sp_cursor_list���̷���ȫ���α������
FETCH NEXT from @x    --�α�ָ������һ��
WHILE (@@FETCH_STATUS <> -1)    --���FETCH���ִ�гɹ�
BEGIN
   FETCH NEXT from @x    --�α���������ƶ�
END
CLOSE @x                --�ر��α�
DEALLOCATE @x           --�ͷ��α�
GO
CLOSE ���ݵ���         --�ر��α�
DEALLOCATE ���ݵ���    --�ͷ��α�   
GO
