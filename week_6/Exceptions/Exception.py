#1

def safe_int(s):
    try:
       return int(s)
    except ValueError:
        return

#2

def safe_divide(a, b):
    try:
        return a/b
    except ZeroDivisionError:
        return "undefined"


#3

def get_value(d, key):
    try:
        return d[key]
    except Exception:
        return  "missing"


#4

def parse_ints(values):
    lst=[]
    for i in values:
        try:
            lst.append(int(i))
        except ValueError:
            continue
    return lst



#5

def set_age(age):
    if  age > 150 or 0 > age  :
        raise ValueError
    return age

#6

def retry(func, n):
    for i in range(n):
        try:
            return func()
        except Exception as e:
            continue
    return e


#7

def count_errors(funcs):
    cnt_exceptions=0
    for i in funcs:
        try:
            i()
        except Exception:
            cnt_exceptions+=1
    return cnt_exceptions


#8

def load_config(path):
    try:
        with open(path,"r" ) as f:
            return int(f.readline())
    except Exception as e:
        raise RuntimeError("failed to load config") from e
