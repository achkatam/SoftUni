from project.formula_teams.red_bull_team import RedbullTeam
from project.formula_teams.mercedes import MercedesTeam


class F1SeasonApp:
    def __init__(self):
        self.red_bull_team = None
        self.mercedes_team = None

    def register_team_for_season(self, team_name: str, budget: int):
        if team_name == "Red Bull":
            self.red_bull_team = RedbullTeam(budget)
        elif team_name == "Mercedes":
            self.mercedes_team = MercedesTeam(budget)
        else:
            raise ValueError(f'Invalid team name!')

        return f'{team_name} has joined the new F1 season.'

    def new_race_results(self, race_name: str, red_bull_pos: int, mercedes_pos: int):
        if self.red_bull_team is None or self.mercedes_team is None:
            raise Exception(f'Not all teams have registered for the season.')

        string_builder = f'{self.red_bull_team.calculate_revenue_after_race(red_bull_pos)}'
        string_builder += f'{self.mercedes_team.calculate_revenue_after_race(mercedes_pos)}'
        # print(self.mercedes_team.calculate_revenue_after_race(mercedes_pos))
        better_pos = 'Mercedes' if mercedes_pos < red_bull_pos else 'Red Bull'
        string_builder += f'{better_pos} is ahead at the {race_name} race.'

        return string_builder