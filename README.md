# .NET Multi-Project Build Workflow

## Overview
This repository includes a multi-project .NET build workflow designed to facilitate seamless development and deployment of .NET applications.

## Key Features
- **Modular Architecture:** Supports multiple .NET projects within a single solution.
- **CI/CD Integration:** Easy integration with Continuous Integration and Continuous Deployment pipelines.
- **Consistent Build Process:** Automated build and testing to ensure code quality and performance.

## Required Secrets
To successfully build and deploy the projects, the following secrets must be configured in your CI/CD pipeline:
- `DOCKER_USERNAME`: Your Docker Hub username for containerization.
- `DOCKER_PASSWORD`: Your Docker Hub password.
- `AZURE_STORAGE_CONNECTION_STRING`: Connection string for Azure Storage if applicable.

## Directory Structure
The directory structure of the repository is as follows:
```
/.net_app
    ├── ProjectA
    │   ├── ProjectA.csproj
    │   └── ...
    ├── ProjectB
    │   ├── ProjectB.csproj
    │   └── ...
    └── BuildScripts
        └── build.ps1
```

## Setup Instructions
1. **Clone the Repository**:
   ```
   git clone https://github.com/amashfak2020-ai/.net_app.git
   cd .net_app
   ```

2. **Restore Dependencies**:
   Run the following command to restore the necessary packages:
   ```
   dotnet restore
   ```

3. **Build the Solution**:
   To build the solution, execute:
   ```
   dotnet build
   ```

4. **Run Tests**:
   To run the unit tests, execute:
   ```
   dotnet test
   ```

5. **Deploy**:
   Use the provided build scripts or your CI/CD system to deploy the application.

For further information, please refer to the individual project documentation within their respective directories.