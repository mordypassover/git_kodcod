#1

def sum_list(lst):
    list_sum = 0
    for num in lst:
        list_sum += num
    return list_sum

#2

def list_max(lst):
    lst_max = lst[0]
    for num in lst:
        if lst_max < num :
            lst_max = num
    return lst_max

#3

def count_item_in_list(item, lst):
    count=0
    for list_item in lst:
        if list_item == item:
            count+=1
    return count

#4

def revers_list(lst):
    return [lst[(- index) - 1] for index in range(len(lst))]

#5

def remove_duplicates(lst):
    new_list=[]
    for num in lst:
        if num not in new_list:
            new_list.append(num)
    return new_list

#6

def second_largest(lst):
    max_num=list_max(lst)
    second_max=min(lst)
    for num in lst:
        if max_num > num > second_max :
            second_max =num
    return second_max if second_max != max_num else None

#7

def merge_sorted_lists(list1, list2):
    return sorted(list1 + list2)

#8

def rotate_list(lst,k):
    return [lst[(index + 1 + k) % len(lst)] for index in range(len(lst))]

print(rotate_list([1, 2, 3, 4, 5], k = 7))