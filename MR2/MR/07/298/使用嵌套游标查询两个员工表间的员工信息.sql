declare @name varchar(10)/*��������*/
  declare cur_lab cursor for/*�����α�*/
    select Ա����� from нˮ�� where Ա����� =1001 /*�����α�����*/
  open cur_lab/*���α�*/
    fetch next from cur_lab into @name/*��������ֵ*/
    while ( @@fetch_status=0 )  
begin
    declare @day varchar(10) /*��������*/
    declare cur_lab_2 cursor for/*�����α�*/
    select ������� from ��ٱ� where ��� = @name/*��������*/
    open cur_lab_2/*���α�*/
    fetch next from cur_lab_2 into @day/*ʹ���α꽫������ֵ*/
    while ( @@fetch_status=0)  
    begin
      print '���Ϊ1001��Ա�����������Ϊ' +@day +'��'/*������Ϊ1���������*/
      return 
    end
    close cur_lab_2/*�ر��α�*/
    deallocate cur_lab_2/*�ͷ��α�*/ 
end   
    close cur_lab 
    deallocate cur_lab
