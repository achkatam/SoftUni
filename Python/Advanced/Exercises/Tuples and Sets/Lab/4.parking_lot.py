num = int(input())
pairs = {}
cars_left = []

for _ in range(num):
    direction, tag = input().split(', ')

    if tag not in pairs.keys():
        pairs[tag] = [direction]
    else:
        pairs[tag] = [direction]
        del pairs[tag]


if pairs.keys():
    print("\n".join(pairs.keys()))
else:
    print(f'Parking Lot is Empty')
