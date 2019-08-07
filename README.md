# TCDFx<br/>![Repository Size][GitHub.RepoSize.Badge] ![Repository Top Language][GitHub.RepoLang.Badge] [![Contributors][GitHub.Contributors.Badge]][GitHub.Contributors.Link] [![Codacy Status][Codacy.Badge]][Codacy.Link] [![Dependabot Status][Dependabot.Badge]][Dependabot.Link] [![Gitter Chat][Gitter.Badge]][Gitter.Link]

<!--TODO: Add 1-2 paragraphs summarizing TCDFx. -->

<small>**This README is being rewritten, and may contain outdated or missing information.**</small>

TCDFx is a small collection of cross-platform packages targeting .NET Standard 2.1 that provide helper classes, alternate P/Invoke implementations, and an API for GUI development (using [libui][Libui.Link]).

## Project Status

Currently, this project should still be considered a work-in-progress and should not be used in a production environment. Anything is subject to change at anytime (e.g.: folder restructuring, breaking API changes, etc.).

### Build Status

We use [Azure Pipelines][AzurePipelines.Link] for our CI builds. Although we currently only run builds on the following platforms, TCDFx can be built and used on any [platform supported by .NET Core 3.0][DotNetCore.SupportedOS.Link].

| <big><sub>Platform</sub>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<sup>Package</sup></big> | TCDFx.Core | TCDFx.UI  |
| ------------------------------------------------------------------------------------------------------ | ---------: | --------: |
| **Windows 8.1 (x86)<br/><br/><br/>Windows 8.1 (x64)<br/><br/>**                                        | <small>Debug: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxCore.Win81x86Debug.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub><br/>Release: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxCore.Win81x86Release.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub><br/><br/>Debug: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxCore.Win81x64Debug.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub><br/>Release: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxCore.Win81x64Release.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub></small> | <small>Debug: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxUI.Win81x86Debug.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub><br/>Release: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxUI.Win81x86Release.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub><br/><br/>Debug: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxUI.Win81x64Debug.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub><br/>Release: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxUI.Win81x64Release.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub></small> |
| **Windows 10 (x86)<br/><br/><br/>Windows 10 (x64)<br/><br/>**                                          | <small>Debug: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxCore.Win10x86Debug.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub><br/>Release: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxCore.Win10x86Release.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub><br/><br/>Debug: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxCore.Win10x64Debug.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub><br/>Release: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxCore.Win10x64Release.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub></small> | <small>Debug: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxUI.Win10x86Debug.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub><br/>Release: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxUI.Win10x86Release.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub><br/><br/>Debug: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxUI.Win10x64Debug.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub><br/>Release: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxUI.Win10x64Release.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub></small> |
| **Ubuntu 16.04 (x64)<br/><br/>**                                                                       | <small>Debug: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxCore.Ubuntu1604x64Debug.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub><br/>Release: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxCore.Ubuntu1604x64Release.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub></small> | <small>Debug: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxUI.Ubuntu1604x64Debug.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub><br/>Release: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxUI.Ubuntu1604x64Release.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub></small> |
| **macOS 10.13 (x64)<br/><br/>**                                                                        | <small>Debug: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxCore.macos1013x64Debug.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub><br/>Release: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxCore.macos1013x64Release.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub></small> | <small>Debug: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxUI.macos1013x64Debug.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub><br/>Release: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxUI.macos1013x64Release.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub></small> |
| **macOS 10.14 (x64)<br/><br/>**                                                                        | <small>Debug: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxCore.macos1014x64Debug.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub><br/>Release: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxCore.macos1014x64Release.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub></small> | <small>Debug: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxUI.macos1014x64Debug.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub><br/>Release: <sub><sub><sub><sub><sub><sub><sub>[![Build Status][BuildStatus.TCDFxUI.macos1014x64Release.Badge]][BuildStatus.Link]</sub></sub></sub></sub></sub></sub></sub></small> |

### Current Versions

**Notice**: *There are currently no stable or preview packages. The first preview packages will be released after [andlabs/libui:remodel](https://github.com/andlabs/libui/tree/remodel) is merged into [andlabs/libui:master](https://github.com/andlabs/libui/tree/master) since there are major changes to the native `libui` API.*

<!--TODO: Add description of versioning scheme. -->

| Package    | Versions  |
| :--------- | --------: |
| TCDFx.Core | ![Stable][Versions.TCDFxCore.Stable.Badge]<br/>![Stable][Versions.TCDFxCore.Preview.Badge]<br/>![Stable][Versions.TCDFxCore.CIBuild.Badge] |
| TCDFx.UI   | ![Stable][Versions.TCDFxUI.Stable.Badge]<br/>![Stable][Versions.TCDFxUI.Preview.Badge]<br/>![Stable][Versions.TCDFxUI.CIBuild.Badge] |

<!--TODO: Package Links -->

## Contributing

[![Open Issues][GitHub.Issues.Open.Badge]][GitHub.Issues.Open.Link] [![Closed Issues][GitHub.Issues.Closed.Badge]][GitHub.Issues.Closed.Link] [![Help Wanted Issues][GitHub.Issues.HelpWanted.Badge]][GitHub.Issues.HelpWanted.Link] [![Good First Issues][GitHub.Issues.GoodFirstIssue.Badge]][GitHub.Issues.GoodFirstIssue.Link]

Contributing is as easy as filing an issue, fixing a bug, or suggesting a new feature. For more information about contributing to this project, see the [CONTRIBUTING.md][File.Contributing.Link] file.

[AzurePipelines.Link]: https://azure.microsoft.com/en-us/services/devops/pipelines/
[BuildStatus.Link]: https://dev.azure.com/tom-corwin/tcdfx/_build/latest?definitionId=15&branchName=master
[BuildStatus.TCDFxCore.Win81x86Debug.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxCore_Win81x86_Debug
[BuildStatus.TCDFxCore.Win81x86Release.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxCore_Win81x86_Release
[BuildStatus.TCDFxCore.Win81x64Debug.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxCore_Win81x64_Debug
[BuildStatus.TCDFxCore.Win81x64Release.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxCore_Win81x64_Release
[BuildStatus.TCDFxCore.Win10x86Debug.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxCore_Win10x86_Debug
[BuildStatus.TCDFxCore.Win10x86Release.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxCore_Win10x86_Release
[BuildStatus.TCDFxCore.Win10x64Debug.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxCore_Win10x64_Debug
[BuildStatus.TCDFxCore.Win10x64Release.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxCore_Win10x64_Release
[BuildStatus.TCDFxCore.Ubuntu1604x64Debug.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxCore_Ubuntu1604x64_Debug
[BuildStatus.TCDFxCore.Ubuntu1604x64Release.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxCore_Ubuntu1604x64_Release
[BuildStatus.TCDFxCore.macos1013x64Debug.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxCore_macOS1013x64_Debug
[BuildStatus.TCDFxCore.macOS1013x64Release.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxCore_macOS1013x64_Release
[BuildStatus.TCDFxCore.macos1014x64Debug.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxCore_macOS1014x64_Debug
[BuildStatus.TCDFxCore.macOS1014x64Release.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxCore_macOS1014x64_Release
[BuildStatus.TCDFxUI.Win81x86Debug.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxUI_Win81x86_Debug
[BuildStatus.TCDFxUI.Win81x86Release.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxUI_Win81x86_Release
[BuildStatus.TCDFxUI.Win81x64Debug.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxUI_Win81x64_Debug
[BuildStatus.TCDFxUI.Win81x64Release.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxUI_Win81x64_Release
[BuildStatus.TCDFxUI.Win10x86Debug.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxUI_Win10x86_Debug
[BuildStatus.TCDFxUI.Win10x86Release.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxUI_Win10x86_Release
[BuildStatus.TCDFxUI.Win10x64Debug.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxUI_Win10x64_Debug
[BuildStatus.TCDFxUI.Win10x64Release.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxUI_Win10x64_Release
[BuildStatus.TCDFxUI.Ubuntu1604x64Debug.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxUI_Ubuntu1604x64_Debug
[BuildStatus.TCDFxUI.Ubuntu1604x64Release.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxUI_Ubuntu1604x64_Release
[BuildStatus.TCDFxUI.macos1013x64Debug.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxUI_macOS1013x64_Debug
[BuildStatus.TCDFxUI.macOS1013x64Release.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxUI_macOS1013x64_Release
[BuildStatus.TCDFxUI.macos1014x64Debug.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxUI_macOS1014x64_Debug
[BuildStatus.TCDFxUI.macOS1014x64Release.Badge]: https://dev.azure.com/tom-corwin/tcdfx/_apis/build/status/TCDFx?branchName=master&jobName=TCDFxUI_macOS1014x64_Release
[Codacy.Badge]: https://img.shields.io/codacy/grade/2140aa3a23a848a28391aa3c778b9526/master.svg?label=Codacy+Grade&logo=codacy
[Codacy.Link]: https://www.codacy.com/app/tom-corwin/tcdfx?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=tom-corwin/tcdfx&amp;utm_campaign=Badge_Grade
[Dependabot.Badge]: https://badgen.net/dependabot/tom-corwin/tcdfx?icon=dependabot
[Dependabot.Link]: https://api.dependabot.com/badges/status?host=github&repo=tom-corwin/tcdfx
[DotNetCore.SupportedOS.Link]: https://github.com/dotnet/core/blob/master/release-notes/3.0/3.0-supported-os.md
[File.Contributing.Link]: https://github.com/tom-corwin/tcdfx/blob/master/CONTRIBUTING.md
[GitHub.RepoSize.Badge]: https://img.shields.io/github/repo-size/tom-corwin/tcdfx.svg?color=grey&label=Size&logo=github
[GitHub.RepoLang.Badge]: https://img.shields.io/github/languages/top/tom-corwin/tcdfx.svg?color=grey&label=C%23&logo=github
[GitHub.Contributors.Badge]: https://img.shields.io/github/contributors/tom-corwin/tcdfx.svg?color=grey&label=Contributors&logo=github
[GitHub.Contributors.Link]: https://github.com/tom-corwin/tcdfx/graphs/contributors
[GitHub.Issues.Closed.Badge]: https://img.shields.io/github/issues-closed-raw/tom-corwin/tcdfx.svg?color=grey&label=Closed%20Issues&logo=github
[GitHub.Issues.Closed.Link]: https://github.com/tom-corwin/tcdfx/issues?&q=is%3Aissue+is%3Aclosed
[GitHub.Issues.GoodFirstIssue.Badge]: https://img.shields.io/github/issues-raw/tom-corwin/tcdfx/GoodFirstIssue.svg?color=grey&label=Good%20First%20Issues&logo=github
[GitHub.Issues.GoodFirstIssue.Link]: https://github.com/tom-corwin/tcdfx/issues?q=is%3Aissue+is%3Aopen+label%3A%22GoodFirstIssue%22
[GitHub.Issues.HelpWanted.Badge]: https://img.shields.io/github/issues-raw/tom-corwin/tcdfx/HelpWanted.svg?color=grey&label=Help%20Wanted%20Issues&logo=github
[GitHub.Issues.HelpWanted.Link]: https://github.com/tom-corwin/tcdfx/issues?q=is%3Aissue+is%3Aopen+label%3A%22HelpWanted%22
[GitHub.Issues.Open.Badge]: https://img.shields.io/github/issues-raw/tom-corwin/tcdfx.svg?color=grey&label=Open%20Issues&logo=github
[GitHub.Issues.Open.Link]: https://github.com/tom-corwin/tcdfx/issues?&q=is%3Aissue+is%3Aopen
[Gitter.Badge]: https://img.shields.io/gitter/room/tom-corwin/tcdfx.svg?label=Chat&logo=gitter
[Gitter.Link]: https://gitter.im/tom-corwin/tcdfx?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge
[Libui.Link]: https://github.com/andlabs/libui
[Versions.TCDFxCore.Stable.Badge]: https://img.shields.io/nuget/v/TCDFx.Core.svg?color=blue&label=Stable&logo=nuget
[Versions.TCDFxCore.Preview.Badge]: https://img.shields.io/nuget/vpre/TCDFx.Core.svg?color=orange&label=Preview&logo=nuget
[Versions.TCDFxCore.CIBuild.Badge]: https://img.shields.io/myget/tcdfx-build/vpre/TCDFx.Core.svg?color=lightgrey&label=CIBuild&logo=nuget
[Versions.TCDFxUI.Stable.Badge]: https://img.shields.io/nuget/v/TCDFx.UI.svg?color=blue&label=Stable&logo=nuget
[Versions.TCDFxUI.Preview.Badge]: https://img.shields.io/nuget/vpre/TCDFx.UI.svg?color=orange&label=Preview&logo=nuget
[Versions.TCDFxUI.CIBuild.Badge]: https://img.shields.io/myget/tcdfx-build/vpre/TCDFx.UI.svg?color=lightgrey&label=CIBuild&logo=nuget

<!--
<hr/><hr/><hr/><hr/><hr/><hr/><hr/><hr/><hr/><hr/>

## Using TCDFx Libraries

For examples, see the `examples\` directory.

Until the first stable packages are released, you can either build the libraries from source, or use unstable pre-built packages from our [CI build feed](https://www.myget.org/feed/Details/tcdfx-build).

```
 https://www.myget.org/F/tcdfx-build/api/v3/index.json
```

### Using Pre-Built Packages

While following these instructions:

  * Replace `{PackageName}` with the package you want to use.  
  * Replace `{PackageVersion}` with the version of the package.

#### Install using Visual Studio

Open the Package Management Console, and enter the following:

```
PM> Install-Package {PackageName} -Version {PackageVersion}
```

#### Install using .NET CLI

Open a terminal (or `Command Prompt` on Windows), and enter the following:

```
dotnet add package {PackageName} --version {PackageVersion}
```

#### Install using a PackageReference

Add the following to your `.csproj`:

```xml
<ItemGroup>
  <PackageReference Include="{PackageName}" Version="{PackageVersion}" />
</ItemGroup>
```

### Building From Source

You can build the packages just by installing the prerequisites and running a few commands. Use the steps below to get started!

#### Prerequisites

The table below lists the required tools to build TCDFx and it's dependencies.

\*<small> - This is a prerequisite of [libui](https://github.com/andlabs/libui).</small>

| Operating System | Prerequisites                |
| :--------------- | :----------------------------|
| Windows 7/8.1/10 | Python 3.7.0+\*</br>Meson 0.51.0+\*</small></small><br/>Microsoft Visual Studio 2019+\*</br>Microsoft .NET Core 3.0 Preview 6+ SDK |
| Linux            | Python 3.7.0+\*</br>Meson 0.51.0+\*<br/>Ninja 1.9.0+\*<br/>Microsoft .NET Core 3.0 Preview 6+ SDK |
| macOS            | Python 3.7.0+\*</br>Meson 0.51.0+\*<br/>Xcode 10.2+\*<br/>Microsoft .NET Core 3.0 Preview 6+ SDK |

#### Build Using a CLI

Run the following command in a command-line interface in the root directory of this repository:

```
dotnet build .\source\**\*.csproj
```
--.