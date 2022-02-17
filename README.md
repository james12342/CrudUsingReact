# CrudUsingReact
ASP.NET MVC+ Web Api+ React+ Sqlserver

1.Create a table in the database
 
Open SQL Server Management Studio, create a database named "CrudDemo", and in this database, create a table. Give that table a name like "studentmaster". 
USE [CrudDemo]  
GO  
CREATE TABLE [dbo].[studentmaster](  
    [Id] [int] IDENTITY(1,1) NOT NULL,  
    [Name] [varchar](50) NULL,  
    [RollNo] [varchar](50) NULL,  
    [Class] [varchar](50) NULL,  
    [Address] [varchar](50) NULL,  
 CONSTRAINT [PK_studentmaster] PRIMARY KEY CLUSTERED   
(  
    [Id] ASC  
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]  
) ON [PRIMARY]  
  
GO  
2.Then run the backend and react(front end), note:backend has it's own view


