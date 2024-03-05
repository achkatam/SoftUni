from django.core.validators import MinLengthValidator, MinValueValidator
from django.db import models

from djangoProject.profile.validators import validate_username


class Profile(models.Model):
    MAX_USERNAME_LENGTH = 15
    MIN_USERNAME_LENGTH = 3
    MIN_AGE = 21
    MAX_FIRST_AND_LAST_NAME = 25

    MAX_PASSWORD_LENGTH = 20

    username = models.CharField(
        max_length=MAX_USERNAME_LENGTH,
        validators=(
            MinLengthValidator(MIN_USERNAME_LENGTH,
                               message="Username must be at least 3 chars long!"),
            validate_username),
        null=False,
        blank=False
    )

    email = models.EmailField(
        null=False,
        blank=False,

    )

    age = models.PositiveIntegerField(
        validators=(
            MinValueValidator(MIN_AGE,
                              message="Age requirement: 21 years and above."),
        ),
        help_text="Age requirement: 21 years and above.",
        null=False,
        blank=False,
    )

    password = models.CharField(
        max_length=MAX_PASSWORD_LENGTH,
        null=False,
        blank=False,
    )

    first_name = models.CharField(
        max_length=MAX_FIRST_AND_LAST_NAME,
        null=True,
        blank=True,
    )

    last_name = models.CharField(
        max_length=MAX_FIRST_AND_LAST_NAME,
        null=True,
        blank=True,
    )

    profile_pic = models.URLField(
        null=True,
        blank=True,
    )

    def __str__(self):
        return f"{self.first_name} {self.last_name}"
