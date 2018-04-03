def coinToss():
    import random
    result=""
    heads=0
    tails=0
    for i in range(5001):
        if random.randint(1,2)==2:
            result="head"
            heads+=1
        else:
            result="tail"
            tails+=1
        print "Attempt #"+str(i)+": throwing a coin... it's a " +result+"! Got "+str(heads)+" head(s) so far and " + str(tails)+ " tail(s) so far."

coinToss()
        