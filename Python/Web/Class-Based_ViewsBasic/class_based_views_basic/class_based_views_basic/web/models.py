from django.db import models
from django.core.validators import MinLengthValidator


# Create your models here.
class Todo(models.Model):
    MIN_TITLE_FIELD = 3
    MAX_TITLE_FIELD = 24

    title = models.TextField(max_length=MAX_TITLE_FIELD,
                             validators=
                             (MinLengthValidator(MIN_TITLE_FIELD),
                              ),
                             null=False,
                             blank=False,
                             )

    date_created = models.DateField(
        auto_now_add=True,
    )

    deadline = models.DateTimeField(
        null=True,
        blank=True,
    )
