# CometPeak Unity & C# Logging
This project will allow pure C# projects that want to use logging, to easily switch to logging in the Unity game engine, so that they may work with both.

:information_source: This project is **geared towards C# Visual Studio projects,** so that they may work both in a pure C# environment, and also in Unity, **but not the other way around.** Unity projects are assumed to contain code specific to Unity, and do not need generalization at this time (for our needs).

## Usage in Your Projects
To use CometPeak Unity C# Logging in your project, we recommend the following:
1. Download a .zip of one of the latest [Github Releases](https://github.com/cometpeakgames/cometpeak-unity-csharp-logging/releases).
2. Unzip the folder into your Unity or VS C# project.
3. Include the DLL:
    - a) In your Unity project, the DLL should be recognized and linked automatically for you. It's a .NET Standard 2.0 library, so it should be compatible with most Unity 2018+ projects.
    - b) In your VS C# project, you can include a reference to the DLL, either with the GUI in your Solution Explorer, or by adding something similar to the following in your .csproj file(s):
      ```xml
      <ItemGroup>
        <Reference Include="CometPeak.UnityCSharpLogging">
          <HintPath>..\Libraries\CometPeak.UnityCSharpLogging (CSharp) v0.1.1\netstandard2.0\CometPeak.UnityCSharpLogging.dll</HintPath>
        </Reference>
      </ItemGroup>
      ```

## Note about Nuget Packages
⚠️ Note that we currently don't distribute Nuget packages of this, since Unity doesn't support Nuget packages, and it might interfere with Unity compatibility.

However, we might start distributing them in the future, especially if we can confirm that your VS C# project can reference a Nuget package, and **also** be successfully imported into a Unity project (when manually providing the DLL(s) of the referenced NuGet package(s) alongside your VS C# project's DLLs within your Unity project).

This should be explored sometime soon.
