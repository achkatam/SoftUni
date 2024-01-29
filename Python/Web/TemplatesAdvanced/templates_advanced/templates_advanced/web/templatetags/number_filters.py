from django import template

register = template.Library()


# Should be register in Django
def only_with_condition(numbers, condition_func):
    return [x for x in numbers if condition_func(x)]


# Explicit
@register.filter
def only_odd(numbers):
    return only_with_condition(numbers, lambda x: x % 2 != 0)


@register.filter
def only_even(numbers):
    return only_with_condition(numbers, lambda x: x % 2 == 0)

# Python
# def only_odd(numbers):
#     return [x for x in numbers if x % 2 != 0]

# def only_even(numbers):
#     return [x for x in numbers if x % 2 == 0]
