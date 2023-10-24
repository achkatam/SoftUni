price_strawberries_per_kg = float(input())
quantity_bananas = float(input())
quantity_oranges = float(input())
quantity_olives = float(input())
quantity_strawberries = float(input())

price_strawberries = price_strawberries_per_kg * quantity_strawberries

price_olives = price_strawberries_per_kg / 2
price_oranges = price_olives - (price_olives * 0.4)
price_bananas = price_olives - (price_olives * 0.8)

total_sum = price_bananas * quantity_bananas + quantity_oranges *  price_oranges + price_olives * quantity_olives + price_strawberries
print(total_sum.__round__(2))
