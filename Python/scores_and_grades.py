def scoresAndGrades():
    import random
    for i in range(11):
        score=random.randint(60,100)
        if score<70:
            grade="D"
        elif score <80:
            grade="C"
        elif score <90:
            grade="B"
        else:
            grade= "A"
        print "Score: "+ str(score)+ "; your grade is " + grade
scoresAndGrades()