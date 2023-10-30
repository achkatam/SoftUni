products_inpt = input().split()
bakery = {}

for i in range(0, len(products_inpt), 2):
    product = products_inpt[i]
    qnty = products_inpt[i+1]

    bakery[product] = int(qnty)

looked_for_products = input().split()

for product in looked_for_products:
    if product in bakery:
        print(f'We have {bakery[product]} of {product} left')
    else:
        print(f"Sorry, we don't have {product}")
