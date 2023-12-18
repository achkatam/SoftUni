num = int(input())

start_pump = 0
fuel_left = 0

for i in range(num):
    gas_qnty, distance = [int(x) for x in input().split()]
    fuel_left += gas_qnty

    if fuel_left >= distance:
        fuel_left -= distance
    else:
        start_pump = i + 1
        fuel_left = 0

print(start_pump)