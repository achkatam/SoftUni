class vowels:
    def __init__(self, input_string: str):
        self.input_string = input_string
        self.vowels = ['a', 'i', 'e', 'u', 'y', 'o']
        self.index = -1

    def __iter__(self):
        return self

    def __next__(self):
        while True:
            self.index += 1
            if self.index < len(self.input_string):
                if self.input_string[self.index].lower() in self.vowels:
                    return self.input_string[self.index]
            else:
                raise StopIteration


my_string = vowels('Abcedifuty0o')
for char in my_string:
    print(char)
