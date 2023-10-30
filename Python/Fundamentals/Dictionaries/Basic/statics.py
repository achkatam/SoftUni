products = {}

command = input()

while command != 'statistics':
    tokens = command.split(': ')
    product = tokens[0]
    qunty = int(tokens[1])

    if product not in products:
        products[product] = 0

    products[product] += qunty

    command = input()

print(f'Products in stock:')
for (product, qunty) in products.items():
    print(f'- {product}: {qunty}')
print(f'Total Products: {len(products.keys())}')
print(f'Total Quantity: {sum(products.values())}')
