## Ticket Machine
This solution delivers an implementation of the "Station Finder" algorithm for train ticket machines.  This version is one of the simplest algorithms (if not the simplest) and makes use of predefined functions for C# Strings and Lists (along with the power of LINQ). It provides an elegant solution, that performs very well and quick enough to give the user and great experience, in just a few lines of code.

To allow for the testing of the algorithm a demo console application is provided. 

### Brief description of the algorithm
Since the most important bit is to give the user a good experience, any major work could and should be done upfront ("during boot time"). Basically at this stage we parse the string with all stations to a List with of Station objects that only stores the name of the station and a normalized name that is the name of the station with all non alphabetic characters stripped of. Since I assume that the machine would only have keys for alphabetic characters this normalization would simplify and speed the Find function later on, since any work and comparison are done in this property and the actual name of the station is only used in the UI.

Then the "find" function is quite trivial. I use the String.StartsWith(userInput) and return all the matches along with "next letter" for each one of the matches. This is done by getting the String.ElementAt and passing the length of the userInput.




### Packages

| Package | Description | .NET Core version|
|:-------:|:-----------:|:--------------:|
|[TicketMachine.Core](https://github.com/jruimartins/ticketmachine/tree/master/src/TicketMachine.Core) | Core package that contains the logic for the algorithm | 2.2
|[TicketMachine.Entities](https://github.com/jruimartins/ticketmachine/tree/master/src/TicketMachine.Entities)| Entities package contains the definition classes for the data | 2.2 |
|[TicketMachine.Demo](https://github.com/jruimartins/ticketmachine/tree/master/src/TicketMachine.Demo)| Console application that allows a user to simulate the station finder on a ticket machine | 2.2 |
|[TicketMachine.Core.Tests](https://github.com/jruimartins/ticketmachine/tree/master/tests/TicketMachine.Core.Tests)| Unit tests package for TicketMachine.Core | 2.2 |
|[TicketMachine.Entities.Tests](https://github.com/jruimartins/ticketmachine/tree/master/tests/TicketMachine.Entities.Tests)| Unit tests package for TicketMachine.Entities | 2.2 |

#### Build and run the Demo
As specified above to build and run the Demo, .Net Core 2.2 needs to be installed.
The solution can be opened, built and ran on Visual Studio 2017 (or later).

Alternatively it can be built from the command line:
 `dotnet build .\TicketMachine.sln -c Release`
 in the root of the repo/solution and dist folder should be created. 
 
To start the demo, just run :
`dotnet dist\netcoreapp2.2\TicketMachine.Demo.dll`

#### Run Unit Tests
There are 2 packages with unit tests (using xUnit). 
They can be run from the command line using the dotnet test and targeting the desired project file.

Example:
 `dotnet test .\tests\TicketMachine.Core.Tests\TicketMachine.Core.Tests.csproj`

Alternatively there's a batch file that runs the tests for both packages:
`runtests.bat` located on the root of the repo/solution

 