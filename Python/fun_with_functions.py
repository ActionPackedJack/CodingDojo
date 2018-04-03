def oddEven():
    for i in range(2001):
        if i%2==1:
            divisibility="odd"
        else:
            divisibility="even"
        print "Number is "+ str(i) + ". This is an " + divisibility + " number."

oddEven()

def multiply(ls,mult):
    for i in range(len(ls)):
        ls[i]*=mult
    return ls

print multiply([2,4,10,16],5)

def layeredMultiples(arr):
    newArr=[]
    for i in range (len(arr)):
        nextElem=[]
        for j in range (arr[i]):
            nextElem.append(1)
        newArr.append(nextElem)
    return newArr

print layeredMultiples([2,3,4])