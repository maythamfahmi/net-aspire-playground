# Step-by-step action

Prerequisite:
- Install azd command line
- Visual Studio 2022 preview 17.9. and newer
- Visual Studio Code optional
- Docker Desktop for local development

## Login to azure
```
azd auth login
```

## Switch to Aspire project
```
cd WeatherApp.AppHost
```

## generate manifest.json
```
dotnet run --publisher manifest --output-path manifest.json
```

## Required only first time
```
azd init
```

What to answer:
```
-> Use code in the current directory

-> Confirm and continue initializing my app

[X] frontend
[ ] weatherapi

Enter a new environment name: staging-environment
```
When done successfully

```
azd up
```

-> subscription selection
-> location
wait for provision resources in Azure

## to delete resource
```
azd down
```
## Enable feature that generates bicep
```
azd config set alpha.infraSynth on
```

## Generate infra folder with bicep 
```
azd infra synth
```

I have put all commands in line order to start and stop the solution

From PowerShell:

```
.\start.ps1
```

When finished testing and playing, then clean up:

```
.\stop.ps1
```

Read more

## Aspire home

https://learn.microsoft.com/en-us/dotnet/aspire/

Note: The background of .net aspire comes from Microsoft Tye 2020, which was very useful tool, what was turned overtime into Aspire
