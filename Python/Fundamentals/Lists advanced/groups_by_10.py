numbers_inpt = list(map(int, input().split(", ")))
group = 0
while len(numbers_inpt) > 0:
    group += 10
    numbers_group = list(filter(lambda x: group - 10 < x <= group, numbers_inpt))
    numbers_inpt = [y for y in numbers_inpt if y not in numbers_group]
    print(f"Group of {group}'s: {numbers_group}")
