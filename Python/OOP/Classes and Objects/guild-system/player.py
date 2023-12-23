class Player:
    def __init__(self, name, hp, mp):
        self.name = name
        self.hp = hp
        self.mp = mp
        self.skills = {}
        self.guild = "Unaffiliated"

    def add_skill(self, skill_name, mana_cost):
        if skill_name in self.skills:
            return f'Skill already added'

        self.skills[skill_name] = mana_cost
        return f'Skill {skill_name} added to the collection of the player {self.name}'

    def player_info(self):
        string_Builder = (f'Name: {self.name}\n'
                          f'Guild: {self.guild}\n'
                          f'HP: {self.hp}\n'
                          f'MP: {self.mp}\n')

        for k, v in self.skills.items():
            string_Builder += f'==={k} - {v}\n'

        return string_Builder
