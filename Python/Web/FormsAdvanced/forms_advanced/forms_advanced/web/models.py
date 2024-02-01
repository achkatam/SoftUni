from django.db import models
from django.core.validators import MinLengthValidator
from django.core.exceptions import ValidationError


def validate_first_name(value):
    if " " in value:
        raise ValidationError("First name cannot contain a whitespace.")


# Create your models here.
class Person(models.Model):
    first_name = models.CharField(
        max_length=32,
        validators=(
            # do not call the validate_first_name() function but
            # pass it as reference
            validate_first_name,
            MinLengthValidator(1),
        )
    )
