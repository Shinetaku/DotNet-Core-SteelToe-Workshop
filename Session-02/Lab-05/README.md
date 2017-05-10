# Lab 05 - Start Spring Cloud Services and Configure

## Clone Source
1. Download the app source code, by cloning Git Repo
```
> mkdir SCS-Java-App
> cd SCS-Java-App
> git clone https://github.com/ddieruf/SCSJavaApp.git
> cd SCSJavaApp
```

## Push The App
1. Open a Terminal (or command prompt) and navigate to the app directory.
```
> cd ~/SCS-Java-App/SCSJavaApp
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

##Bind Service Registry