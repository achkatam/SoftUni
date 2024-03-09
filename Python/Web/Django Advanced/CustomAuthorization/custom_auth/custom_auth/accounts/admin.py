from django.contrib import admin
from django.contrib.auth import get_user_model
from django.contrib.auth import admin as auth_admin

from custom_auth.accounts.forms import AccountUserCreationForm, AccountUserChangeForm

UserModel = get_user_model()


@admin.register(UserModel)
class UserModelAdmin(auth_admin.UserAdmin):
    list_display = ("email", "is_superuser", "is_staff",)
    search_fields = ("email",)
    ordering = ("email",)

    add_form = AccountUserCreationForm
    form = AccountUserChangeForm

    fieldsets = (
        (None, {"fields": ("email", "password")}),
        ("Personal info", {"fields": ()}),
        ("Permissions", {"fields": ("is_active", "is_staff",
                                    "groups", "is_superuser",)}),
        ("Important dates", {"fields": ("last_login",)}),
    )

    add_fieldsets = (
        (
            None,
            {
                "classes": ("wide",),
                "fields": ("email", "password1", "password2"),
            },
        ),
    )
