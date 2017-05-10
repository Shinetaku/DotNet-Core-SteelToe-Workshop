[vsCodeStartupCs]: img/vsCodeStartupCs.png " "
[vsCodeFortuneControllerCs]: img/vsCodeFortuneControllerCs.png " "
[vsCodeFortuneCs]: img/vsCodeFortuneCs.png " "
[appManagerAppsPage]: img/appManagerAppsPage.png " "
[fortuneTellerWebSite]: img/fortuneTellerWebSite.png " "

# Lab 01 - Clone Source and Push App

## Clone Source

1. Download the app source code, by cloning Git Repo
```
> mkdir DotNet-Core-SteelToe-Workshop
> cd DotNet-Core-SteelToe-Workshop
> git clone https://github.com/ddieruf/dotnet-core-fortuneteller.git
> cd FortuneTeller
```
2. Open the source code directory in IDE (using VS Code as example)
```
> ~/DotNet-Core-SteelToe-Workshop/FortuneTeller
```

## Review App Architecture

1. Data storage - Notice in the app startup, a data context of "InMemory" is created. This will (initially) be used to store the Fortunes.
![alt text][vsCodeStartupCs]
2. Entity framework - The App is utilizing EntityFrameworkCore, with a single entity of Fortune.
![alt text][vsCodeFortuneCs]
3. Microservice endpoints - The app has 6 endpoints: GET /fortunes, GET /random, GET /{fortunId}, POST fortune, PUT /{fortunId}, DELETE /{fortunId}
![alt text][vsCodeFortuneControllerCs]

## Review Manifest

1. To push the app to PCF, a configuration must be provided. The App has a manifest.yml file with all needed values.
[The app name to be used by PCF]
```
name: fortune-teller-services
```
[The url prefix to execute the microservice endpoints]
```
host: fortuneTellerService
```
[The number of instances]
```
instances: 1
```
[The amount of memory allocated to the app]
```
memory: 256M
```
[The amount of disk storage allocated to the app]
```
disk_quota: 512M
```

## Push The App
1. Open a Terminal (or command prompt) and navigate to the app directory.
```
> cd ~/DotNet-Core-SteelToe-Workshop/FortuneTeller
```
2. Confirm the API target is set
```
> cf target

API endpoint:   https://api.system.XXXXXX.XXX
User:           USER123
Org:            Student01
Space:          Development
```
3. Push the app
```
> cf push
```
4. The cf cli will provide feedback about each step it takes to create the App Container and deploy.

## View The App
1. Once successfully pushed, in AppManager click the 'Development' space in the left box.
![alt text][appManagerAppsPage]
2. Notice there are two apps running! Yeah!
3. The column labeled 'Route' will offer a link to execute the app. Click the route for the 'fortune-teller-www' app.
4. A new tab will be created, loading the FortuneTeller app web site.
![alt text][fortuneTellerWebSite]
5. Horray! The app is running!


___

___
| **[Prev Lab](../AppMgr-Login/README.md)** |_______________________________________________________________________________| **[Next Lab](../Lab-02/README.md)** |