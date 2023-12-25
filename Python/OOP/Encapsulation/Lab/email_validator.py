import re


class EmailValidator:
    def __init__(self, min_length: int, mails: list, domains: list) -> None:
        self.min_length = min_length
        self.mails = mails
        self.domains = domains

    def __is_name_valid(self, name):
        if len(name) >= self.min_length:
            return True

        return False

    def __is_mail_valid(self, mail):
        if mail in self.mails:
            return True

        return False

    def __is_domain_valid(self, domain):
        if domain in self.domains:
            return True

        return False

    def validate(self, email):
        regex = r"(\w+)@(\w+)\.(\w+)"
        matches = re.findall(regex, email)
        if self.__is_name_valid(matches[0][0]):
            if self.__is_mail_valid(matches[0][1]):
                if self.__is_domain_valid(matches[0][2]):
                    return True

        return False


mails = ["gmail", "softuni"]
domains = ["com", "bg"]

email_validator = EmailValidator(6, mails, domains)
print(email_validator.validate("pe77er@gmail.com"))
print(email_validator.validate("georgios@gmail.net"))
print(email_validator.validate("stamatito@abv.net"))
print(email_validator.validate("abv@softuni.bg"))
