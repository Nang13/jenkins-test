pipeline {
    agent { 
        node {
            label 'docker-agent-alpine'
            }
      }
    triggers  {
        pollSCM  '*/5 * * * *'
      }
    stages {
        stage('Hello') {
            steps {
                echo 'Hello World'
                
            }
        }
        stage('Build  and Restore') {
            steps {
                cd .\jenkins\code\
                dotnet build
                dotnet restore
                echo 'Hello World'
            }
        }
        stage('Run') {
            steps {
                cd .\jenkins\code\
                dotnet run
            }
        }
    }
}