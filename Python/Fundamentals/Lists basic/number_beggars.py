string_input = input()

line_of_products = [int(x) for x in string_input.split(", ")]
count_of_beggars = int(input())

result = []

if count_of_beggars == len(line_of_products):
    result = line_of_products
elif count_of_beggars > len(line_of_products):
    for i in range(count_of_beggars - len(line_of_products)):
        line_of_products.append(0)
    result = line_of_products
elif count_of_beggars < len(line_of_products):
    beggars_with_products = []
    for beggar in range(count_of_beggars):
        beggar_shopping = 0
        for i in range(beggar, len(line_of_products), count_of_beggars ):
            beggar_shopping += line_of_products[i]
        beggars_with_products.append(beggar_shopping)
    result = beggars_with_products

print(result)
