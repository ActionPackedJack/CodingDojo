words = "It's thanksgiving day. It's my birthday,too!"
print words.find("day")
print words.replace("day", "month", 1)
x = [2,54,-2,7,12,98]
print min(x)
print max(x)
x = ["hello",2,54,-2,7,12,98,"world"]
x=[x[0],x[len(x)-1]]
print x
x = [19,2,54,-2,7,12,98,32,10,-3,6]
x.sort()
y=[]
for i in range(6):
    y.append(x[i])
z=[]
z.append(y)
for i in range (6,len(x)):
    z.append(x[i])
print z