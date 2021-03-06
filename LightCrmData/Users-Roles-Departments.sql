USE [CrmDataBase]
GO
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([Id], [Name]) VALUES (1, N'Администратор
')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (2, N'Хирургия
')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (3, N'Гинекология
')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (4, N'Гастроэнтерология
')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (5, N'Гематология
')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (6, N'Детская хирургия
')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (7, N'Дерматовенерология
')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (8, N'Комбустиология
')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (9, N'Нейрохирургия
')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (10, N'Неонатология
')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (11, N'Онкология
')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (12, N'Оториноларингология
')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (13, N'Офтальмология
')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (14, N'Педиатрия
')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (15, N'Ревматология
')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (16, N'Сердечно-сосудистая хирургия
')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (17, N'Травматология
')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (18, N'Урология
')
SET IDENTITY_INSERT [dbo].[Departments] OFF
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([Id], [Name]) VALUES (1, N'Администратор')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (2, N'Оператор')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (3, N'Врач')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (4, N'Медсестра')
SET IDENTITY_INSERT [dbo].[Roles] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Name], [Password], [Surname], [Patronymic], [UserName], [RoleId], [DepartmentId]) VALUES (6, N'Администратор', N'6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b', N'Администраторов', N'Администраторович', N'1', 1, 1)
INSERT [dbo].[Users] ([Id], [Name], [Password], [Surname], [Patronymic], [UserName], [RoleId], [DepartmentId]) VALUES (33, N'1', N'd4735e3a265e16eee03f59718b9b5d03019c07d8b6c51f90da3a666eec13ab35', N'1', N'1', N'2', 4, 1)
INSERT [dbo].[Users] ([Id], [Name], [Password], [Surname], [Patronymic], [UserName], [RoleId], [DepartmentId]) VALUES (34, N'zz', N'594e519ae499312b29433b7dd8a97ff068defcba9755b6d5d00e84c524d67b06', N'zx', N'xbc', N'zzz', 4, 1)
INSERT [dbo].[Users] ([Id], [Name], [Password], [Surname], [Patronymic], [UserName], [RoleId], [DepartmentId]) VALUES (35, N'pb', N'5feceb66ffc86f38d952786c6d696c79c2dbc239dd4e91b46729d73a27fb57e9', N'upi', N'pbvy8', N'ipb', 2, 12)
SET IDENTITY_INSERT [dbo].[Users] OFF
