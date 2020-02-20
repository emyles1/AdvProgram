Create PROCEDURE studentReturn @IDStud int
AS
Select * from Student where ID = @IDStud