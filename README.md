This application is creted in C#.Net.

This application demonstrates the basic use of IoC autofac.

Application has following classes. 

1. ConsoleOutput.cs which implements IOutput. It provides a method Write() to display content on the console. 
2. TodayDateWriter.cs which implements IDateWriter. It provides method WriteDate() to display date. It has dependancy on IOutput. 
3. Startup.cs which contains a method WriteDate.

Startup.cs uses Autofac container to instantiate objects of TodayDateWriter and ConsoleOutput.