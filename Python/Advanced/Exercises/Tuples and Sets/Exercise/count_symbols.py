text = tuple(input())

unique_symbols = sorted(set(text))

for char in unique_symbols:
    print(f"{char}: {text.count(char)} time/s")