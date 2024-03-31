from django.contrib.auth import get_user_model
from django.test import TestCase
from django.urls import reverse

UserModel = get_user_model()


class IndexFbvTests(TestCase):
    def test_index_fbv_what_can_be_tested(self):
        response = self.client.get(reverse("index fbv"))

        context = response.context
        self.assertEqual("web/users.html", context.template_name)
        self.assertEqual(200, response.status_code)

    def test_index_fbv_when_no_users__expect_empty_user_list(self):
        response = self.client.get(reverse("index fbv"))

        context = response.context
        users_list = context["users_list"]
        expected_users_list = []

        self.assertListEqual(expected_users_list, list(users_list))

    def test_index_fbv_when_single_user__expect_list_with_one_user(self):
        # Arrange
        user = UserModel.objects.create(username="test_user", password="test_password")

        # Act
        response = self.client.get(reverse("index fbv"))

        # Assert
        context = response.context
        users_list = context["users_list"]

        expected_users_list = [user]

        self.assertListEqual(expected_users_list, list(users_list))

    def test_index_fbv_when_three_users__expect_users_with_three_users(self):
        # Arrange
        users = [
            UserModel.objects.create(username=f"test_user-{index}", password="test_password")
            for index in range(1, 4)
        ]

        # Act
        response = self.client.get(reverse("index fbv"))

        # Assert
        context = response.context
        users_list = context["users_list"]
        expected_users_list = users

        self.assertListEqual(expected_users_list, list(users_list))
