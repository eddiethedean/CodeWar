def is_interesting(n, awesome_phrases):
    green = check_interest(str(n), awesome_phrases)
    if green:return 2
    yellow = max(check_interest(str(n+1),awesome_phrases), check_interest(str(n+2),awesome_phrases))
    if yellow:return 1
    return 0
    
def check_interest(n, phrases):
    if int(n) < 100:return False
    if int(n[1:])==0:return True
    if n in '1234567890':return True
    if n in '9876543210':return True
    if n==n[::-1]:return True
    if int(n) in phrases:return True
    return 0