n, m = [int(x) for x in input().split()]

nset = set()
mset = set()

for _ in range(n):
    nset.add(input())

for _ in range(m):
    mset.add(input())

unique = nset.intersection(mset)

print("\n".join(unique))