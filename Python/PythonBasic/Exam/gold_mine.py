locations_cnt = int(input())

for i in range(locations_cnt):
    expected_per_day = float(input())
    days_mining = int(input())
    total_mined = 0

    for j in range(days_mining):
        mined_gold_for_day = float(input())
        total_mined += mined_gold_for_day
    total_mined /= days_mining

    if total_mined >= expected_per_day:
        print(f"Good job! Average gold per day: {total_mined:.2f}.")
    else:
        print(f"You need {expected_per_day - total_mined:.2f} gold.")
