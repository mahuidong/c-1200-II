create TRIGGER 管理员日志 ON dbo.系统管理员表 
FOR UPDATE
AS insert into 系统日志表(备注) select
 '用户名：'+inserted.用户名称 +' —密码：'+ inserted.密码 from inserted

