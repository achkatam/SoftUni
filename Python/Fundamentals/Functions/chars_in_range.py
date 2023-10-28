def converted_chars(char1, char2):
    converted1 = ord(char1)
    converted2 = ord(char2)

    converted_list = []
    for i in range(converted1 + 1, converted2):
        converted_list.append(chr(i))

    return ' '.join(converted_list)


char1 = input()
char2 = input()

print(converted_chars(char1, char2))
