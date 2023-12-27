def start_playing(instance):
    return instance.play()


class Guitar:
    def play(self):
        return "Playing the guitar"


guitar = Guitar()
print(start_playing(guitar))


class Children:
    def play(self):
        return f"Children are playing"


children = Children()
print(start_playing(children))
