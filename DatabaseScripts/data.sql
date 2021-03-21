SET IDENTITY_INSERT [dbo].[Stock] ON
INSERT INTO [dbo].[Stock] ([Id], [Company], [Price], [NumberOfStocks]) VALUES (3, N'ABC Systems Inc.', CAST(50.00 AS Decimal(18, 2)), 20000)
INSERT INTO [dbo].[Stock] ([Id], [Company], [Price], [NumberOfStocks]) VALUES (4, N'Mega Fashion', CAST(40.00 AS Decimal(18, 2)), 30000)
INSERT INTO [dbo].[Stock] ([Id], [Company], [Price], [NumberOfStocks]) VALUES (5, N'Tech Networking', CAST(60.00 AS Decimal(18, 2)), 50000)
INSERT INTO [dbo].[Stock] ([Id], [Company], [Price], [NumberOfStocks]) VALUES (6, N'E-Channeling.com', CAST(70.00 AS Decimal(18, 2)), 60000)
SET IDENTITY_INSERT [dbo].[Stock] OFF
