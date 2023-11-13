#  Write a program to read a sequence of integers and find
#  and print the top 5 numbers greater than the average value in the sequence,
#  sorted in descending order.
def average(numbers: list):
    return sum(numbers) / len(numbers)


numbers = [int(x) for x in input().split()]

avg = average(numbers)
greater_than_avg = []
for i in range(len(numbers)):
    if numbers[i] > avg:
        greater_than_avg.append(numbers[i])

greater_than_avg.sort()
greater_than_avg.reverse()

top5 = greater_than_avg[:5]

if len(top5) <= 0:
    print("No")
else:
    print(*top5)
