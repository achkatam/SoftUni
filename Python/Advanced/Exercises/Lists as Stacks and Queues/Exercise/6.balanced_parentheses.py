parentheses_input = input()
mid_char = int(len(parentheses_input) / 2)
print(mid_char)
left_side = parentheses_input[:mid_char]
right_side = parentheses_input[mid_char:]

for i in reversed(left_side):
    for j in right_side:
        print(f'left side: {i}')
        print(f'right side: {j}')