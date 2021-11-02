cd %system.agent.home.dir%
C:\sonarqube\bin\MSBuild.SonarQube.Runner.exe begin /k:"test" /d:sonar.host.url="http://localhost:9000"  /d:sonar.login="4cd3768033086152d04ae856256a20727fd608e9"
C:\sonarqube\bin\MSBuild.SonarQube.Runner.exe end /d:sonar.login="4cd3768033086152d04ae856256a20727fd608e9"