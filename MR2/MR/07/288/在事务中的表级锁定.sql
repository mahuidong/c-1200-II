--ɾ�����������ݱ�
if object_id('CGoods') is not null drop table CGoods
GO
CREATE TABLE CGoods
(
  g_id varchar(50),
  g_name varchar(50),
  g_price money
)
GO
--��������
INSERT INTO CGoods
SELECT 'SP10001','Ӥ������װ',108 UNION ALL
SELECT 'SP10002','Ӥ��������ƿ',88 UNION ALL
SELECT 'SP10003','GG��ߣ��У�',189 UNION ALL
SELECT 'SP10004','�׶���̣���������̣�',389
GO
--Ӧ������
BEGIN TRAN tra01
SELECT * FROM CGoods WITH(HOLDLOCK)
WAITFOR DELAY '00:00:10' 
COMMIT TRAN tra01
GO
BEGIN TRAN tra02
UPDATE CGoods
SET g_name = 'Ӥ������װ'
WHERE g_id = 'SP10001'
SELECT * FROM CGoods WITH(HOLDLOCK)
COMMIT TRAN tra02

