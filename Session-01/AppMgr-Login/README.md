[login]: img/login.png "PCF Login"
[appManagerHome]: img/appManagerHome.png "AppManager Home"

# Accessing the Workshop Environment

## CF CLI Target and Log In

1. Download the latest release of the Cloud Foundry CLI from https://github.com/cloudfoundry/cli/releases for your operating system and install it.

2. From a command prompt, set the API target for the CLI: (set appropriate end point for your environment)
```
> cf api https://api.system.XXXXXX.XXX
```
3. Log In to Pivotal Cloud Foundry:
```
> cf login
```
4. Follow the prompts, entering the username (email) and password.
```
> cf login
API endpoint: https://api.system.XXXXXX.XXX

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
## AppsManager Log In

7. Log In to Apps Manager URL: https://apps.system.XXXXXX.XXX. Use the same username and password you entered when using the CF CLI.

![alt text][login]

8. Post Log In Screen:
![alt text][appManagerHome]