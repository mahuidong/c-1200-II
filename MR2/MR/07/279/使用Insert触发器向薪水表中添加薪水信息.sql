/*�жϱ����Ƿ�����Ϊ��[trig_InsertInfo]���Ĵ�����*/
if EXISTS (SELECT name 
	FROM   sysobjects 
	WHERE  name = '[trig_InsertInfo]' 
	AND type = 'TR')
/*����Ѿ�������ɾ��*/
drop trigger [trig_InsertInfo]
go
create TRIGGER [trig_InsertInfo] on [dbo].[tb_Employee]
FOR insert
AS
if exists(select ID from inserted where ID in(select ID from tb_Salary))
begin
update tb_Salary set Name=(select Name from inserted),Salary=1500 where ID=(select ID from inserted) 
end
else
begin
insert into tb_Salary(ID,Name,Salary)
select ID,Name,1500 from inserted
end
go
