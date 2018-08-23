def cakes(recipe, available):
    #divide avaiable by recipe, replace count with lowest
    count = 0
    for ing in recipe:
        if ing in available:
            temp = available[ing]//recipe[ing]
            if temp==0:return 0
            if count==0:
                count = temp
            else:
                if temp < count:
                    count = temp
        else:
            return 0
    return count