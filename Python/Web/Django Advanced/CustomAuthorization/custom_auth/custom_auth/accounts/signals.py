from django.contrib.auth import get_user_model
from django.db.models.signals import post_save
from django.dispatch import receiver

from custom_auth.accounts.models import Profile
from custom_auth.web.models import Model1

UserModel = get_user_model()


@receiver(post_save, sender=Model1)
def user_created(sender, instance, created, *args, **kwargs):
    if not created:
        return

    profile = instance.profile

    if profile is not None:
        return

    Profile.objects.create(user=instance)
