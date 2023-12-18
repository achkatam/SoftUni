import sys
from collections import deque

inpt = input().split()
q = deque()

for kid in inpt:
    q.append(kid)

toss = int(input())

cnt = 1
while len(q) > 1:
    if cnt % toss == 0:
        kid_removed = q.popleft()
        print(f'Removed {kid_removed}')
        cnt += 1
        continue

    kid_removed = q.popleft()
    q.append(kid_removed)

    cnt += 1
print(f'Last is {q.popleft()}')
