# .NET Application Documentation

## Multi-Project .NET Build Workflow
This section explains how to build multiple projects within a single solution using .NET CLI commands and Visual Studio.

### Building Projects with .NET CLI
1. Open a terminal and navigate to the solution directory.
2. Use the `dotnet build` command to compile the entire solution:
   ```bash
   dotnet build
   ```
3. For individual projects, navigate to their directories and run:
   ```bash
   dotnet build
   ```

### Using Visual Studio
1. Open the solution (.sln) file in Visual Studio.
2. Select the projects to build in the "Solution Explorer" and click on "Build > Build Solution".

## SonarQube Integration
This section covers how to integrate SonarQube with our .NET projects to analyze code quality.

### Setup SonarQube
1. Install SonarQube locally or use a hosted version.
2. Add the SonarScanner for .NET to your projects:
   ```bash
   dotnet tool install --global dotnet-sonarscanner
   ```
3. Configure the SonarQube properties in your project files (e.g., `SonarQube.Analysis.xml`).
4. Run the analysis:
   ```bash
   dotnet sonarscanner begin /k:"project-key"
   dotnet build
   dotnet sonarscanner end
   ```

## Snyk Security Scanning
This section discusses the integration of Snyk for security vulnerability scanning.

### Installing Snyk
1. Install Snyk globally:
   ```bash
   npm install -g snyk
   ```
2. Run a test on your project:
   ```bash
   snyk test
   ```
3. Monitor your project continuously:
   ```bash
   snyk monitor
   ```

## JFrog Artifact Management
This section provides information on using JFrog Artifactory for package management.

### Setting Up JFrog Artifactory
1. Create a JFrog account and set up your repository.
2. Configure `nuget.config` to use Artifactory:
   ```xml
   <configuration>
     <packageSources>
       <add key="Artifactory" value="https://your-artifactory-url/artifactory/api/nuget/your-repo" />
     </packageSources>
   </configuration>
   ```
3. Use `dotnet nuget push` to deploy packages to Artifactory.

## Key Features
- Multi-project build support
- Code quality analysis with SonarQube
- Security scanning with Snyk
- Efficient package management with JFrog Artifactory

## Required Secrets
Ensure the following secrets are configured in your CI/CD environment:
- SonarQube token
- Snyk API token
- JFrog Artifactory credentials

## Directory Structure
```
/.net_app
  /Project1
  /Project2
  /Project3
  README.md
```

## Setup Instructions
1. Clone the repository:
   ```bash
   git clone https://github.com/amashfak2020-ai/.net_app.git
   ```
2. Run `dotnet restore` to install dependencies.
3. Build the solution as described above.

## Troubleshooting Guide
- If you encounter issues during the build, ensure that all project dependencies are correctly referenced.
- For SonarQube integration issues, check the logs for detailed error messages.
- If Snyk reports vulnerabilities, review the suggested fixes and update dependencies accordingly.

---
*Last updated: 2026-02-25 03:28:58 UTC*