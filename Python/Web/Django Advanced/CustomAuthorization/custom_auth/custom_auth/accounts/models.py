from django.contrib.auth import get_user_model, models as auth_models
from django.db import models

# UserModel = get_user_model()

"""
1. Use the default user model as-is
2. Extend the default user model and add more stuff (Extend "AbstractUser" class)
    - AbstractUser has fields and username, first_name, last_name and etc.
3. Rewrite the whole user model (Extend "AbstractBaseUser" class)
    - AbstractBaseUser has password field
"""

"""



    2.2. Create our own user model

    # Benefits:
     - Easier migration to other auth model in the future 
"""

"""
1. Extend the default user model through 'AbstractUser' class
    - Add age field, first_name, last_name and etc.
    - ...

    # Benefits:
     - Simple to use
     - No need to override Django auth system
     """

#
# class AccountUser(auth_models.AbstractUser):
#     age = models.PositiveIntegerField(
#         null=True,
#         blank=True,
#     )

# ******************************************

"""
! 2. Extend the user model using One-to-One relationship to 'Profile'
    - Add 'age' field
    - Add 'first_name' field
    - Add 'last_name'
    - and etc.

    2.1 Use the build-in user model for auth
"""
UserModel = get_user_model()


class Profile(models.Model):
    age = models.PositiveIntegerField(
        null=False,
        blank=False,
    )

    user = models.OneToOneField(
        UserModel,
        on_delete=models.DO_NOTHING,
        primary_key=True,
    )

# Use the proxy to add custom behaviour
# class AccountUserProxy(UserModel):
#     class Meta:
#         proxy = True
#         ordering = ("first_name",)
#
#     def some_custom_behavior(self): ...
