first_concierge_capacity = int(input())
second_concierge_capacity = int(input())
third_concierge_capacity = int(input())

all_together = first_concierge_capacity + second_concierge_capacity + third_concierge_capacity

students_count = int(input())

hours_needed = 0

while students_count > 0:
    hours_needed += 1

    students_count -= all_together

    if hours_needed % 4 == 0:
        hours_needed += 1

print(f"Time needed: {hours_needed}h.")
