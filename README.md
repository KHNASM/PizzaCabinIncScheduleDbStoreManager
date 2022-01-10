# PizzaCabinIncScheduleDbStoreManager

Project Type: .Net Core Class Library<br>

The solution includes two projects, the actual class library and a Console Applcation to test the Class Library.
<br>
To set it up:<br>

1: Open the solution in Visual Studio <br>
2: Update the Nuget Packages using PM Console <br>
3: Change the connection string in DbContext class <br>
4: Update Database using PM Console and you're ready to go <br>



Tools:<br>
C# & .Net Core 5.0<br>
EF Core as ORM<br>
MSSQL<br>
I opted for System.Text.Json for managing Json Data<br>


Room for Improvements:<br>
There is lot to improve in solution, for example:<br>

1 :- A Config could be used for Connection strings and other configuration ( code has a hard coded connection string)<br>
2 :- The Json data exposed by the API needs to be revised for a better schema<br>
3 :- Better Exception and Error Handling can be implemented<br>
4 :- an authorization token could be used to allow the consumption of class library ( because it has hard coded db credentials)<br>


Why Class Library?<br>
A Class Library was deemed better choice due the fact it could be integrated with any platform  Windows Application or in a web api etc.<br>

