#### [ModComponent](index.md 'index')
### [ModComponent](index.md#ModComponent 'ModComponent').[Public](Public.md 'ModComponent.Public')

## Public.AddDependencyEntry(string, string[], bool) Method

Add a DependencyChecker entry, MC filenames should not include the extension  
(should be called OnInitializeMelon, does not require MC to be ready)

```csharp
public static void AddDependencyEntry(string MCFileName, string[] RequiresMCFileNames, bool RequiresDlc=false);
```
#### Parameters

<a name='ModComponent.Public.AddDependencyEntry(string,string[],bool).MCFileName'></a>

`MCFileName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the ModComponent file the dependency is for

<a name='ModComponent.Public.AddDependencyEntry(string,string[],bool).RequiresMCFileNames'></a>

`RequiresMCFileNames` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

Array of ModComponent filenames required

<a name='ModComponent.Public.AddDependencyEntry(string,string[],bool).RequiresDlc'></a>

`RequiresDlc` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Does this ModComponent file require the DLC to be loaded