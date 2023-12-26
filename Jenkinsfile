pipeline {
    agent any
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
                    sh 'dotnet build'
                    sh 'dotnet restore'
                }
            }
        }
        stage('Run') {
            steps {
                dir(path: 'jenkins/code') {
                    sh 'dotnet run'
                }
            }
        }
    }
}
