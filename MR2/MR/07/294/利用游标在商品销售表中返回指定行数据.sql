DECLARE khqc_Cursor CURSOR --�����α�
for select * FROM ���۱�
OPEN khqc_Cursor --���α�
BEGIN
   --��ȡ��¼���α귵��ָ������
   FETCH next FROM khqc_Cursor  
END
CLOSE khqc_Cursor   /*�ر��α�*/
DEALLOCATE khqc_Cursor  /*�ͷ��α�*/
GO