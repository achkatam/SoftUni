# Generated by Django 5.0.1 on 2024-02-10 13:05

import django.core.validators
from django.db import migrations, models


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='Todo',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('title', models.TextField(max_length=24, validators=[django.core.validators.MinLengthValidator(3)])),
                ('date_created', models.DateField(auto_now_add=True)),
                ('deadline', models.DateTimeField(blank=True, null=True)),
            ],
        ),
    ]
