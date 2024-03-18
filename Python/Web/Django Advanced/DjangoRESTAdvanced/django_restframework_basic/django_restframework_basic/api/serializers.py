from rest_framework import serializers

from django_restframework_basic.api.models import Book, Author


class BookForAuthorListSerializer(serializers.ModelSerializer):
    class Meta:
        model = Book
        fields = ("title", "genre",)


class AuthorForListSerializer(serializers.ModelSerializer):
    book_set = BookForAuthorListSerializer(many=True, read_only=True)

    class Meta:
        model = Author
        fields = ("name", "book_set",)


class AuthorForBookSerializer(serializers.ModelSerializer):
    class Meta:
        model = Author
        fields = ("name",)


class AuthorForCreateSerializer(serializers.ModelSerializer):
    class Meta:
        model = Author
        fields = ("name",)


class BookForCreateSerializer(serializers.ModelSerializer):
    author = AuthorForCreateSerializer(many=False)

    class Meta:
        model = Book
        fields = "__all__"

    def create(self, validated_data):
        author_data = validated_data.pop('author')
        author_name = author_data.get('name')

        author, created = Author.objects.get_or_create(name=author_name)

        if created:
            author.save()

        return Book.objects.create(author=author, **validated_data)

    # def save(self, **kwargs):
    #     author_data = self.validated_data.pop('author', None)
    #
    #     author, _ = Author.objects.get_or_create(author_data)
    #
    #     return Book.objects.create(**self.validated_data, author=author)


class BookForListSerializer(serializers.ModelSerializer):
    author = AuthorForBookSerializer(many=False, read_only=True)

    class Meta:
        model = Book
        fields = ("pk", "title", "author", "genre",)


class BookForUpdateSerializer(serializers.ModelSerializer):
    author = AuthorForBookSerializer(many=False, read_only=True)

    class Meta:
        model = Book
        fields = ("title", "pages", "author", "genre",)
