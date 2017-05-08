# DotNet Core with SteelToe Workshop
This workshop assumes the student has a basic understanding of PCF, with regard to pushing apps and the AppManager. The first day will start with a brief refresh of Org/Space/App in AppManager and confirm all attendees have correct desktops tools installed. A brief slide deck will be shown about the hands-on labs, with the majority of time for hands-on execution. All labs are focused on DotNet Core application development.

## Prerequisites
- [Cloud Foundry CLI](https://github.com/cloudfoundry/cli)
- [Git Client](https://git-scm.com/downloads)
- [VS Code](https://code.visualstudio.com/download) or [Visual Studio](https://www.visualstudio.com/downloads/)
- [JDK 1.8](http://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html)
**Java IDE will not be needed

## Workshop Sessions

#### Session 1: DotNet Core Deployment with High availability Enhancement [Start Session](Session-01/README.md)
  - AppManager Refresh - Review AppManager layout and confirm login credentials
  - Session Overview - Review app and manifest, Push to PCF, Bind MySql, Auto Scaling, and Zero Downtime
  - Lab 1 - Clone Source and Push
  - Lab 2 - Using MySql as Data Store
  - Lab 3 - Auto Scaling the App Instances
  - Lab 4 - Zero Downtime Deployments

#### Session 2: Spring Cloud Services and the SteelToe Framework [Start Session](Session-02/README.md)
  - Session Overview - Start spring cloud services and push test java app, refactor DotNet Core app to consume Spring Cloud
  - Lab 5 - Start SCS and Configure
  - Lab 6 - Service Discovery through Eureka
  - Lab 7 - Refactor DotNet Core for Service Discovery
  - Lab 8 - Rafactor DotNet Core with MySql Abstractions