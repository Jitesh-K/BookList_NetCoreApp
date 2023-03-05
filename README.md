# BookList_NetCoreApp

## HomePage
![image](https://user-images.githubusercontent.com/21361060/222944997-e0619012-7f94-4c63-b88e-8e2c7113a2b8.png)
## Upsert 
![image](https://user-images.githubusercontent.com/21361060/222945759-cf5a3439-0d0a-465e-9eb0-738437afd6e2.png)
## Delete
![image](https://user-images.githubusercontent.com/21361060/222945786-0dd90a63-4230-4a92-882b-1001cc64d64a.png)
![image](https://user-images.githubusercontent.com/21361060/222945792-2caa8659-4035-4e2d-8c29-b901cd7a30f6.png)




## A Sample .Net core 3.1 app for basic crud operations.

### 1.0 Tech Stack:
1. .Net Core 3.1
2. Sql Server
   * Ef-core used for DB Operations
4. External Libraries:
   * Jquery Datatables https://datatables.net/
   * SweetAlert https://sweetalert2.github.io/
   * Toastr https://github.com/CodeSeven/toastr

### 1.1 Min Requirements in system:
1. Visual Studio 2019/2022 IDE or any editor of your choice. https://visualstudio.microsoft.com/vs/
2. .Net core 3.1 https://dotnet.microsoft.com/en-us/download/dotnet/3.1
3. SQL Server 2019 https://www.microsoft.com/en-in/sql-server/sql-server-downloads 
4. SQL server management studio https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16
5. Git https://git-scm.com/download/win
6. Docker (optional) https://www.docker.com/products/docker-desktop/

### 1.2 Steps to run the application:
##### Environment: Local
1. Make sure dev dependencies listed in 1.1 are installed.
2. Run command: git clone https://github.com/Jitesh-K/BookList_NetCoreApp.git 
3. In Package manager console Type the following commands:
   * add-migration initial
   * update-database
4. Run the application

### Note - As of now this app is only meant for running locally.
