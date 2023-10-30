products_inpt = input().split()

bakery = {}

for i in range(0, len(products_inpt), 2):
    product = products_inpt[i]
    qnty = products_inpt[i+1]

    bakery[product] = int(qnty)

print(bakery)
