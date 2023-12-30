from project.formula_teams.formula_team import FormulaTeam


class RedbullTeam(FormulaTeam):
    EXPENSES_PER_RACE = 250_000

    def __init__(self, budget: int):
        super().__init__(budget)

    def calculate_revenue_after_race(self, race_pos: int):
        reward = 0
        # Oracles bonus:
        if race_pos == 1:
            reward += 1_500_000
        elif race_pos == 2:
            reward += 800_000

        #  Honda bonus
        if race_pos <= 8:
            reward += 20_000
        elif race_pos <= 10:
            reward += 10_000

        revenue = reward - RedbullTeam.EXPENSES_PER_RACE
        self.budget += revenue

        return f'Red Bull: The revenue after the race is {revenue}$. Current budget {self.budget}$. '

