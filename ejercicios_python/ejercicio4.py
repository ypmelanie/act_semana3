import math

# entrada
r = float(input("Radio de un círculo: "))

# proceso
area = math.pi * (r ** 2)
perimetro = 2 * math.pi * r

# salida
print(f"AREA DEL CIRCULO: {area:.2f}")
print(f"PERIMETRO DEL CIRCULO: {perimetro:.2f}")