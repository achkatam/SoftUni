from . import views
from django.urls import path, include

urlpatterns = [
    # Errors
    path("raise_error/", views.raise_error, name="raise_error"),
    path("raise_error404/", views.raise_error404, name="raise_error404"),

    # Redirect
    path(f'to_softuni/', views.redirect_to_softuni),
    path("to_index/", views.redirect_to_index, name="redirect_to_index"),
    path("to_index_with_params/", views.redirect_to_index_with_params, name="redirect_to_index_with_params"),

    path("", views.index, name="index_no_params"),
    path("<int:pk>/", views.index),
    path("<slug:slug>/", views.index),
    path("<int:pk>/<slug:slug>/", views.index, name="index_with_pk_and_slug"),

    path("json/", include([
        path("", views.index),
        path("<int:pk>/", views.index),
        path("<slug:slug>/", views.index),
        path("<int:pk>/<slug:slug>/", views.index),
    ])),


]
