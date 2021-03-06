# Store Web Application

## Project Description

This is an ASP.NET Core MVC project utilizing Entity Framework Core to create a Web Store Application that allows a user to create an account then view orders by user and store location. The user can create an order, view their order history, and view the order history of a store location.

## Technologies Used

* C# Programming, ASP.NET MVC, ADO.NET Entity Framework, Testing Process / SDLC, HTML5, CSS3, Defect Logging, Microsoft SQL Server, SQL, XML - version 1.0

## Features

* Used Database-First approach to create content using Microsoft SQL Server and T-SQL while adhering to third base normal form.
* Utilized XUnit to test various functionalities.
* Users are able to create new accounts and log in with previous credentials.
* Accounts that are labeled as admin have access to additional functionalities.
* Users are able to create new orders and look back on details on previous orders.
* Users are able to search for stores and have a look into their inventory.
* Admins are able to open new stores, restock store inventory, and check previous orders with stores.
* Admins are able to search for users and view their account and previous order history.

To-do list:
* Allow search resullts to be ordered by date and price.
* Allow users to log in with a username and password.
* Allow users to have a set budget on how much they can spend.
* Establish CI/CD with an Azure Pipeline and deploy onto Azure Web Services

## Getting Started
   
* Run `git clone https://github.com/06012021-dotnet-uta/AlainDuplanP1` in your terminal.
* Open the SQL folder and run `Builder.sql`  to build the database, than proceed to run `Populate.sql` to populate.
* Open `P1/P1/P1.sln` in Visual Studio to view the project, ensure the connection string in `/P1/P1/ShopperContext/ShopperContext.cs` matches your local copy.
* Click ISSExpress to run project in your local browser.

## Usage

* Log in with ID: 1007 to access admin functionalities.

## License

This project uses the following license: [MIT](https://opensource.org/licenses/MIT).

