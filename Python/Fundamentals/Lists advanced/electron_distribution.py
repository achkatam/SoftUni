from math import pow

n_electrons = int(input())
position = 0
shells = []

while True:

    if n_electrons == 0:
        break

    position += 1
    shell_formula = 2 * pow(position, 2)

    if n_electrons >= shell_formula:
        shells.append(shell_formula)
        n_electrons -= shell_formula
    else:
        shells.append(n_electrons)
        n_electrons = 0

shells = [int(x) for x in shells]
print(shells)
