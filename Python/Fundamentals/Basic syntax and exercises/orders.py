orders_cnt = int(input())

today_order_price = 0
total_price = 0

for i in range(0, orders_cnt):
    capsule_price = float(input())
    days = int(input())
    capsules_cnt = int(input())

    today_order_price = ((days * capsules_cnt) * capsule_price)

    if today_order_price > 0:
        print(f"The price for the coffee is: ${today_order_price:.2f}")

    total_price += today_order_price

print(f"Total: ${total_price:.2f}")
