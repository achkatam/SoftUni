class reverse_iter:
    def __init__(self, iterable: iter) -> None:
        self.iterable = iterable
        self.index = -1

    def __iter__(self):
        return self

    def __next__(self):
        try:
            if abs(self.index) <= len(self.iterable):
                num = self.iterable[self.index]
                self.index += -1
                return num
            else:
                raise IndexError
        except Exception:
            raise StopIteration


reverse_list = reverse_iter([1, 2, 3, 4, 5])
for item in reverse_list:
    print(item)
