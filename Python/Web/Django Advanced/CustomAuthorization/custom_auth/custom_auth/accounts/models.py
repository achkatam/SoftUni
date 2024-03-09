from django.contrib.auth import get_user_model, models as auth_models
from django.contrib.auth import models as auth_mixins
from django.contrib.auth import base_user as auth_base
from django.contrib.auth.hashers import make_password
from django.contrib import auth

from django.db import models
from django.utils import timezone
from django.utils.translation import gettext_lazy as _

# UserModel = get_user_model()

"""
1. Use the default user model as-is
2. Extend the default user model and add more stuff (Extend "AbstractUser" class)
    - AbstractUser has fields and username, first_name, last_name and etc.
3. Rewrite the whole user model (Extend "AbstractBaseUser" class)
    - AbstractBaseUser has password field
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
# UserModel = get_user_model()
#
#
# class Profile(models.Model):
#     age = models.PositiveIntegerField(
#         null=False,
#         blank=False,
#     )
#
#     user = models.OneToOneField(
#         UserModel,
#         on_delete=models.DO_NOTHING,
#         primary_key=True,
#     )


"""
! 2. Extend the user model using One-to-One relationship to 'Profile'
    - Add 'age' field
    - Add 'first_name' field
    - Add 'last_name'
    - and etc.
    
    
    2.2. Create our own user model

    # Benefits:
     - Easier migration to other auth model in the future 
"""


# ****************************************************************


class AccountUserManager(auth_base.BaseUserManager):
    user_in_migrations = True

    def _create_user(self, email, password, **extra_fields):
        """
        Create and save a user with the given  email, and password.
        """
        if not email:
            raise ValueError("The given email must be set")
        email = self.normalize_email(email)

        user = self.model(email=email, **extra_fields)
        user.password = make_password(password)
        user.save(using=self._db)
        return user

    def create_user(self, email, password=None, **extra_fields):
        extra_fields.setdefault("is_staff", False)
        extra_fields.setdefault("is_superuser", False)
        return self._create_user(email, password, **extra_fields)

    def create_superuser(self, email, password=None, **extra_fields):
        extra_fields.setdefault("is_staff", True)
        extra_fields.setdefault("is_superuser", True)

        if extra_fields.get("is_staff") is not True:
            raise ValueError("Superuser must have is_staff=True.")
        if extra_fields.get("is_superuser") is not True:
            raise ValueError("Superuser must have is_superuser=True.")

        return self._create_user(email, password, **extra_fields)

    def with_perm(
            self, perm, is_active=True, include_superusers=True, backend=None, obj=None
    ):
        if backend is None:
            backends = auth._get_backends(return_tuples=True)
            if len(backends) == 1:
                backend, _ = backends[0]
            else:
                raise ValueError(
                    "You have multiple authentication backends configured and "
                    "therefore must provide the `backend` argument."
                )
        elif not isinstance(backend, str):
            raise TypeError(
                "backend must be a dotted import path string (got %r)." % backend
            )
        else:
            backend = auth.load_backend(backend)
        if hasattr(backend, "with_perm"):
            return backend.with_perm(
                perm,
                is_active=is_active,
                include_superusers=include_superusers,
                obj=obj,
            )
        return self.none()


# Only has password and last_login, so we can customize everything else
# Instead of username, we gonna use email
# Keeps the auth data
class AccountUser(auth_models.AbstractBaseUser, auth_mixins.PermissionsMixin):
    email = models.EmailField(
        unique=True,
        error_messages={
            "unique": _("A user with that email already exists."),
        },
    )

    is_active = models.BooleanField(
        _("active"),
        default=True,
        help_text=_(
            "Designates whether this user should be treated as active. "
            "Unselect this instead of deleting accounts."
        ),
    )
    date_joined = models.DateTimeField(_("date joined"), default=timezone.now)

    is_staff = models.BooleanField(
        _("staff status"),
        default=False,
        help_text=_("Designates whether the user can log into this admin site."),
    )

    # For credentials
    USERNAME_FIELD = "email"

    objects = AccountUserManager()


# Keeps the user data
class Profile(models.Model):
    age = models.PositiveIntegerField(
        null=False,
        blank=False,
    )

    user = models.OneToOneField(
        AccountUser,
        on_delete=models.DO_NOTHING,
        primary_key=True,
    )

# Use the proxy to add custom behaviour WITHOUT fields
# class AccountUserProxy(UserModel):
#     class Meta:
#         proxy = True
#         ordering = ("first_name",)
#
#     def some_custom_behavior(self): ...
