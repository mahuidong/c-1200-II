Set xact_Abort on
/*��ʾ�����ֲ�����*/
Begin DISTRIBUTED TRANSACTION
Update EmployeeInfo set Name='С��' 
where EmployeeCode='20091117091811609'
Update [MRWXK].[Northwind].[dbo].[Employees] 
set FirstName='smith' where LastName='bob'
/*�����ֲ�ʽ����*/
COMMIT TRANSACTION