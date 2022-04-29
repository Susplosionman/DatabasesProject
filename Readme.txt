This is the code for Team 10's CIS560 SQL Server Application.

To run properly, make sure that you run Powershell as an Administrator, and that you run the command 'Set-ExecutionPolicy RemoteSigned'. Then, run the Powershell script
RebuildDatabase as './RebuildDatabase.ps1'. Set the front end project to the Startup Project, and then you should be able to use the application. 

Inside the code, you will find 3 projects: Data, DataAccess, and FrontEnd; and an additional folder called Solution Items.

Solution Items contains the Powershell scripts required to build, create, drop, and rebuild the database. We only use the RebuildDatabase script when needing to build
and use database information in this application.

The 'Data' project contains all of our DataDelegates, Models, and SQL. The DataDelegates folder allows for us to call Procedures from the database directly from
the FrontEnd application, to receive the result of our queries. The Models folder contains all of our class representations of our Table types. The SQL holds all of our
data inputs in Data, all of our Procedures in Procedures, the schema of the database in Schema, and the table creation scripts in Tables.

The 'DataAccess' project doesn't contain much of our own code. We used most of the code from the in-class demonstrations.

The 'FrontEnd' project contains all of our forms for the User Interface. It interacts with the 'DataAccess' project as well as the 'Data' project (but mostly the 'Data'
project). Each window in the interface is divided into its own respective CS class.