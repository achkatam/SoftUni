trip_price = float(input())
months = int(input())

saved_sum = 0
for i in range(1, months + 1):

    if i % 2 != 0 and i != 1:
        saved_sum -= saved_sum * 0.16

    if i % 4 == 0:
        saved_sum += saved_sum * 0.25

    saved_sum += trip_price * 0.25

if saved_sum >= trip_price:
    print(f"Bravo! You can go to Disneyland and you will have {saved_sum-trip_price:.2f}lv. for souvenirs.")
else:
    print(f"Sorry. You need {trip_price-saved_sum:.2f}lv. more.")