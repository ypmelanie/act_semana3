# entrada
precio = float(input("Precio unitario (s/.): "))
cantidad = int(input("Cantidad de productos: "))

# proceso
subtotal = precio * cantidad
igv = subtotal * 0.18
total = subtotal + igv

# salida
print("****************************************")
print(f"Subtotal (sin IGV): s/. {subtotal}")
print(f"IGV (18%): s/. {igv}")
print(f"Total a pagar: s/. {total}")
print("****************************************")