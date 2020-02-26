
USE StudentDB

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE Admin(ID int IDENTITY(1,1) PRIMARY KEY, Username VARCHAR(20), Password VARCHAR(20));

GO

SET IDENTITY_INSERT Admin OFF;
GO

INSERT INTO Admin VALUES('Admin','Admin')

GO

CREATE TABLE Student (ID int IDENTITY(1,1) PRIMARY KEY, FirstName VARCHAR(20), Surname VARCHAR(20), Email VARCHAR(20), Phone  VARCHAR(10), AddressL1 VARCHAR (50), AddressL2 VARCHAR (50), City VARCHAR (20), County VARCHAR (20), Level int, Course VARCHAR (50) );

GO

SET IDENTITY_INSERT Student OFF;
GO

Insert INTO Student Values ('Eamon', 'Myles', 'eamonmyles@gmail.com', '0876500000', '18', 'Annfield Crescent', 'Dublin', 'Dublin',1, 'French')

GO

Create procedure returnPassword @Username varchar(20)
AS
SELECT Password FROM Admin where Username = @Username

GO

Create PROCEDURE StudentDelete 
@ID Int
AS  
Delete Student Where  ID = @ID

GO

Create PROCEDURE StudentEdit ( 
                                         @ID Int,
										 @FirstName    VARCHAR(20),  
                                          @Surname     VARCHAR(20),  
                                          @Email        VARCHAR(20),  
                                          @Phone          VARCHAR(10), 
										  @AddressL1	VARCHAR(20),
										  @AddressL2	VARCHAR(20),
										  @City	VARCHAR(20),
										  @County	VARCHAR(20),
										  @Level	Int,
										  @Course	VARCHAR(20)
										  )                           
AS  
            UPDATE Student SET  
                         
                         FirstName =  @FirstName, 
                         Surname = @Surname,
						 Email = @Email,  
                         Phone = @Phone,
						 AddressL1 = @AddressL1 ,
						 AddressL2 = @AddressL2,
						 City =@city,
						 County= @County,
						 Level = @Level,
						 Course = @Course
            
                      where ID = @ID

GO

Create PROCEDURE StudentInsert ( 
                                          @FirstName    VARCHAR(20),  
                                          @Surname     VARCHAR(20),  
                                          @Email        VARCHAR(20),  
                                          @Phone          VARCHAR(10), 
										  @AddressL1	VARCHAR(20),
										  @AddressL2	VARCHAR(20),
										  @City	VARCHAR(20),
										  @County	VARCHAR(20),
										  @Level	Int,
										  @Course	VARCHAR(20)
										  )                           
AS  
            INSERT INTO Student  
                        (  
                         FirstName,  
                         Surname,
						 Email,  
                         Phone,
						 AddressL1,
						 AddressL2,
						 City,
						 County,
						 Level,
						 Course)  
            VALUES     (   
                         @FirstName,  
                         @Surname,  
                         @Email,
						 @Phone,
						 @AddressL1,
						 @AddressL2,
                         @city,
						 @County,
						 @Level,
						 @Course)

GO

Create PROCEDURE studentReturn @IDStud int
AS
Select * from Student where ID = @IDStud





