from django.contrib.auth import get_user_model
from rest_framework import serializers

UserModel = get_user_model()


class UserCreateSerializer(serializers.ModelSerializer):
    class Meta:
        model = UserModel
        fields = ("username", "password")

    def create(self, validated_data):
        password = validated_data.pop("password")
        return UserModel.objects.create_user(**validated_data, password=password)

    def to_representation(self, *args, **kwargs):
        representation = super().to_representation(*args, **kwargs)
        representation.pop("password")

        return representation
