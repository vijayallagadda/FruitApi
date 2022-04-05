# Fruit API Exercise

This is an API that is deliberately written in a way that works, but may not be optimal from many other perspectives.

The API is a simple API that composes the results of 2 other APIs into a single result.  The services used are

* The fruit info service - eg https://fruitinfo.azurewebsites.net/api/Info?name=apple
* The fruit nutrition service - eg http://fruitnutritions.azurewebsites.net/api/nutritions?type=apple

## Getting Started

**Please don't fork the repo** - it will make it easy for others to find your code, take a local copy and push to a fresh repo in github.

You will need dotnet core 3.1 and the ASP.NET core runtime installed. https://dotnet.microsoft.com/en-us/download/dotnet/3.1

### Running The Code

Once you have a local copy of the repo, the code should be runnable in an IDE or from command line.

* For Visual Studio - Open FriutApi.sln, press play and navigate to https://localhost:44327/swagger/index.html in a browser, if it does not already open for you.
* For command line - run ```dotnet run``` and navigate to https://localhost:5001/swagger/index.html
* For VS Code - Open the project folder, install the C# plugin if not already installed, run the project and navigate to https://localhost:5001/swagger/index.html

From here you can find information out about your favorite fruit.  We suggest you do initial tests with an apple.

## What Is Expected

Please study the code and make any updates that you want.  You can spend as much time as you like making changes.  However, it is not the expectation that you spend days on this exercise.  It is recommended that you priorities changes, make high priority changes and perhaps comment the code with TODOs for changes you don't implement, but would like to.

### Hints

We are looking for things like, but not limited to ...

* pattern use
* testability / tests
* clean code

## The Purpose

The sole purpose of this exercise is to have a conversation at interview about your changes.  There is no right or wrong outcome in terms of the code changes, the conversation about why you made your changes is what is important.  Also, keep in mind that it is okay to have a different view to what your interviewers may have.
