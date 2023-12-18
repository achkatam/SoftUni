inpt = input()
stack = []
reversed_stack = ''

for i in inpt:
    stack.append(i)
for i in range(len(stack)):
    reversed_stack += stack.pop()

print(reversed_stack)