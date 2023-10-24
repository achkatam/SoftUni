n = int(input())

p1 = 0.0  # divides by 2
p2 = 0.0  # divides by 3
p3 = 0.0  # divides by 4

for i in range(1, n + 1):
    number = int(input())

    if number % 2 == 0:
        p1 += 1
    if number % 3 == 0:
        p2 += 1
    if number % 4 == 0:
        p3 += 1

p1_formula = float(p1) / n * 100
p2_formula = float(p2) / n * 100
p3_formula = float(p3) / n * 100

print(f'{p1_formula:.2f}%')
print(f'{p2_formula:.2f}%')
print(f'{p3_formula:.2f}%')
