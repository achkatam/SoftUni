team_input = input().split()
team_a = list(range(1, 12))
team_b = list(range(1, 12))


def game_terminated(list1, list2):
    if len(list1) < 7 or len(list2) < 7:
        return True


for team_player in team_input:
    team, player = team_player.split('-')
    player = int(player)

    if team == 'A' and player in team_a:
        team_a.remove(player)

    elif team == 'B' and player in team_b:
        team_b.remove(player)

    if game_terminated(team_a, team_b):
        break

print(f'Team A - {len(team_a)}; Team B - {len(team_b)}')

if game_terminated(team_a, team_b):
    print('Game was terminated')
