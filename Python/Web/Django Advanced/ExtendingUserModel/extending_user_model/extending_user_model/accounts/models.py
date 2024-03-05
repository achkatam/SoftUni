from django.contrib.auth import get_user_model

UserModel = get_user_model()


# Create your models here.
class AccountsUserProxy(UserModel):
    class Meta:
        proxy = True
        ordering = ("first_name",)

    def some_custom_behavior(self): ...


print(UserModel.objects.all())  # ordered by PK
print(AccountsUserProxy.objects.all())  # ordered by "first_name"
