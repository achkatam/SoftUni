class Calculator:

    @staticmethod
    def add(*args):
        return sum(args)

    @staticmethod
    def subtract(*args):
        result = args[0]
        for num in args[1:]:
            result -= num
        return result

    @staticmethod
    def multiply(*args):
        result = 1

        for num in args:
            result *= num
        return result

    @staticmethod
    def divide(*args):
        if len(args) == 0:
            raise ValueError('Cannot divide by zero.')
        result = args[0]
        for num in args[1:]:
            if num == 0:
                raise ValueError("Cannot divide by zero.")
            result /= num
        return result


print(Calculator.add(5, 10, 4))
print(Calculator.multiply(1, 2, 3, 5))
print(Calculator.divide(100, 2))
print(Calculator.subtract(90, 20, -50, 43, 7))
