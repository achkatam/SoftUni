from project.wizard import Wizard


class DarkWizard(Wizard):
    def __init__(self, username, level) -> None:
        super().__init__(username, level)
        
    def __str__(self) -> str:
        return super().__str__()
