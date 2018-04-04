class car(object):
    def __init__(self,price,speed,fuel,mileage):
        if price > 10000:
            self.tax=0.15
            self.price=price*1.15
        else:
            self.tax=0.12
            self.price=price*1.12
        self.speed=speed
        self.fuel=fuel
        self.mileage=mileage
    def displayAll(self):
        print "Price: " +str(self.price)
        print "Speed: " +str(self.speed)+"mph"
        print "Fuel: " +str(self.fuel)
        print "Mileage: "+str(self.mileage)+"mpg"
        print "Tax: " +str(self.tax)
        return self

car1=car(41,26,"full",30)
car2=car(10001,602,"empty",22222)
car3=car(13408124081,21311,"reasonably full",515)
car4=car(1,2,"half full",4)
car5=car(1209,2380424308,"half empty",3458035408)
car6=car(11,111,"so close to empty it borders on passive aggressive",1111)

car1.displayAll()
car2.displayAll()
car3.displayAll()
car4.displayAll()
car5.displayAll()
car6.displayAll()
