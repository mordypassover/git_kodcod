import os


def init_diary():
    with open("diary.txt", "w", encoding="utf-8") as f:
        f.write("line 1 \n")
        f.write("line 2 \n")
        f.write("line 3 \n")
        print("file created successfully!")


def read_diary():
    with open("diary.txt", "r", encoding="utf-8") as f:
        print(f.read())

init_diary()
read_diary()

def add_entry(filename, date, content):
    with open(filename, "a", encoding="utf-8") as f:
        f.writelines([date," ",content,"\n"])


def search_diary(filename, keyword):
    keyword_line_list=[]
    with open(filename, "r", encoding="utf-8") as f:
        for line in f.readlines():
            if keyword in line.split():
                keyword_line_list.append(line)
    return keyword_line_list

def safe_read_diary(filename):
    if os.path.exists(filename):
        with open(filename, "r", encoding="utf-8") as f:
            return f.read()
    return "file not found"

print(safe_read_diary("diary.txt"))