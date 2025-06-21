CREATE TABLE [dbo].[CourseDetails] (
    [course_id]       VARCHAR (50) NOT NULL,
    [course_name]     VARCHAR (50) NOT NULL,
    [course_category] VARCHAR (50) NOT NULL, 
    CONSTRAINT [PK_CourseDetails] PRIMARY KEY ([course_id])
);

