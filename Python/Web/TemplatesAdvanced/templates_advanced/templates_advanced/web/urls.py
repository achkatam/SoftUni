from django.urls import path
from templates_advanced.web.views import index, about, visualize_bootstrap

urlpatterns = (
    path("", index, name="index"),
    path("about/", about, name="about"),
    path("bootstrap/", visualize_bootstrap, name="visualize_bootstrap"),
)
