# CSharpForMe

## C# vs .NET
C# is a programming Language.
.NET is a framework for building applications using that framework. It consistes of CLR (Common Language Runtime ) & Class Library

## CLR - Common Language Runtime
C/C++ --> ILCode (Like byte code in java) --> Native code 
This is called Just in time compilation or JIT.

## Archiecture of .NET Applications
1. classes -> Data & Methods
2. Namespaces --> Similar to packages in Java
3. Assembly(.dll)--> Similar to Jar file in java.
4. Assembly is a container for related name spaces

## Naming conventions
Camel Case: firstName<br/>
Pascal Case: FirstName<br/>
Hungarian Notation: strFirstName<br/>

## Non Primitive Data Types
String<br/>
Array<br/>
Enum<br/>
Class<br/>

## MSTest Attributes
MSTest is the unit test like testng in Java
```c#
[TestInitialize] //before test
[TestCleanUp] //afterTest
[TestMethod] //declare a method as test method
[Testclass] //declare a class as test class
[ClassInitialize]  //Before class..will be executed before any of the test methods present in the class
[ClassCleanup] //afterclass ...will be executed after any of the test methods present in the class
[AssemblyInitialize] // Methods with this attribute will be executed before any of the method in the assembly(.dll like .jar) is executed.
[AssemblyCleanup] //Methods with this attribute will be executed after any of the method in the assembly is executed.
[TestCategory("SmokeTest")] //to group the test cases by a category
[Ignore] //to ignore the test
```

## Nuget 
Nuget is the package manager for the microsoft development platform like npm for node and maven for java
Right click on the project - > Manage Nuget package

## App Config
```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
	<appSettings>
		<add key="Browser" value ="Chrome"/>
		<add key="UserName" value="Ravi"/>
		<add key="Password" value="Password"/>
	</appSettings>
</configuration>
```

## Reading data from App.config
This requires adding reference System.Configuration
```c#
ConfigurationSettings.AppSettings.Get("Browser")
```

## Install Selenium
Right Click on Project --> Add Reference --Search for Selenium.WebDriver & Selenium.Helper and add them
