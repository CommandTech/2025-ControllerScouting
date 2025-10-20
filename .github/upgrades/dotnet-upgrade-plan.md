# .NET 8.0 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that an .NET 8.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 8.0 upgrade.
3. Upgrade ControllerScouting\ControllerScouting.csproj


## Settings

This section contains settings and data used by execution steps.

### Excluded projects

Table below contains projects that do belong to the dependency graph for selected projects and should not be included in the upgrade.

| Project name                                   | Description                 |
|:-----------------------------------------------|:---------------------------:|


### Aggregate NuGet packages modifications across all projects

NuGet packages used across all selected projects or their dependencies that need version update in projects that reference them.

| Package Name                        | Current Version | New Version | Description                                   |
|:------------------------------------|:---------------:|:-----------:|:----------------------------------------------|
| Newtonsoft.Json                      |   13.0.3        |  13.0.4    | Update to latest patch release recommended    |


### Project upgrade details
This section contains details about each project upgrade and modifications that need to be done in the project.

#### ControllerScouting modifications

Project file: `ControllerScouting\ControllerScouting.csproj`

Project properties changes:
  - Project is a legacy non-SDK style project and needs to be converted to an SDK-style project file.
  - Target framework should be changed from `net48` (alias for .NETFramework,Version=v4.8) to `net8.0-windows`.

NuGet packages changes:
  - `Newtonsoft.Json` should be updated from `13.0.3` to `13.0.4`.

Feature upgrades / other changes:
  - Converting to SDK-style may require moving assembly binding redirects, web.config transformations, and other legacy build settings into the new project format or into code/configuration files.
  - Review usages of APIs that are Windows/.NET Framework specific (System.Web, AppDomain features, etc.) and replace or adapt as needed for .NET 8 (targeting `net8.0-windows`).

