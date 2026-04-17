import math

# entrada
monto = float(input("Ingrese el monto en soles: "))

# proceso (redondeos)
ceiling = math.ceil(monto)
floor = math.floor(monto)
truncado = math.trunc(monto)

# salida
print(f"Precio original: {monto}")
print(f"Ceiling (hacia arriba): {ceiling}")
print(f"Floor (hacia abajo): {floor}")
print(f"Truncado: {truncado}")