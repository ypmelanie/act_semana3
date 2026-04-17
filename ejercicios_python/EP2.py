# entrada
kwh = float(input("Ingrese los kWh consumidos: "))

# proceso
subtotal = 5.00 + (kwh * 0.55)
igv = subtotal * 0.18
total = subtotal + igv

# salida
print(f"Subtotal: S/. {subtotal:.2f}")
print(f"IGV (18%): S/. {igv:.2f}")
print(f"Total a pagar: S/. {total:.2f}")