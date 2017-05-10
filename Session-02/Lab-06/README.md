[appmanager-service-registry]: img/appmanager-service-registry.png " "

# Lab 06 - Service Discovery through Eureka

## Add Spring Cloud Service Registry
1. Navigate to the Marketplace and select Service Registry service.
appmanager-service-registry

2. There is only one plan available. Click on 'Select this plan' button and name it SCS-Registry.







XX. The provided Java app (jar) has some special features. Most noteably each method has been annotated with Spring Cloud Services declarations.
```java
@SpringBootApplication
@EnableJpaRepositories
@EnableDiscoveryClient
public class FortuneTeller {
```