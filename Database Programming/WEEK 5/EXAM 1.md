## EXAM 1

Question 1
1 / 1 pts
When you use the .NET data provider objects to retrieve data from a database, you can store the data in an object called a

  dataset


Question 2
1 / 1 pts
To modify the data in one or more rows of a table in a database, you use the SQL _______________ statement.

update

Question 3
1 / 1 pts
Consider the following code example:

Select VendorName, InvoiceNumber, InvoiceDate, InvoiceTotal
From Vendors Inner Join Invoices
    On Vendors.VendorID = Invoices.VendorID
Where InvoiceTotal >= 500
Order By VendorName Desc

What table(s) does the data in the result set come from?

  Vendors and Invoices

Question 4
1 / 1 pts
What does a relational database use to uniquely identify each row in a table?

  primary keys

Question 5
1 / 1 pts
What type of concurrency does ADO.NET use by default to check whether a row has changed before an update or delete operation is performed?

  optimistic


Question 6
1 / 1 pts
When you drag a data source table whose columns are associated with individual controls to a form, Visual Studio automatically adds the controls along with __________________ that identify the controls.

labels

UnansweredQuestion 7
0 / 1 pts
When you create a connection to a database, you have the option of saving the connection string to the ________________ file.

Question 8
1 / 1 pts
Because Visual Studio uses a disconnected data architecture when you use data sources, optimistic concurrency is implemented by

  the generated SQL statements


Question 9
1 / 1 pts
The Fill method of a table adapter object that’s working with a SQL Server database will throw errors of the
  SqlException class


Question 10
1 / 1 pts
In general, there are two categories of data errors that occur when you use a data source: data provider errors and _______________ errors.

ADO.NET

IncorrectQuestion 11
0 / 1 pts
When a DataGridView control raises a DataError event, the event handler should normally

  display a message that gives the row and column of the field that caused the error
  disable the UpdateAll method so the row won’t be updated
  refresh the DataGridView control so the user can re-enter the data for the current row


Question 12
1 / 1 pts
By default, the Data Source Configuration Wizard generates ____________________ statements after Insert and Update statements to refresh the dataset with the changes made to the database.

Select

Question 13
1 / 1 pts
When you use a data source, the SQL statements that are used to retrieve and update rows can be found in the SelectCommand and UpdateCommand properties of the

  table adapter


Question 14
1 / 1 pts
When a DBConcurrencyException is caught, your code should normally display a message to the user that indicates that some rows weren’t updated and then

  use the Fill method to retrieve the current data from the database

Question 15
1 / 1 pts
When you use a SQL Server database with a data source, data provider errors throw exceptions of the _______________ class.

SqlException

Question 16
1 / 1 pts
Although the binding navigator toolbar makes it easy to develop a form that gets data from a data source, you may prefer not to use this toolbar for all but one of the following reasons. Which one is it?

  So you can easily delete a row in a dataset


Question 17
1 / 1 pts
Assume that you’ve added a Cancel button to the binding navigator toolbar for an application that is supposed to cancel the current editing operation. If the binding source object is named CustomersBindingSource, write the code that you would use in the the event handler for the Click event of that button to cancel the edit operation.

________________________________________________

customersBindingSource.CancelEdit();

Question 18
1 / 1 pts
When you add a parameterized query to a table adapter, Visual Studio automatically generates the code that’s required for executing the query, including a try-catch statement that catches
  data provider exceptions
  ADO.NET exceptions
  all types of data exceptions
  all types of exceptions

Question 19
1 / 1 pts
After you customize a binding navigator toolbar so it can be used to start queries, you need to write the _____________________ handlers that make this work.

event

Question 20
1 / 1 pts
To apply formatting to a bound text box, you can use the Formatting and Advanced Binding dialog box that you can access from the __________________ window.

properties

Question 21
1 / 1 pts
When you edit the properties or columns of a DataGridView control, you can do all but one of the following. Which one is it?

  disable row navigation


IncorrectQuestion 22
0 / 1 pts
For each parameterized query that you add to a data table, Visual Studio adds a/an __________________ control to the form.

toolbar

Question 23
1 / 1 pts
To create a Master/Detail form that uses a DataGridView control for the detail rows, you just need to

  drag a subordinate table from the Data Sources window to a form


IncorrectQuestion 24
0 / 1 pts
When you bind a combo box to a table in one data source, you can display the data from one column of that table in the list of the combo box and use the selected value to

  update another column in that table
  update a column in a table of another data source
  update another column in that table and a column in a table of another data source

Question 25
1 / 1 pts
You can use the Position property of a BindingSource object to

  get the index of the current row in the data source
