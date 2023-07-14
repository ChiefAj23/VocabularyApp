# VocabularyApp
This is a Vocabulary app built using ASP.NET 7 and C#. The app allows users to manage their vocabulary lists, perform CRUD operations, search for specific words, and includes authorization and authentication features.

# Features
* User Registration: Users can create an account to access the app's features.
* User Login: Registered users can log in to their accounts.
* User Management: Administrators can manage user accounts, including creating, updating, and deleting user profiles.
* Vocabulary List Management: Users can create, read, update, and delete vocabulary lists.
* Word Management: Users can add, edit, and delete words within their vocabulary lists.
* Search: Users can search for specific words within their vocabulary lists.
* Authorization and Authentication: Users must be authenticated and authorized to access certain features and data.

# Technologies Used
* ASP.NET 7: The web framework used to build the application.
* C#: The programming language used for server-side development.
* Entity Framework Core: An Object-Relational Mapping (ORM) framework for working with databases.
* SQL Server: The database management system used to store data.
* HTML/CSS: Markup and styling languages used for the front-end interface.
* JavaScript: A programming language used for client-side scripting and interactivity.

# Setup Instructions
* Clone the repository to your local machine.
* Make sure you have ASP.NET 7 and the necessary dependencies installed.
* Create a new SQL Server database and update the connection string in the app's configuration file (appsettings.json) to point to your database.
* Run the database migration command to apply the necessary database schema: dotnet ef database update.
* Build the solution and run the application.
* Access the app through your web browser.

# Usage
* Register a new user account or log in with an existing account.
* Once logged in, you can create a new vocabulary list.
* Add words to your vocabulary list by providing the word and its definition.
* Edit or delete existing words in your vocabulary list.
* Use the search feature to find specific words within your vocabulary list.
* Manage your account and access other features based on your user role.

# Contributions
Contributions to the Vocabulary App are welcome! If you would like to contribute, please follow these steps:
1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and test thoroughly.
4. Commit and push your changes to your forked repository.
5. Create a pull request with a clear description of your changes.

# License
The Vocabulary App is released under the MIT License.
