--������ͼ
CREATE VIEW Lesson_Profession_view
WITH ENCRYPTION--������ͼ
AS
--����SELECT��ѯ���
SELECT a.Name,a.JoinTime, 
      b.PreName, a.ID
FROM tb_Lesson AS a INNER JOIN
      tb_Profession AS b ON a.ofProfession = b.ID
GO
--�鿴��������ͼ�е�����
EXEC sp_helptext Lesson_Profession_view


