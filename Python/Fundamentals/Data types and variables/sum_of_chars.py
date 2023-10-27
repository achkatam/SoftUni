num = int(input())

summ = 0
for i in range(num):
    character = str(input())
    summ += ord(character)

print(f"The sum equals: {summ}")
