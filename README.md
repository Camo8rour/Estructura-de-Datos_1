# ✈️ **Aire Tour - Simulador de Vuelos** 🌍

## 🚀 Descripción

¡Bienvenido al simulador de vuelos de **Aire Tour**! Esta aplicación ha sido desarrollada en **C#** en modo consola y tiene como objetivo calcular el valor a pagar por un vuelo según el destino, la clase del vuelo, el estrato socioeconómico del cliente, el día de la semana y el género del pasajero. 🎉

### 📋 Requisitos
- **Lenguaje:** C#
- **Modo:** Consola
- **Función:** Calcular el valor del vuelo y aplicar descuentos según diferentes factores.

## 🛫 Tabla de Valores por Destino y Clase de Vuelo

| Destino   | Clase A   | Clase B   | Clase C   |
|-----------|-----------|-----------|-----------|
| Bogotá    | $300,000  | $225,000  | $150,000  |
| Medellín  | $420,000  | $315,000  | $210,000  |
| Florencia | $270,000  | $202,500  | $135,000  |
| Pitalito  | $250,000  | $187,500  | $125,000  |

## 💸 Descuentos por Estrato Socioeconómico

| Estrato | Descuento |
|---------|-----------|
| 1       | 10%       |
| 2       | 10%       |
| 3       | 7%        |
| 4       | 7%        |
| 5       | 5%        |
| 6       | 5%        |

## 📅 Descuentos por Día de la Semana

| Día       | Descuento |
|-----------|-----------|
| Lunes     | 10%       |
| Martes    | 10%       |
| Miércoles | 10%       |
| Jueves    | 5%        |
| Viernes   | 5%        |
| Sábado    | 0%        |
| Domingo   | 0%        |

## 👩‍🦰 Descuento Adicional por Género

La aerolínea **Aire Tour** está ofreciendo un **descuento adicional del 3%** para mujeres.

## 💻 Instrucciones de Uso

1. Al ejecutar la aplicación, se mostrará la siguiente información inicial:

   - Nombre completo del estudiante
   - Nombre de la aplicación (**Aire Tour**)
   - Nombre del curso
   - Contraseña de acceso (la contraseña por defecto es `123`)

2. Si la contraseña ingresada es correcta, se te llevará a la siguiente pantalla para ingresar los datos del estudiante y realizar los cálculos.

3. Los datos que debes ingresar son:
   - **Número de Identificación**
   - **Nombre Completo**
   - **Destino del Vuelo**
   - **Clase del Vuelo (A, B, C)**
   - **Estrato Socioeconómico**
   - **Género (Masculino/Femenino)**
   - **Día de la Semana del Vuelo**

4. La aplicación calculará automáticamente:
   - El valor del vuelo
   - El descuento aplicado por estrato
   - El descuento aplicado por día de la semana
   - El descuento adicional por género (si aplica)

5. **Resultado Final:** El simulador mostrará en pantalla la siguiente información:
   - Identificación
   - Nombre completo
   - Género
   - Destino del vuelo
   - Clase del vuelo
   - Estrato socioeconómico
   - Día de la semana del vuelo
   - Valor total a pagar del vuelo
   - Descuento obtenido

## 🎯 Ejemplo de Salida

```plaintext
Bienvenido a Aire Tour ✈️

Por favor, ingresa la contraseña:
> 123

¡Acceso autorizado!

Ingresa los siguientes datos:
Número de Identificación: 123456789
Nombre Completo: Juan Pérez
Destino del Vuelo: Bogotá
Clase de Vuelo: A
Estrato: 3
Género: Masculino
Día de la Semana: Lunes

---

Información Final:
Identificación: 123456789
Nombre: Juan Pérez
Género: Masculino
Destino del Vuelo: Bogotá
Clase de Vuelo: A
Estrato: 3
Día de la Semana: Lunes
Valor Total a Pagar: $270,000
Descuento: 20% (Estrato + Día de la Semana)
