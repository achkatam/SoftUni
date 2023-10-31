contacts = {}

while True:
    command = input()

    if command.isdigit():
        command = int(command)
        break

    contact = command.split("-")
    contact_name = contact[0]
    contact_number = contact[1]
    if contact_name not in contacts:
        contacts[contact_name] = []
    contacts[contact_name] = contact_number

for i in range(command):
    name = input()
    if name not in contacts.keys():
        print(f'Contact {name} does not exist.')
    else:
        print(f'{name} -> {contacts[name]}')
