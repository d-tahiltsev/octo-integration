
# AlaskaX | Octo Travel Integration REST API | v0.1.0

**Welcome to the Octo Travel Integration API**

This repository showcases a small demonstration of the benefits of hexagonal architecture for project setup and its associated advantages.

---

## Framework

Built using **.NET 8.0 C#**

---

## Architecture Layers

### **Adapters**
Adapters are external or specialized packages that can be detached from the project at any time, making them reusable across different layers, projects, or solutions. If required, all adapters can even be packaged as a NuGet Package.

- **Octo-Travel**
  - Integration with the Octo Travel API, designed with an interface to enable flexibility and proper dependency injection. This adapter could be separated into a standalone NuGet Package. 
  - All integration logic, including specific request and response DTOs, authentication, and related tasks, is handled here.

### **Application**
This layer contains service implementations that drive the business logic for APIs or scheduled jobs. Any logic that directly impacts the application should reside in this layer.

### **Domain**
The domain layer is where Domain-Driven Design (DDD) principles are applied. It defines business rules, entities, and Data Transfer Objects (DTOs) that convert entities into API request and response objects, shielding the data model structure and preserving business secrets.

### **Infrastructure**
This layer includes intermediate-level configurations such as cron job settings, task structures, and database certificates that can be shared across multiple APIs.

- **Data**
  - This sublayer houses repositories based on domain interfaces. These repositories depend on the chosen database implementations, allowing flexible depth based on database requirements.

- **IoC (Inversion of Control)**
  - The IoC sublayer connects APIs to internal layers through dependency injection, enabling flexibility in database connections and other configurations.

### **Rest API**
This layer includes controllers and instance configurations for the API, in this case, a REST API. Depending on project requirements, other instances like gRPC APIs or mobile-optimized APIs can also be added to the solution.

---

## How to Run

1. Configure the environment variable `OCTO_TRAVEL_API_KEY` with your Octo Travel API Key. This key will be automatically applied to the adapter instance.

2. Run the application either:
   - As a **unit test** for scoped validation.
   - Through the API by navigating to the Swagger UI.

``` dotnet run --project .\AlaskaX.Dmytro.RestAPI ```

3. To allow access to the localhost from the web, use a tunnel. ([See more...](https://dev.to/jagkush/a-quick-way-to-access-your-local-server-on-the-internet-4kei))

``` ssh -R 80:localhost:8080 ssh.localhost.run ```


---

## About

**Developed by:** Dmytro Tahiltsev  
**Location:** Kyiv, Ukraine  
**Contact:** [dmytrotahiltsev@gmail.com](mailto:dmytrotahiltsev@gmail.com)

---
