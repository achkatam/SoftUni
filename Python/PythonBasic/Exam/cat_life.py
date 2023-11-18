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

cat_dict = males if sex_inpt.lower() == 'm' else females

if breed_inpt in cat_dict:
    lifespan_in_years = cat_dict[breed_inpt]
    lifespan_in_months = lifespan_in_years * 12
    cats_life = lifespan_in_months / 6
    print(f"{int(cats_life)} cat months")
