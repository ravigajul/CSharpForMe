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

## SpecFlow for BDD
1. Install "Specflow for visual Studio" extension from Extensions->ManageExtensions<br/>
2. Right Click on Project - > Manage Nuget Packages -> Gherkin, SpecFlow, SpecFlow.NUnit.Runners, Selenium.WebDriver, Selenium.Support, etc<br/>
3. Create Spec Flow Feature, StepDefinitions, Hooks<br/>

## Parameterization
1. Inline Parameters<br/>
2. Data Table <br/>
3. Examples <br/>

## Hooks
[BeforeTestRun]<br/>
[AfterTestRun]<br/>
[BeforeFeature]<br/>
[AfterFeature]<br/>
[BeforeScenario]<br/>
[AfterScenario]<br/>
[BeforeScenarioBlock]<br/>
[AfterScenarioBlock]<br/>
[BeforeStep]<br/>
[AfterStep]<br/>

## Keyboard Short Cuts
### Navigation
control + enter -> insert row above
shift + enter --> insert row below
ctrl + g go to line

### Selection
shift + end/home to select from the cursor position to end/home
Control + W selects the word where the cursor is currently
alt+shift + left/right arrow key  select mulitple blocks of same size. This can be used to perform same operation(write/delete)  in multiple lines

### Finding code in other files
F12 to go to function definition
Alt+F12 or peek definition to view/edit the code in a temporary window.
Ctrl + T opens the search window. 
Ctrl + , opens the search window too.
Ctrl + ; searches in solution explorer
Ctrl + KK to bookmark/unbookmark an item 
Ctrl + KN (Next) to move between bookmarks downwards 
Ctrl + KP (previous) to move between bookmarks upwards
Ctrl + KW to view all book marks at once. Bookmarks can be renames(F2)

### Cut/Copy/Paste
Ctrl + Delete deletes the right side of the cursor in a given word
Ctrl + Backspace deletes the left side of the cursor in a given  word
Shift + Delete deletes the whole row
ctrl + C will copy entire line even if its not fully selected.

### Formatting
Ctrl + K + D auto formatt
Tab ..moves forward by 4 spaces
shift + Tab moves backward by 4 spaces

### Renaming variables
Ctrl + R + R will select all the variables with same name in current document and renames all as you type

### Minimize/Maximize the block of code
Ctrl + MM

### Comment Code
Ctrl + KC Single line Comment
Ctrl + KU Uncomment

### Windows arragment
ctrl + tab
