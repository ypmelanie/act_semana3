import math

# entrada
x1 = float(input("x1: "))
y1 = float(input("y1: "))
x2 = float(input("x2: "))
y2 = float(input("y2: "))

# proceso
dx = x2 - x1
dy = y2 - y1
distancia = math.sqrt(dx * dx + dy * dy)

# salida
print(f"DISTANCIA ENTRE LOS PUNTOS: {distancia:.2f}")