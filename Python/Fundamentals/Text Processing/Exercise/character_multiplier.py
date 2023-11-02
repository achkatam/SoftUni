words_inpt = input().split()
sum = 0
first_word = words_inpt[0]
sec__word = words_inpt[1]

if len(first_word) < len(sec__word):
    shorter = first_word
    longer = sec__word
else:
    shorter = sec__word
    longer = first_word

for idx in range(len(shorter)):
    sum += ord(first_word[idx]) * ord(sec__word[idx])

longer = longer[index + 1]

for ch in longer:
    sum += ord(ch)

print(sum)
