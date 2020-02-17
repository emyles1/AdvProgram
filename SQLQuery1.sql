Create PROCEDURE Masterinsertupdatedelete ( 
@ID int,

                                          @FirstName    VARCHAR(20),  
                                          @Surname     VARCHAR(20),  
                                          @Email        VARCHAR(20),  
                                          @Phone          VARCHAR(10), 
										  @AddressL1	VARCHAR(20),
										  @AddressL2	VARCHAR(20),
										  @City	VARCHAR(20),
										  @County	VARCHAR(20),
										  @Level	Int,
										  @Course	VARCHAR(20),
                                          @StatementType NVARCHAR(20) = '')  
AS  
  BEGIN  
      IF @StatementType = 'Insert'  
        BEGIN  
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
        END  
  
      IF @StatementType = 'Select'  
        BEGIN  
            SELECT *  
            FROM   Student  
        END  
  
      IF @StatementType = 'Update'  
        BEGIN  
            UPDATE Student  
            SET    FirstName = @FirstName,  
                   Surname = @Surname,  
                   Email = @Email,  
                   Phone = @Phone,
				   AddressL1 = @AddressL1,
				   AddressL2 = @AddressL2,
				   City = @City,
				   County = @County,
				   Level = @Level,
				   Course = @Course
				   
            WHERE  id = @id  
        END  
      ELSE IF @StatementType = 'Delete'  
        BEGIN  
            DELETE FROM Student  
            WHERE  ID = @id  
        END  
  END    