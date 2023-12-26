class ExercisePlan:
    id = 1

    def __init__(self, trainer_id: int, equipment_id: int, duration: int):
        self.trainer_id = trainer_id
        self.equipment_id = equipment_id
        self.duration = duration
        self.id = ExercisePlan.id
        ExercisePlan.id += 1

    @staticmethod
    def get_next_id():
        return ExercisePlan.id

    def from_hours(self, trainer_id: int, equipment_id: int, hours: int):
        self.equipment_id = equipment_id
        self.trainer_id = trainer_id
        self.duration = hours

    def __repr__(self):
        return f'Plan <{self.id}> with duration {self.duration} minutes'