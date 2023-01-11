# BuggyCarsRating

Test Automation suite for the BuggyRating.org 

# Languages
 1. C#
 2. Gherkin

# Pre-requisites
1.  Visual Studio 2019 version 16.10
2. .Net Core 3.1
3.  SpecFlow + Runner Framework
4.  Git

# Setup

1. Clone the repository to your local machine
2. Open Visual Studio 2019  and open the solution
3. Build the project before run the tests.(Make sure you have all Nuget packages installed)
4. Add and Install the latest LivingDoc CLI by using following command using command prompt to generate the test execution report. 

```
     dotnet add package SpecFlow.Plus.LivingDocPlugin --version 3.9.57
```
```
     dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI --version 3.9.57
```
     
5. execute below command to generate the document with test results.
```
livingdoc test-assembly [YOUR_PROJECT_DIRECTORY]\BugCars\BugCars.Tests\bin\Debug\netcoreapp3.1\BugCars.Tests.dll -t [YOUR_PROJECT_DIRECTORY]\BugCars\BugCars.Tests\bin\Debug\netcoreapp3.1\TestExecution.json
```

6. Navigate to Test in Menubar and then click Test Explorer.Then click Run All Tests In View button.Make sure to sign in and activate to free Specflow account before running the tests.

Follow https://docs.specflow.org/projects/specflow-runner/en/stable/Installation/Installation.html for more information. 

