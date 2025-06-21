CREATE TABLE [dbo].[TeacherDetails] (
    [teacher_id]         NCHAR (13)    NOT NULL,
    [teacher_name]       VARCHAR (MAX) NULL,
    [teacher_gender]     VARCHAR (50)  NULL,
    [course_id]     VARCHAR (50)  NULL,
    [teacher_department] VARCHAR (50)  NULL,
    [teacher_num]        NCHAR (10)    NULL,
    PRIMARY KEY CLUSTERED ([teacher_id] ASC)
);

