# Store Web Application

## Project Description

This web application was built using ASP.Net Core MVC to stimulate various users shopping at numerous stores. By using Microsoft Entity Framework Core, the web application utilized a locally store database normalized in third base form to information on availalble users, stores, inventory and orders that persists all changes. By logging in as an admin, the user is also able to access private user infomation along with open and restock stores.

## Technologies Used

* ASP.NET Core MVC, XUnit Testing, Microsoft Entity Framework Core - version 1.0

## Features

List of features ready and TODOs for future development
* Users are able to create new account and log in with previous creditials.
* Accounts that are labeled as admin have access to addition functionalities.
* Users are able to create new orders and look back on details on previous orders.
* Users are able to search for stores and have a look into their inventory.
* Admins are able to open new stores, restock store inventory, and check previous orders with stores.
* Admins are able to search for users and view their account and previous order history.

To-do list:
* Allow search resullts to be ordered by date and price.
* Allow users to log in with a username and password.
* Allow users to have a set budget on how much they can spend.

## Getting Started
   
* Run `git clone https://github.com/06012021-dotnet-uta/AlainDuplanP1` in your terminal.
* Open the SQL folder and run `Builder.sql`  to build the database, than proceed to run `Populate.sql` to populate.
* Open `P1/P1/P1.sln` in Visual Studio to view the project, ensure the connection string in `/P1/P1/ShopperContext/ShopperContext.cs` matches your local copy.
* Click ISSExpress to run project in your local browser.

## Usage

* Log in with ID: 1007 to access admin functionalities.

## License

This project uses the following license: [MIT](https://opensource.org/licenses/MIT).

