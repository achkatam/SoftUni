from django.db import models


# Create your models here.
# Database entity

class Task(models.Model):
    title = models.CharField(max_length=50)
    description = models.TextField()
    done = models.BooleanField(default=False)
