from rest_framework import serializers

from todo_app.todos.models import Todo, Category, TodoState


class CategorySerializer(serializers.ModelSerializer):
    class Meta:
        model = Category
        fields = "__all__"


class TodoBaseSerializer(serializers.ModelSerializer):
    class Meta:
        model = Todo
        fields = "__all__"


class TodoListSerializer(TodoBaseSerializer):
    category = CategorySerializer(many=False)


class TodoDetailsSerializer(TodoBaseSerializer):
    def to_representation(self, instance):
        result = super().to_representation(instance)

        return {
            **result,
            "is_done": result["state"] == TodoState.DONE,
        }


class TodoCreateSerializer(TodoBaseSerializer):
    def create(self, validated_data):
        validated_data["user"] = self.context["request"].user
        return super().create(validated_data)

    class Meta(TodoBaseSerializer.Meta):
        fields = ("title", "description", "category")

    pass
    # def create(self, validated_data):
    #     category_data = validated_data.pop("category")
    #     category = Category.objects.get_or_create(**category_data)
    #
    #     return Todo.objects.create(**validated_data, category=category[0])
