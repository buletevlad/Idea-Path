USE [DailyDo]
GO

/****** Object:  Table [dbo].[Idea]    Script Date: 10-Feb-18 1:15:32 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Idea](
	[Id] [int] identity(1,1),
	[TaskId] [int] NOT NULL,
	[StatusId] [int] NOT NULL,
	[TypeId] [int] NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Line] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Idea]  WITH CHECK ADD  CONSTRAINT [FK_Line_Status] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([Id])
GO

ALTER TABLE [dbo].[Idea] CHECK CONSTRAINT [FK_Line_Status]
GO

ALTER TABLE [dbo].[Idea]  WITH CHECK ADD  CONSTRAINT [FK_Line_Task] FOREIGN KEY([TaskId])
REFERENCES [dbo].[Task] ([Id])
GO

ALTER TABLE [dbo].[Idea] CHECK CONSTRAINT [FK_Line_Task]
GO

ALTER TABLE [dbo].[Idea]  WITH CHECK ADD  CONSTRAINT [FK_Line_Type] FOREIGN KEY([TypeId])
REFERENCES [dbo].[Type] ([Id])
GO

ALTER TABLE [dbo].[Idea] CHECK CONSTRAINT [FK_Line_Type]
GO

