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
