import sys


def not_enough_food(food_amount: float):
    return food_amount <= 0


food_grs = float(input()) * 1000
hay_grs = float(input()) * 1000
cover_grs = float(input()) * 1000
guinea_weight_grs = float(input()) * 1000

for i in range(1, 31):
    food_grs -= 300  # 300 grams every single day
    if i % 2 == 0:
        eaten_hay = food_grs * 0.05
        hay_grs -= eaten_hay

    if i % 3 == 0:
        cover_amount = guinea_weight_grs / 3
        cover_grs -= cover_amount

    if not_enough_food(food_grs) or not_enough_food(hay_grs) or not_enough_food(cover_grs):
        print(f"Merry must go to the pet store!")
        sys.exit(0)

food_kgs = food_grs / 1000
hay_kgs = hay_grs / 1000
cover_kgs = cover_grs / 1000

print(f"Everything is fine! Puppy is happy! Food: {food_kgs:.2f}, Hay: {hay_kgs:.2f}, Cover: {cover_kgs:.2f}.")
