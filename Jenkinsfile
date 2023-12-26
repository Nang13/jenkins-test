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
    }
}