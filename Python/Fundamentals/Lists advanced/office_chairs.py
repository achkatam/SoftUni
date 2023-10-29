n = int(input())

free_chairs_cnt = 0

called_in = bool

for room in range(1, n + 1):
    inpt = input().split()

    chairs_cnt = inpt[0]
    visitors_cnt = int(inpt[1])

    if len(chairs_cnt) >= visitors_cnt:
        free_chairs_cnt += len(chairs_cnt) - visitors_cnt
        if len(chairs_cnt) == visitors_cnt:
            called_in = False
            continue

        called_in = True

    else:
        needed_chairs = visitors_cnt - len(chairs_cnt)
        print(f'{needed_chairs} more chairs needed in room {room}')
        called_in = True

if not called_in:
    print(f'Game On, {free_chairs_cnt} free chairs left')
