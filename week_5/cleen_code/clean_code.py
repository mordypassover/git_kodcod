#1

def active_from_data_list(data_list):
    active_adult_names=[]
    for data_line in data_list:
        is_active=data_line[2]
        is_adult=data_line[1] >= 18
        if is_adult and is_active:
            active_adult_names.append(data_line[0])
    return active_adult_names

data=[["Dan", 25,True],
    ["Noa", 16, True],
    ["Yael", 30, False]
]

print(active_from_data_list(data))

#2

def validate_email(email):
    return email if email else None

def validate_quantity(quantity,stock):
    return True if (quantity > 0  and stock >= quantity) else False

def check_discount(product_price,quantity):
    return product_price*0.85 if quantity >= 50 else product_price * 0.9 if quantity >= 10 else product_price

def confirm_order(user_email, stock, quantity):
    return "confirmed" if validate_email(user_email) and validate_quantity(quantity,stock) else "order dined"


def handle_purchase(user_email, product_name, product_price, stock, quantity):
    order_user = user_email
    order_product = product_name
    order_quantity = quantity
    order_total = check_discount(product_price, quantity)
    order_status = confirm_order(user_email, stock, quantity)
    print(f"Order {order_status}: {order_user} bought {order_quantity}x {order_product} for ${order_total}")
    return order_user, order_product, order_quantity, order_total, order_status

#3



def manage_students(names, grades, new_name, new_grade):
    pass
