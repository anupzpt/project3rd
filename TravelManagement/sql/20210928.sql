USE [travelmanagement]
GO

/****** Object:  Table [dbo].[trekchangepanel]    Script Date: 2021-09-28 9:30:53 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[trekchangepanel](
	[SN] [int] IDENTITY(1,1) NOT NULL,
	[trekpicture] [text] NULL,
	[trekpricelabel] [int] NULL,
	[treklocation] [text] NULL,
 CONSTRAINT [PK_trekchangepanel] PRIMARY KEY CLUSTERED 
(
	[SN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


