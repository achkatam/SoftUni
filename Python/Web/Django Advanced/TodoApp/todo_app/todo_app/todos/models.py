from django.db import models

# Create your models here.
"""
Category

· Name - maximum 15 characters

Todo

· Title - maximum 30 characters

· Description - any text, with no limit of words/chars

· Category - a relation to category

· State - can be either "Done" or "Not done
"""


class Category(models.Model):
    MAX_NAME_LENGTH = 15
    name = models.CharField(
        max_length=MAX_NAME_LENGTH,
        null=False,
        blank=False,
    )


class Todo(models.Model):
    MAX_TITLE_LENGTH = 30
    choices = (
        ('Done', 'Done'),
        ('Not done', 'Not done')
    )
    title = models.CharField(
        max_length=MAX_TITLE_LENGTH
    )
    description = models.TextField()
    category = models.ForeignKey(
        Category,
        on_delete=models.CASCADE)
    state = models.CharField(
        max_length=10,
        choices=choices
    )
