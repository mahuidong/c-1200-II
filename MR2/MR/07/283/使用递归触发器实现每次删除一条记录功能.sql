/*�жϱ����Ƿ�����Ϊ��delete_employee���Ĵ�����*/
if EXISTS (SELECT name 
	FROM   sysobjects 
	WHERE  name = 'delete_employee' 
	AND type = 'TR')
/*����Ѿ�������ɾ��*/
drop trigger delete_employee
go
  create trigger delete_employee
   on Ա����
    after delete as
       declare @rowcount int
       select @rowcount = @@rowcount
  if @rowcount>1
       begin
          rollback transaction
       print('��ǰɾ���ļ�¼��������һ����һ��ֻ����ɾ��һ��')
       end
  if @rowcount=1
      begin
          declare @�������� varchar(50) 
          select @�������� = �������� from deleted
      delete from Ա���� where �������� = @��������
      end
go
