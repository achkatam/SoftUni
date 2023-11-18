from math import floor

ship_width = float(input())
ship_length = float(input())
ship_height = float(input())
astronauts_avg_height = float(input())

spaceship_volume = ship_height * ship_length * ship_width
room_volume = (astronauts_avg_height + 0.4) * 2 * 2

avg_astro = floor(spaceship_volume / room_volume)

if 3 <= avg_astro <= 10:
    print(f"The spacecraft holds {avg_astro} astronauts.")
elif avg_astro < 3:
    print(f"The spacecraft is too small.")
elif avg_astro > 10:
    print(f"The spacecraft is too big.")
