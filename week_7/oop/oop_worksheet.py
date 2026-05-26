#1
class Dog:
    def __init__(self, name):
        self.name = name

    def bark(self):
        return f"{self.name} says woof!"


#2
class Rectangle:
    def __init__(self, width, height):
        self._width = width
        self._height = height

    def area(self):
        return self._width * self._height

#3
class Counter:
    def __init__(self, count_start = 0):
        self._count = count_start

    def increment(self):
        self._count += 1

    def value(self):
        return self._count

