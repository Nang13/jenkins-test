pipeline {
     agent { 
        node {
            label 'docker-agent-alpine'
            }
      }
    stages {
        stage('Hello') {
            steps {
                echo 'Hello World'
            }
        }
    }
}