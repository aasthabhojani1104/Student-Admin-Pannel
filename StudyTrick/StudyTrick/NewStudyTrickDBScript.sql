ALTER DATABASE [StudyTrickDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudyTrickDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudyTrickDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudyTrickDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudyTrickDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudyTrickDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudyTrickDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudyTrickDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StudyTrickDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudyTrickDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudyTrickDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudyTrickDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudyTrickDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudyTrickDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudyTrickDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudyTrickDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudyTrickDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StudyTrickDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudyTrickDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudyTrickDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudyTrickDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudyTrickDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudyTrickDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudyTrickDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudyTrickDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StudyTrickDB] SET  MULTI_USER 
GO
ALTER DATABASE [StudyTrickDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudyTrickDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudyTrickDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudyTrickDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StudyTrickDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StudyTrickDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [StudyTrickDB] SET QUERY_STORE = OFF
GO
USE [StudyTrickDB]
GO
/****** Object:  Table [dbo].[ADM_Intake]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADM_Intake](
	[IntakeID] [int] IDENTITY(1,1) NOT NULL,
	[AdmissionYearID] [int] NOT NULL,
	[ProgramID] [int] NOT NULL,
	[CourseID] [int] NOT NULL,
	[QuotaID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[Intake] [int] NOT NULL,
	[Description] [nvarchar](100) NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ADM] PRIMARY KEY CLUSTERED 
(
	[IntakeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ADM_Student]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADM_Student](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[VisitorID] [int] NULL,
	[AdmissionYearID] [int] NOT NULL,
	[QuotaID] [int] NOT NULL,
	[CourseID] [int] NOT NULL,
	[ProgramID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[QualificationID] [int] NOT NULL,
	[CasteCategoryID] [int] NOT NULL,
	[StateID] [int] NULL,
	[CityID] [int] NULL,
	[StudentName] [nvarchar](100) NOT NULL,
	[ParentPhone] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](10) NOT NULL,
	[DateOfBirth] [datetime] NULL,
	[SSCPercentage] [decimal](5, 2) NULL,
	[SSCSchoolName] [nvarchar](100) NULL,
	[SSCPassingYear] [int] NULL,
	[HSCPercentage] [decimal](5, 2) NULL,
	[HSCSchoolName] [nvarchar](100) NULL,
	[HSCPassingYear] [int] NULL,
	[DiplomaPercentage] [decimal](5, 2) NULL,
	[DiplomaCollegeName] [nvarchar](100) NULL,
	[DiplomaPassingYear] [int] NULL,
	[UGPercentage] [decimal](5, 2) NULL,
	[UGCollegeName] [nvarchar](100) NULL,
	[UGPassingYear] [int] NULL,
	[PGPercentage] [decimal](5, 2) NULL,
	[PGCollegeName] [nvarchar](100) NULL,
	[PGPassingYear] [int] NULL,
	[PhotoPath] [nvarchar](250) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ADM_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ADM_StudentDocument]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADM_StudentDocument](
	[StudentDocumentID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[DocumentID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[DocumentPath] [nvarchar](250) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ADM_StudentDocument] PRIMARY KEY CLUSTERED 
(
	[StudentDocumentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ADM_Visitor]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADM_Visitor](
	[VisitorID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[AdmissionYearID] [int] NOT NULL,
	[CounsellorStaffID] [int] NULL,
	[VisitorStaffID] [int] NULL,
	[VisitorName] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[NoOfPeople] [int] NULL,
	[Address] [nvarchar](500) NOT NULL,
	[PassingYear] [date] NULL,
	[Description] [nvarchar](100) NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ADM_Visitor] PRIMARY KEY CLUSTERED 
(
	[VisitorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ADM_VisitorInterestedCourses]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADM_VisitorInterestedCourses](
	[VisitorInterestedCoursesID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[VisitorID] [int] NOT NULL,
	[CourseID] [int] NOT NULL,
 CONSTRAINT [PK_ADM_StudentInterestedCourses] PRIMARY KEY CLUSTERED 
(
	[VisitorInterestedCoursesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CNT_Count]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CNT_Count](
	[CountID] [int] IDENTITY(1,1) NOT NULL,
	[CountName] [nvarchar](100) NOT NULL,
	[CountValue] [int] NOT NULL,
 CONSTRAINT [PK_CNT_Count] PRIMARY KEY CLUSTERED 
(
	[CountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOC_City]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOC_City](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[StateID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[CityName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_LOC_City] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOC_State]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOC_State](
	[StateID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[StateName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_LOC_State] PRIMARY KEY CLUSTERED 
(
	[StateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MST_AdmissionYear]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MST_AdmissionYear](
	[AdmissionYearID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[AdmissionYear] [int] NOT NULL,
	[Description] [nvarchar](100) NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_MST_AdmissionYear] PRIMARY KEY CLUSTERED 
(
	[AdmissionYearID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MST_CasteCategory]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MST_CasteCategory](
	[CasteCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[CategoryName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_MST_CasteCategory] PRIMARY KEY CLUSTERED 
(
	[CasteCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MST_Course]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MST_Course](
	[CourseID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[CourseName] [nvarchar](100) NOT NULL,
	[CourseLevel] [nvarchar](50) NOT NULL,
	[CourseDuration] [nvarchar](20) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_MST_Course] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MST_CourseWiseDocument]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MST_CourseWiseDocument](
	[CourseWiseDocumentID] [int] IDENTITY(1,1) NOT NULL,
	[CourseID] [int] NOT NULL,
	[DocumentID] [int] NOT NULL,
	[AdmissionYearID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[Description] [nvarchar](100) NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_MST_CourseWiseDocument] PRIMARY KEY CLUSTERED 
(
	[CourseWiseDocumentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MST_Document]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MST_Document](
	[DocumentID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[DocumentName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_MST_Document] PRIMARY KEY CLUSTERED 
(
	[DocumentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MST_Program]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MST_Program](
	[ProgramID] [int] IDENTITY(1,1) NOT NULL,
	[CourseID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[ProgramName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_MST_Program] PRIMARY KEY CLUSTERED 
(
	[ProgramID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MST_Qualification]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MST_Qualification](
	[QualificationID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[QualificationName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_MST_Qualification] PRIMARY KEY CLUSTERED 
(
	[QualificationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MST_Quota]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MST_Quota](
	[QuotaID] [int] IDENTITY(1,1) NOT NULL,
	[CourseID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[QuotaName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_MST_Quota] PRIMARY KEY CLUSTERED 
(
	[QuotaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MST_Staff]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MST_Staff](
	[StaffID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[StaffName] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[StaffCode] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_MST_Staff] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MST_User]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MST_User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_MST_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ADM_Intake] ON 

INSERT [dbo].[ADM_Intake] ([IntakeID], [AdmissionYearID], [ProgramID], [CourseID], [QuotaID], [UserID], [Intake], [Description], [CreationDate], [ModificationDate]) VALUES (3, 3, 2, 2, 2, 2, 100, NULL, CAST(N'2023-03-27T23:32:37.660' AS DateTime), CAST(N'2023-03-27T23:32:37.660' AS DateTime))
INSERT [dbo].[ADM_Intake] ([IntakeID], [AdmissionYearID], [ProgramID], [CourseID], [QuotaID], [UserID], [Intake], [Description], [CreationDate], [ModificationDate]) VALUES (5, 8, 2, 8, 2, 1, 45, N'gfg', CAST(N'2023-04-03T01:19:27.750' AS DateTime), CAST(N'2023-04-03T01:19:27.750' AS DateTime))
INSERT [dbo].[ADM_Intake] ([IntakeID], [AdmissionYearID], [ProgramID], [CourseID], [QuotaID], [UserID], [Intake], [Description], [CreationDate], [ModificationDate]) VALUES (10, 7, 12, 8, 4, 1, 45, N'hh', CAST(N'2023-05-01T23:30:38.377' AS DateTime), CAST(N'2023-05-01T23:30:38.377' AS DateTime))
INSERT [dbo].[ADM_Intake] ([IntakeID], [AdmissionYearID], [ProgramID], [CourseID], [QuotaID], [UserID], [Intake], [Description], [CreationDate], [ModificationDate]) VALUES (11, 8, 7, 4, 4, 1, 80, NULL, CAST(N'2023-05-01T23:35:42.677' AS DateTime), CAST(N'2023-05-01T23:36:13.387' AS DateTime))
SET IDENTITY_INSERT [dbo].[ADM_Intake] OFF
GO
SET IDENTITY_INSERT [dbo].[ADM_Student] ON 

INSERT [dbo].[ADM_Student] ([StudentID], [VisitorID], [AdmissionYearID], [QuotaID], [CourseID], [ProgramID], [UserID], [QualificationID], [CasteCategoryID], [StateID], [CityID], [StudentName], [ParentPhone], [Gender], [DateOfBirth], [SSCPercentage], [SSCSchoolName], [SSCPassingYear], [HSCPercentage], [HSCSchoolName], [HSCPassingYear], [DiplomaPercentage], [DiplomaCollegeName], [DiplomaPassingYear], [UGPercentage], [UGCollegeName], [UGPassingYear], [PGPercentage], [PGCollegeName], [PGPassingYear], [PhotoPath], [Description], [CreationDate], [ModificationDate]) VALUES (8, 16, 7, 2, 4, 7, 1, 2, 5, 1, 2, N'Hemang Kateshiya', N'78799', N'Male', CAST(N'2023-11-30T00:00:00.000' AS DateTime), CAST(78.90 AS Decimal(5, 2)), N'School', 2020, CAST(80.00 AS Decimal(5, 2)), N'School', 2022, CAST(9.00 AS Decimal(5, 2)), N'College', 2025, CAST(9.00 AS Decimal(5, 2)), N'College', 2029, CAST(9.00 AS Decimal(5, 2)), N'College', 2031, N'~/Uploads/profile-img.jpg', N'Nothing Nothing Nothing Nothing Nothing Nothing Nothing Nothing Nothing Nothing Nothing Nothing Noth', CAST(N'2023-04-08T22:48:21.260' AS DateTime), CAST(N'2023-06-01T10:49:15.413' AS DateTime))
INSERT [dbo].[ADM_Student] ([StudentID], [VisitorID], [AdmissionYearID], [QuotaID], [CourseID], [ProgramID], [UserID], [QualificationID], [CasteCategoryID], [StateID], [CityID], [StudentName], [ParentPhone], [Gender], [DateOfBirth], [SSCPercentage], [SSCSchoolName], [SSCPassingYear], [HSCPercentage], [HSCSchoolName], [HSCPassingYear], [DiplomaPercentage], [DiplomaCollegeName], [DiplomaPassingYear], [UGPercentage], [UGCollegeName], [UGPassingYear], [PGPercentage], [PGCollegeName], [PGPassingYear], [PhotoPath], [Description], [CreationDate], [ModificationDate]) VALUES (12, 10, 2, 4, 4, 7, 1, 6, 2, 9, 10, N'ABC', N'78799', N'Male', CAST(N'2023-11-30T00:00:00.000' AS DateTime), CAST(70.80 AS Decimal(5, 2)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'~/Uploads/logo.jpg', NULL, CAST(N'2023-04-09T19:12:27.093' AS DateTime), CAST(N'2023-05-03T23:49:36.487' AS DateTime))
INSERT [dbo].[ADM_Student] ([StudentID], [VisitorID], [AdmissionYearID], [QuotaID], [CourseID], [ProgramID], [UserID], [QualificationID], [CasteCategoryID], [StateID], [CityID], [StudentName], [ParentPhone], [Gender], [DateOfBirth], [SSCPercentage], [SSCSchoolName], [SSCPassingYear], [HSCPercentage], [HSCSchoolName], [HSCPassingYear], [DiplomaPercentage], [DiplomaCollegeName], [DiplomaPassingYear], [UGPercentage], [UGCollegeName], [UGPassingYear], [PGPercentage], [PGCollegeName], [PGPassingYear], [PhotoPath], [Description], [CreationDate], [ModificationDate]) VALUES (18, 15, 7, 4, 4, 8, 1, 2, 5, 1, 3, N'Parth G.', N'3', N'Female', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'~/Uploads/smile.png', NULL, CAST(N'2023-04-30T20:52:33.080' AS DateTime), CAST(N'2023-05-29T12:10:51.663' AS DateTime))
INSERT [dbo].[ADM_Student] ([StudentID], [VisitorID], [AdmissionYearID], [QuotaID], [CourseID], [ProgramID], [UserID], [QualificationID], [CasteCategoryID], [StateID], [CityID], [StudentName], [ParentPhone], [Gender], [DateOfBirth], [SSCPercentage], [SSCSchoolName], [SSCPassingYear], [HSCPercentage], [HSCSchoolName], [HSCPassingYear], [DiplomaPercentage], [DiplomaCollegeName], [DiplomaPassingYear], [UGPercentage], [UGCollegeName], [UGPassingYear], [PGPercentage], [PGCollegeName], [PGPassingYear], [PhotoPath], [Description], [CreationDate], [ModificationDate]) VALUES (20, 17, 27, 4, 4, 2, 1, 5, 8, 1, 3, N'Keval K.', N'454', N'Male', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'~/Uploads/neutral.png', NULL, CAST(N'2023-05-03T20:08:44.780' AS DateTime), CAST(N'2023-05-29T12:07:53.340' AS DateTime))
INSERT [dbo].[ADM_Student] ([StudentID], [VisitorID], [AdmissionYearID], [QuotaID], [CourseID], [ProgramID], [UserID], [QualificationID], [CasteCategoryID], [StateID], [CityID], [StudentName], [ParentPhone], [Gender], [DateOfBirth], [SSCPercentage], [SSCSchoolName], [SSCPassingYear], [HSCPercentage], [HSCSchoolName], [HSCPassingYear], [DiplomaPercentage], [DiplomaCollegeName], [DiplomaPassingYear], [UGPercentage], [UGCollegeName], [UGPassingYear], [PGPercentage], [PGCollegeName], [PGPassingYear], [PhotoPath], [Description], [CreationDate], [ModificationDate]) VALUES (21, 12, 3, 9, 3, 14, 2, 11, 3, 17, 12, N'ABC', N'676', N'Male', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'~/Uploads/verified.png', NULL, CAST(N'2023-05-04T11:57:12.333' AS DateTime), CAST(N'2023-05-04T11:57:12.333' AS DateTime))
SET IDENTITY_INSERT [dbo].[ADM_Student] OFF
GO
SET IDENTITY_INSERT [dbo].[ADM_StudentDocument] ON 

INSERT [dbo].[ADM_StudentDocument] ([StudentDocumentID], [StudentID], [DocumentID], [UserID], [DocumentPath], [Description], [CreationDate], [ModificationDate]) VALUES (7, 12, 4, 1, N'~/Uploads/done.png', NULL, CAST(N'2023-05-02T00:10:17.043' AS DateTime), CAST(N'2023-05-02T00:12:44.907' AS DateTime))
INSERT [dbo].[ADM_StudentDocument] ([StudentDocumentID], [StudentID], [DocumentID], [UserID], [DocumentPath], [Description], [CreationDate], [ModificationDate]) VALUES (8, 8, 11, 1, N'~/Uploads/smile.png', NULL, CAST(N'2023-05-02T11:04:10.203' AS DateTime), CAST(N'2023-05-02T11:04:10.203' AS DateTime))
SET IDENTITY_INSERT [dbo].[ADM_StudentDocument] OFF
GO
SET IDENTITY_INSERT [dbo].[ADM_Visitor] ON 

INSERT [dbo].[ADM_Visitor] ([VisitorID], [UserID], [AdmissionYearID], [CounsellorStaffID], [VisitorStaffID], [VisitorName], [Phone], [Email], [NoOfPeople], [Address], [PassingYear], [Description], [CreationDate], [ModificationDate]) VALUES (8, 2, 2, 2, 3, N'XYZ', N'12341234', N'sample@sample.com', 4, N'abc road', CAST(N'2022-01-01' AS Date), NULL, CAST(N'2023-04-08T22:28:44.350' AS DateTime), CAST(N'2023-04-11T23:22:36.617' AS DateTime))
INSERT [dbo].[ADM_Visitor] ([VisitorID], [UserID], [AdmissionYearID], [CounsellorStaffID], [VisitorStaffID], [VisitorName], [Phone], [Email], [NoOfPeople], [Address], [PassingYear], [Description], [CreationDate], [ModificationDate]) VALUES (10, 1, 2, NULL, NULL, N'ABC', NULL, NULL, 4, N'xyz road', CAST(N'2023-05-26' AS Date), NULL, CAST(N'2023-04-08T22:47:27.573' AS DateTime), CAST(N'2023-05-26T11:41:57.607' AS DateTime))
INSERT [dbo].[ADM_Visitor] ([VisitorID], [UserID], [AdmissionYearID], [CounsellorStaffID], [VisitorStaffID], [VisitorName], [Phone], [Email], [NoOfPeople], [Address], [PassingYear], [Description], [CreationDate], [ModificationDate]) VALUES (12, 2, 3, 7, 7, N'Deep Popat', N'12341234', N'sample@sample.com', 4, N'abc road', CAST(N'2022-11-30' AS Date), NULL, CAST(N'2023-04-11T23:00:04.440' AS DateTime), CAST(N'2023-05-04T11:58:04.730' AS DateTime))
INSERT [dbo].[ADM_Visitor] ([VisitorID], [UserID], [AdmissionYearID], [CounsellorStaffID], [VisitorStaffID], [VisitorName], [Phone], [Email], [NoOfPeople], [Address], [PassingYear], [Description], [CreationDate], [ModificationDate]) VALUES (13, 2, 2, 2, 2, N'Deep Popat', N'12341234', N'sample@sample.com', 4, N'abc road', CAST(N'2022-01-01' AS Date), NULL, CAST(N'2023-04-11T23:19:31.437' AS DateTime), CAST(N'2023-04-11T23:19:31.437' AS DateTime))
INSERT [dbo].[ADM_Visitor] ([VisitorID], [UserID], [AdmissionYearID], [CounsellorStaffID], [VisitorStaffID], [VisitorName], [Phone], [Email], [NoOfPeople], [Address], [PassingYear], [Description], [CreationDate], [ModificationDate]) VALUES (14, 1, 7, 6, 2, N'Deep Popat', N'1267343343', N'deep.popat@gmail.com', 3, N'Umiya Circle, Morbi', CAST(N'2019-11-30' AS Date), N'dadddsdisd sfisfisdfdif dfidfnsifnsd fdfinfsdf dfnidfdf d sdsdsdkm sdsds dsidsi dsids dsid isdsids', CAST(N'2023-04-11T23:26:24.787' AS DateTime), CAST(N'2023-05-27T23:25:16.037' AS DateTime))
INSERT [dbo].[ADM_Visitor] ([VisitorID], [UserID], [AdmissionYearID], [CounsellorStaffID], [VisitorStaffID], [VisitorName], [Phone], [Email], [NoOfPeople], [Address], [PassingYear], [Description], [CreationDate], [ModificationDate]) VALUES (15, 1, 14, NULL, NULL, N'Parth', N'45574', NULL, NULL, N'hi', NULL, NULL, CAST(N'2023-04-17T09:19:16.520' AS DateTime), CAST(N'2023-04-17T09:19:16.520' AS DateTime))
INSERT [dbo].[ADM_Visitor] ([VisitorID], [UserID], [AdmissionYearID], [CounsellorStaffID], [VisitorStaffID], [VisitorName], [Phone], [Email], [NoOfPeople], [Address], [PassingYear], [Description], [CreationDate], [ModificationDate]) VALUES (16, 1, 2, NULL, NULL, N'Hemang Kateshiya', N'1234567890', N'kateshiyahemang344@gmail.com', NULL, N'sd', CAST(N'2023-11-30' AS Date), NULL, CAST(N'2023-04-17T13:38:18.117' AS DateTime), CAST(N'2023-05-27T23:26:18.770' AS DateTime))
INSERT [dbo].[ADM_Visitor] ([VisitorID], [UserID], [AdmissionYearID], [CounsellorStaffID], [VisitorStaffID], [VisitorName], [Phone], [Email], [NoOfPeople], [Address], [PassingYear], [Description], [CreationDate], [ModificationDate]) VALUES (17, 1, 14, NULL, NULL, N'Keval', N'1234333', N'rte.ER@er.df', NULL, N'gt', CAST(N'2023-04-13' AS Date), NULL, CAST(N'2023-04-17T13:39:02.810' AS DateTime), CAST(N'2023-04-17T13:39:02.810' AS DateTime))
INSERT [dbo].[ADM_Visitor] ([VisitorID], [UserID], [AdmissionYearID], [CounsellorStaffID], [VisitorStaffID], [VisitorName], [Phone], [Email], [NoOfPeople], [Address], [PassingYear], [Description], [CreationDate], [ModificationDate]) VALUES (23, 1, 14, NULL, NULL, N'Lalji', NULL, NULL, NULL, N'Hostel New', CAST(N'2023-11-30' AS Date), NULL, CAST(N'2023-04-25T11:22:21.480' AS DateTime), CAST(N'2023-04-29T13:36:12.820' AS DateTime))
INSERT [dbo].[ADM_Visitor] ([VisitorID], [UserID], [AdmissionYearID], [CounsellorStaffID], [VisitorStaffID], [VisitorName], [Phone], [Email], [NoOfPeople], [Address], [PassingYear], [Description], [CreationDate], [ModificationDate]) VALUES (24, 1, 8, NULL, NULL, N'Jay', NULL, NULL, NULL, N'op', NULL, NULL, CAST(N'2023-04-25T12:23:22.343' AS DateTime), CAST(N'2023-04-25T12:23:22.343' AS DateTime))
INSERT [dbo].[ADM_Visitor] ([VisitorID], [UserID], [AdmissionYearID], [CounsellorStaffID], [VisitorStaffID], [VisitorName], [Phone], [Email], [NoOfPeople], [Address], [PassingYear], [Description], [CreationDate], [ModificationDate]) VALUES (30, 1, 27, NULL, NULL, N'TY', NULL, NULL, NULL, N'ui', NULL, NULL, CAST(N'2023-04-29T13:14:13.363' AS DateTime), CAST(N'2023-04-29T23:02:19.657' AS DateTime))
INSERT [dbo].[ADM_Visitor] ([VisitorID], [UserID], [AdmissionYearID], [CounsellorStaffID], [VisitorStaffID], [VisitorName], [Phone], [Email], [NoOfPeople], [Address], [PassingYear], [Description], [CreationDate], [ModificationDate]) VALUES (32, 1, 2, 3, 6, N'Demo', N'12121212', N'demo@demo.com', 2, N'dmeo', CAST(N'2023-05-17' AS Date), N'demo', CAST(N'2023-05-17T11:38:29.683' AS DateTime), CAST(N'2023-05-17T11:38:29.683' AS DateTime))
SET IDENTITY_INSERT [dbo].[ADM_Visitor] OFF
GO
SET IDENTITY_INSERT [dbo].[ADM_VisitorInterestedCourses] ON 

INSERT [dbo].[ADM_VisitorInterestedCourses] ([VisitorInterestedCoursesID], [UserID], [VisitorID], [CourseID]) VALUES (12, 1, 14, 2)
INSERT [dbo].[ADM_VisitorInterestedCourses] ([VisitorInterestedCoursesID], [UserID], [VisitorID], [CourseID]) VALUES (13, 1, 14, 4)
INSERT [dbo].[ADM_VisitorInterestedCourses] ([VisitorInterestedCoursesID], [UserID], [VisitorID], [CourseID]) VALUES (14, 1, 14, 11)
SET IDENTITY_INSERT [dbo].[ADM_VisitorInterestedCourses] OFF
GO
SET IDENTITY_INSERT [dbo].[CNT_Count] ON 

INSERT [dbo].[CNT_Count] ([CountID], [CountName], [CountValue]) VALUES (1, N'Male', 10)
SET IDENTITY_INSERT [dbo].[CNT_Count] OFF
GO
SET IDENTITY_INSERT [dbo].[LOC_City] ON 

INSERT [dbo].[LOC_City] ([CityID], [StateID], [UserID], [CityName], [Description], [CreationDate], [ModificationDate]) VALUES (2, 1, 1, N'Baroda', NULL, CAST(N'2023-03-25T13:36:53.703' AS DateTime), CAST(N'2023-03-25T13:36:53.703' AS DateTime))
INSERT [dbo].[LOC_City] ([CityID], [StateID], [UserID], [CityName], [Description], [CreationDate], [ModificationDate]) VALUES (3, 1, 1, N'Morbi', NULL, CAST(N'2023-03-25T13:37:02.073' AS DateTime), CAST(N'2023-04-11T22:25:47.240' AS DateTime))
INSERT [dbo].[LOC_City] ([CityID], [StateID], [UserID], [CityName], [Description], [CreationDate], [ModificationDate]) VALUES (4, 1, 1, N'Rajkot', NULL, CAST(N'2023-03-25T13:37:12.550' AS DateTime), CAST(N'2023-03-25T13:37:12.550' AS DateTime))
INSERT [dbo].[LOC_City] ([CityID], [StateID], [UserID], [CityName], [Description], [CreationDate], [ModificationDate]) VALUES (10, 9, 1, N'Kochi', NULL, CAST(N'2023-04-11T22:26:04.643' AS DateTime), CAST(N'2023-04-11T22:26:04.643' AS DateTime))
INSERT [dbo].[LOC_City] ([CityID], [StateID], [UserID], [CityName], [Description], [CreationDate], [ModificationDate]) VALUES (12, 17, 2, N'Ahmedabad', NULL, CAST(N'2023-05-04T11:56:21.727' AS DateTime), CAST(N'2023-05-04T11:56:21.727' AS DateTime))
INSERT [dbo].[LOC_City] ([CityID], [StateID], [UserID], [CityName], [Description], [CreationDate], [ModificationDate]) VALUES (13, 17, 2, N'Morbi', NULL, CAST(N'2023-05-04T11:56:30.363' AS DateTime), CAST(N'2023-05-04T11:56:30.363' AS DateTime))
INSERT [dbo].[LOC_City] ([CityID], [StateID], [UserID], [CityName], [Description], [CreationDate], [ModificationDate]) VALUES (14, 1, 1, N'Jamanagar', N'new city', CAST(N'2023-12-08T21:21:59.740' AS DateTime), CAST(N'2023-12-08T21:21:59.740' AS DateTime))
SET IDENTITY_INSERT [dbo].[LOC_City] OFF
GO
SET IDENTITY_INSERT [dbo].[LOC_State] ON 

INSERT [dbo].[LOC_State] ([StateID], [UserID], [StateName], [Description], [CreationDate], [ModificationDate]) VALUES (1, 1, N'Gujarat', NULL, CAST(N'2023-03-25T08:12:12.087' AS DateTime), CAST(N'2023-03-27T10:33:48.403' AS DateTime))
INSERT [dbo].[LOC_State] ([StateID], [UserID], [StateName], [Description], [CreationDate], [ModificationDate]) VALUES (4, 1, N'New Delhi', NULL, CAST(N'2023-03-26T21:30:06.790' AS DateTime), CAST(N'2023-03-31T00:13:42.313' AS DateTime))
INSERT [dbo].[LOC_State] ([StateID], [UserID], [StateName], [Description], [CreationDate], [ModificationDate]) VALUES (9, 1, N'Keral', NULL, CAST(N'2023-03-28T23:46:31.607' AS DateTime), CAST(N'2023-03-30T23:21:58.547' AS DateTime))
INSERT [dbo].[LOC_State] ([StateID], [UserID], [StateName], [Description], [CreationDate], [ModificationDate]) VALUES (17, 2, N'Gujarat', NULL, CAST(N'2023-05-04T11:56:09.567' AS DateTime), CAST(N'2023-05-04T11:56:09.567' AS DateTime))
SET IDENTITY_INSERT [dbo].[LOC_State] OFF
GO
SET IDENTITY_INSERT [dbo].[MST_AdmissionYear] ON 

INSERT [dbo].[MST_AdmissionYear] ([AdmissionYearID], [UserID], [AdmissionYear], [Description], [CreationDate], [ModificationDate]) VALUES (2, 1, 2022, N'New Batch 2022', CAST(N'2023-03-27T09:27:35.860' AS DateTime), CAST(N'2023-04-01T01:09:48.137' AS DateTime))
INSERT [dbo].[MST_AdmissionYear] ([AdmissionYearID], [UserID], [AdmissionYear], [Description], [CreationDate], [ModificationDate]) VALUES (3, 2, 2021, NULL, CAST(N'2023-03-27T09:27:44.663' AS DateTime), CAST(N'2023-03-27T09:27:44.663' AS DateTime))
INSERT [dbo].[MST_AdmissionYear] ([AdmissionYearID], [UserID], [AdmissionYear], [Description], [CreationDate], [ModificationDate]) VALUES (7, 1, 2024, N'M.Tech', CAST(N'2023-04-01T01:37:13.793' AS DateTime), CAST(N'2023-04-01T01:37:13.793' AS DateTime))
INSERT [dbo].[MST_AdmissionYear] ([AdmissionYearID], [UserID], [AdmissionYear], [Description], [CreationDate], [ModificationDate]) VALUES (8, 1, 2025, N'New Year', CAST(N'2023-04-01T08:12:36.263' AS DateTime), CAST(N'2023-04-01T08:13:05.087' AS DateTime))
INSERT [dbo].[MST_AdmissionYear] ([AdmissionYearID], [UserID], [AdmissionYear], [Description], [CreationDate], [ModificationDate]) VALUES (14, 1, 2023, NULL, CAST(N'2023-04-16T11:34:47.927' AS DateTime), CAST(N'2023-04-16T11:34:47.927' AS DateTime))
INSERT [dbo].[MST_AdmissionYear] ([AdmissionYearID], [UserID], [AdmissionYear], [Description], [CreationDate], [ModificationDate]) VALUES (20, 1, 2026, NULL, CAST(N'2023-04-16T12:11:45.743' AS DateTime), CAST(N'2023-04-16T12:11:45.743' AS DateTime))
INSERT [dbo].[MST_AdmissionYear] ([AdmissionYearID], [UserID], [AdmissionYear], [Description], [CreationDate], [ModificationDate]) VALUES (21, 1, 2027, NULL, CAST(N'2023-04-16T12:12:48.263' AS DateTime), CAST(N'2023-04-16T12:12:48.263' AS DateTime))
INSERT [dbo].[MST_AdmissionYear] ([AdmissionYearID], [UserID], [AdmissionYear], [Description], [CreationDate], [ModificationDate]) VALUES (27, 1, 2020, NULL, CAST(N'2023-04-16T17:07:13.160' AS DateTime), CAST(N'2023-04-16T17:07:13.160' AS DateTime))
SET IDENTITY_INSERT [dbo].[MST_AdmissionYear] OFF
GO
SET IDENTITY_INSERT [dbo].[MST_CasteCategory] ON 

INSERT [dbo].[MST_CasteCategory] ([CasteCategoryID], [UserID], [CategoryName], [Description], [CreationDate], [ModificationDate]) VALUES (2, 1, N'SC', NULL, CAST(N'2023-03-27T10:16:28.450' AS DateTime), CAST(N'2023-03-27T10:16:28.450' AS DateTime))
INSERT [dbo].[MST_CasteCategory] ([CasteCategoryID], [UserID], [CategoryName], [Description], [CreationDate], [ModificationDate]) VALUES (3, 2, N'Open', NULL, CAST(N'2023-03-27T10:16:41.310' AS DateTime), CAST(N'2023-03-27T10:16:41.310' AS DateTime))
INSERT [dbo].[MST_CasteCategory] ([CasteCategoryID], [UserID], [CategoryName], [Description], [CreationDate], [ModificationDate]) VALUES (5, 1, N'OBC', NULL, CAST(N'2023-04-01T10:43:09.160' AS DateTime), CAST(N'2023-04-01T10:43:09.160' AS DateTime))
INSERT [dbo].[MST_CasteCategory] ([CasteCategoryID], [UserID], [CategoryName], [Description], [CreationDate], [ModificationDate]) VALUES (6, 1, N'SEBC', NULL, CAST(N'2023-04-01T10:43:20.583' AS DateTime), CAST(N'2023-04-01T10:43:20.583' AS DateTime))
INSERT [dbo].[MST_CasteCategory] ([CasteCategoryID], [UserID], [CategoryName], [Description], [CreationDate], [ModificationDate]) VALUES (8, 1, N'ST', NULL, CAST(N'2023-04-01T13:06:32.570' AS DateTime), CAST(N'2023-04-01T13:06:32.570' AS DateTime))
SET IDENTITY_INSERT [dbo].[MST_CasteCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[MST_Course] ON 

INSERT [dbo].[MST_Course] ([CourseID], [UserID], [CourseName], [CourseLevel], [CourseDuration], [Description], [CreationDate], [ModificationDate]) VALUES (2, 1, N'BCA', N'UG', N'4 Years', NULL, CAST(N'2023-03-26T23:38:28.277' AS DateTime), CAST(N'2023-04-11T22:29:02.913' AS DateTime))
INSERT [dbo].[MST_Course] ([CourseID], [UserID], [CourseName], [CourseLevel], [CourseDuration], [Description], [CreationDate], [ModificationDate]) VALUES (3, 2, N'MCA', N'UG', N'3 Years', NULL, CAST(N'2023-03-26T23:39:12.943' AS DateTime), CAST(N'2023-03-26T23:39:12.943' AS DateTime))
INSERT [dbo].[MST_Course] ([CourseID], [UserID], [CourseName], [CourseLevel], [CourseDuration], [Description], [CreationDate], [ModificationDate]) VALUES (4, 1, N'B.Tech', N'UG', N'4 Years', NULL, CAST(N'2023-03-27T11:09:08.320' AS DateTime), CAST(N'2023-04-11T22:29:34.203' AS DateTime))
INSERT [dbo].[MST_Course] ([CourseID], [UserID], [CourseName], [CourseLevel], [CourseDuration], [Description], [CreationDate], [ModificationDate]) VALUES (7, 1, N'MCA', N'PG', N'2 Years', NULL, CAST(N'2023-04-02T17:39:49.397' AS DateTime), CAST(N'2023-04-11T22:34:34.753' AS DateTime))
INSERT [dbo].[MST_Course] ([CourseID], [UserID], [CourseName], [CourseLevel], [CourseDuration], [Description], [CreationDate], [ModificationDate]) VALUES (8, 1, N'Diploma', N'Polytechnic', N'3 Years', NULL, CAST(N'2023-04-02T20:18:06.160' AS DateTime), CAST(N'2023-04-11T22:34:23.023' AS DateTime))
INSERT [dbo].[MST_Course] ([CourseID], [UserID], [CourseName], [CourseLevel], [CourseDuration], [Description], [CreationDate], [ModificationDate]) VALUES (9, 1, N'BBA', N'UG', N'3 Years', NULL, CAST(N'2023-04-11T22:32:50.747' AS DateTime), CAST(N'2023-04-11T22:32:50.747' AS DateTime))
INSERT [dbo].[MST_Course] ([CourseID], [UserID], [CourseName], [CourseLevel], [CourseDuration], [Description], [CreationDate], [ModificationDate]) VALUES (10, 1, N'MBA', N'PG', N'2 Years', NULL, CAST(N'2023-04-11T22:33:09.657' AS DateTime), CAST(N'2023-04-11T22:33:09.657' AS DateTime))
INSERT [dbo].[MST_Course] ([CourseID], [UserID], [CourseName], [CourseLevel], [CourseDuration], [Description], [CreationDate], [ModificationDate]) VALUES (11, 1, N'M.Tech', N'PG', N'2 Years', NULL, CAST(N'2023-04-11T22:34:07.663' AS DateTime), CAST(N'2023-04-11T22:34:07.663' AS DateTime))
SET IDENTITY_INSERT [dbo].[MST_Course] OFF
GO
SET IDENTITY_INSERT [dbo].[MST_CourseWiseDocument] ON 

INSERT [dbo].[MST_CourseWiseDocument] ([CourseWiseDocumentID], [CourseID], [DocumentID], [AdmissionYearID], [UserID], [Description], [CreationDate], [ModificationDate]) VALUES (4, 4, 6, 7, 1, NULL, CAST(N'2023-03-27T12:46:47.780' AS DateTime), CAST(N'2023-04-10T23:23:26.783' AS DateTime))
INSERT [dbo].[MST_CourseWiseDocument] ([CourseWiseDocumentID], [CourseID], [DocumentID], [AdmissionYearID], [UserID], [Description], [CreationDate], [ModificationDate]) VALUES (5, 4, 4, 2, 1, N'as', CAST(N'2023-04-02T17:58:14.280' AS DateTime), CAST(N'2023-04-02T17:58:14.280' AS DateTime))
INSERT [dbo].[MST_CourseWiseDocument] ([CourseWiseDocumentID], [CourseID], [DocumentID], [AdmissionYearID], [UserID], [Description], [CreationDate], [ModificationDate]) VALUES (8, 8, 4, 14, 1, N'New', CAST(N'2023-04-16T18:50:55.940' AS DateTime), CAST(N'2023-04-16T18:50:55.940' AS DateTime))
SET IDENTITY_INSERT [dbo].[MST_CourseWiseDocument] OFF
GO
SET IDENTITY_INSERT [dbo].[MST_Document] ON 

INSERT [dbo].[MST_Document] ([DocumentID], [UserID], [DocumentName], [Description], [CreationDate], [ModificationDate]) VALUES (3, 2, N'UG Marksheet', NULL, CAST(N'2023-03-27T09:01:34.073' AS DateTime), CAST(N'2023-03-27T09:01:34.073' AS DateTime))
INSERT [dbo].[MST_Document] ([DocumentID], [UserID], [DocumentName], [Description], [CreationDate], [ModificationDate]) VALUES (4, 1, N'Photo', N'Student Photo', CAST(N'2023-04-02T10:26:04.443' AS DateTime), CAST(N'2023-04-02T10:26:04.443' AS DateTime))
INSERT [dbo].[MST_Document] ([DocumentID], [UserID], [DocumentName], [Description], [CreationDate], [ModificationDate]) VALUES (6, 1, N'HSC Marksheet', N'HSC', CAST(N'2023-04-02T17:39:31.933' AS DateTime), CAST(N'2023-05-02T11:03:34.070' AS DateTime))
INSERT [dbo].[MST_Document] ([DocumentID], [UserID], [DocumentName], [Description], [CreationDate], [ModificationDate]) VALUES (11, 1, N'SSC Marksheet', NULL, CAST(N'2023-05-02T11:03:44.740' AS DateTime), CAST(N'2023-05-02T11:03:44.740' AS DateTime))
SET IDENTITY_INSERT [dbo].[MST_Document] OFF
GO
SET IDENTITY_INSERT [dbo].[MST_Program] ON 

INSERT [dbo].[MST_Program] ([ProgramID], [CourseID], [UserID], [ProgramName], [Description], [CreationDate], [ModificationDate]) VALUES (2, 4, 1, N'Civil Engineering', NULL, CAST(N'2023-03-27T10:58:18.030' AS DateTime), CAST(N'2023-03-27T11:28:13.850' AS DateTime))
INSERT [dbo].[MST_Program] ([ProgramID], [CourseID], [UserID], [ProgramName], [Description], [CreationDate], [ModificationDate]) VALUES (7, 4, 1, N'Computer Engineering', NULL, CAST(N'2023-04-09T17:28:34.430' AS DateTime), CAST(N'2023-04-09T17:28:34.430' AS DateTime))
INSERT [dbo].[MST_Program] ([ProgramID], [CourseID], [UserID], [ProgramName], [Description], [CreationDate], [ModificationDate]) VALUES (8, 4, 1, N'Mechanical Engineering', NULL, CAST(N'2023-04-11T22:41:19.327' AS DateTime), CAST(N'2023-04-11T22:41:19.327' AS DateTime))
INSERT [dbo].[MST_Program] ([ProgramID], [CourseID], [UserID], [ProgramName], [Description], [CreationDate], [ModificationDate]) VALUES (9, 4, 1, N'Electrical Engineering', NULL, CAST(N'2023-04-11T22:41:35.910' AS DateTime), CAST(N'2023-04-11T22:41:35.910' AS DateTime))
INSERT [dbo].[MST_Program] ([ProgramID], [CourseID], [UserID], [ProgramName], [Description], [CreationDate], [ModificationDate]) VALUES (12, 8, 1, N'Electrical Engineering', NULL, CAST(N'2023-04-24T16:53:12.733' AS DateTime), CAST(N'2023-04-24T16:53:12.733' AS DateTime))
INSERT [dbo].[MST_Program] ([ProgramID], [CourseID], [UserID], [ProgramName], [Description], [CreationDate], [ModificationDate]) VALUES (14, 3, 2, N'MCA', NULL, CAST(N'2023-05-04T11:54:08.360' AS DateTime), CAST(N'2023-05-04T11:54:08.360' AS DateTime))
INSERT [dbo].[MST_Program] ([ProgramID], [CourseID], [UserID], [ProgramName], [Description], [CreationDate], [ModificationDate]) VALUES (15, 10, 1, N'MBA', NULL, CAST(N'2023-05-04T12:30:28.820' AS DateTime), CAST(N'2023-05-04T12:30:28.820' AS DateTime))
INSERT [dbo].[MST_Program] ([ProgramID], [CourseID], [UserID], [ProgramName], [Description], [CreationDate], [ModificationDate]) VALUES (16, 7, 1, N'MCA', NULL, CAST(N'2023-05-04T12:30:37.603' AS DateTime), CAST(N'2023-05-04T12:30:37.603' AS DateTime))
INSERT [dbo].[MST_Program] ([ProgramID], [CourseID], [UserID], [ProgramName], [Description], [CreationDate], [ModificationDate]) VALUES (17, 9, 1, N'BBA', NULL, CAST(N'2023-05-04T12:30:46.963' AS DateTime), CAST(N'2023-05-04T12:30:46.963' AS DateTime))
INSERT [dbo].[MST_Program] ([ProgramID], [CourseID], [UserID], [ProgramName], [Description], [CreationDate], [ModificationDate]) VALUES (18, 2, 1, N'BCA', NULL, CAST(N'2023-05-04T12:30:55.027' AS DateTime), CAST(N'2023-05-04T12:30:55.027' AS DateTime))
SET IDENTITY_INSERT [dbo].[MST_Program] OFF
GO
SET IDENTITY_INSERT [dbo].[MST_Qualification] ON 

INSERT [dbo].[MST_Qualification] ([QualificationID], [UserID], [QualificationName], [Description], [CreationDate], [ModificationDate]) VALUES (2, 1, N'PG', NULL, CAST(N'2023-03-27T00:34:31.320' AS DateTime), CAST(N'2023-03-27T00:34:31.320' AS DateTime))
INSERT [dbo].[MST_Qualification] ([QualificationID], [UserID], [QualificationName], [Description], [CreationDate], [ModificationDate]) VALUES (5, 1, N'HSC', NULL, CAST(N'2023-04-11T22:24:25.527' AS DateTime), CAST(N'2023-04-11T22:24:25.527' AS DateTime))
INSERT [dbo].[MST_Qualification] ([QualificationID], [UserID], [QualificationName], [Description], [CreationDate], [ModificationDate]) VALUES (6, 1, N'SSC', NULL, CAST(N'2023-04-11T22:24:30.777' AS DateTime), CAST(N'2023-04-11T22:24:30.777' AS DateTime))
INSERT [dbo].[MST_Qualification] ([QualificationID], [UserID], [QualificationName], [Description], [CreationDate], [ModificationDate]) VALUES (7, 1, N'UG', NULL, CAST(N'2023-04-11T22:28:11.063' AS DateTime), CAST(N'2023-04-11T22:28:11.063' AS DateTime))
INSERT [dbo].[MST_Qualification] ([QualificationID], [UserID], [QualificationName], [Description], [CreationDate], [ModificationDate]) VALUES (10, 2, N'SSC', NULL, CAST(N'2023-05-04T11:55:11.947' AS DateTime), CAST(N'2023-05-04T11:55:11.947' AS DateTime))
INSERT [dbo].[MST_Qualification] ([QualificationID], [UserID], [QualificationName], [Description], [CreationDate], [ModificationDate]) VALUES (11, 2, N'HSC', NULL, CAST(N'2023-05-04T11:55:18.560' AS DateTime), CAST(N'2023-05-04T11:55:18.560' AS DateTime))
SET IDENTITY_INSERT [dbo].[MST_Qualification] OFF
GO
SET IDENTITY_INSERT [dbo].[MST_Quota] ON 

INSERT [dbo].[MST_Quota] ([QuotaID], [CourseID], [UserID], [QuotaName], [Description], [CreationDate], [ModificationDate]) VALUES (2, 3, 1, N'Management', NULL, CAST(N'2023-03-27T13:36:26.420' AS DateTime), CAST(N'2023-03-27T13:36:26.420' AS DateTime))
INSERT [dbo].[MST_Quota] ([QuotaID], [CourseID], [UserID], [QuotaName], [Description], [CreationDate], [ModificationDate]) VALUES (4, 7, 1, N'General', NULL, CAST(N'2023-04-02T22:36:36.347' AS DateTime), CAST(N'2023-04-09T17:34:07.840' AS DateTime))
INSERT [dbo].[MST_Quota] ([QuotaID], [CourseID], [UserID], [QuotaName], [Description], [CreationDate], [ModificationDate]) VALUES (8, 3, 2, N'Management', NULL, CAST(N'2023-05-04T11:54:52.830' AS DateTime), CAST(N'2023-05-04T11:54:52.830' AS DateTime))
INSERT [dbo].[MST_Quota] ([QuotaID], [CourseID], [UserID], [QuotaName], [Description], [CreationDate], [ModificationDate]) VALUES (9, 3, 2, N'General', NULL, CAST(N'2023-05-04T11:55:02.800' AS DateTime), CAST(N'2023-05-04T11:55:02.800' AS DateTime))
SET IDENTITY_INSERT [dbo].[MST_Quota] OFF
GO
SET IDENTITY_INSERT [dbo].[MST_Staff] ON 

INSERT [dbo].[MST_Staff] ([StaffID], [UserID], [StaffName], [Phone], [Email], [StaffCode], [Description], [CreationDate], [ModificationDate]) VALUES (2, 1, N'XYZ', N'1234000089', N'demo@demo.com', N'1', N'dd', CAST(N'2023-03-27T08:34:34.920' AS DateTime), CAST(N'2023-05-01T20:18:00.617' AS DateTime))
INSERT [dbo].[MST_Staff] ([StaffID], [UserID], [StaffName], [Phone], [Email], [StaffCode], [Description], [CreationDate], [ModificationDate]) VALUES (3, 1, N'ABC', N'2121212123', N'b@b.b', N'2', NULL, CAST(N'2023-03-27T22:48:00.727' AS DateTime), CAST(N'2023-03-27T22:48:00.727' AS DateTime))
INSERT [dbo].[MST_Staff] ([StaffID], [UserID], [StaffName], [Phone], [Email], [StaffCode], [Description], [CreationDate], [ModificationDate]) VALUES (6, 1, N'CDV', N'34334', N'dr@sd.f', N'34t', NULL, CAST(N'2023-04-05T22:08:30.500' AS DateTime), CAST(N'2023-04-05T22:08:30.500' AS DateTime))
INSERT [dbo].[MST_Staff] ([StaffID], [UserID], [StaffName], [Phone], [Email], [StaffCode], [Description], [CreationDate], [ModificationDate]) VALUES (7, 2, N'Staff 1', N'12345678', N'staff1@gmail.com', N'123', NULL, CAST(N'2023-04-08T22:27:41.140' AS DateTime), CAST(N'2023-04-08T22:27:41.140' AS DateTime))
INSERT [dbo].[MST_Staff] ([StaffID], [UserID], [StaffName], [Phone], [Email], [StaffCode], [Description], [CreationDate], [ModificationDate]) VALUES (8, 2, N'Staff 2', N'8343898394', N'staff2@gmail.com', N'234', NULL, CAST(N'2023-04-08T22:28:11.213' AS DateTime), CAST(N'2023-04-08T22:28:11.213' AS DateTime))
SET IDENTITY_INSERT [dbo].[MST_Staff] OFF
GO
SET IDENTITY_INSERT [dbo].[MST_User] ON 

INSERT [dbo].[MST_User] ([UserID], [UserName], [Password], [Name], [CreationDate], [ModificationDate]) VALUES (1, N'hemang@h.com', N'1234', N'Hemang Kateshiya', CAST(N'2023-03-25T08:11:36.280' AS DateTime), CAST(N'2023-04-05T23:52:15.380' AS DateTime))
INSERT [dbo].[MST_User] ([UserID], [UserName], [Password], [Name], [CreationDate], [ModificationDate]) VALUES (2, N'admin@admin.com', N'1111', N'Admin', CAST(N'2023-03-25T08:12:01.043' AS DateTime), CAST(N'2023-03-25T08:12:01.043' AS DateTime))
SET IDENTITY_INSERT [dbo].[MST_User] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_Table_1]    Script Date: 1/18/2025 2:16:32 PM ******/
ALTER TABLE [dbo].[MST_User] ADD  CONSTRAINT [UK_Table_1] UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ADM_Intake] ADD  CONSTRAINT [DF_ADM_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO
ALTER TABLE [dbo].[ADM_Intake] ADD  CONSTRAINT [DF_ADM_ModificationDate]  DEFAULT (getdate()) FOR [ModificationDate]
GO
ALTER TABLE [dbo].[ADM_Student] ADD  CONSTRAINT [DF_ADM_Student_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO
ALTER TABLE [dbo].[ADM_Student] ADD  CONSTRAINT [DF_ADM_Student_ModificationDate]  DEFAULT (getdate()) FOR [ModificationDate]
GO
ALTER TABLE [dbo].[ADM_StudentDocument] ADD  CONSTRAINT [DF_ADM_StudentDocument_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO
ALTER TABLE [dbo].[ADM_StudentDocument] ADD  CONSTRAINT [DF_ADM_StudentDocument_ModificationDate]  DEFAULT (getdate()) FOR [ModificationDate]
GO
ALTER TABLE [dbo].[ADM_Visitor] ADD  CONSTRAINT [DF_ADM_Visitor_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO
ALTER TABLE [dbo].[ADM_Visitor] ADD  CONSTRAINT [DF_ADM_Visitor_ModificationDate]  DEFAULT (getdate()) FOR [ModificationDate]
GO
ALTER TABLE [dbo].[LOC_City] ADD  CONSTRAINT [DF_LOC_City_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO
ALTER TABLE [dbo].[LOC_City] ADD  CONSTRAINT [DF_LOC_City_ModificationDate]  DEFAULT (getdate()) FOR [ModificationDate]
GO
ALTER TABLE [dbo].[LOC_State] ADD  CONSTRAINT [DF_LOC_State_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO
ALTER TABLE [dbo].[LOC_State] ADD  CONSTRAINT [DF_LOC_State_ModificationDate]  DEFAULT (getdate()) FOR [ModificationDate]
GO
ALTER TABLE [dbo].[MST_AdmissionYear] ADD  CONSTRAINT [DF_MST_AdmissionYear_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO
ALTER TABLE [dbo].[MST_AdmissionYear] ADD  CONSTRAINT [DF_MST_AdmissionYear_ModificationDate]  DEFAULT (getdate()) FOR [ModificationDate]
GO
ALTER TABLE [dbo].[MST_CasteCategory] ADD  CONSTRAINT [DF_MST_CasteCategory_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO
ALTER TABLE [dbo].[MST_CasteCategory] ADD  CONSTRAINT [DF_MST_CasteCategory_ModificationDate]  DEFAULT (getdate()) FOR [ModificationDate]
GO
ALTER TABLE [dbo].[MST_Course] ADD  CONSTRAINT [DF_MST_Course_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO
ALTER TABLE [dbo].[MST_Course] ADD  CONSTRAINT [DF_MST_Course_ModificationDate]  DEFAULT (getdate()) FOR [ModificationDate]
GO
ALTER TABLE [dbo].[MST_CourseWiseDocument] ADD  CONSTRAINT [DF_MST_CourseWiseDocument_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO
ALTER TABLE [dbo].[MST_CourseWiseDocument] ADD  CONSTRAINT [DF_MST_CourseWiseDocument_ModificationDate]  DEFAULT (getdate()) FOR [ModificationDate]
GO
ALTER TABLE [dbo].[MST_Document] ADD  CONSTRAINT [DF_MST_Document_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO
ALTER TABLE [dbo].[MST_Document] ADD  CONSTRAINT [DF_MST_Document_ModificationDate]  DEFAULT (getdate()) FOR [ModificationDate]
GO
ALTER TABLE [dbo].[MST_Program] ADD  CONSTRAINT [DF_MST_Program_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO
ALTER TABLE [dbo].[MST_Program] ADD  CONSTRAINT [DF_MST_Program_ModificationDate]  DEFAULT (getdate()) FOR [ModificationDate]
GO
ALTER TABLE [dbo].[MST_Qualification] ADD  CONSTRAINT [DF_MST_Qualification_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO
ALTER TABLE [dbo].[MST_Qualification] ADD  CONSTRAINT [DF_MST_Qualification_ModificationDate]  DEFAULT (getdate()) FOR [ModificationDate]
GO
ALTER TABLE [dbo].[MST_Quota] ADD  CONSTRAINT [DF_MST_Quota_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO
ALTER TABLE [dbo].[MST_Quota] ADD  CONSTRAINT [DF_MST_Quota_ModificationDate]  DEFAULT (getdate()) FOR [ModificationDate]
GO
ALTER TABLE [dbo].[MST_Staff] ADD  CONSTRAINT [DF_MST_Staff_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO
ALTER TABLE [dbo].[MST_Staff] ADD  CONSTRAINT [DF_MST_Staff_ModificationDate]  DEFAULT (getdate()) FOR [ModificationDate]
GO
ALTER TABLE [dbo].[MST_User] ADD  CONSTRAINT [DF_MST_User_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO
ALTER TABLE [dbo].[MST_User] ADD  CONSTRAINT [DF_MST_User_ModificationDate]  DEFAULT (getdate()) FOR [ModificationDate]
GO
ALTER TABLE [dbo].[ADM_Intake]  WITH CHECK ADD  CONSTRAINT [FK_ADM_Intake_MST_AdmissionYear] FOREIGN KEY([AdmissionYearID])
REFERENCES [dbo].[MST_AdmissionYear] ([AdmissionYearID])
GO
ALTER TABLE [dbo].[ADM_Intake] CHECK CONSTRAINT [FK_ADM_Intake_MST_AdmissionYear]
GO
ALTER TABLE [dbo].[ADM_Intake]  WITH CHECK ADD  CONSTRAINT [FK_ADM_Intake_MST_Course] FOREIGN KEY([CourseID])
REFERENCES [dbo].[MST_Course] ([CourseID])
GO
ALTER TABLE [dbo].[ADM_Intake] CHECK CONSTRAINT [FK_ADM_Intake_MST_Course]
GO
ALTER TABLE [dbo].[ADM_Intake]  WITH CHECK ADD  CONSTRAINT [FK_ADM_Intake_MST_Program] FOREIGN KEY([ProgramID])
REFERENCES [dbo].[MST_Program] ([ProgramID])
GO
ALTER TABLE [dbo].[ADM_Intake] CHECK CONSTRAINT [FK_ADM_Intake_MST_Program]
GO
ALTER TABLE [dbo].[ADM_Intake]  WITH CHECK ADD  CONSTRAINT [FK_ADM_Intake_MST_Quota] FOREIGN KEY([QuotaID])
REFERENCES [dbo].[MST_Quota] ([QuotaID])
GO
ALTER TABLE [dbo].[ADM_Intake] CHECK CONSTRAINT [FK_ADM_Intake_MST_Quota]
GO
ALTER TABLE [dbo].[ADM_Intake]  WITH CHECK ADD  CONSTRAINT [FK_ADM_Intake_MST_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[MST_User] ([UserID])
GO
ALTER TABLE [dbo].[ADM_Intake] CHECK CONSTRAINT [FK_ADM_Intake_MST_User]
GO
ALTER TABLE [dbo].[ADM_Student]  WITH CHECK ADD  CONSTRAINT [FK_ADM_Student_ADM_Visitor] FOREIGN KEY([VisitorID])
REFERENCES [dbo].[ADM_Visitor] ([VisitorID])
GO
ALTER TABLE [dbo].[ADM_Student] CHECK CONSTRAINT [FK_ADM_Student_ADM_Visitor]
GO
ALTER TABLE [dbo].[ADM_Student]  WITH CHECK ADD  CONSTRAINT [FK_ADM_Student_LOC_City] FOREIGN KEY([CityID])
REFERENCES [dbo].[LOC_City] ([CityID])
GO
ALTER TABLE [dbo].[ADM_Student] CHECK CONSTRAINT [FK_ADM_Student_LOC_City]
GO
ALTER TABLE [dbo].[ADM_Student]  WITH CHECK ADD  CONSTRAINT [FK_ADM_Student_LOC_State] FOREIGN KEY([StateID])
REFERENCES [dbo].[LOC_State] ([StateID])
GO
ALTER TABLE [dbo].[ADM_Student] CHECK CONSTRAINT [FK_ADM_Student_LOC_State]
GO
ALTER TABLE [dbo].[ADM_Student]  WITH CHECK ADD  CONSTRAINT [FK_ADM_Student_MST_AdmissionYear] FOREIGN KEY([AdmissionYearID])
REFERENCES [dbo].[MST_AdmissionYear] ([AdmissionYearID])
GO
ALTER TABLE [dbo].[ADM_Student] CHECK CONSTRAINT [FK_ADM_Student_MST_AdmissionYear]
GO
ALTER TABLE [dbo].[ADM_Student]  WITH CHECK ADD  CONSTRAINT [FK_ADM_Student_MST_CasteCategory] FOREIGN KEY([CasteCategoryID])
REFERENCES [dbo].[MST_CasteCategory] ([CasteCategoryID])
GO
ALTER TABLE [dbo].[ADM_Student] CHECK CONSTRAINT [FK_ADM_Student_MST_CasteCategory]
GO
ALTER TABLE [dbo].[ADM_Student]  WITH CHECK ADD  CONSTRAINT [FK_ADM_Student_MST_Course] FOREIGN KEY([CourseID])
REFERENCES [dbo].[MST_Course] ([CourseID])
GO
ALTER TABLE [dbo].[ADM_Student] CHECK CONSTRAINT [FK_ADM_Student_MST_Course]
GO
ALTER TABLE [dbo].[ADM_Student]  WITH CHECK ADD  CONSTRAINT [FK_ADM_Student_MST_Program] FOREIGN KEY([ProgramID])
REFERENCES [dbo].[MST_Program] ([ProgramID])
GO
ALTER TABLE [dbo].[ADM_Student] CHECK CONSTRAINT [FK_ADM_Student_MST_Program]
GO
ALTER TABLE [dbo].[ADM_Student]  WITH CHECK ADD  CONSTRAINT [FK_ADM_Student_MST_Qualification] FOREIGN KEY([QualificationID])
REFERENCES [dbo].[MST_Qualification] ([QualificationID])
GO
ALTER TABLE [dbo].[ADM_Student] CHECK CONSTRAINT [FK_ADM_Student_MST_Qualification]
GO
ALTER TABLE [dbo].[ADM_Student]  WITH CHECK ADD  CONSTRAINT [FK_ADM_Student_MST_Quota] FOREIGN KEY([QuotaID])
REFERENCES [dbo].[MST_Quota] ([QuotaID])
GO
ALTER TABLE [dbo].[ADM_Student] CHECK CONSTRAINT [FK_ADM_Student_MST_Quota]
GO
ALTER TABLE [dbo].[ADM_Student]  WITH CHECK ADD  CONSTRAINT [FK_ADM_Student_MST_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[MST_User] ([UserID])
GO
ALTER TABLE [dbo].[ADM_Student] CHECK CONSTRAINT [FK_ADM_Student_MST_User]
GO
ALTER TABLE [dbo].[ADM_StudentDocument]  WITH CHECK ADD  CONSTRAINT [FK_ADM_StudentDocument_ADM_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[ADM_Student] ([StudentID])
GO
ALTER TABLE [dbo].[ADM_StudentDocument] CHECK CONSTRAINT [FK_ADM_StudentDocument_ADM_Student]
GO
ALTER TABLE [dbo].[ADM_StudentDocument]  WITH CHECK ADD  CONSTRAINT [FK_ADM_StudentDocument_MST_Document] FOREIGN KEY([DocumentID])
REFERENCES [dbo].[MST_Document] ([DocumentID])
GO
ALTER TABLE [dbo].[ADM_StudentDocument] CHECK CONSTRAINT [FK_ADM_StudentDocument_MST_Document]
GO
ALTER TABLE [dbo].[ADM_StudentDocument]  WITH CHECK ADD  CONSTRAINT [FK_ADM_StudentDocument_MST_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[MST_User] ([UserID])
GO
ALTER TABLE [dbo].[ADM_StudentDocument] CHECK CONSTRAINT [FK_ADM_StudentDocument_MST_User]
GO
ALTER TABLE [dbo].[ADM_VisitorInterestedCourses]  WITH CHECK ADD  CONSTRAINT [FK_ADM_VisitorInterestedCourses_MST_Course] FOREIGN KEY([VisitorID])
REFERENCES [dbo].[ADM_Visitor] ([VisitorID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ADM_VisitorInterestedCourses] CHECK CONSTRAINT [FK_ADM_VisitorInterestedCourses_MST_Course]
GO
ALTER TABLE [dbo].[ADM_VisitorInterestedCourses]  WITH CHECK ADD  CONSTRAINT [FK_ADM_VisitorInterestedCourses_MST_Course1] FOREIGN KEY([CourseID])
REFERENCES [dbo].[MST_Course] ([CourseID])
GO
ALTER TABLE [dbo].[ADM_VisitorInterestedCourses] CHECK CONSTRAINT [FK_ADM_VisitorInterestedCourses_MST_Course1]
GO
ALTER TABLE [dbo].[ADM_VisitorInterestedCourses]  WITH CHECK ADD  CONSTRAINT [FK_ADM_VisitorInterestedCourses_MST_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[MST_User] ([UserID])
GO
ALTER TABLE [dbo].[ADM_VisitorInterestedCourses] CHECK CONSTRAINT [FK_ADM_VisitorInterestedCourses_MST_User]
GO
ALTER TABLE [dbo].[LOC_City]  WITH CHECK ADD  CONSTRAINT [FK_LOC_City_LOC_State] FOREIGN KEY([StateID])
REFERENCES [dbo].[LOC_State] ([StateID])
GO
ALTER TABLE [dbo].[LOC_City] CHECK CONSTRAINT [FK_LOC_City_LOC_State]
GO
ALTER TABLE [dbo].[LOC_City]  WITH CHECK ADD  CONSTRAINT [FK_LOC_City_MST_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[MST_User] ([UserID])
GO
ALTER TABLE [dbo].[LOC_City] CHECK CONSTRAINT [FK_LOC_City_MST_User]
GO
ALTER TABLE [dbo].[LOC_State]  WITH CHECK ADD  CONSTRAINT [FK_LOC_State_MST_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[MST_User] ([UserID])
GO
ALTER TABLE [dbo].[LOC_State] CHECK CONSTRAINT [FK_LOC_State_MST_User]
GO
ALTER TABLE [dbo].[MST_AdmissionYear]  WITH CHECK ADD  CONSTRAINT [FK_MST_AdmissionYear_MST_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[MST_User] ([UserID])
GO
ALTER TABLE [dbo].[MST_AdmissionYear] CHECK CONSTRAINT [FK_MST_AdmissionYear_MST_User]
GO
ALTER TABLE [dbo].[MST_CasteCategory]  WITH CHECK ADD  CONSTRAINT [FK_MST_CasteCategory_MST_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[MST_User] ([UserID])
GO
ALTER TABLE [dbo].[MST_CasteCategory] CHECK CONSTRAINT [FK_MST_CasteCategory_MST_User]
GO
ALTER TABLE [dbo].[MST_Course]  WITH CHECK ADD  CONSTRAINT [FK_MST_Course_MST_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[MST_User] ([UserID])
GO
ALTER TABLE [dbo].[MST_Course] CHECK CONSTRAINT [FK_MST_Course_MST_User]
GO
ALTER TABLE [dbo].[MST_CourseWiseDocument]  WITH CHECK ADD  CONSTRAINT [FK_MST_CourseWiseDocument_MST_AdmissionYear] FOREIGN KEY([AdmissionYearID])
REFERENCES [dbo].[MST_AdmissionYear] ([AdmissionYearID])
GO
ALTER TABLE [dbo].[MST_CourseWiseDocument] CHECK CONSTRAINT [FK_MST_CourseWiseDocument_MST_AdmissionYear]
GO
ALTER TABLE [dbo].[MST_CourseWiseDocument]  WITH CHECK ADD  CONSTRAINT [FK_MST_CourseWiseDocument_MST_Course] FOREIGN KEY([CourseID])
REFERENCES [dbo].[MST_Course] ([CourseID])
GO
ALTER TABLE [dbo].[MST_CourseWiseDocument] CHECK CONSTRAINT [FK_MST_CourseWiseDocument_MST_Course]
GO
ALTER TABLE [dbo].[MST_CourseWiseDocument]  WITH CHECK ADD  CONSTRAINT [FK_MST_CourseWiseDocument_MST_Document] FOREIGN KEY([DocumentID])
REFERENCES [dbo].[MST_Document] ([DocumentID])
GO
ALTER TABLE [dbo].[MST_CourseWiseDocument] CHECK CONSTRAINT [FK_MST_CourseWiseDocument_MST_Document]
GO
ALTER TABLE [dbo].[MST_CourseWiseDocument]  WITH CHECK ADD  CONSTRAINT [FK_MST_CourseWiseDocument_MST_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[MST_User] ([UserID])
GO
ALTER TABLE [dbo].[MST_CourseWiseDocument] CHECK CONSTRAINT [FK_MST_CourseWiseDocument_MST_User]
GO
ALTER TABLE [dbo].[MST_Document]  WITH CHECK ADD  CONSTRAINT [FK_MST_Document_MST_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[MST_User] ([UserID])
GO
ALTER TABLE [dbo].[MST_Document] CHECK CONSTRAINT [FK_MST_Document_MST_User]
GO
ALTER TABLE [dbo].[MST_Program]  WITH CHECK ADD  CONSTRAINT [FK_MST_Program_MST_Course] FOREIGN KEY([CourseID])
REFERENCES [dbo].[MST_Course] ([CourseID])
GO
ALTER TABLE [dbo].[MST_Program] CHECK CONSTRAINT [FK_MST_Program_MST_Course]
GO
ALTER TABLE [dbo].[MST_Program]  WITH CHECK ADD  CONSTRAINT [FK_MST_Program_MST_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[MST_User] ([UserID])
GO
ALTER TABLE [dbo].[MST_Program] CHECK CONSTRAINT [FK_MST_Program_MST_User]
GO
ALTER TABLE [dbo].[MST_Qualification]  WITH CHECK ADD  CONSTRAINT [FK_MST_Qualification_MST_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[MST_User] ([UserID])
GO
ALTER TABLE [dbo].[MST_Qualification] CHECK CONSTRAINT [FK_MST_Qualification_MST_User]
GO
ALTER TABLE [dbo].[MST_Quota]  WITH CHECK ADD  CONSTRAINT [FK_MST_Quota_MST_Course] FOREIGN KEY([CourseID])
REFERENCES [dbo].[MST_Course] ([CourseID])
GO
ALTER TABLE [dbo].[MST_Quota] CHECK CONSTRAINT [FK_MST_Quota_MST_Course]
GO
ALTER TABLE [dbo].[MST_Quota]  WITH CHECK ADD  CONSTRAINT [FK_MST_Quota_MST_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[MST_User] ([UserID])
GO
ALTER TABLE [dbo].[MST_Quota] CHECK CONSTRAINT [FK_MST_Quota_MST_User]
GO
ALTER TABLE [dbo].[MST_Staff]  WITH CHECK ADD  CONSTRAINT [FK_MST_Staff_MST_Staff] FOREIGN KEY([UserID])
REFERENCES [dbo].[MST_User] ([UserID])
GO
ALTER TABLE [dbo].[MST_Staff] CHECK CONSTRAINT [FK_MST_Staff_MST_Staff]
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Intake_DeleteByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Intake_DeleteByPK] 2, 1
--Select * From ADM_Intake

CREATE       PROCEDURE [dbo].[PR_ADM_Intake_DeleteByPK]
	@IntakeID	int
	,@UserID	int

AS

DELETE FROM [dbo].[ADM_Intake]

WHERE [dbo].[ADM_Intake].[IntakeID] = @IntakeID
AND	[dbo].[ADM_Intake].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Intake_Insert]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Intake_Insert] @StateID=1, @UserID=1, @CityName='Baroda', @Description=null, @CreationDate=null, @ModificationDate=null
--Select * from ADM_Intake

CREATE     PROCEDURE [dbo].[PR_ADM_Intake_Insert]
	@AdmissionYearID	int
	,@ProgramID			int
	,@CourseID			int
	,@QuotaID			int
	,@UserID			int
	,@Intake			int
	,@Description		nvarchar(100)
	,@CreationDate		datetime
	,@ModificationDate	datetime
AS

INSERT INTO [dbo].[ADM_Intake]
(
	AdmissionYearID
	,ProgramID
	,CourseID
	,QuotaID
	,UserID
	,Intake
	,Description
	,CreationDate
	,ModificationDate
)

VALUES
(
	@AdmissionYearID			
	,@ProgramID			
	,@CourseID			
	,@QuotaID			
	,@UserID
	,@Intake		
	,@Description
	,ISNULL(@CreationDate,GETDATE())
	,ISNULL(@ModificationDate,GETDATE())
)
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Intake_SelectAll]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Intake_SelectAll] 2
--Select * from ADM_Intake

CREATE      PROCEDURE [dbo].[PR_ADM_Intake_SelectAll]
	@UserID		int

AS

SELECT	[dbo].[ADM_Intake].[IntakeID]
		,[dbo].[ADM_Intake].[AdmissionYearID]
		,[dbo].[MST_AdmissionYear].[AdmissionYear]
		,[dbo].[ADM_Intake].[ProgramID]
		,[dbo].[MST_Program].[ProgramName]
		,[dbo].[ADM_Intake].[CourseID]
		,[dbo].[MST_Course].[CourseName]
		,[dbo].[ADM_Intake].[QuotaID]
		,[dbo].[MST_Quota].[QuotaName]
		,[dbo].[ADM_Intake].[Intake]
		,[dbo].[ADM_Intake].[Description]
		,[dbo].[ADM_Intake].[CreationDate]
		,[dbo].[ADM_Intake].[ModificationDate]

FROM	[dbo].[ADM_Intake]

INNER JOIN [dbo].[MST_AdmissionYear]
ON [dbo].[MST_AdmissionYear].[AdmissionYearID] = [dbo].[ADM_Intake].[AdmissionYearID]

INNER JOIN [dbo].[MST_Program]
ON [dbo].[MST_Program].[ProgramID] = [dbo].[ADM_Intake].[ProgramID]

INNER JOIN [dbo].[MST_Course]
ON [dbo].[MST_Course].[CourseID] = [dbo].[ADM_Intake].[CourseID]

INNER JOIN [dbo].[MST_Quota]
ON [dbo].[MST_Quota].[QuotaID] = [dbo].[ADM_Intake].[QuotaID]

WHERE [dbo].[ADM_Intake].[UserID] = @UserID

ORDER BY [dbo].[MST_AdmissionYear].[AdmissionYear]
		 ,[dbo].[MST_Program].[ProgramName]
		 ,[dbo].[MST_Course].[CourseName]
		 ,[dbo].[MST_Quota].[QuotaName]
		 ,[dbo].[ADM_Intake].[Intake]
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Intake_SelectByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Intake_SelectByPK] 3, 2
--Select * from ADM_Intake

CREATE      PROCEDURE [dbo].[PR_ADM_Intake_SelectByPK]
	@IntakeID	int
	,@UserID	int

AS

SELECT	[dbo].[ADM_Intake].[IntakeID]
		,[dbo].[ADM_Intake].[AdmissionYearID]
		,[dbo].[ADM_Intake].[ProgramID]
		,[dbo].[ADM_Intake].[CourseID]
		,[dbo].[ADM_Intake].[QuotaID]
		,[dbo].[ADM_Intake].[Intake]
		,[dbo].[ADM_Intake].[Description]
		,[dbo].[ADM_Intake].[CreationDate]
		,[dbo].[ADM_Intake].[ModificationDate]

FROM	[dbo].[ADM_Intake]

WHERE [dbo].[ADM_Intake].[IntakeID] = @IntakeID
AND [dbo].[ADM_Intake].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Intake_SelectForDropDown]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Intake_SelectForDropDown] 2
--Select * From ADM_Intake

 Create     PROCEDURE [dbo].[PR_ADM_Intake_SelectForDropDown]
	@UserID		int

AS

SELECT	[dbo].[ADM_Intake].[IntakeID]
		,[dbo].[ADM_Intake].[Intake]

FROM [dbo].[ADM_Intake]

WHERE [dbo].[ADM_Intake].[UserID] = @UserID

ORDER BY [dbo].[ADM_Intake].[Intake]
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Intake_UpdateByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Intake_UpdateByPK] @IntakeID=1, @AdmissionYearID=3, @ProgramID=3, @CourseID=2, @QuotaID=2, @UserID=1, @Intake=80, @Description=null, @ModificationDate=null
--Select * from ADM_Intake

CREATE      PROCEDURE [dbo].[PR_ADM_Intake_UpdateByPK]
	@IntakeID			int
	,@AdmissionYearID	int
	,@ProgramID			int
	,@CourseID			int
	,@QuotaID			int
	,@UserID			int
	,@Intake			int
	,@Description		nvarchar(100)
	,@ModificationDate	datetime
AS

UPDATE [dbo].[ADM_Intake]

SET	[dbo].[ADM_Intake].[AdmissionYearID] = @AdmissionYearID
	,[dbo].[ADM_Intake].[ProgramID] = @ProgramID
	,[dbo].[ADM_Intake].[CourseID] = @CourseID
	,[dbo].[ADM_Intake].[QuotaID] = @QuotaID
	,[dbo].[ADM_Intake].[Intake] = @Intake
	,[dbo].[ADM_Intake].[Description] = @Description
	,[dbo].[ADM_Intake].[ModificationDate] = ISNULL(@ModificationDate,GETDATE())

WHERE [dbo].[ADM_Intake].[IntakeID] = @IntakeID
AND	[dbo].[ADM_Intake].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Student_DeleteByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Student_DeleteByPK] 2, 1
--Select * from ADM_Student

CREATE       PROCEDURE [dbo].[PR_ADM_Student_DeleteByPK]
	@StudentID	int
	,@UserID	int

AS

DELETE FROM [dbo].[ADM_Student]

WHERE [dbo].[ADM_Student].[StudentID] = @StudentID
AND	[dbo].[ADM_Student].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Student_Insert]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
/*[dbo].[PR_ADM_Student_Insert] @VisitorID=8, @AdmissionYearID=2, @QuotaID=2, @CourseID=2, @ProgramID=2, 
	@QualificationID=2, @CasteCategoryID=2, @StateID=1, @CityID=2, @UserID=1, @StudentName="Hemang", 
	@ParentPhone='122222234', @Gender='Male', @DateOfBirth="2022-06-08", @SSCPercentage=65.80, @SSCSchoolName="OSEM", 
	@SSCPassingYear=2022, @HSCPercentage=80.78, @HSCSchoolName="High School", @HSCPassingYear=2020, @DiplomaPercentage=9.35, 
	@DiplomaCollegeName="LEC", @DiplomaPassingYear=2018, @UGPercentage=78.90, @UGCollegeName="Darshan", @UGPassingYear=2025, 
	@PGPercentage=67.90, @PGCollegeName="Darshan", @PGPassingYear=2029, @PhotoPath="sd/dsds/dfdf.jpg", @Description=null, 
	@CreationDate=null, @ModificationDate=null
*/
--Select * from ADM_Student

CREATE     PROCEDURE [dbo].[PR_ADM_Student_Insert]
	@VisitorID				int
	,@AdmissionYearID		int
	,@QuotaID				int
	,@CourseID				int
	,@ProgramID				int
	,@QualificationID		int
	,@CasteCategoryID		int
	,@StateID				int
	,@CityID				int
	,@UserID				int
	,@StudentName			nvarchar(100)
	,@ParentPhone			nvarchar(50)
	,@Gender				nvarchar(10)
	,@DateOfBirth			datetime
	,@SSCPercentage			decimal(5,2)
	,@SSCSchoolName			nvarchar(100)
	,@SSCPassingYear		int
	,@HSCPercentage			decimal(5,2)
	,@HSCSchoolName			nvarchar(100)
	,@HSCPassingYear		int
	,@DiplomaPercentage		decimal(5,2)
	,@DiplomaCollegeName	nvarchar(100)
	,@DiplomaPassingYear	int
	,@UGPercentage			decimal(5,2)
	,@UGCollegeName			nvarchar(100)
	,@UGPassingYear			int
	,@PGPercentage			decimal(5,2)
	,@PGCollegeName			nvarchar(100)
	,@PGPassingYear			int
	,@PhotoPath				nvarchar(250)
	,@Description			nvarchar(100)
	,@CreationDate			datetime
	,@ModificationDate		datetime
AS

INSERT INTO [dbo].[ADM_Student]
(
	VisitorID
	,AdmissionYearID	
	,QuotaID			
	,CourseID			
	,ProgramID			
	,QualificationID	
	,CasteCategoryID	
	,StateID			
	,CityID			
	,UserID
	,StudentName
	,ParentPhone		
	,Gender			
	,DateOfBirth		
	,SSCPercentage		
	,SSCSchoolName		
	,SSCPassingYear	
	,HSCPercentage		
	,HSCSchoolName		
	,HSCPassingYear	
	,DiplomaPercentage	
	,DiplomaCollegeName
	,DiplomaPassingYear
	,UGPercentage		
	,UGCollegeName		
	,UGPassingYear		
	,PGPercentage		
	,PGCollegeName		
	,PGPassingYear		
	,PhotoPath			
	,Description
	,CreationDate
	,ModificationDate
)

VALUES
(
	@VisitorID	
	,@AdmissionYearID	
	,@QuotaID			
	,@CourseID			
	,@ProgramID			
	,@QualificationID	
	,@CasteCategoryID	
	,@StateID			
	,@CityID	
	,@UserID			
	,@StudentName
	,@ParentPhone		
	,@Gender			
	,@DateOfBirth		
	,@SSCPercentage		
	,@SSCSchoolName		
	,@SSCPassingYear	
	,@HSCPercentage		
	,@HSCSchoolName		
	,@HSCPassingYear	
	,@DiplomaPercentage	
	,@DiplomaCollegeName
	,@DiplomaPassingYear
	,@UGPercentage		
	,@UGCollegeName		
	,@UGPassingYear		
	,@PGPercentage		
	,@PGCollegeName		
	,@PGPassingYear		
	,@PhotoPath			
	,@Description
	,ISNULL(@CreationDate,GETDATE())
	,ISNULL(@ModificationDate,GETDATE())
)
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Student_SelectAll]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Student_SelectAll] 1

CREATE      PROCEDURE [dbo].[PR_ADM_Student_SelectAll]
	@UserID		int

AS

SELECT	[dbo].[ADM_Student].[StudentID]
		,[dbo].[ADM_Student].[StudentName]
		,[dbo].[ADM_Student].[VisitorID]
		,[dbo].[ADM_Visitor].[VisitorName]
		,[dbo].[ADM_Visitor].[Phone]
		,[dbo].[ADM_Student].[AdmissionYearID]
		,[dbo].[MST_AdmissionYear].[AdmissionYear]
		,[dbo].[ADM_Student].[QuotaID]
		,[dbo].[MST_Quota].[QuotaName]
		,[dbo].[ADM_Student].[CourseID]
		,[dbo].[MST_Course].[CourseName]
		,[dbo].[ADM_Student].[ProgramID]
		,[dbo].[MST_Program].[ProgramName]
		,[dbo].[ADM_Student].[UserID]
		,[dbo].[ADM_Student].[QualificationID]
		,[dbo].[MST_Qualification].[QualificationName]
		,[dbo].[ADM_Student].[CasteCategoryID]
		,[dbo].[MST_CasteCategory].[CategoryName]
		,[dbo].[ADM_Student].[StateID]
		,[dbo].[LOC_State].[StateName]
		,[dbo].[ADM_Student].[CityID]
		,[dbo].[LOC_City].[CityName]
		,[dbo].[ADM_Student].[ParentPhone]
		,[dbo].[ADM_Student].[Gender]
		,[dbo].[ADM_Student].[DateOfBirth]
		,[dbo].[ADM_Student].[SSCPercentage]
		,[dbo].[ADM_Student].[SSCSchoolName]
		,[dbo].[ADM_Student].[SSCPassingYear]
		,[dbo].[ADM_Student].[HSCPercentage]
		,[dbo].[ADM_Student].[HSCSchoolName]
		,[dbo].[ADM_Student].[HSCPassingYear]
		,[dbo].[ADM_Student].[DiplomaPercentage]
		,[dbo].[ADM_Student].[DiplomaCollegeName]
		,[dbo].[ADM_Student].[DiplomaPassingYear]
		,[dbo].[ADM_Student].[UGPercentage]
		,[dbo].[ADM_Student].[UGCollegeName]
		,[dbo].[ADM_Student].[UGPassingYear]
		,[dbo].[ADM_Student].[PGPercentage]
		,[dbo].[ADM_Student].[PGCollegeName]
		,[dbo].[ADM_Student].[PGPassingYear]
		,[dbo].[ADM_Student].[PhotoPath]
		,[dbo].[ADM_Student].[Description]
		,[dbo].[ADM_Student].[CreationDate]
		,[dbo].[ADM_Student].[ModificationDate]

FROM	[dbo].[ADM_Student]

FULL OUTER JOIN [dbo].[ADM_Visitor]
ON [dbo].[ADM_Visitor].[VisitorID] = [dbo].[ADM_Student].[VisitorID]

FULL OUTER JOIN [dbo].[MST_AdmissionYear]
ON [dbo].[MST_AdmissionYear].[AdmissionYearID] = [dbo].[ADM_Student].[AdmissionYearID]

FULL OUTER JOIN [dbo].[MST_Quota]
ON [dbo].[MST_Quota].[QuotaID] = [dbo].[ADM_Student].[QuotaID]

FULL OUTER JOIN [dbo].[MST_Course]
ON [dbo].[MST_Course].[CourseID] = [dbo].[ADM_Student].[CourseID]

FULL OUTER JOIN [dbo].[MST_Program]
ON [dbo].[MST_Program].[ProgramID] = [dbo].[ADM_Student].[ProgramID]

FULL OUTER JOIN [dbo].[MST_Qualification]
ON [dbo].[MST_Qualification].[QualificationID] = [dbo].[ADM_Student].[QualificationID]

FULL OUTER JOIN [dbo].[MST_CasteCategory]
ON [dbo].[MST_CasteCategory].[CasteCategoryID] = [dbo].[ADM_Student].[CasteCategoryID]

FULL OUTER JOIN [dbo].[LOC_State]
ON [dbo].[LOC_State].[StateID] = [dbo].[ADM_Student].[StateID]

FULL OUTER JOIN [dbo].[LOC_City]
ON [dbo].[LOC_City].[CityID] = [dbo].[ADM_Student].[CityID]

WHERE [dbo].[ADM_Student].[UserID] = @UserID

ORDER BY [dbo].[ADM_Student].[StudentName]
		 ,[dbo].[ADM_Visitor].[VisitorName]
		 ,[dbo].[MST_AdmissionYear].[AdmissionYear]
		 ,[dbo].[MST_Quota].[QuotaName]
		 ,[dbo].[MST_Course].[CourseName]
		 ,[dbo].[MST_Program].[ProgramName]
		 ,[dbo].[MST_Qualification].[QualificationName]
		 ,[dbo].[MST_CasteCategory].[CategoryName]
		 ,[dbo].[LOC_State].[StateName]
		 ,[dbo].[LOC_City].[CityName]
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Student_SelectByAdmissionYear]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Student_SelectByAdmissionYear] 1, 2

CREATE     PROCEDURE [dbo].[PR_ADM_Student_SelectByAdmissionYear]
	@UserID				int
	,@AdmissionYearID	int

AS

SELECT
		[dbo].[ADM_Student].[StudentID]
		,[dbo].[ADM_Visitor].[VisitorName]

FROM	[dbo].[ADM_Student]

INNER JOIN [dbo].[ADM_Visitor]
ON [dbo].[ADM_Visitor].[VisitorID] = [dbo].[ADM_Student].[VisitorID]

WHERE [dbo].[ADM_Student].[AdmissionYearID] = @AdmissionYearID
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Student_SelectByCityID]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Student_SelectByCityID] 1, 2

CREATE           PROCEDURE [dbo].[PR_ADM_Student_SelectByCityID]
	@UserID				int
	,@CityID			int

AS

SELECT
		[dbo].[ADM_Student].[StudentID]

FROM	[dbo].[ADM_Student]

WHERE [dbo].[ADM_Student].[CityID] = @CityID
AND [dbo].[ADM_Student].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Student_SelectByCourseID]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Student_SelectByCourseID] 1, 4

CREATE       PROCEDURE [dbo].[PR_ADM_Student_SelectByCourseID]
	@UserID				int
	,@CourseID			int

AS

SELECT
		[dbo].[ADM_Student].[StudentID]

FROM	[dbo].[ADM_Student]

WHERE [dbo].[ADM_Student].[CourseID] = @CourseID
AND [dbo].[ADM_Student].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Student_SelectByGender]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Student_SelectByGender] 1,'female'

CREATE   PROCEDURE [dbo].[PR_ADM_Student_SelectByGender]
	@UserID		int
	,@Gender	nvarchar(100)

AS

SELECT
		[dbo].[ADM_Student].[StudentID]

FROM	[dbo].[ADM_Student]

WHERE [dbo].[ADM_Student].[Gender] = @Gender
AND [dbo].[ADM_Student].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Student_SelectByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Student_SelectByPK] 1, 1
--Select * From ADM_Student

CREATE      PROCEDURE [dbo].[PR_ADM_Student_SelectByPK]
	@StudentID	int
	,@UserID	int

AS

SELECT	[dbo].[ADM_Student].[StudentID]
		,[dbo].[ADM_Student].[VisitorID]
		,[dbo].[ADM_Student].[AdmissionYearID]
		,[dbo].[ADM_Student].[QuotaID]
		,[dbo].[ADM_Student].[CourseID]
		,[dbo].[ADM_Student].[ProgramID]
		,[dbo].[ADM_Student].[UserID]
		,[dbo].[ADM_Student].[QualificationID]
		,[dbo].[ADM_Student].[CasteCategoryID]
		,[dbo].[ADM_Student].[StateID]
		,[dbo].[ADM_Student].[CityID]
		,[dbo].[ADM_Student].[StudentName]
		,[dbo].[ADM_Student].[ParentPhone]
		,[dbo].[ADM_Student].[Gender]
		,[dbo].[ADM_Student].[DateOfBirth]
		,[dbo].[ADM_Student].[SSCPercentage]
		,[dbo].[ADM_Student].[SSCSchoolName]
		,[dbo].[ADM_Student].[SSCPassingYear]
		,[dbo].[ADM_Student].[HSCPercentage]
		,[dbo].[ADM_Student].[HSCSchoolName]
		,[dbo].[ADM_Student].[HSCPassingYear]
		,[dbo].[ADM_Student].[DiplomaPercentage]
		,[dbo].[ADM_Student].[DiplomaCollegeName]
		,[dbo].[ADM_Student].[DiplomaPassingYear]
		,[dbo].[ADM_Student].[UGPercentage]
		,[dbo].[ADM_Student].[UGCollegeName]
		,[dbo].[ADM_Student].[UGPassingYear]
		,[dbo].[ADM_Student].[PGPercentage]
		,[dbo].[ADM_Student].[PGCollegeName]
		,[dbo].[ADM_Student].[PGPassingYear]
		,[dbo].[ADM_Student].[PhotoPath]
		,[dbo].[ADM_Student].[Description]
		,[dbo].[ADM_Student].[CreationDate]
		,[dbo].[ADM_Student].[ModificationDate]

FROM	[dbo].[ADM_Student]

WHERE [dbo].[ADM_Student].[StudentID] = @StudentID
AND [dbo].[ADM_Student].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Student_SelectByStateID]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Student_SelectByStateID] 1, 4

CREATE         PROCEDURE [dbo].[PR_ADM_Student_SelectByStateID]
	@UserID				int
	,@StateID			int

AS

SELECT
		[dbo].[ADM_Student].[StudentID]

FROM	[dbo].[ADM_Student]

WHERE [dbo].[ADM_Student].[StateID] = @StateID
AND [dbo].[ADM_Student].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Student_SelectForDropDown]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Student_SelectForDropDown] 1
--Select * from ADM_Student

CREATE     PROCEDURE [dbo].[PR_ADM_Student_SelectForDropDown]
	@UserID		int

AS

SELECT	[dbo].[ADM_Student].[StudentID]
		,[dbo].[ADM_Visitor].[VisitorName]

FROM [dbo].[ADM_Student]

INNER JOIN [dbo].[ADM_Visitor]
ON [dbo].[ADM_Visitor].[VisitorID] = [dbo].[ADM_Student].[VisitorID]

WHERE [dbo].[ADM_Student].[UserID] = @UserID

ORDER BY [dbo].[ADM_Visitor].[VisitorName]
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Student_UpdateByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
/*[dbo].[PR_ADM_Student_UpdateByPK] @StudentID=1, @VisitorID=1, @AdmissionYearID=3, @QuotaID=2, @CourseID=2, @ProgramID=2, 
	@QualificationID=2, @CasteCategoryID=2, @StateID=1, @CityID=2, @UserID=1, @ParentPhone='122222234', 
	@Gender='Male', @DateOfBirth="2022-06-08", @SSCPercentage=65.80, @SSCSchoolName="OJAS", @SSCPassingYear=2022, 
	@HSCPercentage=80.78, @HSCSchoolName="High School", @HSCPassingYear=2020, @DiplomaPercentage=9.35, @DiplomaCollegeName="LEC",
	@DiplomaPassingYear=2018, @UGPercentage=78.90, @UGCollegeName="Darshan", @UGPassingYear=2025, @PGPercentage=67.90, 
	@PGCollegeName="Darshan", @PGPassingYear=2029, @PhotoPath="sd/dsds/dfdf.jpg", @Description=null, @ModificationDate=null
*/
--Select * from ADM_Student

CREATE      PROCEDURE [dbo].[PR_ADM_Student_UpdateByPK]
	@StudentID				int
	,@VisitorID				int
	,@AdmissionYearID		int
	,@QuotaID				int
	,@CourseID				int
	,@ProgramID				int
	,@QualificationID		int
	,@CasteCategoryID		int
	,@StateID				int
	,@CityID				int
	,@UserID				int
	,@StudentName			nvarchar(100)
	,@ParentPhone			nvarchar(50)
	,@Gender				nvarchar(10)
	,@DateOfBirth			datetime
	,@SSCPercentage			decimal(5,2)
	,@SSCSchoolName			nvarchar(100)
	,@SSCPassingYear		int
	,@HSCPercentage			decimal(5,2)
	,@HSCSchoolName			nvarchar(100)
	,@HSCPassingYear		int
	,@DiplomaPercentage		decimal(5,2)
	,@DiplomaCollegeName	nvarchar(100)
	,@DiplomaPassingYear	int
	,@UGPercentage			decimal(5,2)
	,@UGCollegeName			nvarchar(100)
	,@UGPassingYear			int
	,@PGPercentage			decimal(5,2)
	,@PGCollegeName			nvarchar(100)
	,@PGPassingYear			int
	,@PhotoPath				nvarchar(250)
	,@Description			nvarchar(100)
	,@ModificationDate		datetime
AS

UPDATE [dbo].[ADM_Student]

SET	[dbo].[ADM_Student].[VisitorID] = @VisitorID
	,[dbo].[ADM_Student].[AdmissionYearID] = @AdmissionYearID
	,[dbo].[ADM_Student].[QuotaID] = @QuotaID
	,[dbo].[ADM_Student].[CourseID] = @CourseID
	,[dbo].[ADM_Student].[ProgramID] = @ProgramID
	,[dbo].[ADM_Student].[QualificationID] = @QualificationID
	,[dbo].[ADM_Student].[CasteCategoryID] = @CasteCategoryID
	,[dbo].[ADM_Student].[StateID] = @StateID
	,[dbo].[ADM_Student].[CityID] = @CityID
	,[dbo].[ADM_Student].[StudentName] = @StudentName
	,[dbo].[ADM_Student].[ParentPhone] = @ParentPhone
	,[dbo].[ADM_Student].[Gender] = @Gender
	,[dbo].[ADM_Student].[DateOfBirth] = @DateOfBirth
	,[dbo].[ADM_Student].[SSCPercentage] = @SSCPercentage
	,[dbo].[ADM_Student].[SSCSchoolName] = @SSCSchoolName
	,[dbo].[ADM_Student].[SSCPassingYear] = @SSCPassingYear
	,[dbo].[ADM_Student].[HSCPercentage] = @HSCPercentage
	,[dbo].[ADM_Student].[HSCSchoolName] = @HSCSchoolName
	,[dbo].[ADM_Student].[HSCPassingYear] = @HSCPassingYear
	,[dbo].[ADM_Student].[DiplomaPercentage] = @DiplomaPercentage
	,[dbo].[ADM_Student].[DiplomaCollegeName] = @DiplomaCollegeName
	,[dbo].[ADM_Student].[DiplomaPassingYear] = @DiplomaPassingYear
	,[dbo].[ADM_Student].[UGPercentage] = @UGPercentage
	,[dbo].[ADM_Student].[UGCollegeName] = @UGCollegeName
	,[dbo].[ADM_Student].[UGPassingYear] = @UGPassingYear
	,[dbo].[ADM_Student].[PGPercentage] = @PGPercentage
	,[dbo].[ADM_Student].[PGCollegeName] = @PGCollegeName
	,[dbo].[ADM_Student].[PGPassingYear] = @PGPassingYear
	,[dbo].[ADM_Student].[PhotoPath] = @PhotoPath
	,[dbo].[ADM_Student].[Description] = @Description
	,[dbo].[ADM_Student].[ModificationDate] = ISNULL(@ModificationDate,GETDATE())

WHERE [dbo].[ADM_Student].[StudentID] = @StudentID
AND	[dbo].[ADM_Student].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_StudentDocument_DeleteByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_StudentDocument_DeleteByPK] 1, 1
--Select * from ADM_StudentDocument

CREATE       PROCEDURE [dbo].[PR_ADM_StudentDocument_DeleteByPK]
	@StudentDocumentID	int
	,@UserID			int

AS

DELETE FROM [dbo].[ADM_StudentDocument]

WHERE [dbo].[ADM_StudentDocument].[StudentDocumentID] = @StudentDocumentID
AND	[dbo].[ADM_StudentDocument].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_StudentDocument_Insert]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_StudentDocument_Insert] @StudentID=1, @DocumentID=2, @UserID=1, @DocumentPath='sdsd/sds', @Description=null, @CreationDate=null, @ModificationDate=null
--Select * from ADM_StudentDocument

CREATE     PROCEDURE [dbo].[PR_ADM_StudentDocument_Insert]
	@StudentID			int
	,@DocumentID		int
	,@UserID			int
	,@DocumentPath		nvarchar(250)
	,@Description		nvarchar(100)
	,@CreationDate		datetime
	,@ModificationDate	datetime
AS

INSERT INTO [dbo].[ADM_StudentDocument]
(
	StudentID
	,DocumentID
	,UserID
	,DocumentPath
	,Description
	,CreationDate
	,ModificationDate
)

VALUES
(
	@StudentID			
	,@DocumentID			
	,@UserID
	,@DocumentPath		
	,@Description
	,ISNULL(@CreationDate,GETDATE())
	,ISNULL(@ModificationDate,GETDATE())
)
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_StudentDocument_SelectAll]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_StudentDocument_SelectAll] 1
--Select * from ADM_StudentDocument

CREATE      PROCEDURE [dbo].[PR_ADM_StudentDocument_SelectAll]
	@UserID		int

AS

SELECT	[dbo].[ADM_StudentDocument].[StudentDocumentID]
		,[dbo].[ADM_StudentDocument].[StudentID]
		,[dbo].[ADM_Visitor].[StudentName]
		,[dbo].[ADM_StudentDocument].[DocumentID]
		,[dbo].[MST_Document].[DocumentName]
		,[dbo].[ADM_StudentDocument].[UserID]
		,[dbo].[ADM_StudentDocument].[DocumentPath]
		,[dbo].[ADM_StudentDocument].[Description]
		,[dbo].[ADM_StudentDocument].[CreationDate]
		,[dbo].[ADM_StudentDocument].[ModificationDate]

FROM	[dbo].[ADM_StudentDocument]

INNER JOIN [dbo].[ADM_Student]
ON [dbo].[ADM_Student].[StudentID] = [dbo].[ADM_StudentDocument].[StudentID]

INNER JOIN [dbo].[ADM_Visitor]
ON [dbo].[ADM_Visitor].[VisitorID] = [dbo].[ADM_Student].[VisitorID]

INNER JOIN [dbo].[MST_Document]
ON [dbo].[MST_Document].[DocumentID] = [dbo].[ADM_StudentDocument].[DocumentID]

WHERE [dbo].[ADM_StudentDocument].[UserID] = @UserID

ORDER BY [dbo].[ADM_Visitor].[StudentName]
		,[dbo].[MST_Document].[DocumentName]
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_StudentDocument_SelectByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_StudentDocument_SelectByPK] 1, 1
--Select * From ADM_StudentDocument

CREATE      PROCEDURE [dbo].[PR_ADM_StudentDocument_SelectByPK]
	@StudentDocumentID	int
	,@UserID			int

AS

SELECT	[dbo].[ADM_StudentDocument].[StudentDocumentID]
		,[dbo].[ADM_StudentDocument].[StudentID]
		,[dbo].[ADM_StudentDocument].[DocumentID]
		,[dbo].[ADM_StudentDocument].[UserID]
		,[dbo].[ADM_StudentDocument].[DocumentPath]
		,[dbo].[ADM_StudentDocument].[Description]
		,[dbo].[ADM_StudentDocument].[CreationDate]
		,[dbo].[ADM_StudentDocument].[ModificationDate]

FROM	[dbo].[ADM_StudentDocument]

WHERE [dbo].[ADM_StudentDocument].[StudentDocumentID] = @StudentDocumentID
AND [dbo].[ADM_StudentDocument].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_StudentDocument_UpdateByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_StudentDocument_UpdateByPK] @StudentDocumentID=1, @StudentID=1, @DocumentID=3, @UserID=1, @DocumentPath='assets/gg', @Description=null, @ModificationDate=null
--Select * from ADM_StudentDocument

CREATE      PROCEDURE [dbo].[PR_ADM_StudentDocument_UpdateByPK]
	@StudentDocumentID	int
	,@StudentID			int
	,@DocumentID		int
	,@UserID			int
	,@DocumentPath		nvarchar(250)
	,@Description		nvarchar(100)
	,@ModificationDate	datetime
AS

UPDATE [dbo].[ADM_StudentDocument]

SET	[dbo].[ADM_StudentDocument].[StudentID] = @StudentID
	,[dbo].[ADM_StudentDocument].[DocumentID] = @DocumentID
	,[dbo].[ADM_StudentDocument].[DocumentPath] = @DocumentPath
	,[dbo].[ADM_StudentDocument].[Description] = @Description
	,[dbo].[ADM_StudentDocument].[ModificationDate] = ISNULL(@ModificationDate,GETDATE())

WHERE [dbo].[ADM_StudentDocument].[StudentDocumentID] = @StudentDocumentID
AND	[dbo].[ADM_StudentDocument].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Visitor_DeleteByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Visitor_DeleteByPK] 2, 1
--Select * from ADM_Visitor

CREATE       PROCEDURE [dbo].[PR_ADM_Visitor_DeleteByPK]
	@VisitorID	int
	,@UserID	int

AS

DELETE FROM [dbo].[ADM_Visitor]

WHERE [dbo].[ADM_Visitor].[VisitorID] = @VisitorID
AND	[dbo].[ADM_Visitor].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Visitor_Insert]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Visitor_Insert] @AdmissionYearID=2, @UserID=2, @CounsellorStaffID=2, @VisitorStaffID=2, @VisitorName="Demo", @Phone="12341234", @Email="sample@sample.com", @NoOfPeople=4, @Address="abc road", @PassingYear="2022", @Description=null, @CreationDate=null, @ModificationDate=null
--Select * from ADM_Visitor

CREATE     PROCEDURE [dbo].[PR_ADM_Visitor_Insert]
	@AdmissionYearID	int
	,@UserID			int
	,@CounsellorStaffID int
	,@VisitorStaffID	int
	,@VisitorName		nvarchar(100)
	,@Phone				nvarchar(50)
	,@Email				nvarchar(50)
	,@NoOfPeople		int
	,@Address			nvarchar(500)
	,@PassingYear		date
	,@Description		nvarchar(100)
	,@CreationDate		datetime
	,@ModificationDate	datetime
	,@VisitorID			int OUT
AS

INSERT INTO [dbo].[ADM_Visitor]
(
	AdmissionYearID
	,UserID
	,CounsellorStaffID
	,VisitorStaffID
	,VisitorName
	,Phone
	,Email
	,NoOfPeople
	,Address	
	,PassingYear
	,Description
	,CreationDate
	,ModificationDate
)

VALUES
(
	@AdmissionYearID			
	,@UserID						
	,@CounsellorStaffID 			
	,@VisitorStaffID				
	,@VisitorName					
	,@Phone							
	,@Email							
	,@NoOfPeople		
	,@Address			
	,@PassingYear		
	,@Description
	,ISNULL(@CreationDate,GETDATE())
	,ISNULL(@ModificationDate,GETDATE())
)

SET @VisitorID=SCOPE_IDENTITY();
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Visitor_SelectAll]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Visitor_SelectAll] 1
--Select * from ADM_Visitor

CREATE      PROCEDURE [dbo].[PR_ADM_Visitor_SelectAll]
	@UserID		int

AS

SELECT	[dbo].[ADM_Visitor].[VisitorID]
		,[dbo].[ADM_Visitor].[AdmissionYearID]
		,[dbo].[MST_AdmissionYear].[AdmissionYear]
		,[dbo].[ADM_Visitor].[CounsellorStaffID]
		,CounsellorStaff.[StaffName] as 'CounsellorStaffName'
		,[dbo].[ADM_Visitor].[VisitorStaffID]
		,VisitorStaff.[StaffName] as 'VisitorStaffName'
		,[dbo].[ADM_Visitor].[VisitorName]
		,[dbo].[ADM_Visitor].[Phone]
		,[dbo].[ADM_Visitor].[Email]
		,[dbo].[ADM_Visitor].[NoOfPeople]
		,[dbo].[ADM_Visitor].[Address]
		,[dbo].[ADM_Visitor].[PassingYear]
		,[dbo].[ADM_Visitor].[Description]
		,[dbo].[ADM_Visitor].[CreationDate]
		,[dbo].[ADM_Visitor].[ModificationDate]

FROM	[dbo].[ADM_Visitor]

INNER JOIN [dbo].[MST_AdmissionYear]
ON [dbo].[MST_AdmissionYear].[AdmissionYearID] = [dbo].[ADM_Visitor].[AdmissionYearID]

FULL OUTER JOIN [dbo].[MST_Staff] CounsellorStaff
ON [dbo].[ADM_Visitor].[CounsellorStaffID] = CounsellorStaff.[StaffID]

FULL OUTER JOIN [dbo].[MST_Staff] VisitorStaff
ON [dbo].[ADM_Visitor].[VisitorStaffID] = VisitorStaff.[StaffID]

WHERE [dbo].[ADM_Visitor].[UserID] = @UserID

ORDER BY [dbo].[ADM_Visitor].[VisitorName]
		 ,CounsellorStaff.[StaffName] 
		 ,VisitorStaff.[StaffName]
		 ,[dbo].[MST_AdmissionYear].[AdmissionYear]
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Visitor_SelectByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Visitor_SelectByPK] 1, 1
--Select * from ADM_Visitor

CREATE      PROCEDURE [dbo].[PR_ADM_Visitor_SelectByPK]
	@VisitorID	int
	,@UserID	int

AS

SELECT	[dbo].[ADM_Visitor].[VisitorID]
		,[dbo].[ADM_Visitor].[AdmissionYearID]
		,[dbo].[MST_AdmissionYear].[AdmissionYear]
		,[dbo].[ADM_Visitor].[CounsellorStaffID]
		,CounsellorStaff.[StaffName] as 'CounsellorStaffName'
		,[dbo].[ADM_Visitor].[VisitorStaffID]
		,VisitorStaff.[StaffName] as 'VisitorStaffName'
		,[dbo].[ADM_Visitor].[VisitorName]
		,[dbo].[ADM_Visitor].[Phone]
		,[dbo].[ADM_Visitor].[Email]
		,[dbo].[ADM_Visitor].[NoOfPeople]
		,[dbo].[ADM_Visitor].[Address]
		,[dbo].[ADM_Visitor].[PassingYear]
		,[dbo].[ADM_Visitor].[Description]
		,[dbo].[ADM_Visitor].[CreationDate]
		,[dbo].[ADM_Visitor].[ModificationDate]

FROM	[dbo].[ADM_Visitor]

INNER JOIN [dbo].[MST_AdmissionYear]
ON [dbo].[MST_AdmissionYear].[AdmissionYearID] = [dbo].[ADM_Visitor].[AdmissionYearID]

FULL OUTER JOIN [dbo].[MST_Staff] CounsellorStaff
ON [dbo].[ADM_Visitor].[CounsellorStaffID] = CounsellorStaff.[StaffID]

FULL OUTER JOIN [dbo].[MST_Staff] VisitorStaff
ON [dbo].[ADM_Visitor].[VisitorStaffID] = VisitorStaff.[StaffID]

WHERE [dbo].[ADM_Visitor].[VisitorID] = @VisitorID
AND [dbo].[ADM_Visitor].[UserID] = @UserID

ORDER BY [dbo].[ADM_Visitor].[VisitorName]
		 ,CounsellorStaff.[StaffName] 
		 ,VisitorStaff.[StaffName]
		 ,[dbo].[MST_AdmissionYear].[AdmissionYear]
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Visitor_SelectByStaff]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Visitor_SelectByStaff] 2, 8

CREATE   PROCEDURE [dbo].[PR_ADM_Visitor_SelectByStaff]
	@UserID				int
	,@StaffID			int

AS

SELECT
		[dbo].[ADM_Visitor].[VisitorID]

FROM	[dbo].[ADM_Visitor]

WHERE ([dbo].[ADM_Visitor].[VisitorStaffID] = @StaffID OR [dbo].[ADM_Visitor].[CounsellorStaffID] = @StaffID)
AND [dbo].[ADM_Visitor].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Visitor_SelectForDropDown]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Visitor_SelectForDropDown] 1
--Select * from ADM_Visitor

CREATE     PROCEDURE [dbo].[PR_ADM_Visitor_SelectForDropDown]
	@UserID		int

AS

SELECT	[dbo].[ADM_Visitor].[VisitorID]
		,[dbo].[ADM_Visitor].[VisitorName]

FROM [dbo].[ADM_Visitor]

WHERE [dbo].[ADM_Visitor].[UserID] = @UserID

ORDER BY [dbo].[ADM_Visitor].[VisitorName]
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_Visitor_UpdateByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_Visitor_UpdateByPK] @VisitorID=8, @AdmissionYearID=2, @UserID=2, @CounsellorStaffID=2, @VisitorStaffID=3, @StudentName="XYZ", @Phone="12341234", @Email="sample@sample.com", @NoOfPeople=4, @Address="abc road", @PassingYear="2022", @Description=null, @ModificationDate=null
--Select * from ADM_Visitor

CREATE      PROCEDURE [dbo].[PR_ADM_Visitor_UpdateByPK]
	@VisitorID			int
	,@AdmissionYearID	int
	,@UserID			int
	,@CounsellorStaffID int
	,@VisitorStaffID	int
	,@VisitorName		nvarchar(100)
	,@Phone				nvarchar(50)
	,@Email				nvarchar(50)
	,@NoOfPeople		int
	,@Address			nvarchar(500)
	,@PassingYear		date
	,@Description		nvarchar(100)
	,@ModificationDate	datetime
AS

UPDATE [dbo].[ADM_Visitor]

SET	[dbo].[ADM_Visitor].[AdmissionYearID] = @AdmissionYearID
	,[dbo].[ADM_Visitor].[CounsellorStaffID] = @CounsellorStaffID
	,[dbo].[ADM_Visitor].[VisitorStaffID] = @VisitorStaffID
	,[dbo].[ADM_Visitor].[VisitorName] = @VisitorName
	,[dbo].[ADM_Visitor].[Phone] = @Phone
	,[dbo].[ADM_Visitor].[Email] = @Email
	,[dbo].[ADM_Visitor].[NoOfPeople] = @NoOfPeople
	,[dbo].[ADM_Visitor].[Address] = @Address
	,[dbo].[ADM_Visitor].[PassingYear] = @PassingYear
	,[dbo].[ADM_Visitor].[Description] = @Description
	,[dbo].[ADM_Visitor].[ModificationDate] = ISNULL(@ModificationDate,GETDATE())

WHERE [dbo].[ADM_Visitor].[VisitorID] = @VisitorID
AND	[dbo].[ADM_Visitor].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_VisitorInterestedCourses_DeleteByVisitorID]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_ADM_VisitorInterestedCourses_DeleteByVisitorID] 23, 1
--Select * from ADM_VisitorInterestedCourses

CREATE   PROCEDURE [dbo].[PR_ADM_VisitorInterestedCourses_DeleteByVisitorID]
	@VisitorID	int
	,@UserID	int

AS

DELETE FROM [dbo].[ADM_VisitorInterestedCourses]

WHERE [dbo].[ADM_VisitorInterestedCourses].[VisitorID] = @VisitorID
AND	[dbo].[ADM_VisitorInterestedCourses].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_VisitorInterestedCourses_Insert]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created By Hemang Kateshiya
--[dbo].[PR_ADM_VisitorInterestedCourses_Insert] @UserID=1,@VisitorID=8, @CourseID=2
--Select * from ADM_VisitorInterestedCourses

CREATE   PROCEDURE [dbo].[PR_ADM_VisitorInterestedCourses_Insert]
	@UserID		int			
	,@VisitorID	int
	,@CourseID	int

AS

INSERT INTO [dbo].[ADM_VisitorInterestedCourses]
(
	UserID	
	,VisitorID
	,CourseID
)
VALUES
(
	@UserID
	,@VisitorID
	,@CourseID
)
GO
/****** Object:  StoredProcedure [dbo].[PR_ADM_VisitorInterestedCourses_SelectByVisitorID]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created By Hemang Kateshiya
--[dbo].[PR_ADM_VisitorInterestedCourses_SelectByVisitorID] @UserID=1, @VisitorID=14
--Select * from [ADM_VisitorInterestedCourses]

CREATE   PROCEDURE [dbo].[PR_ADM_VisitorInterestedCourses_SelectByVisitorID]
	@UserID		int
	,@VisitorID	int

AS

SELECT [dbo].[ADM_VisitorInterestedCourses].[VisitorInterestedCoursesID]
		,[dbo].[ADM_VisitorInterestedCourses].[VisitorID]
		,[dbo].[ADM_VisitorInterestedCourses].[CourseID]
		,[dbo].[MST_Course].[CourseName]

FROM [dbo].[ADM_VisitorInterestedCourses]

INNER JOIN [dbo].[MST_Course]
ON [dbo].[MST_Course].[CourseID]=[dbo].[ADM_VisitorInterestedCourses].[CourseID]

WHERE [dbo].[ADM_VisitorInterestedCourses].[UserID]=@UserID
AND	[dbo].[ADM_VisitorInterestedCourses].[VisitorID]=@VisitorID
GO
/****** Object:  StoredProcedure [dbo].[PR_LOC_City_DeleteByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_LOC_City_DeleteByPK] 1, 1

CREATE     PROCEDURE [dbo].[PR_LOC_City_DeleteByPK]
	@CityID		int
	,@UserID	int

AS

DELETE FROM [dbo].[LOC_City]

WHERE [dbo].[LOC_City].[CityID] = @CityID
AND	[dbo].[LOC_City].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_LOC_City_Insert]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_LOC_City_Insert] @StateID=1, @UserID=1, @CityName='Baroda', @Description=null, @CreationDate=null, @ModificationDate=null
--Select * from LOC_City

CREATE   PROCEDURE [dbo].[PR_LOC_City_Insert]
	@StateID			int
	,@UserID			int
	,@CityName			nvarchar(100)
	,@Description		nvarchar(100)
	,@CreationDate		datetime
	,@ModificationDate	datetime
AS

INSERT INTO [dbo].[LOC_City]
(
	StateID
	,UserID
	,CityName
	,Description
	,CreationDate
	,ModificationDate
)

VALUES
(
	@StateID			
	,@UserID
	,@CityName		
	,@Description
	,ISNULL(@CreationDate,GETDATE())
	,ISNULL(@ModificationDate,GETDATE())
)
GO
/****** Object:  StoredProcedure [dbo].[PR_LOC_City_SelectAll]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_LOC_City_SelectAll] 1

CREATE    PROCEDURE [dbo].[PR_LOC_City_SelectAll]
	@UserID		int

AS

SELECT	[dbo].[LOC_City].[CityID]
		,[dbo].[LOC_City].[CityName]
		,[dbo].[LOC_City].[StateID]
		,[dbo].[LOC_State].[StateName]
		,[dbo].[LOC_City].[Description]
		,[dbo].[LOC_City].[CreationDate]
		,[dbo].[LOC_City].[ModificationDate]

FROM	[dbo].[LOC_City]

INNER JOIN [dbo].[LOC_State]
ON [dbo].[LOC_State].[StateID] = [dbo].[LOC_City].[StateID]

WHERE [dbo].[LOC_City].[UserID] = @UserID

ORDER BY [dbo].[LOC_State].[StateName]
		 ,[dbo].[LOC_City].[CityName]
GO
/****** Object:  StoredProcedure [dbo].[PR_LOC_City_SelectByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_LOC_City_SelectByPK] 1, 1

CREATE    PROCEDURE [dbo].[PR_LOC_City_SelectByPK]
	@CityID		int
	,@UserID	int

AS

SELECT	[dbo].[LOC_City].[CityID]
		,[dbo].[LOC_City].[CityName]
		,[dbo].[LOC_City].[StateID]
		,[dbo].[LOC_City].[Description]
		,[dbo].[LOC_City].[CreationDate]
		,[dbo].[LOC_City].[ModificationDate]

FROM [dbo].[LOC_City]

WHERE [dbo].[LOC_City].[CityID] = @CityID
AND [dbo].[LOC_City].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_LOC_City_SelectDropDownByStateID]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_LOC_City_SelectDropDownByStateID] 1, 1

CREATE    PROCEDURE [dbo].[PR_LOC_City_SelectDropDownByStateID]
	@StateID	int
	,@UserID	int

AS

SELECT	[dbo].[LOC_City].[CityID]
		,[dbo].[LOC_City].[CityName]

FROM	[dbo].[LOC_City]

WHERE	[dbo].[LOC_City].[StateID] = @StateID
AND [dbo].[LOC_City].[UserID] = @UserID

ORDER BY [dbo].[LOC_City].[CityName]
GO
/****** Object:  StoredProcedure [dbo].[PR_LOC_City_SelectForDropDown]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_LOC_City_SelectForDropDown] 1

CREATE   PROCEDURE [dbo].[PR_LOC_City_SelectForDropDown]
	@UserID		int

AS

SELECT	[dbo].[LOC_City].[CityID]
		,[dbo].[LOC_City].[CityName]

FROM [dbo].[LOC_City]

WHERE [dbo].[LOC_City].[UserID] = @UserID

ORDER BY [dbo].[LOC_City].[CityName]
GO
/****** Object:  StoredProcedure [dbo].[PR_LOC_City_UpdateByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_LOC_City_UpdateByPK] @CityID=1, @StateID=1, @UserID=1, @CityName='Surat', @Description=null, @ModificationDate=null
--Select * from LOC_City

CREATE    PROCEDURE [dbo].[PR_LOC_City_UpdateByPK]
	@CityID				int
	,@StateID			int
	,@UserID			int
	,@CityName			nvarchar(100)
	,@Description		nvarchar(100)
	,@ModificationDate	datetime
AS

UPDATE [dbo].[LOC_City]

SET	[dbo].[LOC_City].[StateID] = @StateID
	,[dbo].[LOC_City].[CityName] = @CityName
	,[dbo].[LOC_City].[Description] = @Description
	,[dbo].[LOC_City].[ModificationDate] = ISNULL(@ModificationDate,GETDATE())

WHERE [dbo].[LOC_City].[CityID] = @CityID
AND	[dbo].[LOC_City].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_LOC_State_DeleteByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_LOC_State_DeleteByPK] 3, 1

CREATE    PROCEDURE [dbo].[PR_LOC_State_DeleteByPK]
	@StateID	int
	,@UserID	int

AS

DELETE FROM	[dbo].[LOC_State]

WHERE [dbo].[LOC_State].[StateID]=@StateID
AND	[dbo].[LOC_State].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_LOC_State_Insert]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_LOC_State_Insert] @UserID=1, @StateName='Delhi', @Description=null, @CreationDate=null, @ModificationDate=null

CREATE   PROCEDURE [dbo].[PR_LOC_State_Insert]
	@UserID				int
	,@StateName			nvarchar(100)
	,@Description		nvarchar(100)
	,@CreationDate		datetime
	,@ModificationDate	datetime
AS

INSERT INTO [dbo].[LOC_State]
(
	UserID
	,StateName
	,Description
	,CreationDate
	,ModificationDate
)

VALUES
(
	@UserID
	,@StateName
	,@Description
	,ISNULL(@CreationDate,GETDATE())
	,ISNULL(@ModificationDate,GETDATE())
)
GO
/****** Object:  StoredProcedure [dbo].[PR_LOC_State_SelectAll]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_LOC_State_SelectAll] 1

CREATE     PROCEDURE [dbo].[PR_LOC_State_SelectAll]
	@UserID		int

AS

SELECT
		[dbo].[LOC_State].[StateID]
		,[dbo].[LOC_State].[StateName]
		,[dbo].[LOC_State].[Description]
		,[dbo].[LOC_State].[CreationDate]
		,[dbo].[LOC_State].[ModificationDate]

FROM	[dbo].[LOC_State]

WHERE [dbo].[LOC_State].[UserID] = @UserID

ORDER BY	[dbo].[LOC_State].[StateName]
GO
/****** Object:  StoredProcedure [dbo].[PR_LOC_State_SelectByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_LOC_State_SelectByPK] 1, 1

CREATE    PROCEDURE [dbo].[PR_LOC_State_SelectByPK]
	@StateID	int
	,@UserID	int

AS

SELECT
		[dbo].[LOC_State].[StateID],
		[dbo].[LOC_State].[StateName],
		[dbo].[LOC_State].[Description],
		[dbo].[LOC_State].[CreationDate],
		[dbo].[LOC_State].[ModificationDate]

FROM	[dbo].[LOC_State]

WHERE	[dbo].[LOC_State].[StateID]=@StateID
AND [dbo].[LOC_State].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_LOC_State_SelectForDropDown]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya

--[dbo].[PR_LOC_State_SelectForDropDown] 2

CREATE    PROCEDURE [dbo].[PR_LOC_State_SelectForDropDown]
	@UserID		int

AS

SELECT 
		[dbo].[LOC_State].[StateID],
		[dbo].[LOC_State].[StateName]

FROM	[dbo].[LOC_State]

WHERE [dbo].[LOC_State].[UserID] = @UserID

ORDER BY [dbo].[LOC_State].[StateName]
GO
/****** Object:  StoredProcedure [dbo].[PR_LOC_State_UpdateByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--Select * from LOC_State
--[dbo].[PR_LOC_State_UpdateByPK] @StateID=1, @UserID=1, @StateName="Gujarat", @Description=null, @ModificationDate=null

CREATE     PROCEDURE [dbo].[PR_LOC_State_UpdateByPK]
	@StateID			int
	,@UserID			int
	,@StateName			nvarchar(100)
	,@Description		nvarchar(100)
	,@ModificationDate	datetime
AS

UPDATE [dbo].[LOC_State]

SET	[dbo].[LOC_State].[StateName] = @StateName
	,[dbo].[LOC_State].[Description] = @Description
	,[dbo].[LOC_State].[ModificationDate] = ISNULL(@ModificationDate,GETDATE())

WHERE [dbo].[LOC_State].[StateID] = @StateID
AND	[dbo].[LOC_State].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_AdmissionYear_DeleteByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_AdmissionYear_DeleteByPK] 1, 1
--Select * from MST_AdmissionYear

CREATE      PROCEDURE [dbo].[PR_MST_AdmissionYear_DeleteByPK]
	@AdmissionYearID	int
	,@UserID			int

AS

DELETE FROM	[dbo].[MST_AdmissionYear]

WHERE [dbo].[MST_AdmissionYear].[AdmissionYearID] = @AdmissionYearID
AND	[dbo].[MST_AdmissionYear].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_AdmissionYear_Insert]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_AdmissionYear_Insert] @UserID=2, @AdmissionYear=2021, @Description=null, @CreationDate=null, @ModificationDate=null
--Select * from MST_AdmissionYear

CREATE     PROCEDURE [dbo].[PR_MST_AdmissionYear_Insert]
	@UserID				int
	,@AdmissionYear		int
	,@Description		nvarchar(100)
	,@CreationDate		datetime
	,@ModificationDate	datetime
AS

INSERT INTO [dbo].[MST_AdmissionYear]
(
	UserID
	,AdmissionYear
	,Description
	,CreationDate
	,ModificationDate
)

VALUES
(			
	@UserID
	,@AdmissionYear		
	,@Description
	,ISNULL(@CreationDate,GETDATE())
	,ISNULL(@ModificationDate,GETDATE())
)
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_AdmissionYear_SelectAll]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_AddmissionYear_SelectAll] 1

CREATE       PROCEDURE [dbo].[PR_MST_AdmissionYear_SelectAll]
	@UserID		int

AS

SELECT
		[dbo].[MST_AdmissionYear].[AdmissionYearID]
		,[dbo].[MST_AdmissionYear].[AdmissionYear]
		,[dbo].[MST_AdmissionYear].[Description]
		,[dbo].[MST_AdmissionYear].[CreationDate]
		,[dbo].[MST_AdmissionYear].[ModificationDate]

FROM	[dbo].[MST_AdmissionYear]

WHERE [dbo].[MST_AdmissionYear].[UserID] = @UserID

ORDER BY	[dbo].[MST_AdmissionYear].[AdmissionYear]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_AdmissionYear_SelectByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_AdmissionYear_SelectByPK] 1, 2

CREATE        PROCEDURE [dbo].[PR_MST_AdmissionYear_SelectByPK]
	@AdmissionYearID	int
	,@UserID			int

AS

SELECT
		[dbo].[MST_AdmissionYear].[AdmissionYearID]
		,[dbo].[MST_AdmissionYear].[AdmissionYear]
		,[dbo].[MST_AdmissionYear].[Description]
		,[dbo].[MST_AdmissionYear].[CreationDate]
		,[dbo].[MST_AdmissionYear].[ModificationDate]

FROM	[dbo].[MST_AdmissionYear]

WHERE	[dbo].[MST_AdmissionYear].[AdmissionYearID] = @AdmissionYearID
AND [dbo].[MST_AdmissionYear].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_AdmissionYear_SelectForDropDown]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya

--[dbo].[PR_MST_AdmissionYear_SelectForDropDown] 2

CREATE      PROCEDURE [dbo].[PR_MST_AdmissionYear_SelectForDropDown]
	@UserID		int

AS

SELECT 
		[dbo].[MST_AdmissionYear].[AdmissionYearID]
		,[dbo].[MST_AdmissionYear].[AdmissionYear]

FROM	[dbo].[MST_AdmissionYear]

WHERE [dbo].[MST_AdmissionYear].[UserID] = @UserID

ORDER BY [dbo].[MST_AdmissionYear].[AdmissionYear]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_AdmissionYear_UpdateByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--Select * from MST_AdmissionYear
--[dbo].[PR_MST_AdmissionYear_UpdateByPK] @AdmissionYearID=1, @UserID=1, @AdmissionYear=2020, @Description=null, @ModificationDate=null

CREATE   PROCEDURE [dbo].[PR_MST_AdmissionYear_UpdateByPK]
	@AdmissionYearID	int
	,@UserID			int
	,@AdmissionYear		int
	,@Description		nvarchar(100)
	,@ModificationDate	datetime
AS

UPDATE [dbo].[MST_AdmissionYear]

SET	[dbo].[MST_AdmissionYear].[AdmissionYear] = @AdmissionYear
	,[dbo].[MST_AdmissionYear].[Description] = @Description
	,[dbo].[MST_AdmissionYear].[ModificationDate] = ISNULL(@ModificationDate,GETDATE())

WHERE [dbo].[MST_AdmissionYear].[AdmissionYearID] = @AdmissionYearID
AND	[dbo].[MST_AdmissionYear].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_CasteCategory_DeleteByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_CasteCategory_DeleteByPK] 1, 1
--Select * from MST_CasteCategory

CREATE      PROCEDURE [dbo].[PR_MST_CasteCategory_DeleteByPK]
	@CasteCategoryID	int
	,@UserID			int

AS

DELETE FROM	[dbo].[MST_CasteCategory]

WHERE [dbo].[MST_CasteCategory].[CasteCategoryID] = @CasteCategoryID
AND	[dbo].[MST_CasteCategory].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_CasteCategory_Insert]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_CasteCategory_Insert] @UserID=2, @CategoryName='Open', @Description=null, @CreationDate=null, @ModificationDate=null
--Select * from MST_CasteCategory
CREATE     PROCEDURE [dbo].[PR_MST_CasteCategory_Insert]
	@UserID				int
	,@CategoryName		nvarchar(100)
	,@Description		nvarchar(100)
	,@CreationDate		datetime
	,@ModificationDate	datetime
AS

INSERT INTO [dbo].[MST_CasteCategory]
(
	UserID
	,CategoryName
	,Description
	,CreationDate
	,ModificationDate
)

VALUES
(
	@UserID
	,@CategoryName
	,@Description
	,ISNULL(@CreationDate,GETDATE())
	,ISNULL(@ModificationDate,GETDATE())
)
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_CasteCategory_SelectAll]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_CasteCategory_SelectAll] 2

CREATE       PROCEDURE [dbo].[PR_MST_CasteCategory_SelectAll]
	@UserID		int

AS

SELECT
		[dbo].[MST_CasteCategory].[CasteCategoryID]
		,[dbo].[MST_CasteCategory].[CategoryName]
		,[dbo].[MST_CasteCategory].[Description]
		,[dbo].[MST_CasteCategory].[CreationDate]
		,[dbo].[MST_CasteCategory].[ModificationDate]

FROM	[dbo].[MST_CasteCategory]

WHERE [dbo].[MST_CasteCategory].[UserID] = @UserID

ORDER BY	[dbo].[MST_CasteCategory].[CategoryName]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_CasteCategory_SelectByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_CasteCategory_SelectByPK] 3, 2

CREATE      PROCEDURE [dbo].[PR_MST_CasteCategory_SelectByPK]
	@CasteCategoryID	int
	,@UserID			int

AS

SELECT
		[dbo].[MST_CasteCategory].[CasteCategoryID]
		,[dbo].[MST_CasteCategory].[CategoryName]
		,[dbo].[MST_CasteCategory].[Description]
		,[dbo].[MST_CasteCategory].[CreationDate]
		,[dbo].[MST_CasteCategory].[ModificationDate]

FROM	[dbo].[MST_CasteCategory]

WHERE	[dbo].[MST_CasteCategory].[CasteCategoryID] = @CasteCategoryID
AND [dbo].[MST_CasteCategory].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_CasteCategory_SelectForDropDown]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya

--[dbo].[PR_MST_CasteCategory_SelectForDropDown] 1

CREATE      PROCEDURE [dbo].[PR_MST_CasteCategory_SelectForDropDown]
	@UserID		int

AS

SELECT 
		[dbo].[MST_CasteCategory].[CasteCategoryID]
		,[dbo].[MST_CasteCategory].[CategoryName]

FROM	[dbo].[MST_CasteCategory]

WHERE [dbo].[MST_CasteCategory].[UserID] = @UserID

ORDER BY [dbo].[MST_CasteCategory].[CategoryName]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_CasteCategory_UpdateByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--Select * from MST_CasteCategory
--[dbo].[PR_MST_CasteCategory_UpdateByPK] @CasteCategoryID=1, @UserID=1, @CategoryName="ST", @Description=null, @ModificationDate=null

CREATE     PROCEDURE [dbo].[PR_MST_CasteCategory_UpdateByPK]
	@CasteCategoryID	int
	,@UserID			int
	,@CategoryName		nvarchar(100)
	,@Description		nvarchar(100)
	,@ModificationDate	datetime
AS

UPDATE [dbo].[MST_CasteCategory]

SET	[dbo].[MST_CasteCategory].[CategoryName] = @CategoryName
	,[dbo].[MST_CasteCategory].[Description] = @Description
	,[dbo].[MST_CasteCategory].[ModificationDate] = ISNULL(@ModificationDate,GETDATE())

WHERE [dbo].[MST_CasteCategory].[CasteCategoryID] = @CasteCategoryID
AND	[dbo].[MST_CasteCategory].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Course_DeleteByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Course_DeleteByPK] 1, 1

CREATE      PROCEDURE [dbo].[PR_MST_Course_DeleteByPK]
	@CourseID	int
	,@UserID	int

AS

DELETE FROM	[dbo].[MST_Course]

WHERE [dbo].[MST_Course].[CourseID] = @CourseID
AND	[dbo].[MST_Course].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Course_Insert]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Course_Insert] @UserID=2, @CourseName='MCA', @CourseLevel='UG', @CourseDuration="3 Years", @Description=null, @CreationDate=null, @ModificationDate=null

CREATE   PROCEDURE [dbo].[PR_MST_Course_Insert]
	@UserID				int
	,@CourseName		nvarchar(100)
	,@CourseLevel		nvarchar(50)
	,@CourseDuration	nvarchar(20)
	,@Description		nvarchar(100)
	,@CreationDate		datetime
	,@ModificationDate	datetime
AS

INSERT INTO [dbo].[MST_Course]
(
	UserID
	,CourseName
	,CourseLevel
	,CourseDuration	
	,Description		
	,CreationDate		
	,ModificationDate
)
VALUES
(
	@UserID
	,@CourseName	
	,@CourseLevel	
	,@CourseDuration
	,@Description
	,ISNULL(@CreationDate,GETDATE())
	,ISNULL(@ModificationDate,GETDATE())
)
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Course_SelectAll]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Course_SelectAll] 2

CREATE   procedure [dbo].[PR_MST_Course_SelectAll]
	@UserID		int

AS

SELECT
		[dbo].[MST_Course].[CourseID]
		,[dbo].[MST_Course].[CourseName]
		,[dbo].[MST_Course].[CourseLevel]
		,[dbo].[MST_Course].[CourseDuration]
		,[dbo].[MST_Course].[Description]
		,[dbo].[MST_Course].[CreationDate]
		,[dbo].[MST_Course].[ModificationDate]

FROM	[dbo].[MST_Course]

WHERE [dbo].[MST_Course].[UserID] = @UserID

ORDER BY	[dbo].[MST_Course].[CourseName]
			,[dbo].[MST_Course].[CourseLevel]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Course_SelectByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Course_SelectByPK] 3, 2

CREATE      PROCEDURE [dbo].[PR_MST_Course_SelectByPK]
	@CourseID	int
	,@UserID	int

AS

SELECT
		[dbo].[MST_Course].[CourseID]
		,[dbo].[MST_Course].[CourseName]
		,[dbo].[MST_Course].[CourseLevel]
		,[dbo].[MST_Course].[CourseDuration]
		,[dbo].[MST_Course].[Description]
		,[dbo].[MST_Course].[CreationDate]
		,[dbo].[MST_Course].[ModificationDate]

FROM	[dbo].[MST_Course]

WHERE	[dbo].[MST_Course].[CourseID] = @CourseID
AND [dbo].[MST_Course].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Course_SelectForDropDown]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Course_SelectForDropDown] 2

CREATE   procedure [dbo].[PR_MST_Course_SelectForDropDown]
	@UserID		int

AS

SELECT
		[dbo].[MST_Course].[CourseID]
		,[dbo].[MST_Course].[CourseName]

FROM	[dbo].[MST_Course]

WHERE [dbo].[MST_Course].[UserID] = @UserID

ORDER BY	[dbo].[MST_Course].[CourseName]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Course_UpdateByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[PR_MST_Course_UpdateByPK] @CourseID=1, @UserID=1, @CourseName='BE', @CourseLevel="UG", @CourseDuration="4Years", @Description=null, @ModificationDate=null

CREATE      PROCEDURE [dbo].[PR_MST_Course_UpdateByPK]
	@CourseID			int
	,@UserID			int
	,@CourseName		nvarchar(100)
	,@CourseLevel		nvarchar(50)
	,@CourseDuration	nvarchar(20)
	,@Description		nvarchar(100)
	,@ModificationDate	datetime
AS

UPDATE [dbo].[MST_Course]

SET	[dbo].[MST_Course].[CourseName] = @CourseName
	,[dbo].[MST_Course].[CourseLevel] = @CourseLevel
	,[dbo].[MST_Course].[CourseDuration] = @CourseDuration
	,[dbo].[MST_Course].[Description] = @Description
	,[dbo].[MST_Course].[ModificationDate] = ISNULL(@ModificationDate,GETDATE())

WHERE [dbo].[MST_Course].[CourseID] = @CourseID
AND	[dbo].[MST_Course].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_CourseWiseDocument_DeleteByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_CourseWiseDocument_DeleteByPK] 3, 1

CREATE       PROCEDURE [dbo].[PR_MST_CourseWiseDocument_DeleteByPK]
	@CourseWiseDocumentID	int
	,@UserID				int

AS

DELETE FROM [dbo].[MST_CourseWiseDocument]

WHERE [dbo].[MST_CourseWiseDocument].[CourseWiseDocumentID] = @CourseWiseDocumentID
AND	[dbo].[MST_CourseWiseDocument].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_CourseWiseDocument_Insert]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_CourseWiseDocument_Insert] @CourseID=3, @DocumentID=3, @AdmissionYearID=3, @UserID=1, @Description=null, @CreationDate=null, @ModificationDate=null
--Select * from MST_CourseWiseDocument

Create     PROCEDURE [dbo].[PR_MST_CourseWiseDocument_Insert]
	@CourseID			int
	,@DocumentID		int
	,@AdmissionYearID	int
	,@UserID			int
	,@Description		nvarchar(100)
	,@CreationDate		datetime
	,@ModificationDate	datetime
AS

INSERT INTO [dbo].[MST_CourseWiseDocument]
(
	CourseID
	,DocumentID
	,AdmissionYearID
	,UserID
	,Description
	,CreationDate
	,ModificationDate
)

VALUES
(
	@CourseID			
	,@DocumentID
	,@AdmissionYearID		
	,@UserID		
	,@Description
	,ISNULL(@CreationDate,GETDATE())
	,ISNULL(@ModificationDate,GETDATE())
)
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_CourseWiseDocument_SelectAll]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_CourseWiseDocument_SelectAll] 1
--Select * from MST_CourseWiseDocument

CReate      PROCEDURE [dbo].[PR_MST_CourseWiseDocument_SelectAll]
	@UserID		int

AS

SELECT	[dbo].[MST_CourseWiseDocument].[CourseWiseDocumentID]
		,[dbo].[MST_CourseWiseDocument].[CourseID]
		,[dbo].[MST_Course].[CourseName]
		,[dbo].[MST_CourseWiseDocument].[DocumentID]
		,[dbo].[MST_Document].[DocumentName]
		,[dbo].[MST_CourseWiseDocument].[AdmissionYearID]
		,[dbo].[MST_AdmissionYear].[AdmissionYear]
		,[dbo].[MST_CourseWiseDocument].[Description]
		,[dbo].[MST_CourseWiseDocument].[CreationDate]
		,[dbo].[MST_CourseWiseDocument].[ModificationDate]

FROM	[dbo].[MST_CourseWiseDocument]

INNER JOIN [dbo].[MST_Course]
ON [dbo].[MST_Course].[CourseID] = [dbo].[MST_CourseWiseDocument].[CourseID]

INNER JOIN [dbo].[MST_Document]
ON [dbo].[MST_Document].[DocumentID] = [dbo].[MST_CourseWiseDocument].[DocumentID]

INNER JOIN [dbo].[MST_AdmissionYear]
ON [dbo].[MST_AdmissionYear].[AdmissionYearID] = [dbo].[MST_CourseWiseDocument].[AdmissionYearID]

WHERE [dbo].[MST_CourseWiseDocument].[UserID] = @UserID

ORDER BY [dbo].[MST_Course].[CourseName]
		 ,[dbo].[MST_Document].[DocumentName]
		 ,[dbo].[MST_AdmissionYear].[AdmissionYear]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_CourseWiseDocument_SelectByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_CourseWiseDocument_SelectByPK] 1, 1
--Select * From MST_CourseWiseDocument

CREATE      PROCEDURE [dbo].[PR_MST_CourseWiseDocument_SelectByPK]
	@CourseWiseDocumentID	int
	,@UserID				int

AS

SELECT	[dbo].[MST_CourseWiseDocument].[CourseWiseDocumentID]
		,[dbo].[MST_CourseWiseDocument].[CourseID]
		,[dbo].[MST_CourseWiseDocument].[DocumentID]
		,[dbo].[MST_CourseWiseDocument].[AdmissionYearID]
		,[dbo].[MST_CourseWiseDocument].[Description]
		,[dbo].[MST_CourseWiseDocument].[CreationDate]
		,[dbo].[MST_CourseWiseDocument].[ModificationDate]

FROM	[dbo].[MST_CourseWiseDocument]

WHERE [dbo].[MST_CourseWiseDocument].[CourseWiseDocumentID] = @CourseWiseDocumentID
AND [dbo].[MST_CourseWiseDocument].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_CourseWiseDocument_UpdateByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_CourseWiseDocument_UpdateByPK] @CourseWiseDocumentID=3, @CourseID=3, @DocumentID=2, @AdmissionYearID=2, @UserID=1, @Description=null, @ModificationDate=null
--Select * from MST_CourseWiseDocument

CREATE      PROCEDURE [dbo].[PR_MST_CourseWiseDocument_UpdateByPK]
	@CourseWiseDocumentID	int
	,@CourseID				int
	,@DocumentID			int
	,@AdmissionYearID		int
	,@UserID				int
	,@Description			nvarchar(100)
	,@ModificationDate		datetime
AS

UPDATE [dbo].[MST_CourseWiseDocument]

SET	[dbo].[MST_CourseWiseDocument].[CourseID] = @CourseID
	,[dbo].[MST_CourseWiseDocument].[DocumentID] = @DocumentID
	,[dbo].[MST_CourseWiseDocument].[AdmissionYearID] = @AdmissionYearID
	,[dbo].[MST_CourseWiseDocument].[Description] = @Description
	,[dbo].[MST_CourseWiseDocument].[ModificationDate] = ISNULL(@ModificationDate,GETDATE())

WHERE [dbo].[MST_CourseWiseDocument].[CourseWiseDocumentID] = @CourseWiseDocumentID
AND	[dbo].[MST_CourseWiseDocument].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Document_DeleteByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Document_DeleteByPK] 1, 1

CREATE        PROCEDURE [dbo].[PR_MST_Document_DeleteByPK]
	@DocumentID			int
	,@UserID			int

AS

DELETE FROM	[dbo].[MST_Document]

WHERE [dbo].[MST_Document].[DocumentID] = @DocumentID
AND	[dbo].[MST_Document].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Document_Insert]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Document_Insert] @UserID=1, @DocumentName='HSC Marksheet', @Description=null, @CreationDate=null, @ModificationDate=null
--Select * from MST_Document

CREATE         PROCEDURE [dbo].[PR_MST_Document_Insert]
	@UserID				int
	,@DocumentName		nvarchar(100)
	,@Description		nvarchar(100)
	,@CreationDate		datetime
	,@ModificationDate	datetime
AS

INSERT INTO [dbo].[MST_Document]
(
	UserID
	,DocumentName
	,Description
	,CreationDate
	,ModificationDate
)

VALUES
(			
	@UserID
	,@DocumentName
	,@Description
	,ISNULL(@CreationDate,GETDATE())
	,ISNULL(@ModificationDate,GETDATE())
)
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Document_SelectAll]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Document_SelectAll] 2

CREATE       procedure [dbo].[PR_MST_Document_SelectAll]
	@UserID		int

AS

SELECT
		[dbo].[MST_Document].[DocumentID]
		,[dbo].[MST_Document].[DocumentName]
		,[dbo].[MST_Document].[Description]
		,[dbo].[MST_Document].[CreationDate]
		,[dbo].[MST_Document].[ModificationDate]

FROM	[dbo].[MST_Document]

WHERE [dbo].[MST_Document].[UserID] = @UserID

ORDER BY	[dbo].[MST_Document].[DocumentName]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Document_SelectByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Document_SelectByPK] 2, 1

CREATE       procedure [dbo].[PR_MST_Document_SelectByPK]
	@DocumentID		int
	,@UserID		int

AS

SELECT
		[dbo].[MST_Document].[DocumentID]
		,[dbo].[MST_Document].[DocumentName]
		,[dbo].[MST_Document].[Description]
		,[dbo].[MST_Document].[CreationDate]
		,[dbo].[MST_Document].[ModificationDate]

FROM	[dbo].[MST_Document]

WHERE [dbo].[MST_Document].[UserID] = @UserID
AND	[dbo].[MST_Document].[DocumentID] = @DocumentID

ORDER BY	[dbo].[MST_Document].[DocumentName]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Document_SelectForDropDown]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Document_SelectForDropDown] 2

CREATE       procedure [dbo].[PR_MST_Document_SelectForDropDown]
	@UserID		int

AS

SELECT
		[dbo].[MST_Document].[DocumentID]
		,[dbo].[MST_Document].[DocumentName]

FROM	[dbo].[MST_Document]

WHERE [dbo].[MST_Document].[UserID] = @UserID

ORDER BY	[dbo].[MST_Document].[DocumentName]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Document_UpdateByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[PR_MST_Document_UpdateByPK] @DocumentID=1, @UserID=1, @DocumentName='10th Marksheet', @Description=null, @ModificationDate=null

CREATE        PROCEDURE [dbo].[PR_MST_Document_UpdateByPK]
	@DocumentID			int
	,@UserID			int
	,@DocumentName		nvarchar(100)
	,@Description		nvarchar(100)
	,@ModificationDate	datetime
AS

UPDATE [dbo].[MST_Document]

SET	[dbo].[MST_Document].[DocumentName] = @DocumentName
	,[dbo].[MST_Document].[Description] = @Description
	,[dbo].[MST_Document].[ModificationDate] = ISNULL(@ModificationDate,GETDATE())

WHERE [dbo].[MST_Document].[DocumentID] = @DocumentID
AND	[dbo].[MST_Document].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Program_DeleteByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Program_DeleteByPK] 1, 1
--Select * from MST_Program

CREATE       PROCEDURE [dbo].[PR_MST_Program_DeleteByPK]
	@ProgramID	int
	,@UserID	int

AS

DELETE FROM [dbo].[MST_Program]

WHERE [dbo].[MST_Program].[ProgramID] = @ProgramID
AND	[dbo].[MST_Program].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Program_Insert]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Program_Insert] @CourseID="2", @UserID=1, @ProgramName='Computer Engineering', @Description=null, @CreationDate=null, @ModificationDate=null
--Select * From MST_Program
CREATE     PROCEDURE [dbo].[PR_MST_Program_Insert]
	@CourseID			int
	,@UserID			int
	,@ProgramName		nvarchar(100)
	,@Description		nvarchar(100)
	,@CreationDate		datetime
	,@ModificationDate	datetime
AS

INSERT INTO [dbo].[MST_Program]
(
	CourseID
	,UserID
	,ProgramName
	,Description
	,CreationDate
	,ModificationDate
)

VALUES
(
	@CourseID
	,@UserID
	,@ProgramName
	,@Description
	,ISNULL(@CreationDate,GETDATE())
	,ISNULL(@ModificationDate,GETDATE())
)
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Program_SelectAll]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Program_SelectAll] 1
--Select * from MST_Program

CREATE      PROCEDURE [dbo].[PR_MST_Program_SelectAll]
	@UserID		int

AS

SELECT	[dbo].[MST_Program].[ProgramID]
		,[dbo].[MST_Program].[ProgramName]
		,[dbo].[MST_Program].[CourseID]
		,[dbo].[MST_Course].[CourseName]
		,[dbo].[MST_Program].[Description]
		,[dbo].[MST_Program].[CreationDate]
		,[dbo].[MST_Program].[ModificationDate]

FROM	[dbo].[MST_Program]

INNER JOIN [dbo].[MST_Course]
ON [dbo].[MST_Course].[CourseID] = [dbo].[MST_Program].[CourseID]

WHERE [dbo].[MST_Program].[UserID] = @UserID

ORDER BY [dbo].[MST_Course].[CourseName]
		 ,[dbo].[MST_Program].[ProgramName]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Program_SelectByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Program_SelectByPK] 2, 1

CREATE      PROCEDURE [dbo].[PR_MST_Program_SelectByPK]
	@ProgramID		int
	,@UserID		int

AS

SELECT	[dbo].[MST_Program].[ProgramID]
		,[dbo].[MST_Program].[ProgramName]
		,[dbo].[MST_Program].[CourseID]
		,[dbo].[MST_Program].[Description]
		,[dbo].[MST_Program].[CreationDate]
		,[dbo].[MST_Program].[ModificationDate]

FROM	[dbo].[MST_Program]

WHERE [dbo].[MST_Program].[ProgramID] = @ProgramID
AND [dbo].[MST_Program].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Program_SelectDropDownByCourseID]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Program_SelectDropDownByCourseID] 2, 1
--Select * from MST_Program
CREATE      PROCEDURE [dbo].[PR_MST_Program_SelectDropDownByCourseID]
	@CourseID	int
	,@UserID	int

AS

SELECT	[dbo].[MST_Program].[ProgramID]
		,[dbo].[MST_Program].[ProgramName]

FROM	[dbo].[MST_Program]

WHERE	[dbo].[MST_Program].[CourseID] = @CourseID
AND [dbo].[MST_Program].[UserID] = @UserID

ORDER BY [dbo].[MST_Program].[ProgramName]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Program_SelectForDropDown]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Program_SelectForDropDown] 1

CREATE     PROCEDURE [dbo].[PR_MST_Program_SelectForDropDown]
	@UserID		int

AS

SELECT	[dbo].[MST_Program].[ProgramID]
		,[dbo].[MST_Program].[ProgramName]

FROM [dbo].[MST_Program]

WHERE [dbo].[MST_Program].[UserID] = @UserID

ORDER BY [dbo].[MST_Program].[ProgramName]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Program_UpdateByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Program_UpdateByPK] @ProgramID=2, @CourseID=4, @UserID=1, @ProgramName='Civil Engineering', @Description=null, @ModificationDate=null
--Select * from MST_Program

CREATE      PROCEDURE [dbo].[PR_MST_Program_UpdateByPK]
	@ProgramID			int
	,@CourseID			int
	,@UserID			int
	,@ProgramName		nvarchar(100)
	,@Description		nvarchar(100)
	,@ModificationDate	datetime
AS

UPDATE [dbo].[MST_Program]

SET	[dbo].[MST_Program].[CourseID] = @CourseID
	,[dbo].[MST_Program].[ProgramName] = @ProgramName
	,[dbo].[MST_Program].[Description] = @Description
	,[dbo].[MST_Program].[ModificationDate] = ISNULL(@ModificationDate,GETDATE())

WHERE [dbo].[MST_Program].[ProgramID] = @ProgramID
AND	[dbo].[MST_Program].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Qualification_DeleteByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Qualification_DeleteByPK] 1, 1

CREATE      PROCEDURE [dbo].[PR_MST_Qualification_DeleteByPK]
	@QualificationID	int
	,@UserID			int

AS

DELETE FROM	[dbo].[MST_Qualification]

WHERE [dbo].[MST_Qualification].[QualificationID] = @QualificationID
AND	[dbo].[MST_Qualification].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Qualification_Insert]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Qualification_Insert] @UserID=1, @QualificationName='UG', @Description=null, @CreationDate=null, @ModificationDate=null
--Select * from MST_Qualification

CREATE     PROCEDURE [dbo].[PR_MST_Qualification_Insert]
	@UserID				int
	,@QualificationName	nvarchar(100)
	,@Description		nvarchar(100)
	,@CreationDate		datetime
	,@ModificationDate	datetime
AS

INSERT INTO [dbo].[MST_Qualification]
(
	UserID
	,QualificationName
	,Description
	,CreationDate
	,ModificationDate
)

VALUES
(			
	@UserID
	,@QualificationName		
	,@Description
	,ISNULL(@CreationDate,GETDATE())
	,ISNULL(@ModificationDate,GETDATE())
)
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Qualification_SelectAll]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Qualification_SelectAll] 1

CREATE   PROCEDURE [dbo].[PR_MST_Qualification_SelectAll]
	@UserID		int

AS

SELECT
		[dbo].[MST_Qualification].[QualificationID]
		,[dbo].[MST_Qualification].[QualificationName]
		,[dbo].[MST_Qualification].[Description]
		,[dbo].[MST_Qualification].[CreationDate]
		,[dbo].[MST_Qualification].[ModificationDate]

FROM	[dbo].[MST_Qualification]

WHERE [dbo].[MST_Qualification].[UserID] = @UserID

ORDER BY	[dbo].[MST_Qualification].[QualificationName]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Qualification_SelectByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Qualification_SelectByPK] 1

CREATE   PROCEDURE [dbo].[PR_MST_Qualification_SelectByPK]
	@QualificationID	int
	,@UserID				int

AS

SELECT
		[dbo].[MST_Qualification].[QualificationID]
		,[dbo].[MST_Qualification].[QualificationName]
		,[dbo].[MST_Qualification].[Description]
		,[dbo].[MST_Qualification].[CreationDate]
		,[dbo].[MST_Qualification].[ModificationDate]

FROM	[dbo].[MST_Qualification]

WHERE [dbo].[MST_Qualification].[UserID] = @UserID
AND	[dbo].[MST_Qualification].[QualificationID] = @QualificationID

ORDER BY	[dbo].[MST_Qualification].[QualificationName]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Qualification_SelectForDropDown]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Qualification_SelectForDropDown] 1

CREATE     procedure [dbo].[PR_MST_Qualification_SelectForDropDown]
	@UserID		int

AS

SELECT
		[dbo].[MST_Qualification].[QualificationID]
		,[dbo].[MST_Qualification].[QualificationName]

FROM	[dbo].[MST_Qualification]

WHERE [dbo].[MST_Qualification].[UserID] = @UserID

ORDER BY	[dbo].[MST_Qualification].[QualificationName]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Qualification_UpdateByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[PR_MST_Qualification_UpdateByPK] @QualificationID=1, @UserID=1, @QualificationName='Phd', @Description=null, @ModificationDate=null

CREATE        PROCEDURE [dbo].[PR_MST_Qualification_UpdateByPK]
	@QualificationID	int
	,@UserID			int
	,@QualificationName	nvarchar(100)
	,@Description		nvarchar(100)
	,@ModificationDate	datetime
AS

UPDATE [dbo].[MST_Qualification]

SET	[dbo].[MST_Qualification].[QualificationName] = @QualificationName
	,[dbo].[MST_Qualification].[Description] = @Description
	,[dbo].[MST_Qualification].[ModificationDate] = ISNULL(@ModificationDate,GETDATE())

WHERE [dbo].[MST_Qualification].[QualificationID] = @QualificationID
AND	[dbo].[MST_Qualification].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Quota_DeleteByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Quota_DeleteByPK] 1, 1
--Select * From MST_Quota

CREATE       PROCEDURE [dbo].[PR_MST_Quota_DeleteByPK]
	@QuotaID	int
	,@UserID	int

AS

DELETE FROM [dbo].[MST_Quota]

WHERE [dbo].[MST_Quota].[QuotaID] = @QuotaID
AND	[dbo].[MST_Quota].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Quota_Insert]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Quota_Insert] @CourseID=2, @UserID=1, @QuotaName='Management', @Description=null, @CreationDate=null, @ModificationDate=null
--Select * from MST_Quota

CREATE     PROCEDURE [dbo].[PR_MST_Quota_Insert]
	@CourseID			int
	,@UserID			int
	,@QuotaName			nvarchar(100)
	,@Description		nvarchar(100)
	,@CreationDate		datetime
	,@ModificationDate	datetime
AS

INSERT INTO [dbo].[MST_Quota]
(
	CourseID
	,UserID
	,QuotaName
	,Description
	,CreationDate
	,ModificationDate
)

VALUES
(
	@CourseID			
	,@UserID
	,@QuotaName		
	,@Description
	,ISNULL(@CreationDate,GETDATE())
	,ISNULL(@ModificationDate,GETDATE())
)
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Quota_SelectAll]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Quota_SelectAll] 1
--Select * from MST_Quota

CREATE      PROCEDURE [dbo].[PR_MST_Quota_SelectAll]
	@UserID		int

AS

SELECT	[dbo].[MST_Quota].[QuotaID]
		,[dbo].[MST_Quota].[QuotaName]
		,[dbo].[MST_Quota].[CourseID]
		,[dbo].[MST_Course].[CourseName]
		,[dbo].[MST_Quota].[Description]
		,[dbo].[MST_Quota].[CreationDate]
		,[dbo].[MST_Quota].[ModificationDate]

FROM	[dbo].[MST_Quota]

INNER JOIN [dbo].[MST_Course]
ON [dbo].[MST_Course].[CourseID] = [dbo].[MST_Quota].[CourseID]

WHERE [dbo].[MST_Quota].[UserID] = @UserID

ORDER BY [dbo].[MST_Quota].[QuotaName]
		,[dbo].[MST_Course].[CourseName]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Quota_SelectByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Quota_SelectByPK] 2, 1
--Select * From MST_Quota

CREATE      PROCEDURE [dbo].[PR_MST_Quota_SelectByPK]
	@QuotaID	int
	,@UserID	int

AS

SELECT	[dbo].[MST_Quota].[QuotaID]
		,[dbo].[MST_Quota].[QuotaName]
		,[dbo].[MST_Quota].[CourseID]
		,[dbo].[MST_Quota].[Description]
		,[dbo].[MST_Quota].[CreationDate]
		,[dbo].[MST_Quota].[ModificationDate]

FROM	[dbo].[MST_Quota]

WHERE [dbo].[MST_Quota].[QuotaID] = @QuotaID
AND [dbo].[MST_Quota].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Quota_SelectForDropDown]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Quota_SelectForDropDown] 1
--Select * From MST_Quota

CREATE     PROCEDURE [dbo].[PR_MST_Quota_SelectForDropDown]
	@UserID		int

AS

SELECT	[dbo].[MST_Quota].[QuotaID]
		,[dbo].[MST_Quota].[QuotaName]

FROM [dbo].[MST_Quota]

WHERE [dbo].[MST_Quota].[UserID] = @UserID

ORDER BY [dbo].[MST_Quota].[QuotaName]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Quota_UpdateByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Quota_UpdateByPK] @QuotaID=1, @CourseID=2, @UserID=1, @QuotaName='General', @Description=null, @ModificationDate=null
--Select * from MST_Quota

CREATE      PROCEDURE [dbo].[PR_MST_Quota_UpdateByPK]
	@QuotaID			int
	,@CourseID			int
	,@UserID			int
	,@QuotaName			nvarchar(100)
	,@Description		nvarchar(100)
	,@ModificationDate	datetime
AS

UPDATE [dbo].[MST_Quota]

SET	[dbo].[MST_Quota].[CourseID] = @CourseID
	,[dbo].[MST_Quota].[QuotaName] = @QuotaName
	,[dbo].[MST_Quota].[Description] = @Description
	,[dbo].[MST_Quota].[ModificationDate] = ISNULL(@ModificationDate,GETDATE())

WHERE [dbo].[MST_Quota].[QuotaID] = @QuotaID
AND	[dbo].[MST_Quota].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Staff_DeleteByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Staff_DeleteByPK] 1, 1
--Select * From MST_Staff

CREATE        PROCEDURE [dbo].[PR_MST_Staff_DeleteByPK]
	@StaffID	int
	,@UserID	int

AS

DELETE FROM	[dbo].[MST_Staff]

WHERE [dbo].[MST_Staff].[StaffID] = @StaffID
AND	[dbo].[MST_Staff].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Staff_Insert]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Staff_Insert] @UserID=1, @StaffName='ABC', @Phone="12341234", @Email="demo@demo.com", @StaffCode="1", @Description=null, @CreationDate=null, @ModificationDate=null
--Select * from MST_Staff

CREATE       PROCEDURE [dbo].[PR_MST_Staff_Insert]
	@UserID				int
	,@StaffName			nvarchar(100)
	,@Phone				nvarchar(50)
	,@Email				nvarchar(100)
	,@StaffCode			nvarchar(50)
	,@Description		nvarchar(100)
	,@CreationDate		datetime
	,@ModificationDate	datetime
AS

INSERT INTO [dbo].[MST_Staff]
(
	UserID
	,StaffName
	,Phone
	,Email
	,StaffCode
	,Description
	,CreationDate
	,ModificationDate
)

VALUES
(			
	@UserID
	,@StaffName
	,@Phone
	,@Email
	,@StaffCode
	,@Description
	,ISNULL(@CreationDate,GETDATE())
	,ISNULL(@ModificationDate,GETDATE())
)
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Staff_SelectAll]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Staff_SelectAll] 1

CREATE     procedure [dbo].[PR_MST_Staff_SelectAll]
	@UserID		int

AS

SELECT
		[dbo].[MST_Staff].[StaffID]
		,[dbo].[MST_Staff].[StaffName]
		,[dbo].[MST_Staff].[Phone]
		,[dbo].[MST_Staff].[Email]
		,[dbo].[MST_Staff].[StaffCode]
		,[dbo].[MST_Staff].[Description]
		,[dbo].[MST_Staff].[CreationDate]
		,[dbo].[MST_Staff].[ModificationDate]

FROM	[dbo].[MST_Staff]

WHERE [dbo].[MST_Staff].[UserID] = @UserID

ORDER BY	[dbo].[MST_Staff].[StaffName]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Staff_SelectByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Staff_SelectByPK] 1, 2

CREATE     procedure [dbo].[PR_MST_Staff_SelectByPK]
	@UserID		int
	,@StaffID	int

AS

SELECT
		[dbo].[MST_Staff].[StaffID]
		,[dbo].[MST_Staff].[StaffName]
		,[dbo].[MST_Staff].[Phone]
		,[dbo].[MST_Staff].[Email]
		,[dbo].[MST_Staff].[StaffCode]
		,[dbo].[MST_Staff].[Description]
		,[dbo].[MST_Staff].[CreationDate]
		,[dbo].[MST_Staff].[ModificationDate]

FROM	[dbo].[MST_Staff]

WHERE [dbo].[MST_Staff].[UserID] = @UserID
AND [dbo].[MST_Staff].[StaffID] = @StaffID

ORDER BY	[dbo].[MST_Staff].[StaffName]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Staff_SelectForDropDown]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_Staff_SelectForDropDown] 1

CREATE     procedure [dbo].[PR_MST_Staff_SelectForDropDown]
	@UserID		int

AS

SELECT
		[dbo].[MST_Staff].[StaffID]
		,[dbo].[MST_Staff].[StaffName]

FROM	[dbo].[MST_Staff]

WHERE [dbo].[MST_Staff].[UserID] = @UserID

ORDER BY	[dbo].[MST_Staff].[StaffName]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_Staff_UpdateByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[PR_MST_Staff_UpdateByPK] @StaffID=1, @UserID=1, @StaffName="CDV", @Phone="3224456679", @Email="a@a.a", @StaffCode="324", @Description=null, @ModificationDate=null

CREATE     PROCEDURE [dbo].[PR_MST_Staff_UpdateByPK]
	@StaffID			int
	,@UserID			int
	,@StaffName			nvarchar(100)
	,@Phone				nvarchar(50)
	,@Email				nvarchar(100)
	,@StaffCode			nvarchar(50)
	,@Description		nvarchar(100)
	,@ModificationDate	datetime
AS

UPDATE [dbo].[MST_Staff]

SET	[dbo].[MST_Staff].[StaffName] = @StaffName
	,[dbo].[MST_Staff].[Phone] = @Phone
	,[dbo].[MST_Staff].[Email] = @Email
	,[dbo].[MST_Staff].[StaffCode] = @StaffCode
	,[dbo].[MST_Staff].[Description] = @Description
	,[dbo].[MST_Staff].[ModificationDate] = ISNULL(@ModificationDate,GETDATE())

WHERE [dbo].[MST_Staff].[StaffID] = @StaffID
AND	[dbo].[MST_Staff].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_User_DeleteByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_User_DeleteByPK] @UserID=3
--Select * From MST_User

CREATE      PROCEDURE [dbo].[PR_MST_User_DeleteByPK]
	@UserID	int

AS

DELETE FROM	[dbo].[MST_User]

WHERE [dbo].[MST_User].[UserID] = @UserID
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_User_Insert]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_User_Insert] @UserName='demo@demo.com', @Password='12121212', @Name="Hemang", @CreationDate=null, @ModificationDate=null

CREATE     PROCEDURE [dbo].[PR_MST_User_Insert]
	@UserName			nvarchar(100)
	,@Password			nvarchar(100)
	,@Name				nvarchar(100)
	,@CreationDate		datetime
	,@ModificationDate	datetime

AS

INSERT INTO	[dbo].[MST_User]
(
	UserName
	,Password
	,Name
	,CreationDate
	,ModificationDate
)

VALUES
(
	@UserName
	,@Password
	,@Name
	,ISNULL(@CreationDate,GETDATE())
	,ISNULL(@ModificationDate,GETDATE())
)
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_User_SelectAll]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_User_SelectAll]

CREATE     PROCEDURE [dbo].[PR_MST_User_SelectAll]
	AS

SELECT [dbo].[MST_User].[UserID]
	,[dbo].[MST_User].[UserName]
	,[dbo].[MST_User].[Password]
	,[dbo].[MST_User].[Name]
	,[dbo].[MST_User].[CreationDate]
	,[dbo].[MST_User].[ModificationDate]

FROM [dbo].[MST_User]

ORDER BY [dbo].[MST_User].[UserName]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_User_SelectByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_User_SelectByPK] @UserID=3

CREATE     PROCEDURE [dbo].[PR_MST_User_SelectByPK]
	@UserID		int

AS

SELECT [dbo].[MST_User].[UserID]
	,[dbo].[MST_User].[UserName]
	,[dbo].[MST_User].[Password]
	,[dbo].[MST_User].[Name]
	,[dbo].[MST_User].[CreationDate]
	,[dbo].[MST_User].[ModificationDate]

FROM [dbo].[MST_User]

WHERE [dbo].[MST_User].[UserID] = @UserID

ORDER BY [dbo].[MST_User].[UserName]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_User_SelectByUserNamePassword]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_User_SelectByUserNamePassword] @UserName='Hemang', @Password=null

CREATE     PROCEDURE [dbo].[PR_MST_User_SelectByUserNamePassword]
	@UserName		nvarchar(100)
	,@Password		nvarchar(100)

AS

SELECT [dbo].[MST_User].[UserID]
	,[dbo].[MST_User].[UserName]
	,[dbo].[MST_User].[Password]
	,[dbo].[MST_User].[Name]
	,[dbo].[MST_User].[CreationDate]
	,[dbo].[MST_User].[ModificationDate]

FROM [dbo].[MST_User]

WHERE (@UserName IS NULL OR [dbo].[MST_User].[UserName] LIKE '%'+@UserName+'%')
AND	(@Password IS NULL OR [dbo].[MST_User].[Password] LIKE '%'+@Password+'%')

ORDER BY [dbo].[MST_User].[UserName]
GO
/****** Object:  StoredProcedure [dbo].[PR_MST_User_UpdateByPK]    Script Date: 1/18/2025 2:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Created by Hemang Kateshiya
--[dbo].[PR_MST_User_UpdateByPK] @UserID=1, @UserName='hemang@h.com', @Password='12345678', @Name='HK', @ModificationDate=null

CREATE     PROCEDURE [dbo].[PR_MST_User_UpdateByPK]
	@UserID				int
	,@UserName			nvarchar(100)
	,@Password			nvarchar(100)
	,@Name				nvarchar(100)
	,@ModificationDate	datetime

AS

UPDATE	[dbo].[MST_User]

SET [dbo].[MST_User].[UserName] = @UserName
	,[dbo].[MST_User].[Password] = @Password
	,[dbo].[MST_User].[Name] = @Name
	,[dbo].[MST_User].[ModificationDate] = ISNULL(@ModificationDate,GETDATE())

WHERE	[dbo].[MST_User].[UserID] = @UserID
GO
USE [master]
GO
ALTER DATABASE [StudyTrickDB] SET  READ_WRITE 
GO
