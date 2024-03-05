from django.urls import path

from extending_user_model.accounts.views import LoginUserView

urlpatterns = (
    path("login/", LoginUserView.as_view(), name="login_user"),
)