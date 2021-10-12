# ShopsRUs API
### Getting Started
ShopsRUs is an API that provide discount to their customers on all their web/mobile platforms.
It provides capabilities to calculate discounts, generate the total costs and generate the
invoices for customers with the following conditions.

* If the user is an affilitate of the store, user gets a 10% discount.
* If the user is an employee of the store, user gets a 30% discount.
* If the user has been a customer for over 2 years, user gets a 5% discount.
* For every 100% on the bill, there would be a 5% discount(e.g for $900, you get $45 as a discount)
* The percentage based discounts do not apply on groceries
* A user can get only one percent based discounts on the bill.

#### These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.
* Clone the repo to your local machine ($ git clone https://github.com/Chuks-Onuh/ShopsRUs.git).
* Cd to the root of the cloned file and open the .sln file to run the program. (cd ../path/to/the/file)
* On successfull opening of the program, naviagte to ShopsRUs.API and open ShopsRUs.db to see seeded data for testing purposes.
* Run the program using IIS Express server.

## Built with
* C#.
* Asp.Net Core Web API.
* Rest Framework.
* SQLite (Database).
