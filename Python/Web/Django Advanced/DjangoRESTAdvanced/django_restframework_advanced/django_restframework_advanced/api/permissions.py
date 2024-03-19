from rest_framework import permissions


class IsOwnerPermission(permissions.BasePermission):
    def has_permission(self, request, view):
        return request.user and request.user.is_staff

    def has_object_permission(self, request, view, obj):
        return getattr(obj, 'user', None) == request.user
