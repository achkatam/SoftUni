luggage_price_over_20kg = float(input())
luggage_price_upto_10kgs = luggage_price_over_20kg * 0.2
luggage_price_10to20kgs = luggage_price_over_20kg * 0.5

luggage_weight = float(input())
days_left_to_flight = int(input())
suitcases_cnt = int(input())

ticket_price = 0

if luggage_weight > 20:
    ticket_price = luggage_price_over_20kg
elif 10 < luggage_weight <= 20:
    ticket_price = luggage_price_10to20kgs
elif luggage_weight < 10:
    ticket_price = luggage_price_upto_10kgs

if days_left_to_flight > 30:
    ticket_price += ticket_price * 0.1
elif 7 < days_left_to_flight <= 30:
    ticket_price += ticket_price * 0.15
elif days_left_to_flight < 7:
    ticket_price += ticket_price * 0.4

total_price = ticket_price * suitcases_cnt

output = f"The total price of bags is: \n{total_price:.2f} lv. "
print(output)
