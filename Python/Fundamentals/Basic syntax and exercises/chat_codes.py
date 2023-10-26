num_messages = int(input())

for i in range(0, num_messages):
    num = int(input())
    message = str

    if num == 88:
        message = 'Hello'
    elif num == 86:
        message = 'How are you?'
    elif num != 86 and num != 88 and num < 88:
        message = 'GREAT!'
    elif num > 88:
        message = 'Bye.'

    print(message)