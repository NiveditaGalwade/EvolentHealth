Online Directory:
Asp.net MVC based web application, which allows to create, edit, delete and view conntacts.

Prerequisites:
Tools:

MicrosoftVisual studio Enterprise 2017
SQl server 2012

Frameworks:
Microsoft.AspNet.Mvc:5.2.6
Entity Framework:6.2.0
Dependency injection framework -Autofac: 4.8.1
Unit testing framework- NUnit: 3.10.1

Getting Started:
Copy this Project to your local machine.
Open project in visual studio 2017
Run this project.

To configure a connection string for SQL Server in the Web.config file:

Open the Web.config file in the OnlineDirectory application.
In the Configuration element, assign a connection string with the location of your SQL Server a connectionStrings element.
Your connection string might look like the following:
<connectionStrings>
    <add name="Online_DirectoryEntities" connectionString="Data Source=(your sql server name);Initial Catalog=OnlineDirectory;Integrated Security=True" providerName="System.Data.EntityClient" />
</connectionStrings>
	
Save the Web.config file and close it.

To run application:
Mark OnlineDirectory.sln as start up project.
If you want to run the app in debug mode, pressing the F5 button will do the trick. Otherwise, you can go to debug menu item in Visual Studio. Then, click the "Start Debugging" sub menu item.

Run below scenarios:
Create new contact
Edit new contact
Delete new conatct


Following validations are allowed for fields while Creating and updating:

First Name and Last Name:
Maximum string lenght: 50
Only alphabets allowed
Required fields

Email address:
maximum string lenght: 50
Required fields
Email address should contain @ symbol

Mobile number:
maximum string lenght: 10
Required fields
Only digits allowed

Running unit tests:
Mark OnlineDirectory.UnitTests as start up project.
open ControllerTests.cs
Right click on TestControllerIndex
select Run Tests option.
If you want to debug then select Debug Test Options.


