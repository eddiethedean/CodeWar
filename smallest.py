def smallest(n):
    n = str(n)
    l = [[int(move_char(n, i, j)), i, j] for i in range(len(n)) for j in range(len(n))]
    l.sort()
    return l[0]
    
def move_char(your_string, i, j):
    i_char = your_string[i]
    your_string = your_string[:i] + your_string[i+1:]
    return your_string[:j] + i_char + your_string[j:]