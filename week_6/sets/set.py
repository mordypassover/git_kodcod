#1

def clean_list(lst):
    return list(set(lst))

#2

def count_unique_elements(lst):
    cnt=0
    for i in set(lst):
        cnt+=1
    return cnt

#3

def common_elements_in_lists(list1, list2):
    return list(set(list1).intersection(set(list2)))

#4

def elements_in_one(list1, list2):
    return list(set(list1) ^ set(list2))

#5

def is_subset(a, b):
    return set(a) <= set(b)

#6

def unique_characters(string):
    return len(string) == len(set(string))

#7

def first_repeated_element(lst):
    first_time=set()
    for i in lst:
        if i in first_time:
            return i
        else:
            first_time.add(i)
    return

#8

def distinct_words_finder(string):
    return len(set(string.lower().split(' ')))

#9

def pair_sum_exists(lst, target):
    list_set=set(lst)
    for i in range(len(list_set)):
        num=list_set.pop()
        if (target - num) in list_set:
            return True
    return False

#10

def symmetric_difference(list1, list2):
    all_set = set(list1) | set(list2)
    intersection_set = set(list1) & set(list2)
    return list(all_set.difference(intersection_set))
