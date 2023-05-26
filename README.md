# Dr Sillystringz's Factory

#### This app will allow the client to add engineers and machines to their factory. They can also keep track of repairs assigning Engineers to a machine or a machine to an engineer

#### By Christopher Ross Davila

## Technologies Used

* _Microsoft.EntityFrameworkCore.Design -v 6.0.0_
* _Razor Syntax_
* _C#_
* _ASP.Net Core_
* _VS Code_
* _Git Hub_
* _dotnet -ef_
* _MySQL_


## Description
## Client Wed application that allows client to input Engineers and Machines, update, edit and delete from a data table and view List of displayed Employees and Machines. Using many to many realtionships clients can the join an engineer(s) to a machine(s) they can work on or vice versa to keep track of factory machine to employee relationships

## Setup/Installation Requirements


* _1. Clone this repo using `\$ git clone https://github.com/ChrisRDavila/Dr_Sillystringz_Factory.Solution.git`._
* _2. Open your terminal (e.g., Terminal or GitBash) and navigate to the production directory called "Dr_Sillystringz_Factory.solution" and use command `\$ code .` to open project in vs code_
* _3. _Create appsettings.json file to store database name, user name and password for connecting to MySQL database using this structure:_
```cs
 "ConnectionStrings": 
{
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
}
```
* _3. cont'd: where [YOUR-DB-NAME] is going to be the database you import and connect (i.e. data_base), [YOUR-USER-NAME] will be your MySQL log in name and [YOUR-PASSWORD-HERE] will be your MySQL password_
* _4. Add .gitignore file with appsetting.json inside so private information is not uploaded to repo_
* _5. For next instructions please make sure you have access to MySQL and MySQLWorkbench, download and open isntance if have not already_
* _6. Navigate to project file `\$ /Factory`.
* _7. In the command line, run the command `\$ dotnet tool install --global dotnet-ef --version 6.0.0` if have not added dotnet -ef globally yet._
* _7. In the command line, run the command `\$ dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0` to add Entity EFCore._
* _7. In the command line, run the command `\$ dotnet ef database update` to create data base for project to store data input._
* _8. In the command line, run the command `\$ dotnet restore` to restore project files._
* _15. Run `\$ dotnet build` to compile this console app without running it._
* _16. use `\$ dotnet watch run` to cycle the server and navigate to your browser for UI interface_
* _17. From splash page enter follow the prompted instructions to add an engineer or machine and continue to follow instructions to make desired relationships between man and machine_
* _18. If needed, Edit or delete entries on corresponding views as well_


## Known Bugs

* _May have made more sense to create license class with one(engineer) to many(licenses) instead of assign it as a property.  As it stands now, multiple licenses would just be added in same input with comma.  Doing it as a class may have allowed later to only allow man/machine relationship if license present, will come back and refigure with time_

* _none yet_
## License
[MIT](https://github.com/ChrisRDavila/Dr_Sillystringz_Factory.Solution/blob/main/License.txt)
