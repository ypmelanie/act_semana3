nota1 = int(input("Ingrese la nota 1: "))
nota2 = int(input("Ingrese la nota 2: "))
nota3 = int(input("Ingrese la nota 3: "))
nota4 = int(input("Ingrese la nota 4: "))

suma = nota1 + nota2 + nota3 + nota4
promedio = suma / 4  # en Python sí da decimal automáticamente

print("------------------------------")
print("Suma de notas:", suma)
print("Promedio final:", promedio)
print("------------------------------")