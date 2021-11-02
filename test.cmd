dotnet sonarscanner begin /k:"TestSonarqube" /d:sonar.host.url="http://localhost:9000"  /d:sonar.login="5885d8c80307b0b631e5d2244f2dc3932507dcc0"
dotnet build
dotnet sonarscanner end /d:sonar.login="5885d8c80307b0b631e5d2244f2dc3932507dcc0"