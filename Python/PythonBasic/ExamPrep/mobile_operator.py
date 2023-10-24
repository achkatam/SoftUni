term_length_years = str(input())
type_contract = str(input())
data_added = str(input())
months = int(input())

one_yr_small = 9.98
one_yr_middle = 18.99
one_yr_large = 25.98
one_yr_xlarge = 35.99

two_yr_small = 8.58
two_yr_middle = 17.09
two_yr_large = 23.59
two_yr_xlarge = 31.79

price = 0

if term_length_years == "one":
    if type_contract == "Small":
        price = one_yr_small
    elif type_contract == 'Middle':
        price = one_yr_middle
    elif type_contract == 'Large':
        price = one_yr_large
    else:
        price = one_yr_xlarge
else:
    if type_contract == "Small":
        price = two_yr_small
    elif type_contract == 'Middle':
        price = two_yr_middle
    elif type_contract == 'Large':
        price = two_yr_large
    else:
        price = two_yr_xlarge

if data_added == 'yes':
    if price <= 10:
        price += 5.5
    elif price <= 30:
        price += 4.35
    else:
        price += 3.85

if term_length_years == "two":
    price = price - (price * 0.0375)

price *= months
print(f"{price:.2f} lv.")
