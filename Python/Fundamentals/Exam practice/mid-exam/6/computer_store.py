import sys

sum = 0

while True:
    command = input()

    if command == "special" or command == "regular":
        break

    if float(command) < 0:
        print(f"Invalid price!")
        continue

    sum += float(command)

if sum <= 0:
    print(f"Invalid order!")
    sys.exit(0)

print(f"Congratulations you've just bought a new computer!")
print(f"Price without taxes: {sum:.2f}$")
taxes = sum * 0.2
print(f"Taxes: {taxes:.2f}$")
print(f"-----------")
sum += taxes
if command == "special":
    sum -= sum * 0.1
print(f"Total price: {sum:.2f}$")