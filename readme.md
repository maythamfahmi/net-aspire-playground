# Step-by-step action

Prerequisite:
- Install azd command line
- Visual Studio 2022 preview 17.9. and newer
- Visual Studio Code Optional
- Docker Desktop for local development

## Local development
When you clone the code, open it with Visual Studio 2022 preview 17.9 and newer and set the startup project to **WeatherApp.AppHost** and fire up.

![image](https://github.com/maythamfahmi/net-aspire-playground/assets/9260645/4654bfda-8514-4392-8ed9-6b90451736c1)

With the current code, it will start a dashboard.

![image](https://github.com/maythamfahmi/net-aspire-playground/assets/9260645/5a10b79e-4469-476a-a0c5-a1f6d42a20f9)

## Azure Cloud Development

Follow the steps below:

### Login to azure
```
azd auth login
```

### Switch to Aspire project
```
cd WeatherApp.AppHost
```

### generate manifest.json
```
dotnet run --publisher manifest --output-path manifest.json
```

### Required only first time
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

### to delete the resource
```
azd down
```

### to update existing resources
```
azd config set alpha.infraSynth on
azd infra synth
azd up
```

### Enable a feature that generates bicep
```
azd config set alpha.infraSynth on
```

### Generate infra folder with bicep 
```
azd infra synth
```

I have put all commands in line order to start and stop the solution

Before running the following `start.ps1`, you need to edit it with your azure subscription id.

From PowerShell:

```
.\start.ps1
```

if you need to update the existing resources

```
.\update.ps1
```

When finished testing and playing, then clean up:

```
.\stop.ps1
```

Snapshot of `start.ps1` and `stop.ps1` process

![image](https://github.com/maythamfahmi/net-aspire-playground/assets/9260645/6df081a6-3b4b-4628-870b-8c3af4db9359)


### Learn more about Aspire

https://learn.microsoft.com/en-us/dotnet/aspire/

### Contribution

The repo will be kept updated with new changes from .net Aspire continuous releases and will be as updated as possible.

If you make a nice finding or something that I am not aware of in Aspire, please make a PR to this repo 😊

Note: The background of .net aspire comes from Microsoft Tye 2020, which was a very useful tool, that was turned over time into Aspire

### StackOverflow

- [https://stackoverflow.com/a/77536922/3088349](https://stackoverflow.com/questions/tagged/dotnet-aspire)https://stackoverflow.com/questions/tagged/dotnet-aspire

### issues

- https://github.com/dotnet/aspire/issues
- https://github.com/Azure/azure-dev/issues/3020