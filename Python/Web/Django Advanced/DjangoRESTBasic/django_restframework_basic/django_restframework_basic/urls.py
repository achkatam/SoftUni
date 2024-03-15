from django.contrib import admin
from django.urls import path, include

urlpatterns = [
    path('admin/', admin.site.urls),
    path("", include("django_restframework_basic.web.urls")),
    path("api/", include("django_restframework_basic.api.urls")),
]
