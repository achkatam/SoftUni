from django.core.exceptions import ValidationError

"""
Django needs callable with single argument that raises ValidationError if data is invalid.
We can use functions or classes to validate.
"""


# Function validator
def validate_email(value):
    if "@" not in value:
        raise ValidationError("Email address is not valid.")


# Class validator
class FileSizeValidator:
    def __init__(self, max_files_size):
        self.max_files_size = max_files_size

    def call(self, value):
        if value.size > self.max_files_size:
            raise ValidationError(f"File size is too big."
                                  "Should be less than {self.max_files_size}.")


validate_email("angelog@gmail.com")
FileSizeValidator(5)
