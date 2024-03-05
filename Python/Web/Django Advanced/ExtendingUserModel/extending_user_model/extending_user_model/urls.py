from django.contrib import admin
from django.urls import path, include

urlpatterns = [
    path('admin/', admin.site.urls),
    path("accounts/", include("extending_user_model.accounts.urls")),
    path("", include("extending_user_model.web.urls")),
]
