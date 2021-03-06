USE [DynamicProject]
GO
/****** Object:  StoredProcedure [dbo].[USP_Item_Update]    Script Date: 04/16/2015 16:03:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Author      : Shanu                                                                  
-- Create date : 2015-02-05                                                                  
-- Description : To Update Item Master                                                
-- Tables used :  ItemMasters                                                                 
-- Modifier    : Shanu                                                                  
-- Modify date : 2015-02-05                                                                  
-- =============================================                                                                  
-- exec USP_Item_Update '',''      
-- =============================================                                                             
ALTER PROCEDURE [dbo].[USP_Item_Update]                                                
   (        
     @Item_Code          VARCHAR(50)     = '',                              
     @Item_Name     VARCHAR(50)     = '',  
     @Price      INT=0 ,  
     @TAX1      INT=0 ,  
     @Discount     INT=0 ,  
     @Description     VARCHAR(50)     = '',  
     @USR_Name     VARCHAR(50)     = ''       
      )                                                          
AS                                                                  
BEGIN                  

   UPDATE [ItemMasters]   
     SET [Item_Name]=@Item_Name,  
      [Price]=@Price,  
      [TAX1]=@TAX1,  
      [Discount]=@Discount,  
      [Description]=@Description,  
      [UP_DATE]=GETDATE(),  
      [UP_USR_ID]=@USR_Name  
     WHERE  
      Item_Code=@Item_Code  
select 'Updated' as 'Result'
END  