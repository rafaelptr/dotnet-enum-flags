# .NET Enum Flags 

## Sample

```csharp
enum Enum1 : long { MyValue = 1, OtherValue = 2 }
//Enum1: 3
```
```csharp
[Flags]
enum Enum1Flags : long { MyValue = 1, OtherValue = 2 }
//Enum: MyValue, OtherValue
```
