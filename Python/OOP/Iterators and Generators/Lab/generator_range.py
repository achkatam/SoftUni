def genrange(start: int, end: int):
    for i in range(start, end + 1):
        yield i


print(list(genrange(1, 10)))
