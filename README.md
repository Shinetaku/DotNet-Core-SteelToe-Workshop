# DotNetCore with SteelToe Workshop
This workshop assumes the student has a basic understanding of PCF, with regard to pushing apps and the AppManager. The first day will start with a brief refresh of Org/Space/App in AppManager and confirm all attendees have correct desktops tools installed. A brief slide deck will be shown about the hands-on labs, with the majority of time for hands-on execution. All labs are focused on DotNet Core application development.

## Prerequisites
- [Cloud Foundry CLI](https://github.com/cloudfoundry/cli)
- [Git Client](https://git-scm.com/downloads)
- [VS Code](https://code.visualstudio.com/download) or [Visual Studio](https://www.visualstudio.com/downloads/)
- [JDK 1.8](http://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html)
**Java IDE will not be needed

## Workshop Sessions

#### Session 1: DotNet Core Deployment with High availability Enhancement
  - [Session Overview - Review app and manifest, Push to PCF, Bind MySql, Auto Scaling, and Zero Downtime](Session-01/README.md)
  - [Lab 1 - Clone Source and Push](Session-01/Lab-01/README.md)
  - [Lab 2 - Using MySql as Data Store](Session-01/Lab-02/README.md)
  - [Lab 3 - Auto Scaling the App Instances](Session-01/Lab-03/README.md)
  - [Lab 4 - Zero Downtime Deployments](Session-01/Lab-04/README.md)

#### Session 2: Spring Cloud Services and the SteelToe Framework
  - [Session Overview - Start spring cloud services and push test java app, refactor DotNet Core app to consume Spring Cloud](Session-02/README.md)
  - [Lab 5 - Start SCS and Configure](Session-02/Lab-05/README.md)
  - [Lab 6 - Service Discovery through Eureka](Session-02/Lab-06/README.md)
  - [Lab 7 - Refactor DotNet Core for Service Discovery](Session-02/Lab-07/README.md)
  - [Lab 8 - Rafactor DotNet Core with MySql Abstractions](Session-02/Lab-08/README.md)