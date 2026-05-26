#1
class Dog:
    """doc_string"""
    def __init__(self, name):
        """doc_string"""
        self.name = name

    def bark(self):
        """doc_string"""
        return f"{self.name} says woof!"


#2
class Rectangle:
    """doc_string"""
    def __init__(self, width, height):
        """doc_string"""
        self._width = width
        self._height = height

    def area(self):
        """doc_string"""
        return self._width * self._height

#3
class Counter:
    """doc_string"""
    def __init__(self, count_start = 0):
        self._count = count_start

    def increment(self):
        """doc_string"""
        self._count += 1

    def value(self):
        """doc_string"""
        return self._count

#4

class Point:
    """doc_string"""
    def __init__(self, x, y):
        """doc_string"""
        self.x = x
        self.y = y

    def __str__(self):
        """doc_string"""
        return f"({self.x}, {self.y})"


#5

class BankAccount:
    """doc_string"""
    def __init__(self, balance = 0):
        """doc_string"""
        self._balance = balance


    def deposit(self, amount):
        """doc_string"""
        self._balance += amount if amount > 0 else self._balance

    def withdraw(self, amount):
        """doc_string"""
        self._balance -= amount if amount <= self._balance  else self._balance


#6

class  Temperature:
    """doc_string"""
    def __init__(self, temp):
        """doc_string"""
        self._temp = temp

    def to_fahrenheit(self):
        """doc_string"""
        return (self._temp * 1.8) +32

#7

class Student:
    """doc_string"""
    _school = "Kodcode"
    def __init__(self, name):
        self._name = name

# s1, s2 = Student("moti"), Student("yoti")
# s1._name = "coty"
# print(s1._name, s2._name)


# 8

class Player:
    """doc_string"""
    players = 0
    def __init__(self):
        """doc_string"""
        Player.players += 1

    def get_players(self):
        """doc_string"""
        return Player.players


#9

class Money:
    """doc_string"""
    def __init__(self, amount):
        """doc_string"""
        self._amount = amount

    def get_amount(self):
        """doc_string"""
        return self._amount

    def is_more_than(self, other):
        """doc_string"""
        return self._amount > other.get_amount()


#10

class Playlist:
    """doc_string"""
    def __init__(self):
        """doc_string"""
        self._song_titles = []

    def add_title(self, title):
        """doc_string"""
        self._song_titles.append(title)

    def remove(self, title):
        """doc_string"""
        self._song_titles.remove(title)

    def __str__(self):
        """
        shows the playlist
        """
        return str(self._song_titles)

