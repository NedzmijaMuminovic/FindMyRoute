# FindMyRoute

FindMyRoute is a web application for public transport that allows users to search for bus and train routes between cities, purchase tickets, and manage their accounts. This README provides an overview of how to use the application, including setup instructions and basic usage guidelines.

![calciHtmlLogo](https://github-production-user-asset-6210df.s3.amazonaws.com/56384122/269125057-f6df4368-b099-40d4-a0dd-637b24e8f688.png =300x300)

## Table of Contents

- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
  - [Generating Sample Data](#generating-sample-data)
  - [User Roles](#user-roles)
  - [Searching for Routes](#searching-for-routes)
  - [Buying Tickets](#buying-tickets)
- [Additional Features](#additional-features)

## Getting Started

### Prerequisites

Before you can run the FindMyRoute application, ensure you have the following prerequisites installed:

- [Node.js](https://nodejs.org/) - JavaScript runtime
- [Angular CLI](https://angular.io/cli) - Angular Command Line Interface
- [Your API Dependencies] - Make sure your API dependencies are installed.

### Installation

1. Clone the FindMyRoute repository to your local machine:

   ```shell
   git clone https://github.com/NedzmijaMuminovic/FindMyRoute

2. Navigate to the project directory:
   ```shell
   cd FindMyRoute
   
3. Install the Angular project dependencies:
   ```shell
   npm install @angular-devkit/build-angular --force

4. Start the Angular development server:
   ```shell
   ng serve

5. Run your API. Also be sure to run "add-migration" and "update-database" commands in the Package Manager Console (this will generate a local SQL database named "FindMyRoute").

## Usage

### Generating Sample Data

To populate the database with sample data, follow these steps:

1. After running the API, run the "Generate" function in your Swagger (you will find it under a "TestniPodaci" section). This will populate the database with sample data for demonstration purposes.

### User Roles

FindMyRoute has different user roles with varying functionalities:

- Basic User: You can create your own account and log in as a basic user, but if you are feeling too lazy for that, you can just use the username "test1" and the password "test1". Basic users have the ability to edit their profiles.

- Employee of a Public Transport Company: Log in with the username "radnik1" and the password "radnik1" to access employee functionalities. Employees can add new routes, delete existing routes, and edit company details.

 - Administrator: Log in with the username "admin," the password "admin," and later the PIN "3004" to access administrative functionalities. Administrators can add new employees and new companies to the application, or delete existing ones.

### Searching for Routes

To search for routes between cities:

1. Visit the FindMyRoute web application.

2. Use the starting point and destination textboxes to enter your cities (try Livno and Mostar).

3. Click the search button to get a list of routes between the specified cities. If no direct route is available, the application will suggest routes with transfers (try Livno and Blagaj).

### Buying Tickets

To purchase tickets:

1. Register an account or log in if you haven't already.

2. Search for your desired route.

3. Click on the route to see details.

4. Select the number of tickets you want to purchase and the date you want to travel on.

5. Proceed to checkout and complete the ticket purchase.

## Additional Features

- The application provides help buttons on every component/page to assist users in understanding how to use each feature.
