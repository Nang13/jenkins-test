pipeline {
    agent any
    environment {
        dotnet = 'C:\\Program Files\\dotnet\\dotnet.exe'
    }
    stages {
        stage('Build Stage') {
            steps {
                bat 'C:\\Code\\jenkins\\jenkins_test\\jenkins-test\\jenkins.sln --configuration Release'
            }
        }
        stage('Clone') {
            steps {
                git branch : 'main' , credentialsId: '839d6120-6449-40e8-a1ec-b824be566c31', url: 'https://github.com/Nang13/jenkins-test.git'
            }
        }
        stage('Test Stage') {
            steps {
                bat 'dotnet test %WORKSPACE%\\jenkins\\Test.csproj'
            }
        }
    }
}