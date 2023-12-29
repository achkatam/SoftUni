from project.dog import Dog
from project.tomcat import Tomcat
from project.kitten import Kitten
from project.cat import Cat

dog = Dog("Rocky", 3, "Male")
print(dog.make_sound())
print(dog)

tomcat = Tomcat("Tom", 6)
print(tomcat.make_sound())
print(tomcat)

kitten = Kitten("Kiki", 1)
print(kitten.make_sound())
print(kitten)
cat = Cat("Johnny", 7, "Male")
print(cat.make_sound())
print(cat)
