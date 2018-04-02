def typeList(ls):
    type="The list you entered is of "
    string="String: "
    stringiness="false"
    numberhood="false"
    sum=0
    for i in range(len(ls)):
        if isinstance(ls[i],str):
            string+=ls[i]
            if len(type)==40:
                type="The list you entered is of mixed type."
            if len(type)==27:
                stringiness="true"
                type+="string type."
        if isinstance(ls[i],int):
            sum+=ls[i]
            if len(type)==39:
                type="The list you entered is of mixed type."
            if len(type)==27:
                numberhood="true"
                type+="integer type."
    print type
    if stringiness=="true":
        print string
    if numberhood=="true":
        print "Sum: ", sum

        
typeList(['magical unicorns',19,'hello',98.98,'world'])
typeList([2,3,1,7,4,12])
typeList(['magical','unicorns'])