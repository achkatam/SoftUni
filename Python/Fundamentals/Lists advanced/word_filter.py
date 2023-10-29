string_input = list(input().split(' '))

for word in string_input:
    if len(word) % 2 == 0:
        print(word)
