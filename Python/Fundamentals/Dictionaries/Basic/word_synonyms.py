n = int(input())
synonyms_words = {}

for i in range(n):
    word = input()
    synonym = input()

    if word not in synonyms_words:
        synonyms_words[word] = []
    synonyms_words[word].append(synonym)

for word in synonyms_words:
    print(f"{word} - {', '.join(synonyms_words[word])}")
