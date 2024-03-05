from django.contrib import admin
from django.urls import path, include

urlpatterns = [
    path('admin/', admin.site.urls),

    path("", include("djangoProject.web.urls")),
    path("car/", include("djangoProject.car.urls")),
    path("profile/", include("djangoProject.profile.urls")),
]
