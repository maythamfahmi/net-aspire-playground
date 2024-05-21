azd auth login

# customize settings
$env = "staging-qa"
$subscription = "<put your subscription guid>"
$location = "swedencentral"

# Switch to Aspire project
Set-Location MyApp.AppHost

# Publish configuration manifast based on the apsire project
dotnet run --publisher manifest --output-path manifest.json

# Required only first time
azd init -e $env -l $location -s $subscription 

# Will enable InfraSynth that is used to generate Infrastructure resource
azd config set alpha.infraSynth on

# Generate infrastructure resources
azd infra synth

# Will provision resources on azure
azd up

# This might be required as manual interaction or via command line, it is reported issue
# $name=(Get-AzContainerRegistry -ResourceGroupName "rg-$env").Name
# Update-AzContainerRegistry -Name $name -ResourceGroupName rg-$env -EnableAdminUser

Set-Location ..