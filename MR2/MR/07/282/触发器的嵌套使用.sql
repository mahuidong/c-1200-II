/*Ϊtb_teacher����DELETE������*/
  create trigger teacher_delete
   on tb_teacher
    after delete as
   declare @rowcount int
   select @rowcount=@@rowcount  	/*ɾ���������漰�ļ�¼����*/
    if @rowcount >1             	/*�ж�ɾ���ļ�¼�Ƿ����һ��*/
       begin
    rollback transaction
    print('ɾ��tb_teacher���м�¼����һ����ɾ��ʧ��')
     end
    else
     declare @��ʦ  varchar(10) 	/*ɾ����¼�ġ���ʦ������Ϣ*/
    select @��ʦ = ��ʦ from deleted
     delete tb_school where ��ʦ = @��ʦ
/*Ϊtb_school����DELETE������*/
go
 create trigger school_delete
    on tb_school
 after delete as
   declare @rowcount int
 select @rowcount = @@rowcount  /*ɾ���������漰�ļ�¼����*/
   if @rowcount >1             	 /*�ж�ɾ���ļ�¼�Ƿ����һ��*/
   begin
    rollback transaction       	/*�ع�����*/
   print('ɾ��tb_school���м�¼����һ����ɾ��ʧ��')
 end
   else
   print('tb_school���tb_teacher������Ӧ�����ݾ���ɾ��')
