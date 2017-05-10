[login]: img/login.png "PCF Login"
[appManagerHome]: img/appManagerHome.png "AppManager Home"

# Accessing the Workshop Environment

## CF CLI Target and Log In

1. Download the latest release of the Cloud Foundry CLI from https://github.com/cloudfoundry/cli/releases for your operating system and install it.

2. From a command prompt, set the API target for the CLI: (set appropriate end point for your environment)
```
> cf api <PROVIDED_BY_INSTRUCTOR>
```
3. Log In to Pivotal Cloud Foundry and follow the prompts, entering the username (or email) and password.
```
> cf login
API endpoint: https://api.system.xxxxxxx.xxx

Email> USER123

Password>
Authenticating...
OK
```
5. Choose your assigned student Org

6. Choose the "Development" space
```
API endpoint:   https://api.system.XXXXXX.XXX
User:           USER123
Org:            Student01
Space:          Development
```
7. Great! You have confirmed proper access to PCF.

## AppsManager Log In

7. Log In to Apps Manager URL: <PROVIDED_BY_INSTRUCTOR>. Use the same username and password you entered when logging into the CF CLI.
![alt text][login]

8. Post Log In Screen:
![alt text][appManagerHome]

9. Your a champ!

## [Home](../../README.md) ================================================================[Next Lab-01](../Lab-01/README.md)