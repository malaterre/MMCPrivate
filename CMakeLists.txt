cmake_minimum_required(VERSION 3.8)
project(MMCPrivate VERSION 0.0.0 LANGUAGES CSharp)

add_executable(App App.cs)

add_executable(Dump Dump.cs)

add_executable(ApplicationObjects ApplicationObjects.cs AssemblyInfo.cs)