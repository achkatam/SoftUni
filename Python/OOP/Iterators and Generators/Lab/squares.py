def squares(number: int):
    for num in range(1, number + 1):
        if isinstance(num ** 2, int):
            yield num ** 2


print(list(squares(5)))
