#1
count = 0

def bump():
    global count
    count += 1


def value():
    global count
    return count

#2

def make_counter():
    count = 0
    def inner():
        nonlocal count
        count += 1
        return count
    return inner

#3

# x = "global"
# def outer():
#     x = "enclosing"
#     def inner():
#         x = "local"
#         print(x)
#     inner()
#     print(x)
# outer()
# print(x)

#4
# it changes the constructer list to an actual list disabeling casting
# lst = [1, 2, 3]
# print(list(range(5)))

#7
from datetime import datetime ; print(datetime.now())

#8

def  public_names(m):
    names = []
    for name in dir(m):
        if not name[0] != "_":
            names.append(name)
    return names.sort()


#9

def add_item(item, bag):
    bag.append(item)
    return bag

