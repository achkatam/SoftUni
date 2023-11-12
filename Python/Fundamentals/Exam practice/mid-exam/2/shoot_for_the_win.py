targets = [int(x) for x in input().split()]
counter = 0

command = input()

while command != "End":
    target_idx = int(command)

    if 0 <= target_idx <= len(targets) - 1:
        if targets[target_idx] != -1:
            curr_target = targets[target_idx]
            counter += 1

            targets[target_idx] = -1

            for i in range(len(targets)):
                if targets[i] != -1:
                    if targets[i] > curr_target:
                        targets[i] -= curr_target
                    else:
                        targets[i] += curr_target

    command = input()
print(f"Shot targets: {counter} -> {' '.join(map(str, targets))}")
