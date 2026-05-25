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
