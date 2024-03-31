from django.db import models

from testing_demos.web.validators import validate_book_title


# Create your models here.
class Author(models.Model):
    MAX_NAME_LENGTH = 100

    name = models.CharField(
        max_length=MAX_NAME_LENGTH,
        null=False,
        blank=False,
    )


class Genre(models.TextChoices):
    COMEDY = "Comedy"
    HORROR = "HORROR"
    ACTION = "Action"
    FANTASY = "Fantasy"
    SCIENCE_FICTION = "Science Fiction"


class Book(models.Model):
    MAX_TITLE_LENGTH = 100

    title = models.CharField(
        max_length=MAX_TITLE_LENGTH,
        null=False,
        blank=False,
        # Should be tested
        validators=(
            validate_book_title,
        )
    )

    author = models.ForeignKey(
        Author,
        on_delete=models.CASCADE,
    )

    genre = models.CharField(
        max_length=max(len(x) for _, x in Genre.choices),
        choices=Genre.choices,
        null=False,
        blank=False,
        default=Genre.COMEDY,
    )

    # Should be tested
    def __str__(self):
        return f"{self.title} {self.author}"
