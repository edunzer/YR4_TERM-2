## EXAM 2

Question 1
1 / 1 pts
Code a single statement that creates a SQL Server parameter named ProductCode with the value in a variable named productCode and adds it to the collection of parameters in a command named selectCommand.
 
____________________________________________________________________
selectCommand.Parameters.AddWithValue("@ProductCode", productCode);
 
Question 2
1 / 1 pts
A _________________ lets you include variable information in a SQL statement.
parameter
 
Question 3
1 / 1 pts
The SQL statements that insert, update, and delete data are known as ___________________ queries.
action
 
IncorrectQuestion 4
0 / 1 pts
To create a data reader object, you use one of the methods of the ______________ object for a Select statement.
executereader
 
Question 5
1 / 1 pts
How is a parameter in a parameterized query for a SQL Server data adapter identified?

  by a named variable that begins with an at sign (@) 

Question 6
1 / 1 pts
Write the code for a parameter named UserName as it would appear in a SELECT statement for a SQL Server database.
@UserName
 
Question 7
1 / 1 pts
Which of the following can not be set in a SQL Server connection string?

  command type 
 
Question 8
1 / 1 pts
Given a SqlCommand object named updateCommand that contains a valid SQL Update statement, which of the following statements executes the Update statement and returns the number of rows that were affected by that statement?

  int count = updateCommand.ExecuteNonQuery();
 
Question 9
1 / 1 pts
What method of the BinaryReader class do you use to read an int value from a binary file?

  ReadInt32 

 
Question 10
1 / 1 pts
What method of the BinaryReader class do you use to read a decimal value from a binary file?

  ReadDecimal 

 
Question 11
1 / 1 pts
Which of the following is not the cause of a common I/O exception?

  The path is too long. 
 
Question 12
1 / 1 pts
The primary difference between a text file and a binary file is that a binary file

  stores data with different data types 
 
Question 13
1 / 1 pts
What namespace does the .NET Framework use to store classes that work with input and output operations?

  System.IO

Question 14
1 / 1 pts
If the numbersFile string refers to a file that contains three integers, how many integers will that file contain when the code that follows is executed?
 
BinaryWriter binaryOut =
new BinaryWriter(
new FileStream(numbersFile, FileMode.Create));
 
binaryOut.Write(4);
binaryOut.Close();
 
  1 
 
Question 15
1 / 1 pts
Assume that you have a valid StreamWriter object named textOut. What does the following code do?
 
textOut.Write("Wizard of Oz");
textOut.Write("\t");
textOut.WriteLine("1939");

  Writes a record that consists of two tab-delimited fields to a text file 

Question 16
1 / 1 pts
To read a text file, you need to use a FileStream object and a

  StreamReader object 

Question 17
1 / 1 pts
To get the value of an attribute when you’re using an XmlReader object to read an XML document, you can use the

  the indexer with a name argument 
 
Question 18
1 / 1 pts
XML stands for __________________.
extensible markup language
 
Question 19
1 / 1 pts
Spaces, tabs, and return characters are known as ________________.
white space
 
Question 20
1 / 1 pts
Which of the following statements is not true?

  Attributes are more convenient than child elements for long string values. 
 
IncorrectQuestion 21
0 / 1 pts
A complete XML element consists of a start tag, ________________, and an end tag.
child element
 
Question 22
1 / 1 pts
Consider the following code example:
 
<?xml version="1.0" encoding="utf-8" ?>
<!--Episode data-->
<Episodes>
    <Episode Number="I">
        <Title>The Phantom Menace</Title>
        <Year>1999</Year>
    </Episode>
    <Episode Number="II">
        <Title>Attack of the Clones</Title>
        <Year>2002</Year>
    </Episode>
    <Episode Number="III">
        <Title>Revenge of the Sith</Title>
        <Year>2002</Year>
    </Episode>
    <Episode Number="IV">
        <Title>A New Hope</Title>
        <Year>1977</Year>
    </Episode>
    <Episode Number="V">
        <Title>The Empire Strikes Back</Title>
        <Year>1980</Year>
    </Episode>
    <Episode Number="VI">
        <Title>Return of the Jedi</Title>
        <Year>1983</Year>
    </Episode>
</Episodes>
 
What is the content of the first Year element?

  1999 

 
Question 23
1 / 1 pts
The highest parent element in an XML document is the ____________________________.
root element 
 
Question 24
1 / 1 pts
When using an XmlWriter object to write an XML document, which method or methods can you use to write a child element that contains content?

  WriteElementString 

 
Question 25
1 / 1 pts
In Visual Studio, you can use the _________________ to create or edit an XML document.
XML editor 
