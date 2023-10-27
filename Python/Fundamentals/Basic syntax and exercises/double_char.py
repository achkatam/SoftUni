string = str(input())

result = []

while string != "End":
    if string != "SoftUni":
        double_string = ''.join(char * 2 for char in string)
        result.append(double_string)

    string = str(input())

for doubled_string in result:
    print(doubled_string)
