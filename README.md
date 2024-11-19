# The-Tech-Academy-Basic-C-Sharp-Projects
## EFApp
Create a basic Entity Framework Code-First console application that creates a basic Student database and adds one student.

## EmployeeComparisonApp
Perform these actions and create a console app that includes the following:

Create an Employee class with Id, FirstName and LastName properties. 
In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property. Remember that comparison operators must be overloaded in pairs. 

In the "Program.cs" file, instantiate two objects of the Employee class and assign values to their properties. Then compare the two Employee objects using the newly overloaded operators and display the results.
Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

## EmployeeComparisonPolymorphismApp
Create an interface called IQuittable and have it define a void method called Quit().

Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.

Use polymorphism to create an object of type IQuittable and call the Quit() method on it. Hint: an object can be of an interface type if it implements that specific interface.

Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code. 

## CarInsurance
ASP.NET MVC Entity Framework Assignment Part 4

Now you will add code logic that will calculate a quote based on the information the user inputs into the form.

Complete these actions:

In the InsureeController, add logic to calculate a quote based on these guidelines:

Start with a base of $50 / month.

If the user is 18 or under, add $100 to the monthly total.

If the user is from 19 to 25, add $50 to the monthly total.

If the user is 26 or older, add $25 to the monthly total. Double check your code to ensure all ages are covered.

If the car's year is before 2000, add $25 to the monthly total.

If the car's year is after 2015, add $25 to the monthly total.

If the car's Make is a Porsche, add $25 to the price.

If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price. (Meaning, this specific car will add a total of $50 to the price.)

Add $10 to the monthly total for every speeding ticket the user has.

If the user has ever had a DUI, add 25% to the total.

If it's full coverage, add 50% to the total.

Modify the Create View so that the user does not see the “Quote” input field.
Add an Admin View for a site administrator to the Insuree Views. This page must show all quotes issued, along with the user's first name, last name, and email address.

Email all database .mdf and .ldf files to an Instructor. These are located in your project’s app_data folder.

## Project 1
Requirements

The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”

The user must then be prompted for the package weight.

If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express. Have a good day.” At this point the program would end.

The user must then be prompted for the package width.

Then the package height.

Then the package length.

If the dimensions total greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.

Next, multiply the three dimensions (height, width, & length) together, and multiply the product by the weight. Finally, divide the outcome by 100.

The result of that calculation is the quote.

Display the quote to the user as a dollar amount.

For example: 

Welcome to Package Express. Please follow the instructions below.
Please enter the package weight:
40
Please enter the package width:
10
Please enter the package height:
 12
Please enter the package length:
 11
Your estimated total for shipping this package is: $528.00
Thank you!

Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code. 
