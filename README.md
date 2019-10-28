# :bookmark_tabs: PlusTags 
Simple library for handling localization string tags from code behind of .NET applications.

## :mag: Features
- This library is a .NET Standard library built using Visual Studio 2017
- Support both .NET Framework and .NET Core Framework	
- Use only one XML file to store the information

## :pushpin: Target Applications
This library is aimed at the following type of applications:
- **Desktop**
   - Console Applications (.NET/.NET Core)
   - WinForms (.NET/.NET Core)
- **Web**
   - ASP.NET WebForms (.NET)
   - ASP.NET MVC (.NET/.NET Core)
   
## :wrench: Usage
1. Add the reference to the project.

2. Create or generate the **Tags.xml** file.

   **Option 1)** - Manually create the file.

   In the case of desktop applications (Console / Winforms), create the **Tags.xml** file in the path where the application's .exe is  located.

   In the case of web applications (ASP.NET), create the **Tags.xml** file in the root directory of the current application.

   **Option 2)** - Create the file automatically

   In order for the library to generate the file automatically, you simply have to compile and execute the project once and refresh the files to view the file.

3. Add the following structure:
- :page_facing_up: **XML file structure**
```xml
<?xml version="1.0" encoding="UTF-8"?>
<tags>
  <tag id="01">
    <value language="es-mx">Hola Mundo</value>
    <value language="en-us">Hello World</value>
  </tag>
</tags>
```
4. Add the import (VB) or using (C#):
- c#
```csharp
using PlusTags;
```
- vb
```vbnet
Imports PlusTags
```


5. Use the functions of **TagCollection** class to retrive the string value:
- TagCollection.Value(string **id**) .- Obtains the string value of the specified tag.
   - c#
   ```csharp
      ///// msj = "Hola Mundo"
      string msj = TagCollection.Value("01");
   ```
   - vb
    ```vbnet
      ' msj = "Hola Mundo"
      Dim msj As String = TagCollection.Value("01")
   ```  
   
- TagCollection.Value(string **id**, string **language**) .- Obtains the string value of the specified tag and language.
   - c#
   ```csharp
      ///// msj = "Hello World"
      string msj = TagCollection.Value("01","en-us");
   ```
   - vb
    ```vbnet
      ' msj = "Hello World"
      Dim msj As String = TagCollection.Value("01","en-us")
   ```  

## :memo: License
This project is licensed under MIT License.
