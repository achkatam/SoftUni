from project.equipment import Equipment
from project.customer import Customer
from project.trainer import Trainer
from project.subscription import Subscription
from project.exercise_plan import ExercisePlan


class Gym:
    def __init__(self):
        self.customers = []
        self.trainers = []
        self.equipment = []
        self.plans = []
        self.subscriptions = []

    def add_customer(self, customer: Customer):
        if customer not in self.customers:
            self.customers.append(customer)

    def add_trainer(self, trainer: Trainer):
        if trainer not in self.trainers:
            self.trainers.append(trainer)

    def add_equipment(self, equipment: Equipment):
        if equipment not in self.equipment:
            self.equipment.append(equipment)

    def add_plan(self, plan: ExercisePlan):
        if plan not in self.plans:
            self.plans.append(plan)

    def add_subscription(self, subscription: Subscription):
        if subscription not in self.subscriptions:
            self.subscriptions.append(subscription)

    def subscription_info(self, subscription_id: int):
        new_line = '\n'
        info = [
            list(x) for x in zip(
                self.subscriptions,
                self.customers,
                self.trainers,
                self.equipment,
                self.plans
            )
        ]
        info = [sub for x in info for sub in x]
        return f'{new_line.join(str(i) for i in info)}'