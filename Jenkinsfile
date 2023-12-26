pipeline {
  agent { 
        node {
            label 'docker-agent-alpine'
            }
      }
      triggers {
        pollSCM '*  * * * *'
    }
    stages {
        stage('Hello') {
            steps {
                echo 'Hello World'
            }
        }
    }
}
