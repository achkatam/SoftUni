inpt = input()

tokens = inpt.split('\\')
last_token = tokens[-1]
file_name = last_token.split('.')[0]
extension = last_token.split('.')[1]

print(f"File name: {file_name}")
print(f"File extension: {extension}")
