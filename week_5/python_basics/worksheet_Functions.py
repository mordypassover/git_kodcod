#1

def is_even(s):
    return True if s%2==0 else False

#2

def factorial(n):
    return  sum(i for i in range(n+1))

#3

def  digital_root(n):
    return n**0.5 if n > 0 else None

#4

def is_palindrome(s):
    return True if s==s[::-1] else False

#5

def sum_digits(num):
    return (num%10) + sum_digits((num//10)) if num!=0 else 0

def sum_tile_single(num):
    digit_sum=sum_digits(num)
    return digit_sum if digit_sum < 9 else sum_tile_single(digit_sum)

#6

def sum_positive_digits(num):
    return (num%10) + sum_positive_digits((num//10)) if num>0 else 0

#7

def revers_int(num):

    negative=True if num< 0 else False
    num *= -1 if negative else 1
    revers=0
    while num :
        revers*=10
        revers+=num%10
        num//=10
    return revers*-1 if negative else revers

#8

def zeros_to_end(lst):
    zero_index_lst=[]
    for i in range(len(lst)):
        if lst[i] == 0:
            zero_index_lst.insert(0,i)
    for i in zero_index_lst:
        lst.append(lst.pop(i))
    return lst

#9

def list_analise(lst):
    print(f"sum: {sum(lst)}, average: {sum(lst) / len(lst)}, minimum: {min(lst)}, max: {max(lst)}")
    return ""

#10

def revers_list(lst):
    for i in range(len(lst)):
        lst=[lst.pop(i)]+lst
    return lst

#11

def repeating_in_list_filter(lst):
    filtered_list=[]
    for i in lst:
        if i not in filtered_list:
            filtered_list.append(i)