declare @id char(20)/*��������*/
declare @names char(20)
declare @age int
set @age=27--Ϊ������ֵ
declare @ages int
declare deletecursor cursor for--�����α�
select Ա�����,����,���� from tb_TestDel
open deletecursor--���α�
fetch next from deletecursor--��ȡ�α����һ��
into @id,@names,@ages--ʹ������õ�ǰ�α�ָ���е�Ա����ţ�����������
while @@fetch_status=0
begin
if @age=@ages--�жϱ�����ֵ�Ƿ����α�ָ�����������
begin
delete tb_TestDel where ����=@ages--ɾ��ָ������������
end
fetch next from deletecursor--��ȡ�α����һ��
into @id,@names,@ages
end
close deletecursor--�ر��α�
deallocate deletecursor--�ͷ��α�
select * from tb_TestDel--���²鿴tb_TestDel��
