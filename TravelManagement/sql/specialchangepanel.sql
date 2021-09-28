USE [travelmanagement]
GO

/****** Object:  Table [dbo].[specialchangepanel]    Script Date: 2021-09-28 9:36:07 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[specialchangepanel](
	[SN] [int] IDENTITY(1,1) NOT NULL,
	[specialpicture] [text] NULL,
	[specialpricelabel] [int] NULL,
	[speciallocation] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


