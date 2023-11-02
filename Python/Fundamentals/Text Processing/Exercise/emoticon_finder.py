text_input = input()

emoji = ""
for idx in range(len(text_input)):
    if text_input[idx] == ":":
        emoji = text_input[idx] + text_input[idx + 1]
        print(emoji)
