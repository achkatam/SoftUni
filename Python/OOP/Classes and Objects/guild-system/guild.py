from project.player import Player


class Guild:
    def __init__(self, name):
        self.name = name
        self.players = []

    def assign_player(self, player: Player):
        if player.guild == self.name:
            return f'Player {player.name} is already in the guild.'
        if player.guild != self.name and player.guild != "Unaffiliated":
            return f'Player {player.name} is in another guild.'

        self.players.append(player)
        player.guild = self.name
        return f'Welcome player {player.name} to the guild {self.name}'

    def kick_player(self, player_name):
        if player_name not in self.players:
            return f'Player {player_name} is not in the guild.'

        player: Player
        for player in self.players:
            if player.name == player_name:
                player = player
                player.guild = "Unaffiliated"
                return f'Player {player_name} has been removed from the guild.'

    def guild_info(self):
        str_builder = f"Guild: {self.name}\n"
        for player in self.players:
            str_builder += f'{player.player_info()}\n'

        return str_builder


player = Player("George", 50, 100)
print(player.add_skill("Shield Break", 20))
print(player.player_info())
guild = Guild("UGT")
print(guild.assign_player(player))
print(guild.guild_info())
