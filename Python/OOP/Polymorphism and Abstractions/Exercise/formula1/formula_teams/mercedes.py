from project.formula_teams.formula_team import FormulaTeam


class MercedesTeam(FormulaTeam):
    EXPENSES_PER_RACE = 200_000

    def __init__(self, budget: int):
        super().__init__(budget)

    def calculate_revenue_after_race(self, race_pos: int):
        reward = 0
        # Petronas bonus
        if race_pos == 1:
            reward += 1_000_000
        elif race_pos == 3:
            reward += 500_000

        # TeamViewer bonus
        if race_pos <= 5:
            reward += 100_000
        elif race_pos <= 7:
            reward += 50_000

        revenue = reward - MercedesTeam.EXPENSES_PER_RACE
        self.budget += revenue

        return f'Mercedes: The revenue after the race is {revenue}$. Current budget {self.budget}$. '
