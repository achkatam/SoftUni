from django.urls import path

from middleware_sessions_cookies.web.views import IndexView

urlpatterns = [
    path("", IndexView.as_view(), name="index"),
]
