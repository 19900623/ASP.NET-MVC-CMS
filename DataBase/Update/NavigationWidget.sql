UPDATE  dbo.Language
SET     LanValue = N'���϶�'
WHERE   LanKey = N'NavigationWidget@CustomerClass';

ALTER TABLE dbo.NavigationWidget ADD AlignClass NVARCHAR(50);

ALTER TABLE dbo.NavigationWidget ADD IsTopFix BIT;

DELETE FROM dbo.Language WHERE LanKey=N'NavigationWidget@AlignClass'
INSERT  INTO dbo.Language
        ( LanKey ,
          LanID ,
          LanValue ,
          Module ,
          LanType
        )
VALUES  ( N'NavigationWidget@AlignClass' ,
          2052 ,
          N'����' ,
          N'NavigationWidget' ,
          N'EntityProperty'
        );
DELETE FROM dbo.Language WHERE LanKey=N'NavigationWidget@IsTopFix'
INSERT  INTO dbo.Language
        ( LanKey ,
          LanID ,
          LanValue ,
          Module ,
          LanType
        )
VALUES  ( N'NavigationWidget@IsTopFix' ,
          2052 ,
          N'�����̶�' ,
          N'NavigationWidget' ,
          N'EntityProperty'
        );