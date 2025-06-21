CREATE TABLE [dbo].[StudentDetails] (
    [student_id]      VARCHAR(50)          NOT NULL,
    [student_name]    VARCHAR (50) NOT NULL,
    [student_gender]  VARCHAR (50) NOT NULL,
    [student_course]  VARCHAR (50) NOT NULL,
    [student_number]  VARCHAR(50)          NOT NULL,
    [student_address] VARCHAR(50) NOT NULL,
    PRIMARY KEY CLUSTERED ([student_id] ASC)
);

