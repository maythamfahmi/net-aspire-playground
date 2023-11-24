# Step by step action

Prerequest:
- Install azd command line
- Visual Studio 2022 preview

# Login to azure
azd auth login

# Switch to Aspire project
cd WeatherApp.AppHost

# generate manifest.json
dotnet run --publisher manifest --output-path manifest.json

# Required only first time
azd init
-> Use code in the current directory

-> Confirm and continue initializaing my app

[X] frontend
[ ] weatherapi

Enter a new environment name: staging-environment

When don successfully

azd up
-> subscription selection
-> location
wait provision resources in azure

# to delete resource
azd down

# Enable feature that generate bicep
azd config set alpha.infraSynth on

# Generate infra folder with bicep 
azd infra synth

Read more

Aspire home
https://learn.microsoft.com/en-us/dotnet/aspire/

Note: Background of .net aspire come from Microsoft Tye 2020, was very usful tools, what was turned overtime to Aspire