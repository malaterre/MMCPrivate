all : App Dump ApplicationObjects

App : App.cs
	cli-csc App.cs

Dump : Dump.cs
	cli-csc Dump.cs

ApplicationObjects: ApplicationObjects.cs
	cli-csc ApplicationObjects.cs AssemblyInfo.cs
