import re

pattern = r"(=|\/)([A-Z][a-zA-Z]{2,})\1"

destination = input()

filtered = re.findall(pattern, destination)

destination_list = []
total_sum = 0
for i in filtered:
    total_sum += len(i[1])
    destination_list.append(i[1])

print(f"Destinations: {', '.join(map(str, destination_list))}")
print(f"Travel Points: {total_sum}")
