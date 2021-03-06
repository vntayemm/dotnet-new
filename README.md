- Install C# environment for vscode. Install <ms-vscode.csharp> extension in vscode
- Install <dotnet-sdk-2.0.0-win-x64.exe>
- Install <node.js> framework
- Install bower into global with npm > <npm install -g bower>
- Create new project with cmd > <dotnet new projectname>
- Remove all code didn't concerned in project.
- Config with <bower init> cmd
- Get package with bower management ex: >
    <bower install -S font-awesome>
    <bower uninstall -S font-awesome>

- Database package with .NET CLI
    <dotnet add package Microsoft.EntityFrameworkCore>
    <dotnet add package Microsoft.EntityFrameworkCore.Design>
    <dotnet add package Microsoft.EntityFrameworkCore.SqlServer>
    <dotnet add package Microsoft.EntityFrameworkCore.Tools>
- Database migration with <https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet>
    <dotnet ef migrations add(remove) init>
    <dotnet ef database update>

- Tools:
    Install <npm i -g maildev@0.14.0> and start <maildev> for test mail in project


- Restore .csproj <dotnet restore>
- Restore bower.json <bower restore>
- Restore nuget <nuget restore>
- Deployment step: dotnet <restore, build, test, publish> the app.

0. Git Check credential on git system
    <git config --system --unset credential.helper>
    <git config --global --unset credential.helper>

1. Tech of DI and change Service Conatainer in .net core
    - Transient lifetime services are created each time they are requested. This lifetime works best for lightweight, stateless services.+
    - Scoped lifetime services are created once per request.
    - Singleton lifetime services are created the first time they are requested

2. Choose framework
    Use .NET Core for your server application when:
    - cross-platform needs.
    - Microservices. <http://microservices.io/patterns/microservices.html>
    - Docker containers.
    - High-performance and scalable systems.
    - Side-by-side .NET versions per application.
    Use .NET Framework for your server application when:
    - Your app currently uses .NET Framework (recommendation is to extend instead of migrating).
    - Your app uses third-party .NET libraries or NuGet packages not available for .NET Core.
    - Your app uses .NET technologies that aren't available for .NET Core.
    - Your app uses a platform that doesn’t support .NET Core.
3. Microservice architecture
    Multiple
    - multiple service per host but without distribute transaction
    - multiple application
    - multiple copies app per multiple machine
    - multiple team
