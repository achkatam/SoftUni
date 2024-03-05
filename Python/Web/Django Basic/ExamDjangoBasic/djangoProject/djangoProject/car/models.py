from django.db import models
from django.core.validators import MinValueValidator, MaxValueValidator, MinLengthValidator

from djangoProject.car.enum import CarType
from djangoProject.profile.models import Profile


class Car(models.Model):
    MAX_TYPE_LENGTH = 10
    MAX_MODEL_LENGTH = 15
    MIN_MODEL_LENGTH = 1
    MAX_YEAR_VALIDATOR = 2030
    MIN_YEAR_VALIDATOR = 1999
    ERROR_MESSAGE = "Year must be between 1999 and 2030!"

    TYPE_CHOICES = [
        (tag.value, tag.value) for tag in CarType
    ]

    type = models.CharField(
        max_length=MAX_TYPE_LENGTH,
        choices=TYPE_CHOICES,
        null=False,
        blank=False,
    )

    model = models.CharField(
        max_length=MAX_MODEL_LENGTH,
        validators=(
            MinLengthValidator(MIN_MODEL_LENGTH,
                               message="Model must be at least 1 character long."),
        ),
        null=False,
        blank=False,
    )

    year = models.IntegerField(
        validators=(
            MinValueValidator(MIN_YEAR_VALIDATOR,
                              message=ERROR_MESSAGE),
            MaxValueValidator(MAX_YEAR_VALIDATOR,
                              message=ERROR_MESSAGE),
        ),
        null=False,
        blank=False,
    )

    image_url = models.URLField(
        unique=True,
        null=False,
        blank=False,
        error_messages={
            'unique': "This image URL is already in use! Provide a new one."
        }
    )

    price = models.FloatField(
        validators=(
            MinValueValidator(1.0, message="Price cannot be below 1.0."),
        ),
        null=False,
        blank=False
    )

    owner = models.ForeignKey(
        Profile,
        on_delete=models.CASCADE,
        null=False,
        blank=False,
    )
