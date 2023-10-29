def password_length(password):
    if 6 <= len(password) <= 10:
        return True


def only_digits_letters(password):
    if password.isalnum():
        return True


def two_digits(password):
    digits_cnt = sum(d.isdigit() for d in password)

    if digits_cnt >= 2:
        return True


password = input()

if not password_length(password):
    print('Password must be between 6 and 10 characters')

if not only_digits_letters(password):
    print('Password must consist only of letters and digits')

if not two_digits(password):
    print('Password must have at least 2 digits')

if password_length(password) and only_digits_letters(password) and two_digits(password):
    print('Password is valid')
