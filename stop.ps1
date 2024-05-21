Set-Location MyApp.AppHost

azd down

Remove-Item .\.azure\ -Force -Recurse
Remove-Item .\infra\ -Force -Recurse
Remove-Item .\manifest.json -Force
Remove-Item .\azure.yaml
Remove-Item .\next-steps.md

Set-Location ..