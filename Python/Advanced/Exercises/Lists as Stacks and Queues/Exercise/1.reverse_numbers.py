inpt = (int(x) for x in input().split())
stack = []
for i in inpt:
    stack.append(i)
print(*stack.__reversed__())