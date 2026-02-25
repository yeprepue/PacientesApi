# Pacientes API 🏥

Una API desarrollada en **.NET 8** para la gestión centralizada de pacientes. Este proyecto implementa un sistema CRUD (Crear, Leer, Actualizar, Eliminar) siguiendo las mejores prácticas de arquitectura limpia, inyección de dependencias y el patrón repositorio/servicio.

## 🚀 Características

* **Arquitectura:** Basada en controladores y servicios para una separación de responsabilidades clara.
* **Persistencia:** Integración con **Entity Framework Core** para el manejo de la base de datos.
* **Validaciones:** Uso de `DataAnnotations` para asegurar la integridad de los datos (emails, campos requeridos, etc.).
* **Tipado Moderno:** Implementación de `DateOnly` para el manejo eficiente de fechas de nacimiento.

## 🛠️ Tecnologías Utilizadas

* **Backend:** ASP.NET Core Web API (.NET 8)
* **ORM:** Entity Framework Core
* **Lenguaje:** C#

## 📂 Estructura del Módulo de Pacientes

El proyecto organiza la lógica de pacientes dentro de un módulo dedicado:

* `Models/Paciente.cs`: Definición de la entidad y reglas de validación.
* `Interface/IPacienteService.cs`: Contrato de los métodos de negocio.
* `Services/PacienteService.cs`: Lógica de implementación y comunicación con el DbContext.
* `Controllers/PacienteController.cs`: Endpoints de la API documentados.

## 📋 Endpoints Principales

| Método | Endpoint | Descripción |
| :--- | :--- | :--- |
| **GET** | `/api/paciente` | Obtener lista de todos los pacientes. |
| **GET** | `/api/paciente/{id}` | Obtener un paciente específico por su ID. |
| **POST** | `/api/paciente` | Registrar un nuevo paciente. |
| **PUT** | `/api/paciente/{id}` | Actualizar información de un paciente existente. |
| **DELETE** | `/api/paciente/{id}` | Eliminar un paciente del sistema. |

## ⚙️ Configuración y Ejecución

1. **Clonar el repositorio:**
   ```bash
   git clone [https://github.com/yeprepue/PacientesApi.git](https://github.com/yeprepue/PacientesApi.git)
   cd PacientesApi
