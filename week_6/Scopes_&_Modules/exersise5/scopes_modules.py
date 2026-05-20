#1

def bump():
    global count
    count += 1

def value():
    return count

count = 0

#2

def make_counter():
    num = 0
    def add_1_to_num():
        nonlocal num
        num += 1
        return num
    return add_1_to_num()

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

# כשמגדירים את list למשתנה כבר אי אפשר להפוך על ידו בקאסטאינג ולכן אסור להשתמש בו לשם משתנה

# lst = [1, 2, 3]
# print(list(range(5)))



