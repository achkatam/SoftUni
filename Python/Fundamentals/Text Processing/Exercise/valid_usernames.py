usernames = input().split(", ")

allowed_chars = "-_"

for username in usernames:
    is_valid_username = True

    for ch in username:
        if not ch.isalnum() and ch not in allowed_chars:
            is_valid_username = False
            break

    if 3 <= len(username) <= 16 and is_valid_username:
        print(username)
