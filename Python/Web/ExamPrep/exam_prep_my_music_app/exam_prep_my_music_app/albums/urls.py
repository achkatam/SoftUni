from django.urls import path, include

from exam_prep_my_music_app.albums.views import CreateAlbumView, DetailAlbumView, EditAlbumView

urlpatterns = (
    path("add/", CreateAlbumView.as_view(), name="create_album"),
    path("<int:pk>/",
         include([
             path("details/", DetailAlbumView.as_view(), name="details_album"),
             path("edit/", EditAlbumView.as_view(), name="edit_album"),

         ])
         ),
)

# TODO: Delete this
"""
•	http://localhost:8000/album/<id>/edit/ - Edit album page
•	http://localhost:8000/album/<id>/delete/ - Delete album page
•	http://localhost:8000/profile/details/ - Profile details page
•	http://localhost:8000/profile/delete/ - Delete profile page
"""
