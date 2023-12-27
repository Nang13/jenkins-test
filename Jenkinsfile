pipeline {
    agent any
    environment {
        myVersion = '0.9'
        dotnet = 'path\\to\\dotnet.exe'
    }
    tools {
        msbuild '.NET Core 7.0.0'
    }
    stages {
        stage('checkout') {
          steps {
            bat 'dotnet build'
          }
        }
        stage('restore') {
            steps {
                bat 'dotnet restore --configfile NuGet.Config'
            }
        }
        stage('build') {
            steps {
                bat 'dotnet build'
            }
        }
        stage('publish') {
            steps {
              ...
            }
        }
    }
}
