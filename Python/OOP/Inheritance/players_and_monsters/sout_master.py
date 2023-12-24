from project.dark_wizard import DarkWizard


class SoulMaster(DarkWizard):
    def __init__(self, username, level) -> None:
        super().__init__(username, level)

    def __str__(self) -> str:
        return super().__str__()