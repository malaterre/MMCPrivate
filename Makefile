all : App Dump Write

App : App.cs
	cli-csc App.cs

Dump : Dump.cs
	cli-csc Dump.cs

Write : Write.cs
	cli-csc Write.cs Other.cs
