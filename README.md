# Clínica Veterinaria – ASP.NET Core MVC

## Descripción del Proyecto

**Clínica Veterinaria** es una aplicación web desarrollada en **ASP.NET Core MVC** que permite **registrar y visualizar información de mascotas** atendidas en una clínica veterinaria.  
El sistema fue diseñado aplicando los principios del patrón **MVC**, la **validación de datos** mediante anotaciones, y la **separación de responsabilidades** entre capas.

---

## Objetivo General

Desarrollar una aplicación web en ASP.NET Core MVC que permita registrar y visualizar información de mascotas en una clínica veterinaria, aplicando el patrón MVC, validaciones de datos y separación de responsabilidades.

---

## Historia del Cliente – “Clínica Veterinaria”

La clínica veterinaria requiere una herramienta sencilla para registrar las mascotas que atienden.  
El sistema permite ingresar los siguientes datos:

- Nombre de la mascota  
- Especie (Perro, Gato, Ave, Otro)  
- Raza  
- Edad  
- Nombre del dueño  
- Teléfono del dueño  
- Fecha de ingreso  

Los registros se almacenan en **memoria temporal** (sin base de datos) y se muestran en una tabla en la misma aplicación.

---

## Requisitos de Validación

| Campo | Validación |
|-------|-------------|
| **Nombre de la mascota** | Obligatorio, mínimo 2 caracteres |
| **Especie** | Debe seleccionarse (Perro, Gato, Ave, Otro) |
| **Edad** | Entre 0 y 25 años |
| **Nombre del dueño** | Mínimo 3 caracteres |
| **Teléfono** | Formato válido `809-555-1234` |
| **Fecha de ingreso** | No puede ser futura |

---

## Arquitectura del Proyecto

El sistema se estructura según el patrón **Model–View–Controller (MVC)**:

