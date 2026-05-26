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

#4

class Point:
    def __init__(self, x, y):
        self.x = x
        self.y = y

    def __str__(self):
        return f"({self.x}, {self.y})"


#5

class BankAccount:
    def __init__(self, balance = 0):
        self._balance = balance


    def deposit(self, amount):
        self._balance += amount if amount > 0 else self._balance

    def withdraw(self, amount):
        self._balance -= amount if amount <= self._balance  else self._balance


#6

class  Temperature:
    def __init__(self, temp):
        self._temp = temp

    def to_fahrenheit(self):
        return (self._temp * 1.8) +32

#7

class Student:
    _school = "Kodcode"
    def __init__(self, name):
        self._name = name

# s1, s2 = Student("moti"), Student("yoti")
# s1._name = "coty"
# print(s1._name, s2._name)


# 8

class Player:
    players = 0
    def __init__(self):
        Player.players += 1

    def get_players(self):
        return Player.players


#9

class Money:
    def __init__(self, amount):
        self._amount = amount

    def is_more_than(self, other):
        return self._amount > other._amount


#10

class Playlist:
    def __init__(self):
        self._song_titles = []

    def add_title(self, title):
        self._song_titles.append(title)

    def remove(self, title):
        self._song_titles.remove(title)

    def __str__(self):
        return str(self._song_titles)

