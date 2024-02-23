from django.db import models
from django.core.validators import MinValueValidator

from exam_prep_my_music_app.albums.enum import MusicGenre
from exam_prep_my_music_app.profiles.models import Profile


class Album(models.Model):
    MAX_ALBUM_LENGTH = 30
    MAX_ARTIST_LENGTH = 30
    MAX_GENRE_LENGTH = 30

    MIN_PRICE = 0.0

    name = models.CharField(
        max_length=30,
        unique=True,
        null=False,
        blank=False,
        verbose_name="Album Name",
    )

    artist = models.CharField(
        max_length=MAX_ARTIST_LENGTH,
        null=False,
        blank=False,
    )

    genre = models.CharField(
        max_length=MAX_GENRE_LENGTH,
        choices=[(tag.value, tag.value) for tag in MusicGenre],
        null=False,
        blank=False,
    )

    description = models.TextField(
        null=True,
        blank=True,
    )

    image = models.URLField(
        null=False,
        blank=False,
        verbose_name="Image URL",
    )

    price = models.FloatField(
        null=False,
        blank=False,
        validators=(
            MinValueValidator(MIN_PRICE),
        ),
    )

    owner = models.ForeignKey(
        Profile,
        on_delete=models.CASCADE,
        null=False,
        blank=False,
    )
