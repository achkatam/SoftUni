def parenthesis(expression):
    stack = []

    for i in range(len(expression)):
        if expression[i] == '(':
            stack.append(i)
        elif expression[i] == ')':
            start_index = stack.pop()
            yield expression[start_index:i + 1]


expression = input()

for i in parenthesis(expression):
    print(i)
