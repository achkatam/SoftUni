def reverse_text(string: str):
    yield string[::-1]


for char in reverse_text("step"):
    print(char, end='')
