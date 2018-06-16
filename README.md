
# Introducción:
Supongamos que tenemos la siguiente lista:

A = {55, 86, 32, 12, 82, 43}

Aquí tenemos una simple lista conformada por 6 datos, supongamos que necesitas ordenar esta lista, ¿Como lo harías?, relativamente es fácil, podrías usar la función sort, que se encarga de ordenar listas, pero en ocasiones, como programadores, debemos resolver estos tipos de problemas de una forma más profesional, ¿Como?, creando nuestros propios procedimiento, sí, me refiero a los maravillosos Algoritmos, en este caso, Algoritmos de Ordenamiento.

Hoy te mostrare el funcionamiento del Ordenamiento de Burbuja, un sencillo algoritmo de ordenamiento.

¿Que es el Ordenamiento de Burbuja?
-Como e mencionado anteriormente, el ordenamiento de burbuja es un algoritmo de ordenamiento que nos permite colocar los elementos de una lista o vector en una secuencia dada, ya sea de mayor a menor, o de menor a mayor.

Este algoritmo funciona revisando cada elemento de la lista que va a ser ordenada con el siguiente, intercambiándolos de posición si están en el orden equivocado.

![Ordenamienot de Burbuja](https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Bubblesort-edited-color.svg/512px-Bubblesort-edited-color.svg.png)



```python
# Algoritmo Ordenamiento de Burbuja. Implementación en Python

A = [55, 86, 32, 12, 82, 43]

num = len(A)
i = 0
while i < num:
      j = i
      while j < num:
              if A[i] > A[j]:
                      aux = A[i]
                      A[i] = A[j]
                      A[j] = aux

              j = j + 1
      i = i + 1

print("Lista ordenada: ")
print(A)
```

    Lista ordenada: 
    [12, 32, 43, 55, 82, 86]
    

# Implementación del algoritmo en:
## [C++](https://github.com/CodigoComentado/Ordenamiento-de-Burbuja---Implementaci-n-del-Algoritmo/blob/master/Ordenamiento%20de%20Burbuja%20-%20C%2B%2B.cpp)
## [C#](https://github.com/CodigoComentado/Ordenamiento-de-Burbuja---Implementaci-n-del-Algoritmo/blob/master/Ordenamiento%20de%20burbujo%20-%20C%23.cs)
## [Java](https://github.com/CodigoComentado/Ordenamiento-de-Burbuja---Implementaci-n-del-Algoritmo/blob/master/Ordenamiento%20de%20Burbuja%20-%20Java.java)
## [Ruby](https://github.com/CodigoComentado/Ordenamiento-de-Burbuja---Implementaci-n-del-Algoritmo/blob/master/Ordenamiento%20de%20Burbuja%20-%20Ruby.rb)
## [Python](https://github.com/CodigoComentado/Ordenamiento-de-Burbuja---Implementaci-n-del-Algoritmo/blob/master/Ordenamiento%20de%20Burbuja%20-%20Python.py)
