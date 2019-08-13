# HelloPlus
Sample Hello World App with DI/IoC etc


HelloPlus is a basic 'Hello World' .Net application that demonstrates a few key concepts in modern programming. 
This includes :

WebApi Layer
	- Implements Oops concepts with Inheritance via interfaces, encapsulation,polymorphism
	- DI/IoC concepts for 
		- Multiple ways to notify
		- ConfigurationManager to create test-friendly methods that use configuration settings
	- Dapper for ORM
	- Localization concept to switch languages
	- JSON for API output
	- Cors enabled

Web Application Layer
	  - MVC Web application for display with bootstrap, jQuery
	  - Responsive web page
	  - Localization with ability to display in english, french
	  - moment.js libraries for time displays

Unit Tests for API
	  - Uses NUnit framework
	  - Demonstrates how DI/IoC in a method will help write better testcases for cases where
	    - Config settings are used in methods.

Following are configurable:

	- Notification default method (screen/none,console, file, db)
	- Language (in both api and web)
	- Api url in web application

IIS Express:
	API: http://localhost:64312/swagger
	Web: http://localhost:65367/home/index
Note: Due to some issue with my visual studio, the project settings/nuget packages may cause runtime issues. 
