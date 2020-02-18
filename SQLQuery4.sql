Create PROCEDURE Student ( 
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