#1

def sum_values(dct):
    val_sum=0
    for val in dct.values():
        val_sum+=key

    return val_sum

#2

def max_val_key(dct):
    temp_max = None
    for key, val in dct.items():
        if temp_max == None or temp_max[1] < val :
            temp_max = (key, val)
    return temp_max[0]

#3

def char_count(string):
    char_count_dict={}
    for char in string:
        if char in char_count_dict:
            char_count_dict[char]+=1
        else:
            char_count_dict[char] = 1
    return char_count_dict

#4

def inverted_dict(dct):
    return {val:key for key, val in dct.items}

#5

def merge_dicts(dict1, dict2):
    dict1.update(dict2)
    return dict1



#6

def filter_by_value(dct, threshold):
    return {key:val for key, val in dct.items()  if  val > threshold }

#7

def group_by_first_letter(word_list):
    dct={}
    for word in word_list:
        if word[0] in dct.keys():
            dct[word[0]].append(word)
        else:
            dct[word[0]]=[word]
    return dct

#8

def word_frequency(string):
    word_count_dict={}
    for word in string.split(" "):
        if word in word_count_dict:
            word_count_dict[word]+=1
        else:
            word_count_dict[word] = 1
    return word_count_dict

#9

def common_keys(dict1, dict2):
    common_list=[]
    for key in dict1 :
        if key in dict2:
            common_list.append(key)
    return common_list

#10

def most_frequent_value(dct):
    vals= dct.values()
    vals_cnt_dict={}
    for num in vals:
        if num in vals_cnt_dict:
            vals_cnt_dict[num] += 1
        else:
            vals_cnt_dict[num] = 1
    return max(vals_cnt_dict, key=lambda key: vals_cnt_dict[key])


