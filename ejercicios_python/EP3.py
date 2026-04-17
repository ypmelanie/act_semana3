# entrada
celsius = float(input("Ingrese la temperatura en °C: "))

# proceso (CORREGIDO)
fahrenheit = celsius * (9.0 / 5) + 32
kelvin = celsius + 273.15

# salida
print(f"Temperatura en Celsius: {celsius:.2f} °C")
print(f"Temperatura en Fahrenheit: {fahrenheit:.2f} °F")
print(f"Temperatura en Kelvin: {kelvin:.2f} °K")