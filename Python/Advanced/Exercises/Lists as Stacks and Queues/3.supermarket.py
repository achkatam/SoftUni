def print_served(served_customers: []):
    print('\n'.join(served_customers))

    served_customers.clear()
    return served_customers


served_customers = []
customer = input()

while customer != 'End':
    if customer == 'Paid':
        print_served(served_customers)
        customer = input()
        continue

    served_customers.append(customer)
    customer = input()

print(f'{len(served_customers)} people remaining.')
