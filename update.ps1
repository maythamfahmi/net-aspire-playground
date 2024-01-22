azd auth login

# Switch to Aspire project
Set-Location WeatherApp.AppHost

# Will enable InfraSynth that is used to generate Infrastructure resource
azd config set alpha.infraSynth on

# Generate infrastructure resources
azd infra synth

# Will provision resources on azure
azd up

Set-Location ..