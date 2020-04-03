# _Animal Shelter API _

####  An ASP.NET API for a local animal shelter  , April 3, 2020_

#### By _**Fatma C. Dogan**_

## Description

An API project that allows users to Create, Read, Update, and Delete animals and lists the available animals at the shelter.


## Specifications user stories

* A user is able to GET a list of animals.
* A user is able to GET a specific animal information based on AnimalId.
* A user is able to GET animals by type, age or gender.
* A user is able to POST a new animal in the database.
* A user is able to PUT (edit) an existing animal information in the database.
* A user is able to DELETE an existing animal information in the database.

## API Endpoints

### Get list of Animals
#### Request
`GET /animals/`

   http://localhost:5000/api/animals/

#### Response
    {
        "animalId": 1,
        "name": "Alfie",
        "type": "Cat",
        "age": 7,
        "gender": "Male"
    },
    {
        "animalId": 2,
        "name": "Cheetah",
        "type": "Cat",
        "age": 6,
        "gender": "Female"
    } 

### Get a specific Animal
#### Request
`GET /animals/id`

   http://localhost:5000/api/animals/1

#### Response
    {
        "animalId": 1,
        "name": "Alfie",
        "type": "Cat",
        "age": 7,
        "gender": "Male"
    }

### Create a new Animal

#### Request

`POST /animal/`

    http://localhost:5000/api/animals

#### Request body
    {
      "animalId": 3,
      "name": "Spike",
      "type": "Ferret",
      "age": 2,
      "gender": "Female"
    }

### Edit an Animal's information

#### Request

`PUT /thing/id`

   PUT http://localhost:5000/api/animals/3

#### Request Body
    {
      "animalId": 3,
      "name": "Spike",
      "type": "Ferret",
      "age": 3,
      "gender": "Male"
    }

### Delete an Animal

#### Request

`DELETE /animals/id`

   DELETE http://localhost:5000/api/animal/3

#### Response

    Status: 200 OK
    
### Get a non-existent Animal

#### Request

`GET /animals/id`

   http://localhost:5000/api/animals/9999

#### Response

    Status: 404 Not Found

## Swagger
This application is equipped with Swagger. To testing this API, go to "http://localhost:5000/swagger/index.html" in your browser while running the application.

## Setup/Installation Requirements

### Install .NET Core

* Download the .NET Core SDK [Software Development Kit](https://dotnet.microsoft.com/download)
* Open the .Net Core SDK file and install
* To confirm installation was successful, run the ```$ dotnet --version``` command in your terminal

### Install MySQL Community Server and MySQL Workbench

#### on macOS:
_Download the MySQL Community Server DMG File [MySQL Community Server page](https://dev.mysql.com/downloads/file/?id=484914). 
* Follow along with the installer until you reach the configuration page. Once you've reached Configuration, set the following options (or user default if not specified):_
      * use legacy password encryption
      * set password 
      * click finish

* Verify MySQL installation by opening Terminal and entering the command ``mysql -uroot -p{your password here}``.  
  You can exit the mysql program by entering exit.

_Download MySQL Workbench DMG file [ MySQL Workbench page](https://dev.mysql.com/downloads/file/?id=484391). 
* Install MySQL Workbench to Applications folder. 
* Open MySQL Workbench and select Local instance 3306 server, then enter the password you set. If it connects, you're all set._

#### on Windows:
_Download the MySQL Web Installer [MySQL Web Installer ](https://dev.mysql.com/downloads/file/?id=484919) 
* Choose Custom setup type
* When prompted to Select Products and Features, choose the following: 
    * MySQL Server (Will be under MySQL Servers) 
    * MySQL Workbench (Will be under Applications)
* Select Next, then Execute. Wait for download and installation 
* Advance through Configuration as follows:
  - High Availability set to Standalone.
  - Defaults are OK under Type and Networking.
  - Authentication Method set to Use Legacy Authentication Method.
  - Set password to epicodus. You can use your own if you want but epicodus will be assumed in the lessons.
  - Unselect Configure MySQL Server as a Windows Service.
* Complete installation process

_Add the MySQL environment variable to the System PATH. Instructions for Windows 10:_
* Open the Control Panel and visit _System > Advanced System Settings > Environment Variables..._
* Select _PATH..._, click _Edit..._, then _Add_.
* Add the exact location of your MySQL installation and click _OK_. (This location is likely C:\Program Files\MySQL\MySQL Server 8.0\bin, but may differ depending on your specific installation.)
* Verify installation by opening Windows PowerShell and entering the command ``mysql -uroot -p{your password here}``. It's working correctly if you gain access to the MySQL command line. 
  You can exit the mysql program by entering `exit`


### Download this repository

_Download Manually:_

* Navigate to https://github.com/fc-dogan/AnimalShelterAPI
* Click the green "Clone or Download" button.
* Click "Download ZIP".
* Click downloaded file to unzip.
* Open folder.

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
  ```
  cd desktop
  ```
* Clone the file from GitHub with HTTPS
  ```
  git clone https://github.com/fc-dogan/AnimalShelterAPI 
  ```
* Open file in your preferred text editor
  ```
  cd AnimalShelterAPI
    ```
* Change directories into the project directory
  ``` 
  cd AnimalShelterAPI/AnimalShelter
   ```

* Restore all dependencies
  ```
   dotnet restore
   ```
* Build the project and dependencies
   ```
   dotnet build
   ```

## Create the Database

* Build the database
  ```
  dotnet ef database update
  ```

_To run this application:_


* Run the program
  ``` 
  dotnet run
  ```
   Note: To exit, simply press ```Ctrl + C```
* access the [Swagger UI](http://localhost:5000/swagger/index.html#/Reviews) for testing this API



## Known Bugs

_No known bugs at this time._


## Technologies Used

* C#
* .Net Core 2.2
* ASP.NET Core MVC
* MySQL, MySQL Workbench
* Entity Framework Core
* RestSharp
* Newtonsoft.Json 
* Swagger
<!-- * JSON Web Token Authentication -->

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Fatma C. Dogan_**