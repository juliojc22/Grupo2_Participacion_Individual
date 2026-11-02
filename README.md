# Grupo2 - Participación Individual

# Tema: Relación Facultad y Carrera


Implementación de una relación uno a muchos entre Facultad y Carrera
utilizando:
* [.NET SDK](https://dotnet.microsoft.com/) (Versión 10.0.402).
* [SQL Server 2025].
* Entity Framework Core CLI instalado.
* SSMS 22.
* Visual Studio 2026.

## Integrantes
| Integrante  | Participación |
| :--- | :--- |
| **Julio Emerson Coro Pineida**   | 100% |
| **Darla Sabrina Llano Guamani** | 100% |

## Relación
Una Facultad puede tener muchas Carreras.
Una Carrera pertenece a una Facultad.

Facultad 1 ---- N Carrera

## Aportes
- Integrante 1: Modelo Carrera y CRUD inicial.
- Integrante 1: Validaciones y migración.
- Integrante 2: Modelo Facultad y relación.
- Integrante 2: Corrección del formulario y documentación.

## Ejecución

1. Crear el repositorio.
2. Abrir la solución en Visual Studio.
3. Verificar la conexión a SQL Server Express.
4. Ejecutar Update-Database.
5. Ejecutar el proyecto.
6. Acceder a Facultades y Carreras desde el menú.


## Diagrama

<img width="211" height="387" alt="image" src="https://github.com/user-attachments/assets/5e51cf4c-6ee2-42b6-bf32-6cff47a66d24" />


## Configurar la Cadena de Conexión (Connection String)

Abre el archivo `JSON.cs` ubicado en la raíz del proyecto principal y configura la cadena de conexión apuntando a tu servidor local de SQL Server:

```json
{
  "ConnectionStrings": {
    "SGEContext": "Server=localhost;Database=Grupo2ADB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true"
  }
}

```
## Pasos:
* Install-Package System.Security.Cryptography.Pkcs
* Add-Migration InitialCreate.
* Add-Migration ValidacionesCarrera.
* Add-Migration AgragarFacultad.
* Update-Database
