/****** Object:  Table [dbo].[ExtendField]    Script Date: 2016/7/1 ������ 16:57:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ExtendField](
	[ID] [INT] IDENTITY(1,1) NOT NULL,
	[Title] [NVARCHAR](255) NULL,
	[Value] [NVARCHAR](MAX) NULL,
	[OwnerModule] [NVARCHAR](50) NULL,
	[OwnerID] [NVARCHAR](100) NULL,
	[Status] [INT] NULL,
	[CreateBy] [NVARCHAR](255) NULL,
	[CreatebyName] [NVARCHAR](255) NULL,
	[CreateDate] [DATETIME] NULL,
	[LastUpdateBy] [NVARCHAR](255) NULL,
	[LastUpdateByName] [NVARCHAR](255) NULL,
	[LastUpdateDate] [DATETIME] NULL,
	[Description] [NVARCHAR](255) NULL,
 CONSTRAINT [PK_ExtendField] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

DELETE FROM dbo.Language WHERE  Module=N'ExtendFieldEntity'
INSERT INTO dbo.Language( LanKey ,LanID ,LanValue ,Module ,LanType)
SELECT N'ExtendFieldEntity@ActionType',2052,N'ActionType',N'ExtendFieldEntity',N'EntityProperty' UNION ALL
SELECT N'ExtendFieldEntity@CreateBy',2052,N'CreateBy',N'ExtendFieldEntity',N'EntityProperty' UNION ALL
SELECT N'ExtendFieldEntity@CreatebyName',2052,N'������',N'ExtendFieldEntity',N'EntityProperty' UNION ALL
SELECT N'ExtendFieldEntity@CreateDate',2052,N'��������',N'ExtendFieldEntity',N'EntityProperty' UNION ALL
SELECT N'ExtendFieldEntity@Description',2052,N'����',N'ExtendFieldEntity',N'EntityProperty' UNION ALL
SELECT N'ExtendFieldEntity@ID',2052,N'ID',N'ExtendFieldEntity',N'EntityProperty' UNION ALL
SELECT N'ExtendFieldEntity@LastUpdateBy',2052,N'LastUpdateBy',N'ExtendFieldEntity',N'EntityProperty' UNION ALL
SELECT N'ExtendFieldEntity@LastUpdateByName',2052,N'������',N'ExtendFieldEntity',N'EntityProperty' UNION ALL
SELECT N'ExtendFieldEntity@LastUpdateDate',2052,N'��������',N'ExtendFieldEntity',N'EntityProperty' UNION ALL
SELECT N'ExtendFieldEntity@OwnerID',2052,N'OwnerID',N'ExtendFieldEntity',N'EntityProperty' UNION ALL
SELECT N'ExtendFieldEntity@OwnerModule',2052,N'OwnerModule',N'ExtendFieldEntity',N'EntityProperty' UNION ALL
SELECT N'ExtendFieldEntity@Status',2052,N'״̬',N'ExtendFieldEntity',N'EntityProperty'UNION ALL
SELECT N'ExtendFieldEntity@Title',2052,N'����',N'ExtendFieldEntity',N'EntityProperty' UNION ALL
SELECT N'ExtendFieldEntity@Value',2052,N'ֵ',N'ExtendFieldEntity',N'EntityProperty'
GO
DELETE FROM dbo.Language WHERE LanKey LIKE N'%@ExtendFields'
INSERT INTO dbo.Language( LanKey ,LanID ,LanValue ,Module ,LanType) VALUES (N'PageEntity@ExtendFields',2052,N'��չ����',N'PageEntity',N'EntityProperty')