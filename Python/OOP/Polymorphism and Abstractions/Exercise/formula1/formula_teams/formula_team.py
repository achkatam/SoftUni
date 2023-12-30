from abc import ABC, abstractmethod


class FormulaTeam(ABC):
    def __init__(self, budget: int):
        if budget < 1_000_000:
            raise ValueError(f'F1 is an expensive sport, find more sponsors!')

        self.budget = budget

    @abstractmethod
    def calculate_revenue_after_race(self, race_pos: int):
        pass