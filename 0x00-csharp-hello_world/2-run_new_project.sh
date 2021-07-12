#!/usr/bin/env bash
mkdir 2-new_project
cd 2-new_project/
dotnet new console
dotnet build
cd ~ and mkdir bin
export PATH=$PATH:/home/vagrant/holbertonschool-csharp/bin/
touch bashscript
chmod u+x bashscript
echo "Hello World!"
