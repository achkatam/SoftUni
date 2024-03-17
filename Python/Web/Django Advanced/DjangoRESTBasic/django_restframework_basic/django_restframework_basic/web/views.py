import time

from django.views import generic as views


# Create your views here.
class IndexView(views.TemplateView):
    template_name = "web/index.html"
    
    # def get_context_data(self, **kwargs):
    #     time.sleep(1)
    #
    #     return super().get_context_data(**kwargs)
