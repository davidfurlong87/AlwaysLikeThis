# Commands

## Database
### Databse creation: 
```
Add-Migration InitialCreate
Update - Database
```
The `InitialCreate` argument is the migration name.
`Add-Migration InitialCreate`: Generates a Migrations/{timestamp}_InitialCreate.cs migration file.

`Update - Database`: Updates the database to the latest migration.
Runs the Up method in the Migrations/{time-stamp}_InitialCreate.cs file, which creates the database.

### Adding new fields to a model
Use Entity Framework Code First Migrations
`Code First`:
- Adds a table to track the schema of the database.
- Verifies database is in sync with the model classes it was generated from. 
- If they aren't in sync, EF throws an exception.

`Steps:`
- Add a new property to the model
- Update the binding paramater for the create and edit actions to include that new property.
- Update view templates to include new model.
- Update the Models/SeedData.cd class

### Adding new model fields to a DB
Three approaches:
- Drop the table and rebuild.
- Explicitly modify the schema
- Use Code First Migrations to update the Schema

With CFM, the steps are:
- Tools -> Nuget PM -> PM Console
- `Add-Migration X`, X being arbitrary, but is used for name of the migration
- `Update-Database`