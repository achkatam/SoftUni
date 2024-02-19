from django.db import models
from django.core.validators import MinLengthValidator
from django.core.exceptions import ValidationError


# TODO: Move to validators
def validate_username(username):
    is_valid = all(char.isalnum() or char == "_" for char in username)

    if not is_valid:
        raise ValidationError("Ensure this value contains only letters, numbers, and underscore.")


# Create your models here.
class Profile(models.Model):
    MIN_USERNAME_LENGTH = 2
    MAX_USERNAME_LENGTH = 15

    username = models.CharField(
        max_length=MAX_USERNAME_LENGTH,
        validators=(
            MinLengthValidator(MIN_USERNAME_LENGTH),
        ),
        null=False,
        blank=False,
    )

    email = models.EmailField(
        null=False,
        blank=False,
    )

    age = models.PositiveIntegerField(
        null=True,
        blank=True,
    )
