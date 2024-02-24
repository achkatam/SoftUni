from django.urls import path, include

from djangoProject.car.views import CreateCarView, CatalogueView, DetailsCarView, EditCarView, DeleteCarView

urlpatterns = [
    path("create/", CreateCarView.as_view(), name="create_car"),
    path("catalogue/", CatalogueView.as_view(), name="catalogue"),
    path("<int:pk>/",
         include([
             path("details/", DetailsCarView.as_view(), name="details_car"),
             path("edit/", EditCarView.as_view(), name="edit_car"),
             path("delete/", DeleteCarView.as_view(), name="delete_car"),
         ]),
         ),
]

"""
http://localhost:8000/ - Index page 
· http://localhost:8000/car/catalogue/ 
- Catalogue page · http://localhost:8000/car/create/ 
- Car create page · http://localhost:8000/car/<id>/details/ 
- Car details page · http://localhost:8000/car/<id>/edit/ 
- Car edit page · http://localhost:8000/car/<id>/delete/ 
"""
