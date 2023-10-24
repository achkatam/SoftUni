gas_price = 2.1
tour_guide_price = 100
saturday_disc = 0.1
sunday_disc = 0.2

budget = float(input())
gas_qnty_needed = float(input())
weekend_day = input()

gas_total = gas_price * gas_qnty_needed

total_expenses = (gas_price * gas_qnty_needed) + tour_guide_price

if weekend_day == "Saturday":
    total_expenses = total_expenses - (total_expenses * saturday_disc)
else:
    total_expenses -= total_expenses * sunday_disc

if budget >= total_expenses:
    print(f"Safari time! Money left: {budget - total_expenses:.2f} lv.")
else:
    print(f"Not enough money! Money needed: {total_expenses - budget:.2f} lv.")
