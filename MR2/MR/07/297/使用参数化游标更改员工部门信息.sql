DECLARE @dept AS VARCHAR(20)/*�������*/
SET @dept='Java������'/*Ϊ������ֵ*/
DECLARE cur_eaf CURSOR/*�����α�*/
  FOR (SELECT * FROM tb_Dept WHERE dept=@dept)/*�����α�����*/
  OPEN cur_eaf/*���α�*/
    FETCH NEXT FROM cur_eaf/*�����ƶ��α�ָ��*/
    WHILE @@FETCH_STATUS = 0/*�ж��Ƿ������һ����¼*/
      BEGIN
        FETCH NEXT FROM cur_eaf/*�����ƶ��α�ָ��*/
      END
  CLOSE cur_eaf/*�ر��α�*/
DEALLOCATE cur_eaf/*�ͷ��α�*/
