# Generated by Django 5.0.2 on 2024-02-12 19:09

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('web', '0003_todo_tenant_alter_todo_slug'),
    ]

    operations = [
        migrations.AlterField(
            model_name='todo',
            name='tenant',
            field=models.CharField(blank=True, default=None, max_length=16, null=True),
        ),
    ]