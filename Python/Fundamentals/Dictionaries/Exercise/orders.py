command = input()

products = {}
while command != "buy":
    tokens = command.split()
    product_name = tokens[0]
    product_price = float(tokens[1])
    product_qnty = int(tokens[2])

    if product_name not in products:
        products[product_name] = [0, 0]

    product = products[product_name]

    products[product_name][0] = product_price
    products[product_name][1] += product_qnty

    command = input()

for product, data in products.items():
    print(f'{product} -> {(data[0] * data[1]):.2f}')
