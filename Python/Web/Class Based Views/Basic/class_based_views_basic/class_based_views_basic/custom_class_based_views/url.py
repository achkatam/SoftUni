from django.urls import path
from class_based_views_basic.custom_class_based_views.views import index, IndexView

urlpatterns = (
    path("", index, name="ccvc_index"),
    path("cbv/", IndexView.as_view(), name="cbv_index"),
)
