# .NET API MyLibrary template with NuGet ready

## How To Start with this template
* Clone source code, but do not open in Visual Studio yet
* Rename MyCompany to your company's name everywhere
* Rename MyLibrary to your API name everywhere
* Open in Visual Studio and build the solution
* Ensure you have no errors (it runs ReShareper, StyleCop and FXCop)
* Run Tests project (MSTests) and make sure they passed
* Continue with your project! 

## How To publish NuGet package
* Build Release version
* First time, edit MyLibrary.nuspec to enter product specific information
* Open command line prompt and "cd" to your solution folder
* Execute CreateNuGetPackage.cmd script: your package is created in the current folder
* When visiting nuget.org, register if needed, and click Upload Package
* Verify all the info and click Publish.

 
