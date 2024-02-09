from django.http import HttpResponse
from django.shortcuts import render


class BaseView:
    @classmethod
    def as_view(cls):
        def view(request, *args, **kwargs):
            self = cls()

            # dispatch logic
            if request.method == "GET":
                return self.get(request, *args, **kwargs)
            else:
                return self.post(request, *args, **kwargs)

        return view


class IndexView(BaseView):
    def get(self, request):
        return HttpResponse(f"<h1>It works with CBVs!</h1>")


# Create your views here.
def index(request):
    return render(request, 'custom_class_based_views/custom_index.html')
