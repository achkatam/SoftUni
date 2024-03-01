from django.views import generic as views
from django.contrib.auth.decorators import login_required
from django.http import HttpResponse
from django.contrib.auth import mixins as auth_mixins


# Create your views here.
def index(request):
    # print(request.user)  # prints the "User" or "AnonymousUser"
    return HttpResponse("<h1>it works</h1>")


@login_required
def about(request):
    return HttpResponse(f"<h1>It's about that, {request.user}!</h1>")


class TeamView(auth_mixins.LoginRequiredMixin, views.View):
    def get(self, request):
        return HttpResponse(f"<h1>{request.user}'s team!</h1>")
