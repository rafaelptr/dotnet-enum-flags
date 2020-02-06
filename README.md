# .NET Enum Flags 
[![Build Status](https://travis-ci.com/rafaelptr/dotnet-enum-flags.svg?branch=master)](https://travis-ci.com/rafaelptr/dotnet-enum-flags)
  
Enum flag annotation sample.

```csharp
enum Enum1 : long { MyValue = 1, OtherValue = 2 }
//Enum1: 3
```
```csharp
[Flags]
enum Enum1Flags : long { MyValue = 1, OtherValue = 2 }
//Enum1Flags: MyValue, OtherValue
```
