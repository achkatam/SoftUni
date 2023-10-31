countries = input().split(', ')
cities = input().split(', ')

x = zip(countries, cities)

for key, value in x:
    print(f"{key} -> {value}")
