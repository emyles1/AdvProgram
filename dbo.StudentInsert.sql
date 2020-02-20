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