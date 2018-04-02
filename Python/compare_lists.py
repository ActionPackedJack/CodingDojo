def compareLists(l1,l2):
    if len(l1)!=len(l2):
        return "The lists are not the same."
    for i in range (len(l1)):
        if l1[i]!=l2[i]:
            return "The lists are not the same."
    return "The lists are the same."

print compareLists([1,2,5,6,2],[1,2,5,6,2])
print compareLists([1,2,5,6,5],[1,2,5,6,5,3])
print compareLists([1,2,5,6,5,16],[1,2,5,6,5])
print compareLists(['celery','carrots','bread','milk'],['celery','carrots','bread','cream'])