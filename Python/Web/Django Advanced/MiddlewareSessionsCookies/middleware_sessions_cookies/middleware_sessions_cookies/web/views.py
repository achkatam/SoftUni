import time

from django.views import generic as views


def get_load_count(request):
    load_count = request.session.get('load_count', 0)

    return load_count + 1


class IndexView(views.TemplateView):
    template_name = "web/index.html"

    def dispatch(self, request, *args, **kwargs):
        load_count = get_load_count(self.request)
        self.request.session["load_count"] = load_count
        print(request.COOKIES)
        request.COOKIES["today"] = time.time()

        return super().dispatch(request, *args, **kwargs)
