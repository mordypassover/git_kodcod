#1

# age = int(input("enter age: "))
# print("Invalid") if 0 > age or age > 120 \
#     else print("child") if 12 >= age > 0 \
#     else print("teen") if 12<age<=17 \
#     else print("adult")

#2

# character=input("enter a character: ")
# if not 'A'<= character  <='z':
#     print("invalid")
# elif character in ("a","e","o","u"):
#     print("vowel")
# else:
#     print("consonant")

#3

# age,has_vip=int(input("enter age: ")),input("vip?: ")
# if age > 16:
#     print("rejected!")
# elif age== 18 and has_vip =="yes" or 19<= age <=21:
#     print("entry allowed!")

#4

# passwords=[]
# password=input("enter password: ")
# if password in passwords:
#     print("access granted")
# elif len(password)<8:
#     print("password too short")
# else:
#     print("wrong password")

#5

# x,y= int(input("enter coordinates")),int(input("enter coordinates"))
# if 10< x <50 and 20 < y < 80 :
#     print("inside the rectangle")
# elif ((x == 10 or x == 50) and 20 < y < 80) or ( (y == 20 or y == 80) and 10< x <50) or (x == 10 or x == 50) and (y == 20 or y == 80):
#     print("on the edge")
# else :
#     print("outside the rectangle")

#6

# name= input("enter name: ")
# print("welcome",name or "anonymous")

#8

# num1,num2,num3=int(input("enter number: ")),int(input("enter number: ")),int(input("enter number: "))
# print((num1>0)+(num2>0)+(num3>0))

#10

# score=int(input("enter score from 0 to 100: "))
# print("A") if 90 <= score else print("B") if 80 <= score<= 89 else print('C') if 70 <= score<=79 else print("F")