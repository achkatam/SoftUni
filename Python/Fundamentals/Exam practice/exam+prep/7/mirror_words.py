import re

text = input()
pattern = r"(@|#)([A-Za-z]{3,})(\1)(\1)([A-Za-z]{3,})(\1)"
chars = r"[A-Za-z]"
mirror_words = []
matched = re.finditer(pattern, text)
matched_wds = []

for i in matched:
    matched_wds.append(i.groups())
    first_group = i.group(2)
    second_group = i.group(5)
    sec_reversed = second_group[::-1]

    if first_group == sec_reversed:
        string = f"{first_group} <=> {second_group}"
        mirror_words.append(string)

if len(matched_wds):
    print(f"{len(matched_wds)} word pairs found!")
else:
    print("No word pairs found!")

if len(mirror_words) > 0:
    print("The mirror words are:")
    print(', '.join(mirror_words))
else:
    print("No mirror words!")
