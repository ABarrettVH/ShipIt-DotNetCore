# ShipIt Inventory Management

## Setup Instructions
Open the project in VSCode.
Run ```dotnet restore``` to automatically set up and install everything you'll need apart from the database connection!

### Setting up the Database.
Create 2 new postgres databases - one for the main program and one for our test database.
Ask a team member for a dump of the production databases to create and populate your tables.

For both the main project and the test project, create an empty databse called <my_database> and <my_test_database>.

Create a new role by right-clicking on the “Login/Group Roles” dropdown, set the name to <my_username>, set the password to <my_password>. Tick the “can login” and “create databases” privileges. Select SuperUser toggle option

[PATH to postgres psql.exe file] -d <my_database> -U <my_username> -f [PATH to databse dump.sql file] 
[PATH to postgres psql.exe file] -d <my_test_database> -U <my_username> -f [PATH to databse dump.sql file]

Then for each of the projects, add a .env file at the root of the project. That file should contain a property named POSTGRES_CONNECTION_STRING. It should look something like this:
POSTGRES_CONNECTION_STRING=Server=127.0.0.1;Port=5432;Database=your_database_name;User Id=your_database_user; Password=your_database_password;



Then for each of the projects, add a `.env` file at the root of the project.
That file should contain a property named `POSTGRES_CONNECTION_STRING`.
It should look something like this:
```
POSTGRES_CONNECTION_STRING=Server=127.0.0.1;Port=5432;Database=your_database_name;User Id=your_database_user; Password=your_database_password;
```

## Running The API
Once set up, simply run dotnet run in the ShipIt directory.

## Running The Tests
To run the tests you should be able to run dotnet test in the ShipItTests directory.

## Deploying to Production
TODO
