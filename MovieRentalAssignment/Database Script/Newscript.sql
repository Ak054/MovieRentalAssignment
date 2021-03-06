USE [master]
GO
/****** Object:  Database [MovieRentalSys]    Script Date: 29-11-2020 4.39.50 PM ******/
CREATE DATABASE [MovieRentalSys]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MovieRentalSys', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MovieRentalSys.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MovieRentalSys_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MovieRentalSys_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MovieRentalSys].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MovieRentalSys] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MovieRentalSys] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MovieRentalSys] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MovieRentalSys] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MovieRentalSys] SET ARITHABORT OFF 
GO
ALTER DATABASE [MovieRentalSys] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [MovieRentalSys] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MovieRentalSys] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MovieRentalSys] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MovieRentalSys] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MovieRentalSys] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MovieRentalSys] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MovieRentalSys] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MovieRentalSys] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MovieRentalSys] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MovieRentalSys] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MovieRentalSys] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MovieRentalSys] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MovieRentalSys] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MovieRentalSys] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MovieRentalSys] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MovieRentalSys] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MovieRentalSys] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MovieRentalSys] SET  MULTI_USER 
GO
ALTER DATABASE [MovieRentalSys] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MovieRentalSys] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MovieRentalSys] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MovieRentalSys] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MovieRentalSys] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MovieRentalSys] SET QUERY_STORE = OFF
GO
USE [MovieRentalSys]
GO
/****** Object:  User [ma]    Script Date: 29-11-2020 4.39.50 PM ******/
CREATE USER [ma] FOR LOGIN [ma] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [ma]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 29-11-2020 4.39.50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](255) NOT NULL,
	[LastName] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NOT NULL,
	[Phone] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 29-11-2020 4.39.50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[MovieID] [int] IDENTITY(1,1) NOT NULL,
	[Rating] [nvarchar](50) NULL,
	[Title] [nvarchar](255) NULL,
	[Year] [nvarchar](255) NULL,
	[RentCost] [int] NULL,
	[StoryLine] [ntext] NULL,
	[Genre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentedMovies]    Script Date: 29-11-2020 4.39.50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentedMovies](
	[RMID] [int] IDENTITY(1,1) NOT NULL,
	[MovieID] [int] NULL,
	[CustID] [int] NULL,
	[DateRented] [varchar](100) NULL,
	[DateReturned] [varchar](100) NULL,
	[TotalRent] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (1511, N'Shivam', N'Pandit', N'Willington, NZ', N'989896')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (1512, N'Sukhpal', N'Singh', N'Willington, NZ', N'6400014')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (1513, N'Alex', N'smith', N'Auckland, NZ', N'456456')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (1514, N'Yogesh', N'Malik', N'Auckland, NZ', N'132456')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (1515, N'Olivia', N'Grey', N'London', N'1245656')
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [RentCost], [StoryLine], [Genre]) VALUES (548, N'5.8', N'Chocked', N'2020', 5, N'A bank employee weighed down by her jobless husband''s debts - and her own broken dreams - finds a secret source of seemingly unlimited cash in her home.', N'Drama')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [RentCost], [StoryLine], [Genre]) VALUES (549, N'6.1', N'Lost Girls', N'2020', 5, N'When Mari Gilbert''s daughter disappears, police inaction drives her own investigation into the gated Long Island community where Shannan was last seen. Her search brings attention to over a dozen murdered sex workers.', N' Drama, Mystery, Thriller')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [RentCost], [StoryLine], [Genre]) VALUES (550, N'6.8', N'Serious Men', N'2020', 5, N'Tormented with his ''under-privileged'' societal status, a father capitalizes on his son''s newfound fame as a boy-genius. Little does he realize that the secret he harbors will destroy the very thing he loves the most.', N'Drama')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [RentCost], [StoryLine], [Genre]) VALUES (551, N'6.5', N'Don Jon', N'2013', 2, N'A New Jersey guy dedicated to his family, friends, and church, develops unrealistic expectations from watching porn and works to find happiness and intimacy with his potential true love.', N' Comedy, Drama, Romance ')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [RentCost], [StoryLine], [Genre]) VALUES (552, N'7.5', N'Hugo', N'2011', 2, N'In 1931 Paris, an orphan living in the walls of a train station gets wrapped up in a mystery involving his late father and an automaton.', N' Drama, Family, Fantasy')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [RentCost], [StoryLine], [Genre]) VALUES (553, N'7.3', N'Okja', N'2017', 5, N'A young girl risks everything to prevent a powerful, multinational company from kidnapping her best friend - a fascinating beast named Okja.', N' Action, Adventure, Drama')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [RentCost], [StoryLine], [Genre]) VALUES (554, N'7.8', N'About Time', N'2013', 2, N'At the age of 21, Tim discovers he can travel in time and change what happens and has happened in his own life. His decision to make his world a better place by getting a girlfriend turns out not to be as easy as you might think', N' Comedy, Drama, Fantasy')
SET IDENTITY_INSERT [dbo].[Movies] OFF
GO
SET IDENTITY_INSERT [dbo].[RentedMovies] ON 

INSERT [dbo].[RentedMovies] ([RMID], [MovieID], [CustID], [DateRented], [DateReturned], [TotalRent]) VALUES (6, 550, 1511, N'24-11-2020', N'26-11-2020', 10)
INSERT [dbo].[RentedMovies] ([RMID], [MovieID], [CustID], [DateRented], [DateReturned], [TotalRent]) VALUES (7, 551, 1511, N'24-11-2020', N'28-11-2020', 8)
INSERT [dbo].[RentedMovies] ([RMID], [MovieID], [CustID], [DateRented], [DateReturned], [TotalRent]) VALUES (8, 554, 1511, N'24-11-2020', N'29-11-2020', 10)
INSERT [dbo].[RentedMovies] ([RMID], [MovieID], [CustID], [DateRented], [DateReturned], [TotalRent]) VALUES (9, 549, 1512, N'24-11-2020', N'27-11-2020', 15)
INSERT [dbo].[RentedMovies] ([RMID], [MovieID], [CustID], [DateRented], [DateReturned], [TotalRent]) VALUES (10, 549, 1515, N'24-11-2020', N'26-11-2020', 10)
INSERT [dbo].[RentedMovies] ([RMID], [MovieID], [CustID], [DateRented], [DateReturned], [TotalRent]) VALUES (11, 549, 1514, N'24-11-2020', N'30-11-2020', 30)
INSERT [dbo].[RentedMovies] ([RMID], [MovieID], [CustID], [DateRented], [DateReturned], [TotalRent]) VALUES (12, 552, 1513, N'26-11-2020', N'11-12-2020', 30)
SET IDENTITY_INSERT [dbo].[RentedMovies] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [uk_phone]    Script Date: 29-11-2020 4.39.50 PM ******/
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [uk_phone] UNIQUE NONCLUSTERED 
(
	[Phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Movies__2CB664DCA146C6C2]    Script Date: 29-11-2020 4.39.50 PM ******/
ALTER TABLE [dbo].[Movies] ADD UNIQUE NONCLUSTERED 
(
	[Title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RentedMovies]  WITH CHECK ADD  CONSTRAINT [FK1] FOREIGN KEY([MovieID])
REFERENCES [dbo].[Movies] ([MovieID])
GO
ALTER TABLE [dbo].[RentedMovies] CHECK CONSTRAINT [FK1]
GO
ALTER TABLE [dbo].[RentedMovies]  WITH CHECK ADD  CONSTRAINT [FK2] FOREIGN KEY([CustID])
REFERENCES [dbo].[Customer] ([CustID])
GO
ALTER TABLE [dbo].[RentedMovies] CHECK CONSTRAINT [FK2]
GO
/****** Object:  StoredProcedure [dbo].[CustBorrowMostMovies]    Script Date: 29-11-2020 4.39.50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create proc [dbo].[CustBorrowMostMovies]
	as
	SELECT 
    rm.CustID,
	FirstName,Lastname,
    COUNT(*) CustomerCount
FROM RentedMovies rm join customer cc on cc.custid = rm.custid
GROUP BY
    rm.CustID, FirstName,Lastname
  
HAVING 
    COUNT(*) >=2;
GO
/****** Object:  StoredProcedure [dbo].[InsertCustomerInformation]    Script Date: 29-11-2020 4.39.50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[InsertCustomerInformation](@FirstName nvarchar(255),@LastName nvarchar(255),@Address varchar(max),@Phone nvarchar(255))
  as  insert into customer(FirstName,LastName,Address,Phone) values(@FirstName,@LastName,@Address,@Phone)
GO
/****** Object:  StoredProcedure [dbo].[InsertMovie]    Script Date: 29-11-2020 4.39.50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertMovie](@title nvarchar(255),@year nvarchar(255),@rating nvarchar(50),
  @genre nvarchar(50),@rentcost int,@StoryLine ntext)
  as
  insert into movies values(@Rating,@Title,@Year,@RentCost,@StoryLine,@Genre)
GO
/****** Object:  StoredProcedure [dbo].[RentThisMovie]    Script Date: 29-11-2020 4.39.50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE proc [dbo].[RentThisMovie](@MovieID int,@CustID int,@RentDate varchar(100), @ReturnDate varchar(100),@TotalRent int)
  as
  insert into RentedMovies values(@MovieID,@CustID,@RentDate,@ReturnDate,@TotalRent)
GO
/****** Object:  StoredProcedure [dbo].[ShowAllRentedMovies]    Script Date: 29-11-2020 4.39.50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE proc [dbo].[ShowAllRentedMovies]
  as
  select RMID, concat(FirstName,' ',LastName) as 'Customer Name', Address, Title as MovieTitle,
  RentCost,DateRented,DateReturned,TotalRent from RentedMovies rm 
  join Customer c on c.CustID = rm.CustID join Movies m on m.MovieID= rm.MovieID
  order by DateRented desc
GO
/****** Object:  StoredProcedure [dbo].[ShowMostPopularMovies]    Script Date: 29-11-2020 4.39.50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

   create proc [dbo].[ShowMostPopularMovies]
 as
SELECT 
    rm.MovieID,title, COUNT(*) MovieCount
FROM RentedMovies rm join movies m on m.movieid = rm.movieid
GROUP BY
    rm.MovieID, title
  
HAVING 
    COUNT(*) >=2;
GO
/****** Object:  StoredProcedure [dbo].[ShowMovieByID]    Script Date: 29-11-2020 4.39.50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ShowMovieByID](@movieID int)
  as
  Select * from movies where movieid=@movieID
GO
/****** Object:  StoredProcedure [dbo].[ShowRentedMovieByCustomerID]    Script Date: 29-11-2020 4.39.50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[ShowRentedMovieByCustomerID](@custID int)
  as
  select rm.MovieID, Title from RentedMovies rm join movies mv on rm.movieid= mv.movieid 
  where DateRented is not null and custid=@custID group by Title, rm.MovieID
GO
/****** Object:  StoredProcedure [dbo].[UpdateMovieInform]    Script Date: 29-11-2020 4.39.50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[UpdateMovieInform](@title nvarchar(255),@year nvarchar(255),@rating nvarchar(50),
  @genre varchar(50),@rentcost int,@StoryLine ntext,@movieId int)
  as
  update movies set title=@title,year=@year,Rating=@rating,
  genre=@genre,RentCost=@rentcost, storyline=@StoryLine where movieId=@movieId
GO
USE [master]
GO
ALTER DATABASE [MovieRentalSys] SET  READ_WRITE 
GO
