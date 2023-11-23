import re

num = int(input())
pattern = r'@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+'
nums = []

for i in range(num):
    inpt = input()

    filtered = re.findall(pattern, inpt)
    filtered_all = "".join(filtered)

    if filtered_all:
        for j in filtered_all:
            if j.isdigit():
                nums.append(j)
        if len(nums) == 0:
            print(f"Product group: 00")
        else:
            print(f"Product group: {''.join(map(str, nums))}")
            nums.clear()
    else:
        print("Invalid barcode")
