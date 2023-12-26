pipeline {
  agent { 
        node {
            label 'my_dotnet_test_1'
            }
      }
      triggers {
        pollSCM '*/5  * * * *'
    }
    stages {
        stage('Hello') {
            steps {
                echo 'Hello World'
            }
        }
    }
}
