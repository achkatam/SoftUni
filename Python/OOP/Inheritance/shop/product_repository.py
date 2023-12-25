from project.product import Product


class ProductRepository:
    def __init__(self) -> None:
        self.products = []

    def add(self, product: Product):
        self.products.append(product)

    def find(self, product_name: str):
        for product in self.products:
            if product.name == product_name:
                return product

    def remove(self, product_name: str):
        # for idx, product in enumerate(self.products):
        #     if product.name == product_name:
        #         del self.product[idx]
        if product_name in self.products:
            self.products.remove(product_name)

    def __repr__(self) -> str:
        string_builder = []
        for product in self.products:
            string_builder.append(f'{product.name}: {product.quantity}')
        new_line = '\n'
        return f"{new_line.join(string_builder)}"
