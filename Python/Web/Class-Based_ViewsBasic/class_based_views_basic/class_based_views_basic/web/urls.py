from django.urls import path
from class_based_views_basic.web.views import index, IndexRawView, IndexView

urlpatterns = (
    path("", IndexView.as_view(), name="index"),
    path("raw/", index, name="index raw"),
    path("view/", IndexRawView.as_view(), name="view"),
    path("initkwargs/", TemplateView.as_view(template_name="web/index.html")),
)
