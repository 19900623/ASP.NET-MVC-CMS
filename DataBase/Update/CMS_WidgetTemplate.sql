


INSERT INTO dbo.CMS_WidgetTemplate
        ( Title ,
          GroupName ,
          PartialView ,
          AssemblyName ,
          ServiceTypeName ,
          ViewModelTypeName ,
          Thumbnail ,
          [Order] ,
          Description ,
          Status
        )
VALUES  ( N'��ʽ' , 
          N'1.ͨ��' ,
          N'Widget.StyleSheet' , 
          N'Easy.CMS.Common' , 
          N'Easy.CMS.Common.Service.StyleSheetWidgetService' ,
          N'Easy.CMS.Common.Models.StyleSheetWidget' ,
          N'~/Content/Images/Widget.StyleSheet.png' ,
          8 , -- Order - int
          N'' ,
          1
        )

DELETE dbo.Language WHERE LanKey=N'StyleSheetWidget@StyleSheet'
INSERT INTO dbo.Language
		( LanKey ,
		    LanID ,
		    LanValue ,
		    Module ,
		    LanType
		)
VALUES  ( N'StyleSheetWidget@StyleSheet' , 
		    2052 , 
		    N'��ʽ' , 
		    N'StyleSheetWidget' , 
		    N'EntityProperty'  
		)