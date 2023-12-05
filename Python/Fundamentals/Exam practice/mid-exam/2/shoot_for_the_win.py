targets = [int(x) for x in input().split()]

command = input()

while command != "End":
    target_idx = int(command)

    if 0 <= target_idx <= len(targets) - 1:
        if targets[target_idx] != -1:
            curr_target = targets[target_idx]

            targets[target_idx] = -1

            for i in range(len(targets)):
                if targets[i] != -1:
                    if targets[i] > curr_target:
                        targets[i] -= curr_target
                    else:
                        targets[i] += curr_target

    command = input()

shot_targets = [int(x) for x in targets if x == -1]
print(f"Shot targets: {len(shot_targets)} -> {' '.join(map(str, targets))}")
