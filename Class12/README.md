# Class 12

## Learning Objectives
1. Students will create their own Database ERD given a problem domain
2. Students will learn and apply the differences between primary keys, foreign key, and composite keys.
3. The students will know the difference between a relational and non-relational database. 

## Lecture Outline

## What is a Database

### Different Kinds of Databases
1. Relational
		- SQL Server
2. Non-Relational
		- SQLLite

### Relational vs Non-Relational

1. Relational
	- Relational databases are databases where each table can hold a relationship with another. This is usually done through some sort of unique identifier that can require a row of each table to stay unique even after the many different transactions that process through. This allows for separation of concerns within a database and ability to manipulate individual parts of a grouped together information

2. Non-Relational
	- Non Relational databases don't depend on relationships or keys between tables. NoSQL is an example, and all the information is stored in one "document" that makes it potentially easier to group together information without having to join tables. 
	Examples: Big Data, and Real Time Applications

## Representation
We can represent a relational database through a database ERD. 
	
1. 1:1
2. Many:Many
3. 1:Many
4. Many:1

### Keys
1. Primary Keys
	 - Unique identifier for a specific table. Usually named `Id`.
	 - Each row of the table will have it's own unique primary key.
2. Foreign Key
	- Unique identifier from another table.
	- Often used to join tables within a query and associate table data. 
	- Naming convention is the name of the table plus the word Id. Example: BookId is a foreign key in the Library Table. In the Book table, it is simply `Id`. 
3. Composite Key (New!)
	- A combination of columns that make up a unique identifier for a table
	- Composite keys usually consist of multiple foreign keys combined together. No Primary key needs to be included in the combination. 
	- You do not necessarily need to include a primary key in a table that utilizes a composite key.

### Create a Database ERD

Together, In class, create a database ERD given a problem domain. 

### Problem Domain

This week, we will be building out a student enrollment system 
in class. Here is our problem domain:

You have been tasked to create a system for a new coding school 
in your neighborhood. While gathering requirements, 
you were able to learn how the school plans on managing their 
enrollment. Here is what you gathered: 

The coding school will gather information from each student. 
Their system requires the student's first name, last name and 
birthdate. 
Each course that the coding school will offer has a Name, 
specific course code, and the price that the course will cost.
In addition, each course will be associated with a specific technology,
the options for the technology are predetermined dependent on the 
stacks being taught. 
 
A student can be enrolled in multiple courses and once a student
has completed a course, their final grade and if they passed 
is captured in a single transcript. A student can have many transcripts
associted with them. It is also safe to say 
that once a course is completed, the system will generate a 
transcript for every student that was present in the course. 
The transcript should independently store the student's information,
course information, The grade they received, and if they passed or not. 


Using the information you received above, create a database 
ERD that will accurately represent the data that will be 
held and accessed for this student enrollment system for the 
school. 