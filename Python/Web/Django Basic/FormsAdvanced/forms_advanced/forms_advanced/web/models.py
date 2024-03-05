from django.db import models
from django.core.validators import MinLengthValidator
from django.core.exceptions import ValidationError


def validate_first_name(value):
    if " " in value:
        raise ValidationError("First name cannot contain a whitespace.")


# Create your models here.
class Person(models.Model):
    MIN_LENGTH_FIRST_NAME = 2
    MIN_LENGTH_LAST_NAME = 2

    MAX_LENGTH_FIRST_NAME = 32
    MAX_LENGTH_LAST_NAME = 32

    first_name = models.CharField(
        max_length=MAX_LENGTH_FIRST_NAME,
        validators=(
            # do not call the validate_first_name() function but
            # pass it as reference
            validate_first_name,
            MinLengthValidator(MIN_LENGTH_FIRST_NAME),
        )
    )

    last_name = models.CharField(
        max_length=MAX_LENGTH_LAST_NAME,
        validators=(
            # do not call the validate_first_name() function but
            # pass it as reference
            validate_first_name,
            MinLengthValidator(MAX_LENGTH_FIRST_NAME),
        )
    )

    age = models.PositiveSmallIntegerField()

    profile_image = models.ImageField(
        upload_to="web/profile_images",
        blank=True,
        null=True,
    )
