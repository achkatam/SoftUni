days_plundering = int(input())
daily_plunder = int(input())
expected_plunder = float(input())

total_plundered = 0
for i in range(1, days_plundering + 1):
    total_plundered += daily_plunder

    if i % 3 == 0:
        total_plundered += daily_plunder * 0.5

    if i % 5 == 0:
        total_plundered -= total_plundered * 0.3


if total_plundered >= expected_plunder:
    print(f"Ahoy! {total_plundered:.2f} plunder gained.")
else:
    result = total_plundered / expected_plunder * 100
    print(f"Collected only {result:.2f}% of the plunder.")
