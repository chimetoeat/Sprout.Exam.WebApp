# Employee Payroll System

A simple web app for Employee Payroll where the admin can create, edit and delete employee details.
It can calculate the net income depending whether the employee is Regular or Contractual.
The web app can still be improved and personally I would focus on having integrations with other systems to get more data and updates like
performance checking and salary updates to make sure that Basic Salary and more benefits are added in the net income calculation seamlessly.

## Table of Contents

- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation and Usage](#installation-and-usage)

## Features

- Employee Creation
- Employee Update
- Employee Delete
- Employee Net Income Calculate
- Employee List View
- User-friendly Navigations
- Form Validations

## Getting Started

To get a local copy of this project up and running, follow these simple steps.

### Prerequisites

Before you begin, ensure you have the following installed:

- [Git](https://git-scm.com/) - Version control system
- Visual Studio 2019
- .Net 5
- SQL Server 2016 or up
- Node.js - Make sure to install last version of 16
- Visual Studio Code
- [DB Copy](https://likhacareers-my.sharepoint.com/personal/mdonguines_likhacareers_com/_layouts/15/onedrive.aspx?id=%2Fpersonal%2Fmdonguines%5Flikhacareers%5Fcom%2FDocuments%2FCLIENT%20DOCUMENTS%2FSprout%2FTechnical%20Exam%20%2D%20Junior%20L3%20Engineer%2Ezip&parent=%2Fpersonal%2Fmdonguines%5Flikhacareers%5Fcom%2FDocuments%2FCLIENT%20DOCUMENTS%2FSprout&ga=1) - SproutExamDB11052021.bak



### Installation and Usage

1. Clone the repository:
    git clone https://github.com/chimetoeat/Sprout.Exam.WebApp.git

2. Open your Visual Studio 2019 and select Open a project or solution:
    Go to the cloned project folder and select the .sln file

3. Open you Visual Studio Code and open the ClientApp folder inside the Sprout.Exam.Webapp:
    Drag and drop to workspace

4. In the Visual Studio Code, install dependencies and start the server using the built-in terminal:
    npm install
    npm run start

5. Open your SQL Server Management Studio and connect to your database.

6. In the SQL Server Management Studio, right-click on the Databases folder and select Restore Database:
    Select Device and browse.
    Click Add after the window popup
    Select you .bak file
    Make sure you placed the .bak file you downloaded from the DB Copy link where you can see it do add the file.
    Click OK to the popup windows until restoration completed.
        
7. In Visual Studio 2019, go to project folder Sprout.Exam.WebApp and to appsettings.json:
    Replace the DefaultConnection values based on your local database details.

8. To update the database in Visual Studio 2019:
    Go to Tools > NuGet Package Manager > Package Manager Console
	  Type and enter "update-database -Context MyDbContext" without the quotations
	  You can verify in your SQL Server that Employees table exists in SproutExamDb database

10. Run the project.

11. Login using the username: sprout.test@gmail.com and password: P@$$word6

12. You can now create, update, and delete employees and calculate their net income.
