#Part 1
#list columns and what data types they contain in the jobs table 
#open the jobs table and click on the field types tab
#Columns: DataType
#Id: INT
#Name: TEXT or VARCHAR
#EmployerId: INT

#Part 2 write a query to list the names of the employers in St. Louis City.
SELECT Name
From employers
Where Location = "St. Louis";

#Part 3 write a query to return a list of the names and descriptions of all skills that 
#are attached to jobs in alphabetical order. If a skill does not have a job listed, 
#it should not be included in the results of this query.
SELECT Name, Description
FROM skills
Left JOIN jobskills on skills.Id = jobskills.SkillId where jobskills.JobId IS NOT NULL
order by Name ASC;