


-- CREATE TABLE (IDEA)
CREATE TABLE dbo.Idea	
(
	Date1 DateTime NULL, 
	Text1 VarChar(20) NOT NULL
) 

INSERT INTO Idea VALUES('2020-01-31 12:05', 'My Big idea')
INSERT INTO Idea VALUES('2020-01-01 11:20', 'Another Big idea')
INSERT INTO Idea VALUES('2019-12-03 09:18', 'A Bad idea')
INSERT INTO Idea VALUES('2017-07-04 08:25', 'The worst idea yet')


-- CREATE TEMP TABLE 
SELECT	Date1 as StartDate,
		d.Date2 as EndDate,
		Text1 as Text1
INTO #TempIdea
FROM dbo.Idea i
OUTER APPLY (
	SELECT MIN(Date1) Date2 from dbo.Idea i2 WHERE i2.Date1 > i.Date1
) d
ORDER BY i.Date1 


SELECT * FROM #TempIdea
--DROP TABLE #TempIdea
