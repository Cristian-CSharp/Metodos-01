# Métodos en C# parte 1
Los **métodos** en C# son bloques de código reutilizables que ejecutan una tarea específica. Son esenciales para **estructurar programas**, evitar código repetitivo y mejorar la legibilidad.

## ¿Qué es un método?
Un método es una función que puede recibir datos de entrada (parámetros), procesarlos y devolver un resultado. 

📌 **Estructura de un método:**
```c#
tipo_de_retorno NombreDelMetodo(parámetros) 
{ 
// Código a ejecutar 
return valor; // Si no es void 
}
```

## Tipos de Métodos en C#
📌 **Métodos sin parámetros y con retorno**

Estos métodos no reciben valores de entrada, pero devuelven un resultado con `return`.
```c#
int sumaNumeros() 
{ 
	int num1 = 7; 
	int num2 = 9; 
	int resultado = num1 + num2; 
	return resultado; 
}
```

📌 **Métodos con parámetros y con retorno**

Se les pasan valores desde el exterior y devuelven un resultado.

```c#
int sumaNumeros(int num1, int num2) 
{ 
	int resultado = num1 + num2; 
	return resultado; 
}
```

📌 **Métodos `void` (sin retorno)**

Ejecutan una acción pero **no devuelven un valor**.
```c#
void sumaNumeros() 
{ 
	int num1 = 7;
	int num2 = 9;
	int resultado = num1 + num2; 
	Console.WriteLine(resultado); 
}
```
📌 **Regla importante**: Un método `void` **nunca** lleva `return` con un valor.

## Ejercicios:
- **Ejercicio 1: Método sin parámetros y con retorno**
Crea un método llamado `ObtenerNumeroAleatorio()` que devuelva un número aleatorio entre 1 y 100.
