# Hair Salon Client Tracker

#### Site for owner of hair salon to monitor stylists and clients

#### By Will Greenberg

## Technologies Used

* HTML
* CSS
* Bootstrap
* C#
* .NET
* SQL
* mySQLWorkbench

## Description

This site allows the owner of a hair salon to access information on their stylists and those stylists' respective client's information.

## Setup/Installation Requirements

* Clone this repository to your desktop.
* Navigate to directory `HairSalon.Solution` in your terminal.
* Import database `will_greenberg.sql` in mySQLWorkbench, which is accessible [here](https://dev.mysql.com/downloads/workbench/).
* Once the database is imported, add an `appsettings.json` file to the directory `HairSalon`.
* Add the following code to the `appsettings.json` file, with your password in the appropriate location
  ``{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=will_greenberg;uid=root;pwd=epicodus;"
    }
  }``
* To run the application, run `dotnet run --project HairSalon/`.
* Navigate to `http://localhost:5000` in your browser.

## Known Bugs

* None so far.

## License

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 2022 Will Greenberg