from project.hero import Hero


class Wizard(Hero):
    def __init__(self, username, level):
        super().__init__(username, level)

    def __str__(self) -> str:
        return super().__str__()
