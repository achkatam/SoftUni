# 899 pages
# 2 covers

price_per_page = float(input())
price_per_cover = float(input())
discount_perc = int(input())
designer_wage = float(input())
perc_paid_by_team = int(input())

price = price_per_page * 899 + price_per_cover * 2
discounted_price = price - (price * (discount_perc / 100))
price_for_designer = discounted_price + designer_wage
total_price = price_for_designer - (price_for_designer * (perc_paid_by_team / 100))

print(f"Avtonom should pay {total_price:.2f} BGN.")
