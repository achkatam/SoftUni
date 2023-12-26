from MovieWorld.dvd import DVD
from MovieWorld.customer import Customer


class MovieWorld:
    def __int__(self, name: str):
        self.name = name
        self.customers = []
        self.dvds = []

    @staticmethod
    def dvd_capacity():
        return 15

    @staticmethod
    def customer_capacity():
        return 10

    def add_customer(self, customer: Customer):
        if len(self.customers) < MovieWorld.customer_capacity():
            self.customers.append(customer)

    def add_dvd(self, dvd: DVD):
        if len(self.dvds) < MovieWorld.dvd_capacity():
            self.dvds.append(dvd)

    def rent_dvd(self, customer_id: int, dvd_id: int):
        for customer in self.customers:
            if customer.id == customer_id:
                matched_ids = [i.id for i in customer.rented_dvds if i.id == dvd_id]
                for dvd in self.dvds:
                    if dvd.id == dvd_id:
                        if matched_ids:
                            return f'{customer.name} has already rented " f"{dvd.name}'
                        elif dvd.is_rented:
                            return f'DVD is already rented'
                        elif customer.age < dvd.age_restriction:
                            return (
                                f'{customer.name} should be at least {dvd.age_restriction} to rent this movie'
                            )
                        else:
                            dvd.is_rented = True
                            customer.rented_dvds.append(dvd)
                            return (
                                f"{customer.name} has successfully rented "
                                f"{dvd.name}"
                            )

    def return_dvd(self, customer_id: int, dvd_id: int):
        for customer in self.customers:
            if customer.id == customer_id:
                for dvd in self.dvds:
                    if dvd_id == dvd.id:
                        for idx, v_dvd in enumerate(customer.rented_dvds):
                            if dvd.name == v_dvd.name:
                                dvd.is_rented = False
                                del customer.rented_dvds[idx]
                                return (
                                    f"{customer.name} has successfully "
                                    f"returned {dvd.name}"
                                )
                        return f"{customer.name} does not have that DVD"

    def __repr__(self):
        string_builder = ''
        for customer in self.customers:
            string_builder += f'{customer.__repr__()}\n'
        for dvd in self.dvds:
            if self.dvd.index(dvd) == len(self.dvds) - 1:
                string_builder += f'{dvd.__repr__()}'
            else:
                string_builder += f'{dvd.__repr__}'

        return string_builder