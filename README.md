# Refactoring Workshop

A collaborative exercise on refactoring the TemplateProcessor class and cleaning up the code smells.

## Prerequisites

### Install Tools

- Install Chocolatey using powershell. Execute in elevated prompt 

`Set-ExecutionPolicy Bypass -Scope Process` 

then

`Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://community.chocolatey.org/install.ps1'))` 

Run `install.bat` in the elevated promt or run individual commands:
- Install Git command line executable `choco install git -y`
- Install DotNet SDK `choco install dotnet-sdk`
- Install Visual Studio Code `choco install vscode -y`
- Install mob.sh `choco install mob -y`
- Refresh environment `refreshenv`
- Install Visual Studio Code C# Extension ` code --install-extension ms-dotnettools.csharp`
- Install mob.sh Visual Studio Extension: `code --install-extension alessandrosangalli.mob-vscode-gui`

### Learn how mob.sh in Visual Studio Code is used
Watch the following short video: https://youtu.be/QDZGIozYiIw

## Clone the repository

Command using ssh: 

`git clone git@github.com:darsen-ever/refactoring-workshop.git`

Command using https: 

`https://github.com/darsen-ever/refactoring-workshop.git`

## Build the Project

CD into RefactoringWorkshop

`cd RefactoringWorkshop`

Run the bild

`dotnet build`

Open the project in Visual Studio Code

`code .`

Have fun! :)