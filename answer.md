
## 1. .csproj Contents

<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>



## 2. Does #region / #endregion change the compiled output?

No. #region and #endregion do not change the compiled output.
They are only used by the IDE to organize sections of code.
They can still be useful for keeping large files organized and making the code easier to read.


## 3. When would you use /// XML documentation comments instead of plain //?

I would use /// XML documentation comments when I want to document a public class method property or parameter.

They can be used by IDEs to show documentation and can also be used to generate XML documentation for the project.

Plain // comments are better for short notes or explaining implementation details inside the code.


## 4. 4. Why does C# have no true global variables, and what's the closest equivalent?

C# has no true global variables because variables must belong to a type or a specific scope.
This helps keep code organized and avoids uncontrolled shared state. 
