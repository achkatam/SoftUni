from project.knight import Knight


class DarkKnight(Knight):
    def __init__(self, username, level) -> None:
        super().__init__(username, level)
    
    def __str__(self) -> str:
        return super().__str__()