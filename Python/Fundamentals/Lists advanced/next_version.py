string_input = [int(num) for num in input().split('.')]
string_input[-1] +=1

for idx in range(len(string_input) - 1, -1, -1):
    if string_input[idx] > 9:
        string_input[idx] = 0
        string_input[idx - 1] += 1

print('.'.join(str(x) for x in string_input))
