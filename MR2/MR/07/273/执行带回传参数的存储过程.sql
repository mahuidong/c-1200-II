if exists(select name from sysobjects 
where name='pro_out'and type='p')
drop proc pro_out
GO
create procedure pro_out
  @id varchar(20),
  @name varchar(30),
  @sex int output    --���ô�����ֵ�Ĳ���
as
select * from tb_Employee where ID=@id
GO
--ִ�д洢����
declare @sex char(4)   --�Զ������
exec pro_out 'YGBH0001','С��',100--���ô洢����
if @sex='��'--���ô洢���̵ķ���ֵ�����ж�
  print '����'
if @sex='Ů'
  print 'Ů��'
go
