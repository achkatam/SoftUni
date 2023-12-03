import re

pattern = r'(?:@|#)+([a-z]{3,})[^a-z\d]*\/(\d+)\/+'

text = input()

matches = re.findall(pattern, text)

for egg_color, amount in matches:
    print(f"You found {amount} {egg_color} eggs!")
