# Local dev experience

## Appsettings

- Set env variable ASPNETCORE_Environment to Development:

  - Windows (non powershell): `SET ASPNETCORE_Environment=Development`
  - Mac & Linux: `export ASPNETCORE_Environment=Development`

- Copy `appsettings.json` to `appsettings.Development.json` and replace missing keys.

## Run Application

### Backend + Frontend

Use AngularCliServer instead ProxyToSpa in [Startup.cs](./clicky-clicky/Startup.cs).

```csharp
if (env.IsDevelopment())
{
    spa.UseAngularCliServer(npmScript: "start");
    //spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
}
```

Execute `dotnet run` inside clicky-clicky directory.

### Backend and Frontend seperate

Use ProxyToSpa instead of AngularCliServer in [Startup.cs](./clicky-clicky/Startup.cs).

```csharp
if (env.IsDevelopment())
{
    //spa.UseAngularCliServer(npmScript: "start");
    spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
}
```

- Execute `dotnet run` inside clicky-clicky directory.
- Execute `npm start` inside ClientApp.
