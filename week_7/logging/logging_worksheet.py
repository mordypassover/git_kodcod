# תרגיל 1

#1. לא נכון
#2.    נכון
#3. לא נכון
#4. לא נכון
#5.    נכון
#6.    נכון
#7. לא נכון


# תרגיל 2

#1. info
#2. error / warning
#3. info
#4. error
#5. warning
#6. info


# תרגיל 3

# לוג א
# logger.error('User logged in successfully')
# הלוג לא צריך להיות error צריך להיות info
# logger.info('User logged in successfully')

# לוג ב
# logger.info('Login', email, password)
# אסור להכניס סיסמאות
# logger.info('Login', email, bool(password))

# לוג ג
#print('ERROR: payment failed')
#המידע לא ישמר בלוגים כי הם בפרינט
# logger.error('ERROR: payment failed')

# תרגיל 4
# %(asctime)s: זמן כתיבת הלוג
# %(levelname)s: רמת הלוג
# %(name)s: שם המודול ששלח את הלוג
# %(message)s: הסבר מה הלוג מייצג

# תרגיל 5
import logging
logging.basicConfig(level=logging.INFO, format='%(levelname)s | %(message)s')
logger1 = logging.getLogger(__name__)
logger1.info('Application started')

# תרגיל 6
logging.basicConfig(level=logging.INFO, format='%(levelname)s | %(message)s')
logger2 = logging.getLogger(__name__)

def process_payment(user_id, amount):
    # print(f'Starting payment for user {user_id}')
    logger2.info('Starting payment for user %s', user_id)
    if amount <= 0:
        # print('ERROR: Invalid amount')
        logger2.error('ERROR: Invalid amount %s', user_id)
        return
    if amount > 10000:
        # print('WARNING: Large transaction')
        logger2.warning('WARNING: Large transaction %s', user_id)
    # print(f'Payment of {amount} completed for user {user_id}')
    logger2.info('Payment of %s completed for user %s', amount, user_id)
process_payment(12,5)

