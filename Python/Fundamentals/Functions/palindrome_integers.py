def is_palindrome(input_number):
    number = int(input_number)
    input_str = str(number)

    if 0 <= number <= 9:
        return True

    if input_str[0] == input_str[-1]:
        return True

    return False


numbers = list(map(int, input().split(', ')))

for number in numbers:
    if is_palindrome(number):
        print('True')
    else:
        print('False')
