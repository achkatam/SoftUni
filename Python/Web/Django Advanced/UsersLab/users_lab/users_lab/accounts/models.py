from django.contrib.auth.models import AbstractUser, PermissionsMixin
from django.contrib.auth.base_user import AbstractBaseUser

# Just add new fields:
# class AppUser(AbstractUser):
#     age = models.PositiveIntegerField()

# Completely replace the User
# class AppUser(AbstractBaseUser, PermissionsMixin):
#     pass
