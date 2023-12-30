azd auth login

# Switch to Aspire project
Set-Location WeatherApp.AppHost

# Will enable InfraSynth that is used to generate Infrastructure resource
azd config set alpha.infraSynth on

# Generate infrastructure resources
azd infra synth

# This might be required as manual interaction or via command line, it is reported issue
# Connect-AzAccount
# $name=(Get-AzContainerRegistry -ResourceGroupName "rg-$env").Name
# Update-AzContainerRegistry -Name $name -ResourceGroupName rg-$env -EnableAdminUser

# Will provision resources on azure
azd up

Set-Location ..