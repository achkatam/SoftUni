import sys
from collections import deque

food = int(input())
q = deque()

inpt = [int(x) for x in input().split()]

for i in inpt:
    q.append(i)

print(max(q))

while len(q) > 0:
    food_served = q.popleft()
    if food_served < food:
        food -= food_served
        continue
    else:
        q.appendleft(food_served)
        print(f'Orders left: {" ".join(map(str, q))}')
        sys.exit(0)
print(f'Orders complete')