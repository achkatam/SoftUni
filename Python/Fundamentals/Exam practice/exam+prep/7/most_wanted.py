class Car:
    def __init__(self, make, mileage, fuel):
        self.make = make
        self.mileage = mileage
        self.fuel = fuel
        self.max_hp = 75


def drive(cars: dict, make: str, distance: int, fuel: int):
    if (cars[make].fuel - fuel) <= 0:
        print(f"Not enough fuel to make that ride")
        return

    cars[make].mileage += distance
    cars[make].fuel -= fuel
    print(f"{make} driven for {distance} kilometers. {fuel} liters of fuel consumed.")

    if cars[make].mileage >= 100_000:
        del cars[make]
        print(f'Time to sell the {make}!')


def refuel(cars: dict, make: str, fuel: int):
    if cars[make].fuel + fuel > cars[make].max_hp:
        fuel = cars[make].max_hp - cars[make].fuel

    cars[make].fuel += fuel
    print(f"{make} refueled with {fuel} liters")


def over_reverted(cars: dict, make: str):
    if cars[make].mileage < 10_000:
        cars[make].mileage = 10_000
        return cars[make].mileage


def revert(cars: dict, make: str, kms: int):
    cars[make].mileage -= kms

    if over_reverted(cars, make):
        return
    print(f"{make} mileage decreased by {kms} kilometers")


def print_output(cars: dict):
    for key, value in cars.items():
        print(f"{key} -> Mileage: {value.mileage} kms, Fuel in the tank: {value.fuel} lt.")


num = int(input())

cars = {}

for i in range(num):
    tokens = input().split("|")

    make = tokens[0]
    mileage = int(tokens[1])
    fuel = int(tokens[2])

    cars[make] = Car(make, mileage, fuel)

command = input()

while command != "Stop":
    tokens = command.split(" : ")
    cmd = tokens[0]
    make = tokens[1]

    if cmd == "Drive":
        distance = int(tokens[2])
        fuel = int(tokens[3])
        drive(cars, make, distance, fuel)
    elif cmd == "Refuel":
        fuel = int(tokens[2])
        refuel(cars, make, fuel)
    elif cmd == "Revert":
        kms = int(tokens[2])
        revert(cars, make, kms)
    command = input()

print_output(cars)
