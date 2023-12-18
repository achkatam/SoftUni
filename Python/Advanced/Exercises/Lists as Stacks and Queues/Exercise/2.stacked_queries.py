num = int(input())
stack = []

for i in range(num):
    command = [int(x) for x in input().split()]

    if int(command[0]) == 1:
        stack.append(int(command[1]))
    elif int(command[0]) == 2:
        if len(stack) > 0:
            stack.pop()
    elif int(command[0]) == 3:
        print(max(stack))
    elif int(command[0]) == 4:
        print(min(stack))
print(', '.join(map(str, stack.__reversed__())))