--������ͼ
create view V_waregoods
(���, ��Ʒ����,����,����,����,���۶�,����)
as 
--����SELECT��ѯ���
select ���, ��Ʒ����,����,����,����,(����*����) AS ���۶�,
        (����*����-����*����) AS ����
from tb_xsb
go
--��ѯ��ͼ
select * from V_waregoods 
