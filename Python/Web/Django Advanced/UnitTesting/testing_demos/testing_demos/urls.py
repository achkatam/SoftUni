from django.contrib import admin
from django.urls import path, include

urlpatterns = [
    path('admin/', admin.site.urls),
    path("", include("testing_demos.web.urls")),
]

"""
# Testing
- Manual tests
    * Done by Manual QA/tester
    
- Automated tests
    - Done by Software QA/tester
        * Unit testing:
            - Easy to write
            - Very fast
            - Easy to maintain
            - There could be many of them
        * Integration testing
            - More usable
            - In some cases more difficult to write
            - More time consuming
    - Done by Automated QA/tester
        * End to end testing
        * Functional testing
        * API testing
    - Done by ...
        * System testing
        * Performance testing
    ... 
"""
