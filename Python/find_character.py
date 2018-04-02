def findCharacter(ls,char):
    result=[]
    for i in range(len(ls)):
        if ls[i].find(char)>-1:
            result.append(ls[i])
    return result

print findCharacter(['hello','world','my','name','is','Anna'],'o')