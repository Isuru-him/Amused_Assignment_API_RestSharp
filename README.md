# Amused_Assignment_API_RestSharp

General outline

separate DTO classes have been written for each Response. e:g UpdateObjectDTO.cs

Common Json properties across the DTOs have been grouped in a single partial class file. CommonDTO.cs

Separate class has been written as API_Methods to manage different type of API requests - API_Methods.cs

Separate class has been written as APIHelper to segregate general methods from the API methods, this class will help to minimize code redundancy.

Another Test Project was created to maintain the API tests

Inside that Test Project, API tests has been written inside Regression.cs class

\

Class - API_Methods

Methods in this class has been developed to cater different API requests and responses.

Some methods of this class returns a C# object while some returns a RestResponse object

When C# object is received as a return, it is used to assert the response attributes to determine the validity and the correctness of the response.

RestResponse object is used to assert more general response related attributes like response code.

So for each type of requests in asserting the response attributes both return typed methods are used

\

Class - APIHelper

This class was developed with the following manifest
1.) Reduce code redundancy
2.) To segregate the duplicated code from the API methods
3.) To improve efficiency and effectiveness
4.) To improve code readability and clarity
5.) To enhance code maintainability \

\

Class - Regression

This class contains the test methods of the above REST responses.

ALL Object - GET - Test scenarios - 3
\
Single Object - GET - Test scenarios - 4
\
Single Object - POST - Test scenarios - 3
\
Single Object - PUT - Test scenarios - 3
\
Single Object - DELETE - Test scenarios - 2

All together Regression.cs class contains 15 API test methods to verify the above mentioned APIs

\

Note
This solution still has room for improvements but this code was written in adequacy to serve the purpose.

About Implementation (.Net)

There are two projects, 1st project is a class library project (c#) implemented using the framework .Net 7.0 (Standard Term Support) version
\
The other one is a MSTest Test project (c#) implemented using the framework .Net 7.0 (Standard Term Support) version
\
.Net 7.0 (STM) is the latest .Net version 
\
Reason to build it using .Net 7.0 (STM) is to make the project executable across the platform. 
\
Last time my project was built on top on ".Net framework 4.8" which was released in 2019, it's latest being 4.8.1 but this instance ".net framework" was not used now since it limits that platform independancy.




P:S - To execute these testcases please right-click on the Regression.cs file and select Run Tests option.
