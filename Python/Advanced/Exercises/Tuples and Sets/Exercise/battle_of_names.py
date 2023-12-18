num = int(input())

odd = set()
even = set()
for i in range(1, num + 1):
    ascii = int(sum(ord(x) for x in input()) / i)

    if ascii % 2 == 0:
        even.add(ascii)
    else:
        odd.add(ascii)

sum_even = sum(even)
sum_odd = sum(odd)

if sum_even == sum_odd:
    result = odd.union(even)
elif sum_odd > sum_even:
    result = odd.difference(even)
else:
    result = odd.symmetric_difference(even)

print(*result, sep=', ')
