# Commands

## Database
Databse created via: 
```
Add-Migration InitialCreate
Update - Database
```
The `InitialCreate` argument is the migration name.
`Add-Migration InitialCreate`: Generates a Migrations/{timestamp}_InitialCreate.cs migration file.

`Update - Database`: Updates the database to the latest migration.
Runs the Up method in the Migrations/{time-stamp}_InitialCreate.cs file, which creates the database.