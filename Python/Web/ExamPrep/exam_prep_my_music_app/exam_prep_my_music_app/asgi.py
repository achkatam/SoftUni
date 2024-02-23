"""
ASGI config for exam_prep_my_music_app project.

It exposes the ASGI callable as a module-level variable named ``application``.

For more information on this file, see
https://docs.exam_prep_my_music_app.com/en/5.0/howto/deployment/asgi/
"""

import os

from django.core.asgi import get_asgi_application

os.environ.setdefault('DJANGO_SETTINGS_MODULE', 'exam_prep_my_music_app.settings')

application = get_asgi_application()
