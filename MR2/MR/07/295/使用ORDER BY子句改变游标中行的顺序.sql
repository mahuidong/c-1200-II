DECLARE mycursor CURSOR  /*�����α�*/
FOR 
 SELECT a.Ա�����,a.Ա������,��������,��������,���� /*�����α�����*/ 
 FROM Ա���� a,нˮ�� b
 WHERE a.Ա����� = b.Ա�����
ORDER BY a.Ա����� desc /*��������*/
OPEN mycursor  /*���α�*/
  FETCH NEXT FROM  mycursor /*ִ��ȡ������*/
WHILE @@fetch_status = 0  /*�ж��Ƿ���Լ���ȡ��*/
BEGIN
  FETCH NEXT FROM  mycursor  
END 
CLOSE mycursor /*�ر��α�*/
DEALLOCATE mycursor /*�ͷ��α�*/
