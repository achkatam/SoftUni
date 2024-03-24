from django.contrib.auth import get_user_model
from django.db import models

UserModel = get_user_model()


class Category(models.Model):
    MAX_NAME_LENGTH = 15
    name = models.CharField(
        max_length=MAX_NAME_LENGTH,
        null=False,
        blank=False,
    )

    # def __str__(self):
    #     return f"{self.name}"

    class Meta:
        verbose_name_plural = "Categories"


class TodoState(models.TextChoices):
    DONE = "Done"
    NOT_DONE = "Not done"


class Todo(models.Model):
    MAX_TITLE_LENGTH = 30
    MAX_STATE_LENGTH = max(len(x) for _, x in TodoState.choices)

    title = models.CharField(
        max_length=MAX_TITLE_LENGTH,
        null=False,
        blank=False,
    )
    description = models.TextField(
        null=True,
        blank=True,
    )

    state = models.CharField(
        choices=TodoState,
        max_length=MAX_STATE_LENGTH,
        default=TodoState.NOT_DONE,
    )

    category = models.ForeignKey(
        Category,
        on_delete=models.CASCADE
    )

    user = models.ForeignKey(
        UserModel,
        on_delete=models.CASCADE,
    )
