cmake_minimum_required(VERSION 3.8)
project(MMCPrivate VERSION 0.0.0 LANGUAGES CSharp)

#add_executable(App App.cs)
#add_executable(Dump Dump.cs)

add_library(ApplicationObjects ImageAppData.cs AssemblyInfo.cs )
add_library(image2 DicomImagePrivatePS.cs)

add_executable(RoundTrip RoundTrip.cs)
target_link_libraries(RoundTrip ApplicationObjects image2)
