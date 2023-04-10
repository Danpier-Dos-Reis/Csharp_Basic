# Description
In this practices I learn how to connect my API to SqlServer DataBase using _Entity Framework Core Database_ nuget library.

I need Entity Framework Core Database for use DbContext class and handler my DB.

# DAL
It's a project that content the class "DALConnectionString" and it has a method that return us the connection string.

# Nuget Package
* Microsoft.EntityFrameworkCore: Important to use class **DbContext**
* Microsoft.EntityFrameworkCore.SqlServer

## Notes
* Añadí el string de conexión de forma externa (desde otro proyecto en local). En internet suele agregarse al archivo **appsettings.json** de la siguiente manera:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "MyConnection":"Data Source=DESKTOP-Name;Initial Catalog=TestDB;User id=sa;Password=mypassword;Trusted_Connection=SSPI;TrustServerCertificate=true;Encrypt=false;"
  }
}
```

Y por último generar el servicio de conexión en el archivo **Program.cs**:

<pre><code>
<span style="color:purple;">builder</span>.<span style="color:cyan;">Services</span>.<span style="color:orange;">AddDbContext</span><<span style="color:lightgreen;">PruebaDBContext</span>><span style="color:orange;">(</span><span style="color:purple;">builder</span>.<span style="color:red;">Configuration</span>.<span style="color:cyan;">GetConnectionString</span><span style="color:magenta;">(</span><span style="color:coral;">"MyConnection"</span><span style="color:magenta;">)</span><span style="color:orange;">)</span>;
</code></pre>