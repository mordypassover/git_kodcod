#1

def sum_tuple(tpl):
    tul_sum = 0
    for char in tpl:
        tul_sum += char
    return tul_sum

#2

def max_tpl(tpl):
    tpl_max = tpl[0]
    for char in tpl:
        if tpl_max < char :
            tpl_max = char
    return tpl_max

#3

def count_occurrences_in_tuple(tpl, item):
    count=0
    for char in tpl:
        if char == item:
            count+=1
    return count

#4

def tuple_reverse(tpl):
    return tuple(tpl[( - char) - 1] for char in range(len(tpl)))

#5

def pairs_swapper(tpl):
    tmp_list=[]
    for index in range(0,len(tpl),2):
           tmp_list.append(tpl[index + 1])
           tmp_list.append(tpl[index])
    return tuple(tmp_list)

#6

def tuple_min_and_max(tpl):
    temp_min=tpl[0]
    for char in tpl:
        if temp_min > char:
            temp_min = char

    return temp_min, max_tpl(tpl)

#7

def euclidean_distance(tuple1, tuple2):
    return ((tuple1[0] - tuple2[0]) ** 2 + (tuple1[1] - tuple2[1])**2)**0.5

#8

def merg_and_sort(tuple1, tuple2):
    return tuple(sorted(tuple1 + tuple2))

#9

def frequency_table(tpl):
    temp_list = []
    for item in tpl:
        if item not in temp_list:
            temp_list.append(item)
            temp_list.append(1)
        else:
            temp_list[(temp_list.index(item)) + 1] +=1

    return tuple((temp_list[index], temp_list[index + 1]) for index in  range(0,len(temp_list),2))


#10

def rotate_tuple(tpl, k):
    return tuple(tpl[(index + 1 + k) % len(tpl)] for index in range(len(tpl)))
