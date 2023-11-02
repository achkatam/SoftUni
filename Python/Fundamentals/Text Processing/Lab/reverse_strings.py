text = input()

while text != 'end':
    text_reversed = ''
    for ch in reversed(text):
        text_reversed += ch
    print(f'{text} = {text_reversed}')

    text = input()
