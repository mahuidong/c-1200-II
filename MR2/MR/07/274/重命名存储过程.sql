--�жϴ洢����proc_Name�Ƿ���ڣ�������ڽ���ɾ��
if exists(select name from sysobjects where name='proc_Name' and type='p')
drop proc proc_Name 
go
create procedure proc_Name--����һ���洢����
as
select * from tb_User 
where User_Duty='����Ա'
go
--���������洢����
exec sp_rename 'proc_Name','proc_ReName'
go
