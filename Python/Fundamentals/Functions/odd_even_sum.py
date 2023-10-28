def sum_even_odd(number):
    odd_sum = 0
    even_sum = 0

    for i in str(number):
        digit = int(i)

        if digit % 2 == 0:
            even_sum += digit
        else:
            odd_sum += digit

    return f"Odd sum = {odd_sum}, Even sum = {even_sum}"


number = int(input())
print(sum_even_odd(number))
