full_capacity = 255  # liters

n = int(input())

total_qnty = full_capacity

for i in range(n):
    added_water = int(input())

    if total_qnty - added_water >= 0:
        total_qnty -= added_water
    else:
        print("Insufficient capacity!")

total = full_capacity - total_qnty
print(total)
