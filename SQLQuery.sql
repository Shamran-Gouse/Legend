CREATE TABLE [dbo].[Student](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name_Intial] [nvarchar](50) NOT NULL,
	[Full_Name] [nvarchar](max) NULL,
	[Gender] [nchar](10) NULL,
	[Student_Address] [nvarchar](max) NULL,
	[School] [nvarchar](max) NULL,
	[Contact_No] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Grade] [nvarchar](50) NULL,
	[Medium] [nchar](10) NULL,)
