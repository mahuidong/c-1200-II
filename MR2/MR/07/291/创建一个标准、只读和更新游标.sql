USE db_TomeTwo
GO
--����һ����׼�α�
DECLARE authors_cursor CURSOR FOR
SELECT au_id,au_fname,au_lname
FROM authors
GO
--����һ��ֻ���α�
USE db_TomeTwo
GO
DECLARE authors_cursor1 CURSOR FOR
SELECT au_id,au_fname,au_lname
FROM authors
FOR READ ONLY
GO
--����һ�������α�
USE db_TomeTwo
GO
DECLARE authors_cursor2 CURSOR FOR
SELECT au_id,au_fname,au_lname
FROM authors
FOR UPDATE
GO

