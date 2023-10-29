class Tweet:
    def __init__(self, message):
        self.message = message

    def print_tweet(self):
        print(self.message)


t = Tweet('Message here')
t.print_tweet()