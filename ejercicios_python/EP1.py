# precios unitarios
precio_habitacion = 30
precio_bano = 10
precio_patio = 15

print("PAGO POR ALQUILER")

# entrada
num_habitaciones = int(input("Cantidad de habitaciones: "))
num_banos = int(input("Cantidad de baños: "))
num_patios = int(input("Cantidad de patios: "))

# proceso (CORREGIDO: multiplicar)
total = (num_habitaciones * precio_habitacion) + \
        (num_banos * precio_bano) + \
        (num_patios * precio_patio)

# salida
print(f"El precio a pagar por el alquiler es: S/. {total}")