from django.contrib import admin
from django.urls import path, include


urlpatterns = [
    path("admin/", admin.site.urls),
    path("", include("users_lab.web.urls")),
    path("accounts/", include("users_lab.accounts.urls")),
]
