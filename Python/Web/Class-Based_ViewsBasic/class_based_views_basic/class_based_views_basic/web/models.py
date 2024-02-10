from django.db import models
from django.core.validators import MinLengthValidator


# Create your models here.

class Category(models.Model):
    MIN_NAME_LENGTH = 3
    MAX_NAME_LENGTH = 34
    name = models.CharField(max_length=MAX_NAME_LENGTH,
                            validators=
                            (MinLengthValidator(MIN_NAME_LENGTH),
                             ),
                            null=False,
                            blank=False,
                            )


class Todo(models.Model):
    MIN_TITLE_FIELD = 3
    MAX_TITLE_FIELD = 24

    title = models.TextField(max_length=MAX_TITLE_FIELD,
                             validators=
                             (MinLengthValidator(MIN_TITLE_FIELD),
                              ),
                             null=True,
                             blank=True,
                             )

    date_created = models.DateField(
        auto_now_add=True,
    )

    deadline = models.DateTimeField(
        null=True,
        blank=True,
    )

    category = models.ForeignKey(
        Category,
        on_delete=models.DO_NOTHING,
        null=True,
        blank=True,
    )
