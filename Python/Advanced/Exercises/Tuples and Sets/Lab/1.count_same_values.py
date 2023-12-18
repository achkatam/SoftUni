def solution(keys_input):
    occurrences = {}
    for value in keys_input:
        if value not in occurrences:
            occurrences[value] = 0
        occurrences[value] += 1

    for number, count in occurrences.items():
        print(f'{number} - {count} times')


keys_input = [float(x) for x in input().split()]
solution(keys_input)
