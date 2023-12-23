class Time:
    max_hours = 23
    max_minutes = 59
    max_seconds = 59

    def __init__(self, hours: int, minutes: int, seconds: int):
        self.hours = hours
        self.minutes = minutes
        self.seconds = seconds

    def set_time(self, hours: int, minutes: int, seconds: int):
        if hours > Time.max_hours or minutes > Time.max_minutes or seconds > Time.max_seconds:
            raise Exception("Invalid input")

        self.hours = hours
        self.minutes = minutes
        self.seconds = seconds

    def get_time(self):
        return f'{self.hours:02d}:{self.minutes:02d}:{self.seconds:02d}'

    def next_second(self):
        if self.seconds + 1 > Time.max_seconds:
            self.seconds = 0
            if self.minutes + 1 > Time.max_minutes:
                self.minutes = 0
                if self.hours + 1 > Time.max_hours:
                    self.hours = 0
                else:
                    self.hours += 1
            else:
                self.minutes += 1
        else:
            self.seconds += 1

        return self.get_time()


if __name__ == '__main__':
    time = Time(10, 59, 59)
    print(time.next_second())
    time = Time(23, 59, 59)
    print(time.next_second())
