GO
SELECT ��Ա���,��Ա����,��������,ʵ���ϼ�,������,
    CASE �����·�
        WHEN 1  THEN '1�·ݹ���'
        WHEN 2  THEN '2�·ݹ���'
        WHEN 3  THEN '3�·ݹ���'
        WHEN 4  THEN '4�·ݹ���'
        WHEN 5  THEN '5�·ݹ���'
        WHEN 6  THEN '6�·ݹ���'
        WHEN 7  THEN '7�·ݹ���'
        WHEN 8  THEN '8�·ݹ���'
        WHEN 9  THEN '9�·ݹ���'
        WHEN 10 THEN '10�·ݹ���'
        WHEN 11 THEN '11�·ݹ���'
        WHEN 12 THEN '12�·ݹ���'
    END
FROM dbo.tb_�������ݱ�
ORDER BY ��Ա����
