import sys

males = {"British Shorthair": 13,
         "Siamese": 15,
         "Persian": 14,
         "Ragdoll": 16,
         "American Shorthair": 12,
         "Siberian": 11}

females = {"British Shorthair": 14,
           "Siamese": 16,
           "Persian": 15,
           "Ragdoll": 17,
           "American Shorthair": 13,
           "Siberian": 12}

breed_inpt = input()
sex_inpt = input()

if breed_inpt not in males.keys() or breed_inpt not in females.keys():
    print(f"{breed_inpt} is invalid cat!")
    sys.exit(0)

humans_month = 0

if sex_inpt == "m":
    for breed, lifespan in males.items():
        if breed_inpt == breed:
            humans_month = lifespan * 12
elif sex_inpt == "f":
    for breed, lifespan in females.items():
        if breed_inpt == breed:
            humans_month = lifespan * 12

cats_life = humans_month / 6
print(f"{int(cats_life)} cat months")
