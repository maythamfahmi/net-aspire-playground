# Step-by-step action

Prerequisite:
- Install azd command line
- Visual Studio 2022 preview 17.9. and newer
- Visual Studio Code Optional
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

Snapshot of `start.ps1` and `stop.ps1` process

![image](https://github.com/maythamfahmi/net-aspire-playground/assets/9260645/6df081a6-3b4b-4628-870b-8c3af4db9359)


## Learn more about Aspire

https://learn.microsoft.com/en-us/dotnet/aspire/

## Contribution

The repo will be kept updated with new changes from .net Aspire continuous releases and will be as updated as possible.

If you make a nice finding or something that I am not aware of in Aspire, please make a PR to this repo 😊

Note: The background of .net aspire comes from Microsoft Tye 2020, which was a very useful tool, that was turned over time into Aspire
