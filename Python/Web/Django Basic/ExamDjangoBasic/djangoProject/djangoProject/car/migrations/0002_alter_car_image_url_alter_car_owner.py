# Generated by Django 5.0.2 on 2024-02-24 09:52

import django.db.models.deletion
from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('car', '0001_initial'),
        ('profile', '0002_alter_profile_age'),
    ]

    operations = [
        migrations.AlterField(
            model_name='car',
            name='image_url',
            field=models.URLField(error_messages={'unique': 'This image URL is already in use! Provide a new one.'}, max_length=500, unique=True),
        ),
        migrations.AlterField(
            model_name='car',
            name='owner',
            field=models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='profile.profile'),
        ),
    ]