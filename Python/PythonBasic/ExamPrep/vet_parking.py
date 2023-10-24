days = int(input())
hours_per_day = int(input())

price = 0.0
total_price = 0.0
total_price_per_day = 0.0

for i in range(1, days + 1):
    total_price_per_day = 0
    for y in range(1, hours_per_day + 1):
        if i % 2 == 0 and y % 2 != 0:
            price = 2.5
        elif i % 2 != 0 and y % 2 == 0:
            price = 1.25
        else:
            price = 1

        total_price_per_day += price

    print(f"Day: {i} - {total_price_per_day:.2f} leva")
    total_price += total_price_per_day

print(f"Total: {total_price:.2f} leva")