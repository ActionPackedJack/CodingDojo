def dictionary_from_list(ls1,ls2):
    if len(ls2)>len(ls1):
        print dict(zip(ls2,ls1))
    else:
        print dict(zip(ls1,ls2))

name = ["Anna", "Eli", "Pariece", "Brendan", "Amy", "Shane", "Oscar"]
favorite_animal = ["horse", "cat", "spider", "giraffe", "ticks", "dolphins", "llamas", "Gorfus MacGregor"]

dictionary_from_list(name,favorite_animal)