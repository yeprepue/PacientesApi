# Pacientes API 🏥

Una API robusta desarrollada en **.NET 8** para la gestión centralizada de pacientes. Este proyecto implementa un sistema CRUD completo siguiendo principios de **Clean Architecture**, Inyección de Dependencias y el patrón **Repository/Service**.

## 🚀 Características Técnicas

* **Arquitectura:** Desacoplamiento total mediante interfaces y servicios.
* **Persistencia:** SQL Server con **Entity Framework Core (Code First)**.
* **Validaciones:** Reglas de integridad mediante `DataAnnotations` en el modelo.
* **Eficiencia:** Uso de tipos nativos de .NET 8 como `DateOnly` para optimizar el manejo de fechas.
* **Documentación:** Integración completa con **Swagger/OpenAPI**.

## 🛠️ Stack Tecnológico

* **Runtime:** .NET 8.0 SDK
* **Lenguaje:** C# 12
* **ORM:** Entity Framework Core 8.0
* **Base de Datos:** SQL Server / Azure SQL

## 📂 Estructura del Proyecto

El módulo de pacientes está organizado para facilitar la escalabilidad:
* `Controllers/`: Endpoints de la API y manejo de peticiones HTTP.
* `Services/`: Lógica de negocio pura.
* `Interfaces/`: Contratos para la inversión de control (IoC).
* `Models/`: Entidades de dominio y esquemas de base de datos.
* `Data/`: Contexto de base de datos (`DbContext`) y configuraciones de EF.

## ⚙️ Configuración y Ejecución

Sigue estos pasos para levantar el entorno de desarrollo:

### 1. Prerrequisitos
* Tener instalado el **SDK de .NET 8.0**.
* Instancia de **SQL Server** activa.
* Instalar las herramientas de Entity Framework Core globalmente:
    ```bash
    dotnet tool install --global dotnet-ef
    ```

### 2. Instalación y Dependencias
Clona el repositorio y restaura los paquetes NuGet:
```bash
git clone [https://github.com/yeprepue/PacientesApi.git](https://github.com/yeprepue/PacientesApi.git)
cd PacientesApi
dotnet restore
```
### 3. Configuración de Base de Datos
Abre appsettings.json y actualiza tu cadena de conexión en la sección ConnectionStrings:
```
"DefaultConnection": "Server=TU_SERVIDOR;Database=PacientesDb;Trusted_Connection=True;TrustServerCertificate=True;"
```
### 4. Migraciones y Persistencia
```
dotnet ef database update
```
### 5. Lanzamiento
```
dotnet run
```

O utiliza dotnet watch run para habilitar el Hot Reload mientras programas.

## 📋 Endpoints Principales

Método	Endpoint	Acción
GET	   /api/paciente	Listar todos los registros.
GET	   /api/paciente/{id}	Consultar por ID único.
POST	   /api/paciente	Crear un nuevo registro.
PUT	   /api/paciente/{id}	Actualización total de entidad.
DELETE	/api/paciente/{id}	Eliminación física del registro.

## 🔍 Testing & Documentation
Una vez iniciada la API, accede a la documentación interactiva en:
```
👉 https://localhost:5031/swagger/index.html
```

## Captura

<img width="1904" height="935" alt="image" src="https://github.com/user-attachments/assets/694e1b2c-57e6-417d-8964-5971485a9f33" />


Desarrollado por Yeison Esteban Pretel
