from django.db import models
from django.core.validators import MinLengthValidator

from exam_prep_my_music_app.profiles.validators import validate_username


# Create your models here.
class Profile(models.Model):
    MIN_USERNAME_LENGTH = 2
    MAX_USERNAME_LENGTH = 15

    username = models.CharField(
        max_length=MAX_USERNAME_LENGTH,
        validators=(
            MinLengthValidator(MIN_USERNAME_LENGTH),
            validate_username,
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
