class Catalogue():
    def __init__(self, name):
        self.name = name
        self.products = []

    def add_product(self, product_name):
        return self.products.append(product_name)

    def get_by_letter(self, first_letter):
        return [prod for prod in self.products if prod[0] == first_letter]

    def __repr__(self):
        output = f"Items in the {self.name} catalogue:"
        self.products.sort()
        for prod in self.products:
            output += f"\n{prod}"

        return output


catalogue = Catalogue("Furniture")
catalogue.add_product("Sofa")
catalogue.add_product("Mirror")
catalogue.add_product("Desk")
catalogue.add_product("Chair")
catalogue.add_product("Carpet")

print(catalogue.get_by_letter("C"))
print(catalogue)
