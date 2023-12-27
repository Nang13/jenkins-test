pipeline {
    agent any
    enviroment {
        myVersion = '0.9'
        dotnet = 'path\to\dotnet.exe'
    }
    tools {
        msbuild '.NET Core 7.0.0'
    }
    triggers {
        pollSCM '*/5 * * * *'
    }
    stages {
        stage('Hello') {
            steps {
                echo 'Hello World'
            }
        }
        stage('Build and Restore') {
            steps {
                dir(path: 'jenkins/code') {
                    bat 'dotnet build'
                    bat 'dotnet restore'
                }
            }
        }
        stage('Run') {
            steps {
                dir(path: 'jenkins/code') {
                    bat 'dotnet run'
                }
            }
        }
    }
}
