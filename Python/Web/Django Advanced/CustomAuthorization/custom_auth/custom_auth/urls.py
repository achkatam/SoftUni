from django.contrib import admin
from django.urls import path, include

urlpatterns = [
    path('admin/', admin.site.urls),
    path("", include("custom_auth.web.urls")),
    path("accounts/", include("custom_auth.accounts.urls")),
]
