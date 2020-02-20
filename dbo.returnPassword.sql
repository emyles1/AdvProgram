Create procedure returnPassword @Username varchar(20)
AS
SELECT Password FROM Admin where Username = @Username