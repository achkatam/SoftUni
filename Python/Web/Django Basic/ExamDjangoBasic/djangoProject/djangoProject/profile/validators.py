from django.core.exceptions import ValidationError


def validate_username(username):
    is_valid = all(char.isalnum() or char == "_" for char in username)

    if not is_valid:
        raise ValidationError("Username must contain only letters, digits, and underscores!")
