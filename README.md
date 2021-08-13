# "Getting Started with Dependency Injection in .NET" Resources
This repository contains sample code for the "Getting Started with Dependency Injection in .NET" course by Jeremy Clark on Pluralsight. This repository includes the original examples (.NET Core 2.2) as well as updated projects (.NET 5.0). Additional updates will be posted after .NET 6 is released.  

## Code Samples
The code samples are in folders starting with the environment (core22, net50), followed by the course module (module1). From there, the "before" and "after" folders contain the code at the beginning of the demo and the code at the end of the demo, respectively.  

*Note: The updated samples are as close to the original samples as possible so that they match what is shown in the Pluralsight course. The one exception is the final demo showing late-binding: PeopleViewer.Autofac.LateBinding. The assembly loading system changed significantly in .NET Core 3.0, so the existing .NET Core 2.2 example could not be updated without significant changes. These changes would no longer match the example shown in the video course, and so the example has been excluded from the .NET 5.0 files. If you would like more information on how to dynamically load assemblies, you can take a look at this article: [Dynamically Loading Types in .NET Core with a Custom Assembly Load Context](https://jeremybytes.blogspot.com/2020/01/dynamically-loading-types-in-net-core.html). This technique could be used in conjunction with a dependency injection container to get the late binding functionality shown in the original example.*

## Pluralsight Course
* [Getting Started with Dependency Injection in .NET](http://www.pluralsight.com/courses/using-dependency-injection-on-ramp) by Jeremy Clark (released Mar 2019)  

## Running the Samples  
The code samples can be followed using Visual Studio 2019 or Visual Studio Code on Windows. The code samples use WPF (a Windows desktop technology).

### Visual Studio 2019 (Community Edition)
When using Visual Studio, open the solution file (.sln) that is included in each sample folder. The web service needs to be started separately from the application.

**Starting the Service**  
For the projects that have a "People.Service" folder, use the following steps to start the service:

1. In the Visual Studio solution explorer, right click on the "People.Service" project, and choose "Open Folder in File Explorer".
2. In File Explorer, choose the "File" menu, then "Open Powershell" (this may say "Open Command Prompt").
3. Type "dotnet run". (This will rebuild the project if necessary.)
4. The service should start and show the following info:
```
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: http://localhost:9874
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
```

If you open a browser to http://localhost:9874/people, you will see data from the service.

You can leave this terminal open for all of the samples; each sample uses the same web service.

To stop the service, press "Ctrl+C" in the terminal.

**Running the Application**  
To run the application, press F5 or use "Start debugging" from the toolbar or Debug menu in Visual Studio.

**Running the Unit Tests**  
For the sample that has unit tests, open the Test Explorer in Visual Studio by selection "Test | Test Explorer" from the menu or "Ctrl+E, T".

In the Test Explorer, click the left-most button (or use "Ctrl+R, V") to run all of the tests.

### Visual Studio Code
When using Visual Studio Code, you will need to start the web service project separately from the web application.

**Starting the Service**  
For the projects that have a "People.Service" folder, use the following steps to start the service:

1. Open a terminal in the "People.Service" folder.
2. Type "dotnet run". (This will rebuild the project if necessary.)
3. The service should start and show the following info:
```
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: http://localhost:9874
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
```

If you open a browser to http://localhost:9874/people, you will see data from the service.

You can leave this terminal open for all of the samples; each sample uses the same web service.

To stop the service, press "Ctrl+C" in the terminal.

**Running the Application**  
To run the application (PeopleViewer), use the following steps:

1. Open a terminal in the "PeopleViewer" folder.
2. Type "dotnet run". (This will rebuild the project if necessary.)

**Running the Unit Tests**  
One of the samples includes unit testing. To run unit tests from the terminal, use the following steps:

1. Open a terminal in the "PeopleViewer.Presentation.Tests" folder.
2. Type "dotnet test". (This will rebuild the project if necessary.)
3. The tests will run and the result will be similar to the following:
```
Test run for ...\PeopleViewer.Presentation.Tests.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.10.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     2, Skipped:     0, Total:     2, Duration: 28 ms - PeopleViewer.Presentation.Tests.dll (net5.0)
```

Do the same as above to run the tests in the "PersonDataReader.CSV.Tests" folder.

