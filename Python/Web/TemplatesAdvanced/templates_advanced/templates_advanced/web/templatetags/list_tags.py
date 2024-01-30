from django import template
from django.template.defaultfilters import safe
import datetime

register = template.Library()


# Expects to return a HTML string to visualize
@register.simple_tag
def list_of(values):
    items_strings = ''.join(f'<li>{value}</li>' for value in values)
    return safe(f"<ul>{items_strings}</ul>")


@register.simple_tag
def current_time():
    return datetime.datetime.now()

# Expects to return a HTML string based on a templated
# @register.inclusion_tag


# Expects to return template Node with "render" func
# register.tag