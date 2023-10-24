budget = float(input())
starting_budget = budget
command = str(input())
counter = 1
product_cnt = 0
total_sum = 0

while command != "Stop":
    product_price = float(input())
    if product_price >= budget:
        print(f'You don\'t have enough money!')
        print(f'You need {product_price - budget:.2f} leva!')
        SystemExit()

    if counter == 3:
        product_price /= 2
        counter = 0

    total_sum += product_price
    budget -= product_price
    counter += 1
    product_cnt += 1
    if budget <= 0:
        break

    command = input()

if command == 'Stop':
    print(f"You bought {product_cnt} products for {total_sum:.2f} leva.")

