from project.hero import Hero


class Elf(Hero):
    def __int__(self, username, level) -> None:
        super().__int__(username, level)

    def __str__(self) -> str:
        return super().__str__()
