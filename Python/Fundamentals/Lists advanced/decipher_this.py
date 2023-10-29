message = input().split()

for word in message:
    ascii_code = ''.join([letter for letter in word if letter.isnumeric()])
    letters = [letter for letter in word if letter.isalpha()]
    letters[0], letters[len(letters) - 1] = letters[len(letters) - 1], letters[0]
    letters = ''.join(letters)

    print(f"{chr(int(ascii_code))}{letters}", end=' ')
