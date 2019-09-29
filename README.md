[![Build status](https://ci.appveyor.com/api/projects/status/github/bytedev/ByteDev.Common?branch=master&svg=true)](https://ci.appveyor.com/project/bytedev/ByteDev-Common/branch/master)
[![NuGet Package](https://img.shields.io/nuget/v/ByteDev.Common.svg)](https://www.nuget.org/packages/ByteDev.Common)

# ByteDev.Common

Common is a collection of generic utility methods.

## Installation

ByteDev.Common has been written as a .NET Standard 2.0 library, so you can consume it from a .NET Core or .NET Framework 4.6.1 (or greater) application.

ByteDev.Common is hosted as a package on nuget.org.  To install from the Package Manager Console in Visual Studio run:

`Install-Package ByteDev.Common`

Further details can be found on the [nuget page](https://www.nuget.org/packages/ByteDev.Common/).

## Code

The repo can be cloned from git bash:

`git clone https://github.com/ByteDev/ByteDev.Common`

## Usage

Common has classes covering general extensions such as String, Enum, Guid, Uri, etc.  

As well as functionality covering the following namespaces:
- Encoding
- Exceptions
- Reflection
- Serialization
- Threading
- Time
- Xml

As of version 6.0.0 the Collections namespace has been moved to package: ByteDev.Collections.