def create_grades_file(filename):
    students=[
        ("Dan", [85,90,78]),
    ("MOMO", [92,88,95]),
    ("Yoni",[70,65,80]),
    ("Avi",[100,95,98]),
    ("Sara",[60,72,68])
    ]
    with open(filename, "w", encoding="utf-8") as f:
        for student in students:
            f.write(student[0] + ' ' + (str(student[1])).strip('[]') + "\n")


def calculate_averages(filename):
    avg_dict = {}
    with open(filename, "r", encoding="utf-8") as f:
        for line in f.readlines():
            line_grades = (int(i.strip(",")) for i in line.split()[1:-1])
            avg_dict[line.split()[0]] = (sum(line_grades) / len(line.split()[1:-1]))
    return avg_dict


def print_avg(filename):
    avg_dict=calculate_averages(filename)
    for key, item in avg_dict.items():
        print(f"{key}: {item}")


def save_results(averages, output_filename):
    line_list=[]
    for name, avg in averages.items():
        line_list.append([avg,f"{name}: {avg}"])
    line_list.sort(key=lambda x: x[0], reverse=True)

    with open(output_filename, "w" ,encoding="utf-8") as f:
        f.write("=== Student Results ===\n")

        for index, line in enumerate(line_list):
            f.write(f'{index + 1}. {line[1]}\n')


def get_statistics(filename, output_filename):
    results_dict=calculate_averages(filename)
    avg_list= list(val for val in results_dict.values())
    avg_avg = sum(avg_list) / len(avg_list)
    best = max(results_dict, key=results_dict.get)
    worst = min(results_dict, key=results_dict.get)
    passing = len(list(avg for avg in avg_list if avg >= 60))

    with open(output_filename,  "a", encoding="utf-8") as f:
        f.write("\n=== Statistics ===\n")
        f.write(f"Class average: {avg_avg}\n")
        f.write(f"Highest: {best} {results_dict[best]}\n")
        f.write(f"Lowest: {worst} {results_dict[worst]}\n")
        f.write(f"Passing (>=60): 5/{passing}")
