from django.contrib.auth import get_user_model
from rest_framework import serializers

UserModel = get_user_model()


class UserRegisterSerializer(serializers.ModelSerializer):
    class Meta:
        model = UserModel
        fields = ("username", "password")

    def create(self, validated_data):
        return UserModel.objects.create_user(**validated_data)
