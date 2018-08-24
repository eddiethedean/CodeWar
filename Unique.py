def unique_in_order(iterable):
    #start with iterable[0] in new list
    if len(iterable)==0:return []
    new_list = [iterable[0]]
    #loop through iterable
    #check if last new_list item matches iterable item
    #if not, add to new_list
    for i in iterable:
        if i!=new_list[-1]:
            new_list.append(i)
    return new_list
