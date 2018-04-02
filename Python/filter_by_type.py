def filterByType (data):
    if isinstance(data,str):
        if len(data)<100:
            print "Short sentence."
        else:
            print "Long sentence."
    if isinstance(data,int):
        if data>99:
            print "Big number."
        else:
            print "Small number."
    if isinstance(data,list):
        if len(data)>9:
            print "Big list."
        else:
            print "Small list."

filterByType(45)
filterByType(100)
filterByType(455)
filterByType("Rubber baby buggy bumpers")
filterByType("Experience is simply the name we give our mistakes")
filterByType("Tell me and I forget. Teach me and I remember. Involve me and I learn.")
filterByType("")
filterByType([1,7,4,21])
filterByType([])
filterByType([4,34,22,68,9,13,3,5,7,9,2,12,45,923])
