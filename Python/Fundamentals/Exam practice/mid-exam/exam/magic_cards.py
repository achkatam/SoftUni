def is_valid(string, idx):
    return 0 <= idx < len(string)


card_deck = input().split(":")
new_deck = []
command = input()

while command != "Ready":
    tokens = command.split()
    cmd = tokens[0]

    if cmd == "Add":
        card = tokens[1]
        if card in card_deck:
            new_deck.append(card)
        else:
            print(f"Card not found.")
    elif cmd == "Insert":
        card = tokens[1]
        idx = int(tokens[2])
        if card in card_deck and is_valid(new_deck, idx):
            new_deck.insert(idx, card)
        else:
            print(f"Error!")
    elif cmd == "Remove":
        card = tokens[1]
        if card in new_deck:
            new_deck.remove(card)
        else:
            print(f'Card not found.')
    elif cmd == "Swap":
        card = tokens[1]
        card2 = tokens[2]
        idx_card = new_deck.index(card)
        idx_card2 = new_deck.index(card2)
        new_deck[idx_card], new_deck[idx_card2] = new_deck[idx_card2], new_deck[idx_card]
    elif cmd == "Shuffle":
        new_deck.reverse()

    command = input()

print(" ".join(new_deck))

# passed 100/100
