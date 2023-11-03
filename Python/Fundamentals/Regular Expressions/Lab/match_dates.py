import re

regex = r"(?<day>[0-9]{2})(?<separator>[\.\-\/])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>[0-9]{4})"
dates = input()

matches = re.finditer(regex, dates)


for i in matches:
    day = i.group("day")
    month = i.group("month")
    year = i.group("year")

    print(f"Day: {day}, Month: {month}, Year: {year}")
