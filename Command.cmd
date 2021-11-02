dotnet sonarscanner begin /k:"test" /d:sonar.host.url="http://localhost:9000"  /d:sonar.login="4cd3768033086152d04ae856256a20727fd608e9"
dotnet build
dotnet sonarscanner end /d:sonar.login="4cd3768033086152d04ae856256a20727fd608e9"