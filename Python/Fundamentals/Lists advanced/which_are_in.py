string_list1 = list(input().split(', '))
string_list2 = list(input().split(', '))

last_list = list()

for string1 in string_list1:
    for string2 in string_list2:
        if string1 in string2:
            last_list.append(string1)
            break

print(last_list)
