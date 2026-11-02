# Grupo2 - Participación Individual

# Grupo 2 - Relación Facultad y Carrera

## Tema
Implementación de una relación uno a muchos entre Facultad y Carrera
utilizando ASP.NET Core MVC, Entity Framework Core y SQL Server.

## Integrantes
| Integrante  | Participación |
| :--- :--- |
| **Julio Emerson Coro Pineida**   | 100% |
| **Darla Sabrina Llano Guamani** | 100% |

## Relación
Una Facultad puede tener muchas Carreras.
Una Carrera pertenece a una Facultad.

Facultad 1 ---- N Carrera

## Aportes
- Integrante 1: Modelo Carrera y CRUD inicial.
- Integrante 2: Validaciones y migración.
- Integrante 3: Modelo Facultad y relación.
- Integrante 4: Corrección del formulario y documentación.

## Cómo ejecutar

1. Clonar el repositorio.
2. Abrir la solución en Visual Studio.
3. Verificar la conexión a SQL Server Express.
4. Ejecutar Update-Database.
5. Ejecutar el proyecto.
6. Acceder a Facultades y Carreras desde el menú.














Un sistema web desarrollado para administrar y gestionar los procesos académicos, en una institución educativa.

---

  Integrantes y Entidades Desarrolladas




  Pasos para Ejecutar el Proyecto

Sigue estos pasos para configurar el entorno local, aplicar las migraciones de la base de datos y ejecutar la aplicación.

1. Requisitos Previos.

* [.NET SDK](https://dotnet.microsoft.com/) (Versión 10.0.402).
* [SQL Server 2025].
* Entity Framework Core CLI instalado.
* SSMS 22.
* Visual Studio 2026.

---

2. Configurar la Cadena de Conexión (Connection String)

Abre el archivo `JSON.cs` ubicado en la raíz del proyecto principal y configura la cadena de conexión apuntando a tu servidor local de SQL Server:

```json
{
  "ConnectionStrings": {
    "SGEContext": "Server=localhost;Database=SGEADB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true"
  }
}

```
3. Pasos:
* Install-Package System.Security.Cryptography.Pkcs
* Add-Migration InitialCreate.
* Update-Database.
