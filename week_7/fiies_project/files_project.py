import os.path
from asyncio import all_tasks


def load_tasks(filename):
    """
    :dicts קוראת את הקובץ ומחזירה רשימה של
    [{'id': 1, 'status': 'PENDING', 'desc': 'ללמוד Python'}, ...]
    אם הקובץ לא קיים — מחזירה רשימה ריקה
    """
    if not os.path.exists(filename):
        return []
    dict_list = list()
    with open(filename, "r", encoding="utf-8") as f:
        for line in f.readlines():
            if line == "\n":
                continue
            temp_list = (line.strip().split("|"))
            dict_list.append({"id": temp_list[0], "status": temp_list[1], "desc":temp_list[2]})
    return dict_list


def save_tasks(filename, tasks):
    """
    שומרת את רשימת המשימות לקובץ
    id|status|description :פורמט כל שורה
    """
    with open(filename, "w", encoding="utf-8") as f:
        for task in tasks:
            f.write(f"{task["id"]}|{task["status"]}|{task["desc"]}\n")
    return

def add_task(filename, description):
    """
    :מוסיפה משימה חדשה עם
    מספר המשימה הבאה = ID -
    - status = 'PENDING'
    הפרמטר שניתן =description -
    """
    all_tasks = load_tasks(filename)
    all_tasks.append({"id": int(all_tasks[-1]["id"]) + 1, "status": "pending", "desc":description})
    save_tasks(filename, all_tasks)


def complete_task(filename, task_id):
    """
    DONE-ל PENDING-מ id_task של משימה status משנה את
    לא קיים — מדפיסה הודעת שגיאה ID-אם ה
    """
    all_tasks = load_tasks(filename)
    flag = False
    for dct in all_tasks:
        if task_id == int(dct["id"]):
            dct["status"] = "dune"
            flag = True
    if not flag:
        print(f"id {task_id} not found")

    save_tasks(filename, all_tasks)



def main():
    FILENAME = "tasks.txt"
    while True:
        print('\n=== To-Do List Manager ===')
        print('הצג משימות 1.')
        print('הוסף משימה 2.')
        print('סמן כהושלם 3.')
        print('יציאה 4.')
        choice = input('בחירה:')
        if choice == '1':
            print(load_tasks(FILENAME))
        elif choice == '2':
            desc = input(' :תיאור המשימה')
            add_task(FILENAME, desc)
            print ('!המשימה נוספה')
        elif choice == '3':
            task_id = int(input('משימה מספר:'))
            complete_task(FILENAME, task_id)
        elif choice == '4':
            print('!להתראות')
            break
        else:
            print('בחירה לא תקינה')


if __name__ == '__main__':
    main()