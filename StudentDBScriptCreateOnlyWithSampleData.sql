USE [StudentDb]
GO
/****** Object:  Table [dbo].[StudentInfoTable]    Script Date: 7/3/2020 9:13:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentInfoTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](30) NOT NULL,
	[LastName] [nvarchar](30) NOT NULL,
	[Class] [nvarchar](max) NULL,
 CONSTRAINT [PK_StudentInfoTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubjectInfoTable]    Script Date: 7/3/2020 9:13:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubjectInfoTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SubjectName] [nvarchar](50) NOT NULL,
	[Marks] [int] NOT NULL,
	[StudentId] [int] NOT NULL,
 CONSTRAINT [PK_SubjectInfoTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[StudentInfoTable] ON 

INSERT [dbo].[StudentInfoTable] ([Id], [FirstName], [LastName], [Class]) VALUES (18, N'Abhishek', N'Bhardwaj', N'Third')
INSERT [dbo].[StudentInfoTable] ([Id], [FirstName], [LastName], [Class]) VALUES (19, N'Akshat', N'Sharma', N'BA')
INSERT [dbo].[StudentInfoTable] ([Id], [FirstName], [LastName], [Class]) VALUES (20, N'Pragya', N'Bhardwaj', N'Ba')
INSERT [dbo].[StudentInfoTable] ([Id], [FirstName], [LastName], [Class]) VALUES (21, N'Ankit', N'Suman', N'BSC')
INSERT [dbo].[StudentInfoTable] ([Id], [FirstName], [LastName], [Class]) VALUES (23, N'Sumit', N'Singh', N'BE')
INSERT [dbo].[StudentInfoTable] ([Id], [FirstName], [LastName], [Class]) VALUES (24, N'Ankita', N'Sharma', N'BCom')
INSERT [dbo].[StudentInfoTable] ([Id], [FirstName], [LastName], [Class]) VALUES (25, N'Amith', N'Singh', N'BSC')
INSERT [dbo].[StudentInfoTable] ([Id], [FirstName], [LastName], [Class]) VALUES (26, N'Altaf', N'Raza', N'Bsc')
INSERT [dbo].[StudentInfoTable] ([Id], [FirstName], [LastName], [Class]) VALUES (27, N'Inder', N'Singh', N'Std3')
INSERT [dbo].[StudentInfoTable] ([Id], [FirstName], [LastName], [Class]) VALUES (28, N'Aman', N'Verma', N'BTech')
INSERT [dbo].[StudentInfoTable] ([Id], [FirstName], [LastName], [Class]) VALUES (29, N'Puja', N'Sharma', N'Ba')
INSERT [dbo].[StudentInfoTable] ([Id], [FirstName], [LastName], [Class]) VALUES (30, N'Luke', N'Ronch', N'Bsc')
SET IDENTITY_INSERT [dbo].[StudentInfoTable] OFF
GO
SET IDENTITY_INSERT [dbo].[SubjectInfoTable] ON 

INSERT [dbo].[SubjectInfoTable] ([Id], [SubjectName], [Marks], [StudentId]) VALUES (36, N'Hindi', 98, 18)
INSERT [dbo].[SubjectInfoTable] ([Id], [SubjectName], [Marks], [StudentId]) VALUES (37, N'Maths', 88, 18)
INSERT [dbo].[SubjectInfoTable] ([Id], [SubjectName], [Marks], [StudentId]) VALUES (38, N'English', 75, 19)
INSERT [dbo].[SubjectInfoTable] ([Id], [SubjectName], [Marks], [StudentId]) VALUES (39, N'Maths', 66, 19)
INSERT [dbo].[SubjectInfoTable] ([Id], [SubjectName], [Marks], [StudentId]) VALUES (40, N'Maths', 78, 20)
INSERT [dbo].[SubjectInfoTable] ([Id], [SubjectName], [Marks], [StudentId]) VALUES (41, N'English', 89, 20)
INSERT [dbo].[SubjectInfoTable] ([Id], [SubjectName], [Marks], [StudentId]) VALUES (42, N'Physics', 78, 21)
INSERT [dbo].[SubjectInfoTable] ([Id], [SubjectName], [Marks], [StudentId]) VALUES (43, N'Maths', 98, 21)
INSERT [dbo].[SubjectInfoTable] ([Id], [SubjectName], [Marks], [StudentId]) VALUES (46, N'Maths', 66, 23)
INSERT [dbo].[SubjectInfoTable] ([Id], [SubjectName], [Marks], [StudentId]) VALUES (47, N'Economics', 89, 24)
INSERT [dbo].[SubjectInfoTable] ([Id], [SubjectName], [Marks], [StudentId]) VALUES (48, N'Accounts', 78, 24)
INSERT [dbo].[SubjectInfoTable] ([Id], [SubjectName], [Marks], [StudentId]) VALUES (49, N'Maths', 88, 25)
INSERT [dbo].[SubjectInfoTable] ([Id], [SubjectName], [Marks], [StudentId]) VALUES (50, N'English', 77, 26)
INSERT [dbo].[SubjectInfoTable] ([Id], [SubjectName], [Marks], [StudentId]) VALUES (51, N'Maths', 88, 27)
INSERT [dbo].[SubjectInfoTable] ([Id], [SubjectName], [Marks], [StudentId]) VALUES (52, N'Java Programing', 88, 28)
INSERT [dbo].[SubjectInfoTable] ([Id], [SubjectName], [Marks], [StudentId]) VALUES (53, N'EM', 88, 28)
INSERT [dbo].[SubjectInfoTable] ([Id], [SubjectName], [Marks], [StudentId]) VALUES (54, N'Hindi', 77, 29)
INSERT [dbo].[SubjectInfoTable] ([Id], [SubjectName], [Marks], [StudentId]) VALUES (55, N'Maths', 88, 30)
SET IDENTITY_INSERT [dbo].[SubjectInfoTable] OFF
GO
ALTER TABLE [dbo].[SubjectInfoTable]  WITH CHECK ADD  CONSTRAINT [FK_SubjectInfoTable_StudentInfoTable_StudentId] FOREIGN KEY([StudentId])
REFERENCES [dbo].[StudentInfoTable] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SubjectInfoTable] CHECK CONSTRAINT [FK_SubjectInfoTable_StudentInfoTable_StudentId]
GO
