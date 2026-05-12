#1

# for i in range(1,10):
#     if i%2==0:
#         continue
#     print(i)
#     if i ==7 :
#         break

#2

# while True:
#     code=input("enter code: ")
#     if code =="1234":
#         print("welcome!")
#         break
#     print("try again")

#3

# product_list=[]
# product=None
# while product != "done":
#     product=input("enter product name: ")
#     product_list.append(product)
# product_list.pop()
# print(product_list)



# for row in range(3):
#     for col in range(3):
#         print(row, col)
#         if col==2 :
#             break

#4

# string=input("enter a string: ")
# print(sum(1  for i in string if i.lower() in ("a","e","i","o","u")))

#5

# for i in range(1,6):
#     for j in range(1,6):
#         print(f"{i} X {j} = {i*j}",end="  ")
#     print("\n")

#6

# string=input("enter a string: ")
# flip_word=''
# for i in string:
#     flip_word=i+flip_word
# print(flip_word)

#7

# num=int(input("enter number: "))
# counter=0
# while num:
#     counter+=1 if (num % 10) % 2 == 0 else 0
#     num//=10
# print(counter)

#8

# string=input("enter a string: ")
# duble_letters=''
# for i in string:
#     duble_letters+=i*2
# print(duble_letters)

#9

# num=None
# highest_num=0
# while num != 0:
#     num=int(input("enter number: "))
#     if num > highest_num:
#         highest_num=num
# print(highest_num)

#10

# string=input("enter a string: ")
# is_clean=True
# for i in string:
#     if (i.isdigit() == False) and (i.isalpha() == False):
#         is_clean= False
# print(is_clean)

#11

# num = int(input("enter number: "))
# flip_digit=0
# while num:
#     flip_digit*=10
#     flip_digit+=num % 10
#     num//=10
# print(flip_digit)