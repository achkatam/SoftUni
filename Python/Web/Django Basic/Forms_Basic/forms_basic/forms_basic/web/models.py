from django.db import models
from django.core.exceptions import ValidationError


def non_empty_spaces(value):
    if " " in value:
        raise ValidationError("Spaces are not allowed")


class Department(models.Model):
    name = models.CharField(max_length=25)


# Create your models here.
class Employee(models.Model):
    MAX_LENGTH_FIRST_NAME = 50
    MAX_LENGTH_LAST_NAME = 50
    ROLES = (
        (1, "software developer"),
        (2, "web developer"),
    )

    first_name = models.CharField(
        max_length=MAX_LENGTH_FIRST_NAME,
        blank=False,
        null=False,
        validators=(non_empty_spaces,),
    )

    last_name = models.CharField(
        max_length=MAX_LENGTH_LAST_NAME,
        blank=False,
        null=False,
    )

    roles = models.IntegerField(
        choices=ROLES,
        blank=False,
        null=False,
    )

    department = models.ForeignKey(
        Department,
        on_delete=models.DO_NOTHING,
        null=True,
    )

    @property
    def full_name(self):
        return (f"{self.first_name} {self.last_name} occupied by {self.get_roles_display()}"
                f" in {self.department.name}")
